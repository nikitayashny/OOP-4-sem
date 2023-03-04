using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace laba2sql
{
    public partial class dopForm : Form
    {
        private MySqlDataAdapter adapter = null;
        DataTable table = null;
        public dopForm()
        {
            InitializeComponent();
        }
        private void button_add2_Click(object sender, EventArgs e)
        {
            try
            {             
                if (textBox_organization.Text == "")
                {
                    MessageBox.Show("Введите название организации");
                    return;
                }
                if (textBox_country.Text == "")
                {
                    MessageBox.Show("Введите страну производителя");
                    return;
                }
                if (textBox_address.Text == "")
                {
                    MessageBox.Show("Введите адрес производителя");
                    return;
                }
                if (textBox_phone.Text == "")
                {
                    MessageBox.Show("Введите телефон производителя");
                    return;
                }
                ValidationPhone phone = new ValidationPhone(textBox_phone.Text);
                var results = new List<ValidationResult>();
                var context = new ValidationContext(phone);
                if (!Validator.TryValidateObject(phone, context, results, true))
                {
                    MessageBox.Show("Телефонный номер не проходит валидацию \nВведите норм в формате +xxx-xx-xxxxxxx");
                    return;
                }
                if (CheckUnique())
                    return;

                DB db = new DB();
                MySqlCommand addCommand = new MySqlCommand(
                    "INSERT INTO `producers` (`organization`, `country`, `address`, `phone`) " +
                    "VALUES (@organization, @country, @address, @phone)", db.GetConnection());

                addCommand.Parameters.Add("@organization", MySqlDbType.VarChar).Value = textBox_organization.Text;
                addCommand.Parameters.Add("@country", MySqlDbType.VarChar).Value = textBox_country.Text;
                addCommand.Parameters.Add("@address", MySqlDbType.VarChar).Value = textBox_address.Text;
                addCommand.Parameters.Add("@phone", MySqlDbType.VarChar).Value = textBox_phone.Text;

                if (ProdExist())
                {
                    db.openConnection();

                    if (addCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Товар добавлен");
                        textBox_organization.Enabled = true;
                    }
                    else
                        MessageBox.Show("Товар не добавлен");

                    db.closeConnection();
                }

                RefreshFields();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message); 
            }
        }   // добавление элемента
        private void dopForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            adapter = new MySqlDataAdapter("SELECT * FROM `producers`", db.GetConnection());
            table = new DataTable();

            adapter.Fill(table);
            dataGridView_producer.DataSource = table;

            db.closeConnection();
        }   // загрузка формы
        private void button_refresh2_Click(object sender, EventArgs e)
        {
            table.Clear();

            adapter.Fill(table);
            dataGridView_producer.DataSource = table;
        }   // обновление таблицы
        public bool CheckUnique()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand checkUnique = new MySqlCommand("SELECT * FROM `producers` WHERE `organization` = @organization", db.GetConnection());
            checkUnique.Parameters.Add("@organization", MySqlDbType.VarChar).Value = textBox_organization.Text;

            adapter.SelectCommand = checkUnique;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такое название уже есть, введите другое");
                return true;
            }
            else
                return false;
        }   // проверка уникальности производителя
        private void button_close2_Click(object sender, EventArgs e)
        {
            if (textBox_organization.Text == "")
            {
                this.Close();
                return;
            }
            else if (!CheckUnique())
            {
                MessageBox.Show("Заполните все поля или очистите");
                return;
            }
        }   // закрытие формы
        private void RefreshFields()
        {
            textBox_organization.Text = "";
            textBox_country.Text = "";
            textBox_address.Text = "";
            textBox_phone.Text = "";
        }   // очистка полей
        private bool ProdExist()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand checkUnique = new MySqlCommand("SELECT * FROM `products` WHERE `producer` = @producer", db.GetConnection());
            checkUnique.Parameters.Add("@producer", MySqlDbType.VarChar).Value = textBox_organization.Text;

            adapter.SelectCommand = checkUnique;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
            {
                MessageBox.Show("Такого производителя нет");
                return false;
            }       
        }   // проверка на наличие производителя в таблице товаров
    }
}
