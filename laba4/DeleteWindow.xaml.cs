using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace laba4
{
    public partial class DeleteWindow : Window
    {
        public DeleteWindow()
        {
            InitializeComponent();
        }

        private void DeleteProduct_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TextBox_Delete.Text == "")
                {
                    TextBox_Delete.Background = new SolidColorBrush(Color.FromArgb(80, 255, 0, 0));
                    return;
                }
                else
                    TextBox_Delete.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));

                DB db = new DB();
                MySqlCommand delete = new MySqlCommand("DELETE FROM products WHERE `products`.`id_product` = @id", db.GetConnection());
                delete.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(TextBox_Delete.Text);

                db.openConnection();

                if (delete.ExecuteNonQuery() == 1)
                    MessageBox.Show("Товар удалён");
                else
                    MessageBox.Show("Такого id не существует");

                db.closeConnection();
                TextBox_Delete.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
