using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EF_Version
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrescriptionID { get; set; } // Unique identifier for the prescription
        public DateTime DateIssued { get; set; } // Date when the prescription was issued
        public int AppointmentID { get; set; } // Foreign key to appointment
        public string Notes { get; set; } // Additional notes or instructions for the prescription
        public string Diagnosis { get; set; } // Diagnosis related to the prescription
        public bool IsDeleted { get; set; } // Soft delete flag
        // Navigation properties
        public virtual Appointment Appointment { get; set; }
        public virtual ICollection<PrescriptionDetail> Details { get; set; }
        public Prescription() { }
        public Prescription(DateTime dateIssued, int appointmentId, string notes, string diagnosis)
        {
            DateIssued = dateIssued;
            AppointmentID = appointmentId;
            Notes = notes;
            Diagnosis = diagnosis;
            IsDeleted = false; // Default to not deleted
        }
    }
}