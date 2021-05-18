using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineModels
{
    /// <summary>
    /// The person registering for their covid vaccine/user of the system
    /// </summary>
    public class Patient
    {
        //Fields
        private int patientId;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private DateTime dob;
        private string username;
        private string password;
        private ICollection<Appointment> appointments;

        //Properties
        public int PatientId
        {
            get { return this.patientId; }
            set { this.patientId = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        public DateTime Dob
        {
            get { return this.dob; }
            set { this.dob = value; }
        }
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }
        public ICollection<Appointment> Appointments
        {
            get { return this.appointments; }
            set { this.appointments = value; }
        }

    }
}
