using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineModels
{
    /// <summary>
    /// The specific kind of vaccine being administered
    /// </summary>
    public class Vaccine
    {
        //Fields
        private int vacId;
        private string name;
        private string company;
        private int doses;
        private ICollection<Appointment> appointments;
        private ICollection<PharmacyVaccine> pharmacyVaccines;

        //Properties
        public int VacId
        {
            get { return this.vacId; }
            set { this.vacId = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Company
        {
            get { return this.company; }
            set { this.company = value; }
        }
        public int Doses
        { 
            get { return this.doses; }
            set { this.doses = value; }
        }
        public ICollection<Appointment> Appointments
        {
            get { return this.appointments; }
            set { this.appointments = value; }
        }
        public ICollection<PharmacyVaccine> PharmacyVaccines
        {
            get { return this.pharmacyVaccines; }
            set { this.pharmacyVaccines = value; }
        }
    }
}
