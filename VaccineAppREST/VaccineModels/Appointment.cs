using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private int appId;
        private DateTime date;
        private int pharmId;
        private int? patientId;
        private int vacId;
        private Pharmacy pharmacy;
        private Patient patient;
        private Vaccine vaccine;

        //Properties
        public int AppId
        {
            get { return this.appId; }
            set { this.appId = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public int PharmId
        {
            get { return this.pharmId; }
            set { this.pharmId = value; }
        }
        public int PatientId
        {
            get
            {
                if(this.patientId.HasValue)
                {
                    return this.patientId.Value;
                }
                return -1;
            }
            set { this.patientId = value; }
        }
        public int VacId
        {
            get { return this.vacId; }
            set { this.vacId = value; }
        }
        public Pharmacy Pharmacy
        {
            get { return this.pharmacy; }
            set { this.pharmacy = value; }
        }
        public Patient Patient
        {
            get { return this.patient; }
            set { this.patient = value; }
        }
        public Vaccine Vaccine
        {
            get { return this.vaccine; }
            set { this.vaccine = value; }
        }
    }
}
