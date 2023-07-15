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
    public partial class StaffRegVM : ObservableObject
    {
        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public string staffName;
        [ObservableProperty]
        public string address;
        [ObservableProperty]
        public int contNo;
        [ObservableProperty]
        public int age;
       
        [ObservableProperty]
        ObservableCollection<Person2> staffs;
        public Person2 SelectedPerson { get; set; }



        [RelayCommand]
        public void InsertPerson()
        {
            if (string.IsNullOrEmpty(StaffName))
            {
                
                MessageBox.Show("Please enter Relevant details.");
                return;
            }
            Person2 p2 = new Person2() { Id = Id, StaffName = StaffName, Address = Address, ContNo = ContNo, Age = Age};
            using (var db = new Person2Context())
            {
                db.Staffs.Add(p2);
                db.SaveChanges();
                Id = 0;
                StaffName = "";
               Address = "";
                ContNo = 0;
                Age = 0;



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
            using (var db = new Person2Context())
            {

                var selectedPerson = db.Staffs.FirstOrDefault(p2 => p2.Id == SelectedPerson.Id);

                if (selectedPerson != null)
                {

                    selectedPerson.StaffName = StaffName;
                    selectedPerson.Address = Address;
                    selectedPerson.ContNo = ContNo;
                    selectedPerson.Age = Age;

                  



                    db.SaveChanges();
                    Id = 0;
                    StaffName = "";
                    Address = "";
                    ContNo = 0;
                    Age = 0;



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

            using (var db = new Person2Context())
            {

                var selectedPerson = db.Staffs.FirstOrDefault(p2 => p2.Id == SelectedPerson.Id);

                if (selectedPerson != null)
                {

                    db.Staffs.Remove(selectedPerson);


                    db.SaveChanges();


                    LoadPerson();
                }
                else
                {
                    MessageBox.Show("Selected person not found in database.");
                }
            }
        }

        public Person2 GetPersonById(int id)
        {
            using (var db = new Person2Context())
            {
                return db.Staffs.FirstOrDefault(p2 => p2.Id == id);
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

            Person2 person2 = GetPersonById(id);

            if (person2 != null)
            {
                MessageBox.Show($"Id: {person2.Id}\nStaff_Name: {person2.StaffName}\nAge: {person2.Age}\nContact_Number: {person2.ContNo}\nAddress: {person2.Address}");
            }
            else
            {
                MessageBox.Show("Person not found.");
            }
        }





        public void LoadPerson()
        {
            using (var db = new Person2Context())
            {
                var list = db.Staffs.OrderByDescending(p2 => p2.Id).ToList();
                Staffs = new ObservableCollection<Person2>(list);
            }
        }
        public StaffRegVM()
        {
            LoadPerson();

        }
    }
}

