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
using System.Windows.Shapes;
using Patient_Registration_System.Views;

namespace Patient_Registration_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            var win2 = new Admin();
            win2.Show();
            this.Close();
        }

        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
            var win2 = new Staff();
            win2.Show();
            this.Close();
        }
    }
}
