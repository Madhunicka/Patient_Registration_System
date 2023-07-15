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
using System.Data.SqlClient;

namespace Patient_Registration_System.Views
{
    /// <summary>
    /// Interaction logic for Staff.xaml
    /// </summary>
    public partial class Staff : Window
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Button_click4(object sender, RoutedEventArgs e)
        {
            string username = textUsername.Text;
            string password = txtPassword.Password;

            using (var context = new PasswordContext())
            {
                // Query the Passwords table to check if the entered username and password match
                var matchingPassword = context.Passwords.FirstOrDefault(p => p.UserName == username && p.Passwrd == password);

                if (matchingPassword != null)
                {
                    MessageBox.Show("Login successful!");
                    var win1 = new StaffSub();
                    win1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void Button_click5(object sender, RoutedEventArgs e)
        {
            var win1 = new StaffSignUp();
            win1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win1 = new MainWindow();
            win1.Show();
            this.Close();

        }
    }
}
