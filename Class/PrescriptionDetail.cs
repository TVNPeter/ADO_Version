using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_Version
{
    public class PrescriptionDetail
    {
        public int PrescriptionID { get; set; } // Foreign key to Prescription
        public int MedicineID { get; set; } // Foreign key to Medicine
        public int Quantity { get; set; } // Quantity of the medicine prescribed
        public string Frequency { get; set; } // Frequency of the medicine intake
        //Navigation properties
        public virtual Prescription Prescription { get; set; } // Navigation property to Prescription
        public virtual Medicine Medicine { get; set; } // Navigation property to Medicine
        public PrescriptionDetail() { }
        public PrescriptionDetail(int prescriptionId, int medicineId, int quantity, string frequency)
        {
            PrescriptionID = prescriptionId;
            MedicineID = medicineId;
            Quantity = quantity;
            Frequency = frequency;
        }
    }
}