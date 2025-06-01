using System;
using System.Data.Entity;
using System.Linq;

namespace EF_Version
{
    public class ClinicContext : DbContext
    {
        //Neccessary to contruct the database
        public ClinicContext()
            : base("name=ClinicDB")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ClinicContext>());
        }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Secretary> Secretaries { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PrescriptionDetail>()
                .HasKey(pd => new { pd.PrescriptionID, pd.MedicineID });

            base.OnModelCreating(modelBuilder);
        }
    }
}