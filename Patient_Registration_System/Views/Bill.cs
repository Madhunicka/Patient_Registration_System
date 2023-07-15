using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Registration_System.Views
{
    public class Bill
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public double DoctorCharge { get; set; }
        public double MedicationCost { get; set; }
        public double LabTests { get; set; }
        public double ServiceCharges { get; set; }

        public double AdditionalCharge { get; set; }


    }
}
