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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Button_click3(object sender, RoutedEventArgs e)
        {
            string username = textUsername.Text;
            string password = txtPassword.Password;

            using (var context = new Password1Context())
            {
                // Query the Passwords table to check if the entered username and password match
                var matchingPassword = context.PasswordsAdmin.FirstOrDefault(p => p.UserName == username && p.Passwrd == password);

                if (matchingPassword != null)
                {
                    MessageBox.Show("Login successful!");
                    var win1 = new AdminSub();
                    win1.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }








          //  string username = textUsername.Text;
          //  string password = txtPassword.Password;

           // if (username == "admin" && password == "password")
           // {
           //     MessageBox.Show("Login successful!");
           //     var win1 = new AdminSub();
             //   win1.Show();
           //     this.Close();
          //  }
          //  else
          //  {
          //      MessageBox.Show("Invalid username or password.");
           // }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win1 = new MainWindow();
            win1.Show();
            this.Close();
        }

        private void btn_submit1_Copy_Click(object sender, RoutedEventArgs e)
        {
            var win1 = new AdminReg();
            win1.Show();
        }

    }
}
