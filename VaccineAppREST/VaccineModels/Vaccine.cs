using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineModels
{
    public class Vaccine
    {
        //Fields
        private int vacID;
        private string name;
        private string company;
        private int doses;

        //Properties
        public int VacID
        {
            get { return this.vacID; }
            set { this.vacID = value; }
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
    }
}
