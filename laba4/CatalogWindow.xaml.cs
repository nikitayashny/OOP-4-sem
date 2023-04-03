using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using MySql.Data.MySqlClient;

namespace laba4
{
    public partial class CatalogWindow : Window
    {
        private MySqlDataAdapter adapter;
        private DataTable table;

        private Command search;
        private Command priceSearch;
        private Command rbs_Checked;
        private Command rbm_Checked;
        private Command rbl_Checked;
        private Command change;
        private Command delete;

        public ICommand Search
        {
            get
            {
                return search ?? (search = new Command(obj =>
                {
                    try
                    {
                        RBS.IsChecked = false;
                        RBM.IsChecked = false;
                        RBL.IsChecked = false;
                        TextBox_PriceSearch.Text = "";
                        TextBox_ChangePrice.Text = "";

                        DB db = new DB();
                        adapter = new MySqlDataAdapter();
                        table = new DataTable();

                        MySqlCommand search = new MySqlCommand("SELECT * FROM `products` WHERE `name` LIKE @name", db.GetConnection());
                        search.Parameters.AddWithValue("@name", "%" + TextBox_Search.Text + "%");

                        adapter.SelectCommand = search;
                        adapter.Fill(table);

                        listviewProducts.ItemsSource = table.DefaultView;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }));
            }
        }
        public ICommand PriceSearch
        {
            get
            {
                return priceSearch ?? (priceSearch = new Command(obj =>
                {
                    try
                    {
                        RBS.IsChecked = false;
                        RBM.IsChecked = false;
                        RBL.IsChecked = false;
                        TextBox_ChangePrice.Text = "";
                        TextBox_Search.Text = "";

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
                }));
            }
        }

        public ICommand RBS_Checked
        {
            get
            {
                return rbs_Checked ?? (rbs_Checked = new Command(obj =>
                {
                    try
                    {
                        TextBox_PriceSearch.Text = "";
                        TextBox_ChangePrice.Text = "";
                        TextBox_Search.Text = "";

                        DB db = new DB();

                        adapter = new MySqlDataAdapter();
                        table = new DataTable();

                        MySqlCommand search = new MySqlCommand("SELECT * FROM `products` WHERE size = @size", db.GetConnection());
                        search.Parameters.Add("@size", MySqlDbType.VarChar).Value = RBS.Content;

                        adapter.SelectCommand = search;
                        adapter.Fill(table);

                        listviewProducts.ItemsSource = table.DefaultView;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }));
            }
        }

        public ICommand RBM_Checked
        {
            get
            {
                return rbm_Checked ?? (rbm_Checked = new Command(obj =>
                {
                    try
                    {
                        TextBox_PriceSearch.Text = "";
                        TextBox_ChangePrice.Text = "";
                        TextBox_Search.Text = "";

                        DB db = new DB();

                        adapter = new MySqlDataAdapter();
                        table = new DataTable();

                        MySqlCommand search = new MySqlCommand("SELECT * FROM `products` WHERE size = @size", db.GetConnection());
                        search.Parameters.Add("@size", MySqlDbType.VarChar).Value = RBM.Content;

                        adapter.SelectCommand = search;
                        adapter.Fill(table);

                        listviewProducts.ItemsSource = table.DefaultView;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }));
            }
        }
        public ICommand RBL_Checked
        {
            get
            {
                return rbl_Checked ?? (rbl_Checked = new Command(obj =>
                {
                    try
                    {
                        TextBox_PriceSearch.Text = "";
                        TextBox_ChangePrice.Text = "";
                        TextBox_Search.Text = "";

                        DB db = new DB();

                        adapter = new MySqlDataAdapter();
                        table = new DataTable();

                        MySqlCommand search = new MySqlCommand("SELECT * FROM `products` WHERE size = @size", db.GetConnection());
                        search.Parameters.Add("@size", MySqlDbType.VarChar).Value = RBL.Content;

                        adapter.SelectCommand = search;
                        adapter.Fill(table);

                        listviewProducts.ItemsSource = table.DefaultView;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }));
            }
        }

        public ICommand Change
        {
            get
            {
                return change ?? (change = new Command(obj =>
                {
                    try
                    {
                        RBS.IsChecked = false;
                        RBM.IsChecked = false;
                        RBL.IsChecked = false;
                        TextBox_PriceSearch.Text = "";
                        TextBox_Search.Text = "";

                        if (listviewProducts.SelectedItem != null)
                        {
                            object o = listviewProducts.SelectedItem;
                            ListViewItem lvi = (ListViewItem)listviewProducts.ItemContainerGenerator.ContainerFromItem(o);
                            TextBlock tb = FindByName("TextBlock_id", lvi) as TextBlock;

                            if (tb != null)
                                tb.Dispatcher.BeginInvoke(new Func<bool>(tb.Focus));

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

                            if (flag)
                                return;

                            MySqlCommand change = new MySqlCommand("UPDATE `products` SET `price` = @price WHERE `products`.`id_product` = @id;", db.GetConnection());
                            change.Parameters.Add("@price", MySqlDbType.Int32).Value = TextBox_ChangePrice.Text;
                            change.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(tb.Text);
                            adapter.SelectCommand = change;
                            adapter.Fill(table);

                            Refresh();
                            TextBox_ChangePrice.Text = "";
                        }
                        else
                            MessageBox.Show("Не выбран элемент для изменения");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }));
            }
        }
        public ICommand Delete
        {
            get
            {
                return delete ?? (delete = new Command(obj =>
                {
                    try
                    {
                        if (listviewProducts.SelectedItem != null)
                        {
                            object o = listviewProducts.SelectedItem;
                            ListViewItem lvi = (ListViewItem)listviewProducts.ItemContainerGenerator.ContainerFromItem(o);
                            TextBlock tb = FindByName("TextBlock_id", lvi) as TextBlock;

                            if (tb != null)
                                tb.Dispatcher.BeginInvoke(new Func<bool>(tb.Focus));

                            DB db = new DB();
                            MySqlCommand delete = new MySqlCommand("DELETE FROM products WHERE `products`.`id_product` = @id", db.GetConnection());
                            delete.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(tb.Text);

                            db.openConnection();

                            if (delete.ExecuteNonQuery() == 1)
                                MessageBox.Show("Товар удалён");
                            else
                                MessageBox.Show("Такого id не существует");

                            db.closeConnection();

                            listviewProducts.SelectedItem = null;
                            Refresh();
                        }
                        else
                            MessageBox.Show("Не выбран элемент для удаления");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }));
            }
        }
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

        private FrameworkElement FindByName(string name, FrameworkElement root)
        {
            Stack<FrameworkElement> tree = new Stack<FrameworkElement>();
            tree.Push(root);

            while (tree.Count > 0)
            {
                FrameworkElement current = tree.Pop();
                if (current.Name == name)
                    return current;

                int count = VisualTreeHelper.GetChildrenCount(current);
                for (int i = 0; i < count; ++i)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(current, i);
                    if (child is FrameworkElement)
                        tree.Push((FrameworkElement)child);
                }
            }
            return null;
        }
    }
}
