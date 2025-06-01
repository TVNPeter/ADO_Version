using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EF_Version
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PatientID { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsDeleted { get; set; } // Soft delete flag
        public virtual ICollection<Appointment> Appointments { get; set; }
        public Patient() { }
        public Patient(string fullName, string gender, DateTime BD, string address, string phone)
        {
            FullName = fullName;
            Gender = gender;
            BirthDate = BD;
            Address = address;
            Phone = phone;
            IsDeleted = false; // Default to not deleted
        }
    }
}