using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VaccineModels;

namespace VaccineDL
{
    /// <summary>
    /// DB Context for Vaccine Service 
    /// </summary>
    public class VaccineDBContext : DbContext
    {
        public VaccineDBContext(DbContextOptions options) : base(options)
        {
        }
        protected VaccineDBContext()
        {
        }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Pharmacy> Pharmacy { get; set; }
        public DbSet<PharmacyVaccine> PharmacyVaccine { get; set; }
        public DbSet<Vaccine> Vaccine { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Set Primary Keys
            modelBuilder.Entity<PharmacyVaccine>()
                .HasKey(k => new { k.PharmId, k.VacId })
                .HasName("PK_PharmacyVaccine");
            modelBuilder.Entity<Appointment>()
                .HasKey(k => k.AppId);
            modelBuilder.Entity<Patient>()
                .HasKey(k => k.PatientId);
            modelBuilder.Entity<Pharmacy>()
                .HasKey(k => k.PharmId);
            modelBuilder.Entity<Vaccine>()
                .HasKey(k => k.VacId);

            //PharmacyVaccine FK
            modelBuilder.Entity<PharmacyVaccine>()
                .HasOne(x => x.Pharmacy)
                .WithMany(y => y.PharmacyVaccines)
                .HasForeignKey(x => x.PharmId);
            modelBuilder.Entity<PharmacyVaccine>()
                .HasOne(x => x.Vaccine)
                .WithMany(y => y.PharmacyVaccines)
                .HasForeignKey(x => x.VacId);

            //Auto increment ID's when new model is added to DB
            modelBuilder.Entity<Appointment>()
                .Property(x => x.AppId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Patient>()
                .Property(x => x.PatientId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Pharmacy>()
                .Property(x => x.PharmId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Vaccine>()
                .Property(x => x.VacId)
                .ValueGeneratedOnAdd();

            //Foreign Key Relationships
            modelBuilder.Entity<Appointment>()
                .HasOne(x => x.Patient)
                .WithMany(y => y.Appointments)
                .HasForeignKey(x => x.PatientId);
            modelBuilder.Entity<Appointment>()
                .HasOne(x => x.Vaccine)
                .WithMany(y => y.Appointments)
                .HasForeignKey(x => x.VacId);
            modelBuilder.Entity<Appointment>()
                .HasOne(x => x.Pharmacy)
                .WithMany(y => y.Appointments)
                .HasForeignKey(x => x.PharmId);
        }
    }
}
