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
    public partial class StaffSignUpVM: ObservableObject
    {
        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public string staffName;

        [ObservableProperty]
        public string userName;

        [ObservableProperty]
        public string passwrd;

        
        [ObservableProperty]
        ObservableCollection<Password> passwords;
        public Password SelectedPerson { get; set; }



        [RelayCommand]
        public void InsertPerson()
        {
            if (string.IsNullOrEmpty(StaffName))
            {
                MessageBox.Show("Please enter Relevant details.");
                return;
            }
            Password p = new Password() { Id = Id, StaffName = StaffName, UserName = UserName, Passwrd=Passwrd};
            using (var db = new PasswordContext())
            {
                db.Passwords.Add(p);
                db.SaveChanges();
                Id = 0;
                StaffName = "";
                UserName = "";
                Passwrd = "";
             

            }
            LoadPerson();


        }

        [RelayCommand]
        public void UpdatePerson()
        {
            if (SelectedPerson == null)
            {
                MessageBox.Show("Please select a person to update.");
                return;
            }
            using (var db = new PasswordContext())
            {

                var selectedPerson = db.Passwords.FirstOrDefault(p => p.Id == SelectedPerson.Id);

                if (selectedPerson != null)
                {

                    selectedPerson.StaffName = StaffName;
                    selectedPerson.UserName = UserName;
                    selectedPerson.Passwrd = Passwrd;
            



                    db.SaveChanges();
                    Id = 0;
                    StaffName = "";
                    UserName = "";
                    Passwrd = "";
     



                    LoadPerson();
                }
                else
                {
                    MessageBox.Show("Selected person not found in database.");
                }
            }
        }
        [RelayCommand]
        public void DeletePerson()
        {
            if (SelectedPerson == null)
            {
                MessageBox.Show("Please select a person to delete.");
                return;
            }

            using (var db = new PasswordContext())
            {

                var selectedPerson = db.Passwords.FirstOrDefault(p => p.Id == SelectedPerson.Id);

                if (selectedPerson != null)
                {

                    db.Passwords.Remove(selectedPerson);


                    db.SaveChanges();


                    LoadPerson();
                }
                else
                {
                    MessageBox.Show("Selected person not found in database.");
                }
            }
        }

        public Password GetPersonById(int id)
        {
            using (var db = new PasswordContext())
            {
                return db.Passwords.FirstOrDefault(p => p.Id == id);
            }
        }
        [RelayCommand]
        private void ReadPerson()
        {
            if (id == 0)
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }

            Password password = GetPersonById(id);

            if (password != null)
            {
                MessageBox.Show($"Id: {password.Id}\nStaff_Name: {password.StaffName}\nUser_Name: {password.UserName}\nPassword: {password.Passwrd}\n");
            }
            else
            {
                MessageBox.Show("Person not found.");
            }
        }





        public void LoadPerson()
        {
            using (var db = new PasswordContext())
            {

                var list = db.Passwords.OrderByDescending(p => p.Id).ToList();
                Passwords = new ObservableCollection<Password>(list);
            }
        }
        public StaffSignUpVM()
        {
            LoadPerson();

        }
    }
}
