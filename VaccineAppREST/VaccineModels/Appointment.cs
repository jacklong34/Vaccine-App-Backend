using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineModels
{
    /// <summary>
    /// Has a date, pharmacy, customer, and vaccine 
    /// </summary>
    public class Appointment
    {
        //Fields
        private int appID;
        private DateTime date;
        private int pharmID;
        private int patientID;
        private int vacID;

        //Properties
        public int AppID
        {
            get { return this.appID; }
            set { this.appID = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public int PharmID
        {
            get { return this.pharmID; }
            set { this.pharmID = value; }
        }
        public int PatientID
        {
            get { return this.patientID; }
            set { this.patientID = value; }
        }
        public int VacID
        {
            get { return this.vacID; }
            set { this.vacID = value; }
        }
    }
}
