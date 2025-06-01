using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EF_Version
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DoctorID { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public string Phone { get; set; }
        public bool IsDeleted { get; set; } // Soft delete flag
        public virtual ICollection<Appointment> Appointments { get; set; }
        // Constructor
        public Doctor() { }
        public Doctor(string fullName, string specialty, string phone)
        {
            FullName = fullName;
            Specialty = specialty;
            Phone = phone;
            IsDeleted = false; // Default to not deleted
        }
    }
}