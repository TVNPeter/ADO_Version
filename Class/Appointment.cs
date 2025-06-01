using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EF_Version
{
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AppointmentID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } // e.g., "Scheduled", "Completed", "Cancelled"
        public int PatientID { get; set; } // Foreign key to Patient
        public int DoctorID { get; set; } // Foreign key to Doctor
        public double Fee { get; set; } // Fee for the appointment
        public bool IsDeleted { get; set; } // Soft delete flag
        // Navigation properties
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        //Constructor
        public Appointment() { }
        public Appointment(int patientId, int doctorId, DateTime appointmentDate, string status)
        {
            PatientID = patientId;
            DoctorID = doctorId;
            AppointmentDate = appointmentDate;
            Status = status;
            Fee = 0;
            IsDeleted = false; // Default to not deleted
        }
    }
}