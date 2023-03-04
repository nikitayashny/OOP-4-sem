using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

namespace laba2sql
{
    public partial class MainForm : Form
    {
        private MySqlDataAdapter adapter = null;
        DataTable table;
        public int searchType = 0;
        public Orginator orginator = new Orginator();
        public Caretaker caretaker = new Caretaker();
        public int counter = 0;

        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;

        Timer timer;

        public MainForm()
        {
            InitializeComponent();

            this.CenterToScreen();
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);


            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {

            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }   // закрытие формы
        private void AddButton_Click(object sender, EventArgs e)
        {
            caretaker.History.Push(orginator.SaveState());
            if (textBox_name.Text == "")
            {
                MessageBox.Show("Введите название товара");
                return;
            }
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Введите инвентарный номер товара");
                return;
            }  
            if (Convert.ToInt32(numericUpDown_size.Value) == 0)
            {
                MessageBox.Show("Введите размер товара");
                return;
            }
            if (Convert.ToInt32(numericUpDown_weight.Value) == 0)
            {
                MessageBox.Show("Введите вес товара");
                return;
            }
            if (comboBox_type.Text == "")
            {
                MessageBox.Show("Введите тип товара");
                return;
            }
            if (dateTimePicker_date.Value.ToString() == "")
            {
                MessageBox.Show("Введите дату поступления товара");
                return;
            }
            if (Convert.ToInt32(numericUpDown_amount.Value) == 0)
            {
                MessageBox.Show("Введите количество товара");
                return;
            }
            if (trackBar_price.Value == 0)
            {
                MessageBox.Show("Введите цену товара");
                return;
            }
            if (textBox_producer.Text == "")
            {
                MessageBox.Show("Введите производителя товара");
                return;
            }
            ValidationId id = new ValidationId(textBox_id.Text);
            var results = new List<ValidationResult>();
            var context = new ValidationContext(id);
            if (!Validator.TryValidateObject(id, context, results, true))
            {
                MessageBox.Show("id не проходит валидацию \nid должен быть натуральным числом");
                return;
            }

            if (CheckUnique())
                return;

            DB db = new DB();
            MySqlCommand addCommand = new MySqlCommand(
                "INSERT INTO `products` (`name`, `id`, `size`, `weight`, `type`, `date`, `amount`, `price`, `producer`) " + 
                "VALUES (@name, @id, @size, @weight, @type, @date, @amount, @price, @producer)", db.GetConnection());

            addCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox_name.Text;
            addCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(textBox_id.Text);
            addCommand.Parameters.Add("@size", MySqlDbType.Int32).Value = Convert.ToInt32(numericUpDown_size.Value);
            addCommand.Parameters.Add("@weight", MySqlDbType.Int32).Value = Convert.ToInt32(numericUpDown_weight.Value);
            addCommand.Parameters.Add("@type", MySqlDbType.VarChar).Value = comboBox_type.Text;
            addCommand.Parameters.Add("@date", MySqlDbType.Date).Value = dateTimePicker_date.Value;
            addCommand.Parameters.Add("@amount", MySqlDbType.Int32).Value = Convert.ToInt32(numericUpDown_amount.Value);
            addCommand.Parameters.Add("@price", MySqlDbType.Int32).Value = trackBar_price.Value;
            addCommand.Parameters.Add("@producer", MySqlDbType.VarChar).Value = textBox_producer.Text;

            db.openConnection();

            if (addCommand.ExecuteNonQuery() == 1)
                MessageBox.Show("Товар добавлен");
            else
                MessageBox.Show("Товар не добавлен");

            db.closeConnection();

            dopForm dop = new dopForm();
            
            if (!CompProd())
            {
                dop.textBox_organization.Text = textBox_producer.Text;
                dop.textBox_organization.Enabled = false;
                dop.ShowDialog();
            }

            table.Clear();

            adapter.Fill(table);
            dataGridView_Product.DataSource = table;

            RefreshFields();
        }   // добавление элемента
        private void MainForm_Load(object sender, EventArgs e)
        {    
            caretaker.History.Push(orginator.SaveState());
            DB db = new DB();
            db.openConnection();

            adapter = new MySqlDataAdapter("SELECT * FROM `products`", db.GetConnection());
            table = new DataTable();

            adapter.Fill(table);
            dataGridView_Product.DataSource = table;

            db.closeConnection();
        }   // загрузка формы
        private void button_refresh_Click(object sender, EventArgs e)
        {
            table.Clear();

            adapter.Fill(table);
            dataGridView_Product.DataSource = table;
        }   // обновление таблицы
        public bool CheckUnique()
        {
            DB db = new DB();   
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand checkUnique = new MySqlCommand("SELECT * FROM `products` WHERE `id` = @id", db.GetConnection());
            checkUnique.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(textBox_id.Text);

            adapter.SelectCommand = checkUnique;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой id уже есть, введите другой");
                return true;
            }
            else
                return false;
        }   // проверка на уникальность id
        private void textBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }   // чтобы id был только из цифр
        private void trackBar_price_Scroll(object sender, EventArgs e)
        {
            label_price.Text = $"Цена {trackBar_price.Value}";
        }   // чтобы на трекбаре отображались цифры
        private void button_toProducer_Click(object sender, EventArgs e)
        {
            dopForm dopform = new dopForm();
            dopform.ShowDialog();
        }   // кнопка перехода на вторую форму
        private void RefreshFields()
        {
            textBox_name.Text = "";
            textBox_id.Text = "";
            numericUpDown_size.Value = 0;
            numericUpDown_weight.Value = 0;
            comboBox_type.Text = "";
            dateTimePicker_date.Value = DateTime.Now;
            numericUpDown_amount.Value = 0;
            trackBar_price.Value = 0;
            textBox_producer.Text = "";
            label_price.Text = $"Цена";
        }   // очистка полей
        private bool CompProd()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand checkUnique = new MySqlCommand("SELECT * FROM `producers` WHERE `organization` = @organization", db.GetConnection());
            checkUnique.Parameters.Add("@organization", MySqlDbType.VarChar).Value = textBox_producer.Text;

            adapter.SelectCommand = checkUnique;
            adapter.Fill(table);
           
            if (table.Rows.Count > 0)       
                return true;          
            else
            {
                return false;
            }
        }   // проверка на наличие производителя в таблице производителей
        private void toolStripButton_search_Click(object sender, EventArgs e)
        {
            textBox_min.Visible = false;
            textBox_max.Visible = false;
            label_min.Visible = false;
            label_max.Visible = false;
            if (!textBox_search.Visible)
            {
                textBox_search.Visible = true;
                button_search.Visible = true;
                searchType = 1;
            }
            else
            {
                textBox_search.Visible = false;
                button_search.Visible = false;
                searchType = 0;
            }
        }   // кнопка для открытия окна поиска по названию
        private void button_search_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            XmlSerializer ser = new XmlSerializer(typeof(DataTable));
            DataTable table = new DataTable("TableXML");
            TextWriter writer;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand search;
            switch (searchType)
            {
                case 1:
                    search = new MySqlCommand("SELECT * FROM `products` WHERE `name` LIKE @name", db.GetConnection());
                    search.Parameters.AddWithValue("@name", "%" + textBox_search.Text + "%");
                    adapter.SelectCommand = search;
                    adapter.Fill(table);
                    writer = new StreamWriter(Application.StartupPath + "\\" + "searchName" + ".xml");
                    ser.Serialize(writer, table);
                    writer.Close();
                    break;
                case 2:
                    search = new MySqlCommand("SELECT * FROM `products` WHERE `type` LIKE @type", db.GetConnection());
                    search.Parameters.AddWithValue("@type", "%" + textBox_search.Text + "%");
                    adapter.SelectCommand = search;
                    adapter.Fill(table);
                    writer = new StreamWriter(Application.StartupPath + "\\" + "searchType" + ".xml");
                    ser.Serialize(writer, table);
                    writer.Close();
                    break;
                case 3:
                    if (textBox_min.Text == "" && textBox_max.Text == "")
                    {
                        MessageBox.Show("Заполните поля");
                        return;
                    }
                    search = new MySqlCommand("SELECT * FROM `products` WHERE `price` > @min AND `price` < @max", db.GetConnection());
                    search.Parameters.Add("@min", MySqlDbType.Int32).Value = textBox_min.Text;
                    search.Parameters.Add("@max", MySqlDbType.Int32).Value = textBox_max.Text;
                    adapter.SelectCommand = search;
                    adapter.Fill(table);
                    writer = new StreamWriter(Application.StartupPath + "\\" + "searchPrice" + ".xml");
                    ser.Serialize(writer, table);
                    writer.Close();
                    break;
            }
            dataGridView_Product.DataSource = table;           
            
            textBox_search.Text = "";
            textBox_min.Text = "";
            textBox_max.Text = "";
        }   // кнопка поиска и сериализация
        private void toolStripButton_searchType_Click(object sender, EventArgs e)
        {
            textBox_min.Visible = false;
            textBox_max.Visible = false;
            label_min.Visible = false;
            label_max.Visible = false;
            if (!textBox_search.Visible)
            {
                textBox_search.Visible = true;
                button_search.Visible = true;
                searchType = 2;
            }
            else
            {
                textBox_search.Visible = false;
                button_search.Visible = false;
                searchType = 0;
            }
        }   // кнопка для открытия окна поиска по типу
        private void textBox_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }   // минимальное значение цены
        private void textBox_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }   // максимальное значение цены
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox_search.Visible = false;
            if (!textBox_min.Visible)
            {
                textBox_min.Visible = true;
                textBox_max.Visible = true;
                label_min.Visible = true;
                label_max.Visible = true;
                button_search.Visible = true;
                searchType = 3;
            }
            else
            {
                textBox_min.Visible = false;
                textBox_max.Visible = false;
                label_min.Visible = false;
                label_max.Visible = false;
                button_search.Visible = false;
                searchType = 0;
            }
        }   // кнопка открытия окна поиска по диапазону цены
        private void toolStripButton_program_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия 1.0.0\nРазработчик: Яшный Никита Сергеевич");
        }   // о программе
        private void button_Tools_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            button_Tools.Visible = false;
        }   // открыть панель инструментов
        private void toolStripButton_close_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            button_Tools.Visible = true;
        }   // скрыть панель инструментов    
        private void button_clear_Click(object sender, EventArgs e)
        {
            table.Clear();
        }   // очистить таблицу
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_delete.Text == "")
            {
                MessageBox.Show("Заполните поле для удаления");
                return;
            }
            caretaker.History.Push(orginator.SaveState());
            DB db = new DB();
            MySqlCommand delete = new MySqlCommand("DELETE FROM products WHERE `products`.`id` = @id", db.GetConnection());
            delete.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(textBox_delete.Text);

            db.openConnection();

            if (delete.ExecuteNonQuery() == 1)
                MessageBox.Show("Товар удалён");
            else
                MessageBox.Show("Такого id не существует");

            db.closeConnection();

            table.Clear();

            adapter.Fill(table);
            dataGridView_Product.DataSource = table;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            if (caretaker.History.Count > 0)
            {
                table.Clear();
                dataGridView_Product.DataSource = table;

                orginator.RestoreState(caretaker.History.Pop());
                dataGridView_Product.DataSource = orginator.dt;
            }
            else
                MessageBox.Show("Вы откатились к первоначальному состоянию");
        }

        private void textBox_delete_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        //public int Counter()
        //{
        //    //DB db = new DB();
        //    //MySqlCommand count = new MySqlCommand("select count(*) from `products` where columname = 'id'", db.GetConnection());
        //    //count.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(textBox_delete.Text);
        //    //adapter.SelectCommand = count;
            
        //    //return counter;
        //}
    }
}