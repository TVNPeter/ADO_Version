using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace EF_Version
{
    public class Secretary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SecretaryID { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Phone { get; set; }
        public bool IsDeleted { get; set; } // Soft delete flag
        // Constructor
        public Secretary() { }
        public Secretary(string fullName, string phone)
        {
            FullName = fullName;
            Phone = phone;
            IsDeleted = false;
        }
    }
}