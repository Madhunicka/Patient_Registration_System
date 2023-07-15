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
    /// Interaction logic for PatientReg1.xaml
    /// </summary>
    public partial class PatientReg1 : Window
    {
        int totalCount = 0;
        public PatientReg1()
        {
            DataContext = new PatientRegVM();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win1 = new PatientRegSub1();
            win1.Show();
            this.Close();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            totalCount = datagrid1.Items.Count - 1;
            MessageBox.Show($"Total number of patients: {totalCount}");
        }
    }
}
