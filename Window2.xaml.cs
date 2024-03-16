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
    }
}
