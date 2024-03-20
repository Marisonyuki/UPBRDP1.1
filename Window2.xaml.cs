using System;
using System.Collections.Generic;
using System.Data;
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
using UPBRDP1.BRDUPDataSetTableAdapters;

namespace UPBRDP1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        GameIndustryTableAdapter GI = new GameIndustryTableAdapter();
        public Window2()
        {
            InitializeComponent();
            BDG3.ItemsSource = GI.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GI.InsertQuery(Convert.ToInt32(Texter1.Text), Convert.ToInt32(Texter2.Text));
            BDG3.ItemsSource = GI.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (BDG3.SelectedItem as DataRowView).Row[0];
            GI.UpdateQuery(Convert.ToInt32(Texter1.Text), Convert.ToInt32(Texter2.Text), Convert.ToInt32(id));
            BDG3.ItemsSource = GI.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            object id = (BDG3.SelectedItem as DataRowView).Row[0];
             GI.DeleteQuery(Convert.ToInt32(id));
            BDG3.ItemsSource = GI.GetData();
        }
    }
}
