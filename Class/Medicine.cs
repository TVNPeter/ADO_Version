using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EF_Version
{
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MedicineID { get; set; } // Unique identifier for the medicine
        [Required]
        public string Name { get; set; } // Name of the medicine
        public string Dosage { get; set; } // Dosage instructions for the medicine
        public double Price { get; set; } // Price of the medicine
        public bool IsDeleted { get; set; } // Soft delete flag
        public virtual ICollection<PrescriptionDetail> PrescriptionDetails { get; set; }
        // Constructor
        public Medicine() { }
        public Medicine(string name, string dosage, double price)
        {
            Name = name;
            Dosage = dosage;
            Price = price;
            IsDeleted = false; // Default to not deleted
        }
    }
}