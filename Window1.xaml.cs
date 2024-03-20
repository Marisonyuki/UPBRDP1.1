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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ProjectTableAdapter Project = new ProjectTableAdapter();
        public Window1()
        {
            InitializeComponent();
            BDG2.ItemsSource = Project.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window0 = new MainWindow();
            window0.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Project.InsertQuery(Texter1.Text, Convert.ToDateTime(Texter2.Text));
            BDG2.ItemsSource = Project.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            object id = (BDG2.SelectedItem as DataRowView).Row[0];
            Project.UpdateQuery(Texter1.Text, Convert.ToDateTime(Texter2.Text), Convert.ToInt32(id));
            BDG2.ItemsSource = Project.GetData();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            object id = (BDG2.SelectedItem as DataRowView).Row[0];
            Project.DeleteQuery(Convert.ToInt32(id));
            BDG2.ItemsSource = Project.GetData();
        }
    }
}
