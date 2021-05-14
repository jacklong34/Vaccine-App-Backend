using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineModels
{
    /// <summary>
    /// The location where the covid vaccine is being administered
    /// </summary>
    public class Pharmacy
    {
        //Fields
        private int pharmID;
        private string name;
        private string state;
        private string city;
        private string street;
        private int zip;

        //Properties
        public int PharmID
        {
            get { return this.pharmID; }
            set { this.pharmID = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Street
        {
            get { return this.street; }
            set { this.street = value; }
        }
        public int Zip
        {
            get { return this.zip; }
            set { this.zip = value; }
        }
    }
}
