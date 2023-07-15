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

namespace Patient_Registration_System.Views
{
    /// <summary>
    /// Interaction logic for Surgeries.xaml
    /// </summary>
    public partial class Surgeries : Window
    {
        int totalCount = 0;
        public Surgeries()
        {
            DataContext = new SurgeriesVM();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win1 = new SurgeriesSub();
            win1.Show();
            this.Close();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            totalCount = datagrid1.Items.Count - 1;
            MessageBox.Show($"Total number of Surgeries: {totalCount}");
        }

        private void datagrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
