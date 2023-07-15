using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Patient_Registration_System.Views
{
    public partial class AdminRegVM:ObservableObject
    {
        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public string adminName;

        [ObservableProperty]
        public string userName;

        [ObservableProperty]
        public string passwrd;
     


        [ObservableProperty]
        ObservableCollection<PasswordAdmin> passwordsadmin;
        public PasswordAdmin SelectedPerson { get; set; }

      
        [RelayCommand]
        public void InsertPerson()
        {
            if (string.IsNullOrEmpty(AdminName))
            {
                MessageBox.Show("Please enter Relevant details.");
                return;
            }
            PasswordAdmin p = new PasswordAdmin() { Id = Id, AdminName = AdminName, UserName = UserName, Passwrd = Passwrd };
            using (var db = new Password1Context())
            {
                db.PasswordsAdmin.Add(p);
                db.SaveChanges();
                Id = 0;
                AdminName = "";
                UserName = "";
                Passwrd = "";
             

            }
            LoadPerson();


        }
        public void LoadPerson()
        {
            using (var db = new Password1Context())
            {

                var list = db.PasswordsAdmin.OrderByDescending(p => p.Id).ToList();
                Passwordsadmin = new ObservableCollection<PasswordAdmin>(list);
            }
        }
        public AdminRegVM()
        {
            LoadPerson();

        }



    }
}
