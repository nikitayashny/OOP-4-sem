using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace laba4
{
    public partial class MainWindow : Window
    {
        public Uri uri = new Uri("C:/Users/User/Desktop/ООТПиСП/laba4/laba4/english.xaml", UriKind.RelativeOrAbsolute);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Catalog_Click(object sender, RoutedEventArgs e)
        {
            CatalogWindow catalogWindow = new CatalogWindow();
            catalogWindow.ShowDialog();
        }

        private void button_Add_Click(object sender, RoutedEventArgs e)
        {
            AddWindow addWindow = new AddWindow();
            addWindow.ShowDialog();
        }

        private void button_Delete_Click(object sender, RoutedEventArgs e)
        {
            DeleteWindow deleteWindow = new DeleteWindow();
            deleteWindow.ShowDialog();
        }

        private void button_LanguageEng_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.Resources.MergedDictionaries[0].Source == uri)
            {
                Application.Current.Resources.MergedDictionaries[0].Source = new Uri("C:/Users/User/Desktop/ООТПиСП/laba4/laba4/russian.xaml", UriKind.RelativeOrAbsolute);
            }
            else
                Application.Current.Resources.MergedDictionaries[0].Source = new Uri("C:/Users/User/Desktop/ООТПиСП/laba4/laba4/english.xaml", UriKind.RelativeOrAbsolute);
        }
    }
}
