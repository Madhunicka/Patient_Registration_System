﻿using System;
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
    /// Interaction logic for StaffSub.xaml
    /// </summary>
    public partial class StaffSub : Window
    {
        public StaffSub()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win1 = new PatientRegSub1();
            win1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var win1 = new SurgeriesSub1();
            win1.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var win1 = new MainWindow();
            win1.Show();
            this.Close();
        }
    }
}
