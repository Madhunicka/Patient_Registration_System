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
    public partial class SurgeriesVM : ObservableObject
    {
        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public string patientName;

        [ObservableProperty]
        public string surgentName;

        [ObservableProperty]
        public int contNo;
        [ObservableProperty]
        public int age;
        [ObservableProperty]
        public DateOnly surDate;
        [ObservableProperty]
        ObservableCollection<Person1> surgeries;
        public Person1 SelectedPerson { get; set; }



        [RelayCommand]
        public void InsertPerson()
        {
            if (string.IsNullOrEmpty(PatientName))
            {
               
                MessageBox.Show("Please enter Relevant details.");
                return;
            }
            Person1 p1 = new Person1() { Id = Id, PatientName = PatientName, SurgentName = SurgentName, ContNo = ContNo, Age = Age, SurDate = SurDate };
            using (var db = new Person1Context())
            {
                db.Surgeries.Add(p1);
                db.SaveChanges();
                Id = 0;
                PatientName = "";
                SurgentName = "";
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
            using (var db = new Person1Context())
            {

                var selectedPerson = db.Surgeries.FirstOrDefault(p1 => p1.Id == SelectedPerson.Id);

                if (selectedPerson != null)
                {

                    selectedPerson.PatientName = PatientName;
                    selectedPerson.SurgentName = SurgentName;
                    selectedPerson.ContNo = ContNo;
                    selectedPerson.Age = Age;

                    selectedPerson.SurDate = SurDate;



                    db.SaveChanges();
                    Id = 0;
                    PatientName = "";
                    SurgentName = "";
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

            using (var db = new Person1Context())
            {

                var selectedPerson = db.Surgeries.FirstOrDefault(p1 => p1.Id == SelectedPerson.Id);

                if (selectedPerson != null)
                {

                    db.Surgeries.Remove(selectedPerson);


                    db.SaveChanges();


                    LoadPerson();
                }
                else
                {
                    MessageBox.Show("Selected person not found in database.");
                }
            }
        }

        public Person1 GetPersonById(int id)
        {
            using (var db = new Person1Context())
            {
                return db.Surgeries.FirstOrDefault(p1 => p1.Id == id);
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

            Person1 person1 = GetPersonById(id);

            if (person1 != null)
            {
                MessageBox.Show($"Id: {person1.Id}\nPatient_Name: {person1.SurgentName}\nAge: {person1.Age}\nContact_Number: {person1.ContNo}\nDate: {person1.SurDate}");
            }
            else
            {
                MessageBox.Show("Person not found.");
            }
        }





        public void LoadPerson()
        {
            using (var db = new Person1Context())
            {
                var list = db.Surgeries.OrderByDescending(p1 => p1.Id).ToList();
                Surgeries = new ObservableCollection<Person1>(list);
            }
        }
        public SurgeriesVM()
        {
            LoadPerson();

        }
    }
}
