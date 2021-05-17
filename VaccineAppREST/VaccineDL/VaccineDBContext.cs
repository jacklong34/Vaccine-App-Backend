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
            //Auto increment ID's when new model is added to DB
            modelBuilder.Entity<Appointment>()
                .Property(x => x.AppID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Patient>()
                .Property(x => x.PatientID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Pharmacy>()
                .Property(x => x.PharmID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Vaccine>()
                .Property(x => x.VacID)
                .ValueGeneratedOnAdd();
        }
    }
}
