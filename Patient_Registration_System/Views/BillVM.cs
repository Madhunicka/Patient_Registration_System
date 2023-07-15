using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Patient_Registration_System.Views
{
    public partial class BillVM : ObservableObject
    {
        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public string patientName;
        [ObservableProperty]
        public double doctorCharge;
        [ObservableProperty]
        public double medicationCost;
        [ObservableProperty]
        public double labTests;

        [ObservableProperty]
        public double serviceCharges;

        [ObservableProperty]
        public double additionalCharge;
        [ObservableProperty]
        ObservableCollection<Bill> bills;
        public Bill SelectedBill { get; set; }



        [RelayCommand]

        public void Add()
        {

            if (string.IsNullOrEmpty(PatientName))
                {

                    MessageBox.Show("Please enter Relevant details.");
                    return;
                }
                Bill p = new Bill() {Id = Id, PatientName = PatientName, DoctorCharge = DoctorCharge, MedicationCost = MedicationCost, LabTests = LabTests, ServiceCharges = ServiceCharges, AdditionalCharge=AdditionalCharge};
                using (var db = new BillContext())
                {
                    db.Bills.Add(p);
                    db.SaveChanges();
                    Id = 0;
                    PatientName = "";
                    DoctorCharge = 0;
                    MedicationCost = 0;
                    LabTests = 0;
                    ServiceCharges = 0;
                    AdditionalCharge = 0;

                }
                LoadPerson();


            

        }
        [RelayCommand]
        public void CalculateBill()
        {
            if (SelectedBill == null)
            {
                MessageBox.Show("Please select a person to print the bill.");
                return;
            }

            double totalAmount = SelectedBill.DoctorCharge + SelectedBill.ServiceCharges +
                SelectedBill.AdditionalCharge + SelectedBill.MedicationCost + SelectedBill.LabTests;

            StringBuilder billContent = new StringBuilder();
            billContent.AppendLine("---------- Bill ----------");
            billContent.AppendLine($"Patient Name: {SelectedBill.PatientName}");
            billContent.AppendLine($"Doctor Charge: {SelectedBill.DoctorCharge}");
            billContent.AppendLine($"Service Charges: {SelectedBill.ServiceCharges}");
            billContent.AppendLine($"Additional Charge: {SelectedBill.AdditionalCharge}");
            billContent.AppendLine($"Medication Cost: {SelectedBill.MedicationCost}");
            billContent.AppendLine($"Lab Tests: {SelectedBill.LabTests}");
            billContent.AppendLine("---------------------------");
            billContent.AppendLine($"Total Amount: {totalAmount}");
            billContent.AppendLine("--------------------------");

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                FlowDocument document = CreatePrintableDocument(billContent.ToString());
                document.PageHeight = printDialog.PrintableAreaHeight;
                document.PageWidth = printDialog.PrintableAreaWidth;
                printDialog.PrintDocument(((IDocumentPaginatorSource)document).DocumentPaginator, "Print Bill");
            }
        }

        private FlowDocument CreatePrintableDocument(string billContent)
        {
            FlowDocument document = new FlowDocument();
            Paragraph paragraph = new Paragraph();
            paragraph.Margin = new Thickness(50);
            paragraph.FontFamily = new FontFamily("Arial");
            paragraph.FontSize = 25;
            paragraph.TextAlignment = TextAlignment.Justify;

            paragraph.Inlines.Add(billContent);
            document.Blocks.Add(paragraph);
            return document;
        }







        public void LoadPerson()
        {
            using (var db = new BillContext())
            {

                var list = db.Bills.OrderByDescending(p => p.Id).ToList();
                Bills = new ObservableCollection<Bill>(list);
            }
        }

        public BillVM()
        {
            LoadPerson();

        }



    }
}
