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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UPBRDP1.BRDUPDataSetTableAdapters;

namespace UPBRDP1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WorkerTableAdapter Worker = new WorkerTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            BDG.ItemsSource = Worker.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Worker.InsertQuery(Texter1.Text, Texter2.Text, Texter3.Text);
            BDG.ItemsSource = Worker.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (BDG.SelectedItem as DataRowView).Row[0];
            Worker.UpdateQuery(Texter1.Text, Texter2.Text, Texter3.Text, Convert.ToInt32(id));
            BDG.ItemsSource = Worker.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            object id = (BDG.SelectedItem as DataRowView).Row[0];
            Worker.DeleteQuery(Convert.ToInt32(id));
            BDG.ItemsSource = Worker.GetData();
        }
    }
}
