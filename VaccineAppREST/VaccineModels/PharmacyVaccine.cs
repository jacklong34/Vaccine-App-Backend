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
        private int pharmID;
        private int vacID;
        private int quantity;

        //Properties
        public int PharmID
        {
            get { return this.pharmID; }
            set { this.pharmID = value; }
        }
        public int VacID
        {
            get { return this.vacID; }
            set { this.vacID = value; }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
    }
}
