using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;

namespace Patient_Registration_System.Views
{
    public partial class PatientRegVM : ObservableObject
    {
        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public string patientName;
        [ObservableProperty]
        public string address;
        [ObservableProperty]
        public int contNo;
        [ObservableProperty]
        public int age;
        
        [ObservableProperty]
        public DateOnly appointDate;
        [ObservableProperty]
        ObservableCollection<Person> persons;
        public Person SelectedPerson { get; set; }



        [RelayCommand]
       public void InsertPerson()
        {
            if (string.IsNullOrEmpty(PatientName))
            {
                
                MessageBox.Show("Please enter Relevant details.");
                return;
            }
            Person p = new Person() { Id = Id, PatientName = PatientName, Address = Address, ContNo = ContNo, Age = Age,  AppointDate = AppointDate };
            using (var db = new PersonContext())
            {
                db.Persons.Add(p);
                db.SaveChanges();
                Id = 0;
                PatientName = "";
                Address = "";
                ContNo = 0;
                Age= 0;
                
               
                 
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
            using (var db = new PersonContext())
            {

                var selectedPerson = db.Persons.FirstOrDefault(p => p.Id == SelectedPerson.Id);

                if (selectedPerson != null)
                {

                    selectedPerson.PatientName = PatientName;
                    selectedPerson.Address = Address;
                    selectedPerson.ContNo = ContNo;
                    selectedPerson.Age = Age;
                   
                    selectedPerson.AppointDate = AppointDate;



                    db.SaveChanges();
                    Id = 0;
                    PatientName = "";
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

            using (var db = new PersonContext())
            {

                var selectedPerson = db.Persons.FirstOrDefault(p => p.Id == SelectedPerson.Id);

                if (selectedPerson != null)
                {

                    db.Persons.Remove(selectedPerson);


                    db.SaveChanges();


                    LoadPerson();
                }
                else
                {
                    MessageBox.Show("Selected person not found in database.");
                }
            }
        }

        public Person GetPersonById(int id)
        {
            using (var db = new PersonContext())
            {
                return db.Persons.FirstOrDefault(p => p.Id == id);
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

            Person person = GetPersonById(id);

            if (person != null)
            {
                MessageBox.Show($"Id: {person.Id}\nPatient_Name: {person.PatientName}\nAge: {person.Age}\nContact_Number: {person.ContNo}\nDate: {person.AppointDate}");
            }
            else
            {
                MessageBox.Show("Person not found.");
            }
        }





        public void LoadPerson()
        {
            using (var db = new PersonContext())
            {

                var list = db.Persons.OrderByDescending(p => p.Id).ToList();
                Persons = new ObservableCollection<Person>(list);
            }
        }

      
        public PatientRegVM()
        {
            LoadPerson();

        }
       

     

    }
}

