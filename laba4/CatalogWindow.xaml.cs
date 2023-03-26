using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
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
    public partial class CatalogWindow : Window
    {
        private MySqlDataAdapter adapter;
        private DataTable table;

        public CatalogWindow()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            try
            {
                DB db = new DB();
                db.openConnection();

                adapter = new MySqlDataAdapter("SELECT * FROM `products`", db.GetConnection());
                table = new DataTable();

                adapter.Fill(table);
                listviewProducts.ItemsSource = table.DefaultView;

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {      
            RBS.IsChecked = false;
            RBM.IsChecked = false;
            RBL.IsChecked = false;
            TextBox_PriceSearch.Text = "";
            TextBox_ChangePrice.Text = "";
            TextBox_Id.Text = "";

            DB db = new DB();

            adapter = new MySqlDataAdapter();
            table = new DataTable();

            MySqlCommand search = new MySqlCommand("SELECT * FROM `products` WHERE `name` LIKE @name", db.GetConnection());
            search.Parameters.AddWithValue("@name", "%" + TextBox_Search.Text + "%");

            adapter.SelectCommand = search;
            adapter.Fill(table);

            listviewProducts.ItemsSource = table.DefaultView;
        }
        
        private void RBS_Checked(object sender, RoutedEventArgs e)
        {
            TextBox_PriceSearch.Text = "";
            TextBox_ChangePrice.Text = "";
            TextBox_Search.Text = "";
            TextBox_Id.Text = "";

            DB db = new DB();

            adapter = new MySqlDataAdapter();
            table = new DataTable();

            MySqlCommand search = new MySqlCommand("SELECT * FROM `products` WHERE size = @size", db.GetConnection());
            search.Parameters.Add("@size", MySqlDbType.VarChar).Value = RBS.Content;

            adapter.SelectCommand = search;
            adapter.Fill(table);

            listviewProducts.ItemsSource = table.DefaultView;
        }

        private void RBM_Checked(object sender, RoutedEventArgs e)
        {
            TextBox_PriceSearch.Text = "";
            TextBox_ChangePrice.Text = "";
            TextBox_Search.Text = "";
            TextBox_Id.Text = "";

            DB db = new DB();

            adapter = new MySqlDataAdapter();
            table = new DataTable();

            MySqlCommand search = new MySqlCommand("SELECT * FROM `products` WHERE size = @size", db.GetConnection());
            search.Parameters.Add("@size", MySqlDbType.VarChar).Value = RBM.Content;

            adapter.SelectCommand = search;
            adapter.Fill(table);

            listviewProducts.ItemsSource = table.DefaultView;
        }

        private void RBL_Checked(object sender, RoutedEventArgs e)
        {
            TextBox_PriceSearch.Text = "";
            TextBox_ChangePrice.Text = "";
            TextBox_Search.Text = "";
            TextBox_Id.Text = "";

            DB db = new DB();

            adapter = new MySqlDataAdapter();
            table = new DataTable();

            MySqlCommand search = new MySqlCommand("SELECT * FROM `products` WHERE size = @size", db.GetConnection());
            search.Parameters.Add("@size", MySqlDbType.VarChar).Value = RBL.Content;

            adapter.SelectCommand = search;
            adapter.Fill(table);

            listviewProducts.ItemsSource = table.DefaultView;
        }

        private void Button_PriceSearch_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RBS.IsChecked = false;
                RBM.IsChecked = false;
                RBL.IsChecked = false;
                TextBox_ChangePrice.Text = "";
                TextBox_Search.Text = "";
                TextBox_Id.Text = "";

                DB db = new DB();

                adapter = new MySqlDataAdapter();
                table = new DataTable();

                MySqlCommand search = new MySqlCommand("SELECT * FROM `products` WHERE price <= @price", db.GetConnection());
                search.Parameters.Add("@price", MySqlDbType.Int32).Value = TextBox_PriceSearch.Text;

                adapter.SelectCommand = search;
                adapter.Fill(table);

                listviewProducts.ItemsSource = table.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Change_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                RBS.IsChecked = false;
                RBM.IsChecked = false;
                RBL.IsChecked = false;
                TextBox_PriceSearch.Text = "";
                TextBox_Search.Text = "";

                DB db = new DB();

                adapter = new MySqlDataAdapter();
                table = new DataTable();

                bool flag = false;
                if (TextBox_ChangePrice.Text == "")
                {
                    TextBox_ChangePrice.Background = new SolidColorBrush(Color.FromArgb(80, 255, 0, 0));
                    flag = true;
                }
                else
                    TextBox_ChangePrice.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                if (TextBox_Id.Text == "")
                {
                    TextBox_Id.Background = new SolidColorBrush(Color.FromArgb(80, 255, 0, 0));
                    flag = true;
                }
                else
                    TextBox_Id.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                if (flag)
                    return;

                MySqlCommand checkUnique = new MySqlCommand("SELECT * FROM `products` WHERE id_product = @id", db.GetConnection());
                checkUnique.Parameters.Add("@id", MySqlDbType.Int32).Value = TextBox_Id.Text;

                adapter.SelectCommand = checkUnique;
                adapter.Fill(table);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Такого id не существует");
                    TextBox_Id.Text = "";
                    TextBox_ChangePrice.Text = "";
                    return;
                }

                MySqlCommand change = new MySqlCommand("UPDATE `products` SET `price` = @price WHERE `products`.`id_product` = @id;", db.GetConnection());
                change.Parameters.Add("@price", MySqlDbType.Int32).Value = TextBox_ChangePrice.Text;
                change.Parameters.Add("@id", MySqlDbType.Int32).Value = TextBox_Id.Text;
                adapter.SelectCommand = change;     
                adapter.Fill(table);
                MessageBox.Show("Успешно");

                Refresh();
                TextBox_Id.Text = "";
                TextBox_ChangePrice.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
