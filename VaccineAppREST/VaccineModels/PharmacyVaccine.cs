using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineModels
{
    /// <summary>
    /// Used to model the m:m relationship b/w Pharmacy and Vaccine
    /// </summary>
    public class PharmacyVaccine
    {
        //Fields
        private int pharmId;
        private int vacId;
        private int quantity;
        private Pharmacy pharmacy;
        private Vaccine vaccine;

        //Properties
        public int PharmId
        {
            get { return this.pharmId; }
            set { this.pharmId = value; }
        }
        public int VacId
        {
            get { return this.vacId; }
            set { this.vacId = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        public Pharmacy Pharmacy
        {
            get { return this.pharmacy; }
            set { this.pharmacy = value; }
        }
        public Vaccine Vaccine
        {
            get { return this.vaccine; }
            set { this.vaccine = value; }
        }
    }
}
