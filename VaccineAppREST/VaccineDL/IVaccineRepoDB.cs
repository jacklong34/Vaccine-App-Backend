using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineModels;

namespace VaccineDL
{
    public interface IVaccineRepoDB
    {
        //Appointment CRUD Methods
        Task<Appointment> AddAppointmentAsync(Appointment newAppointment);
        Task<Appointment> GetAppointmentByID(int appID);
        Task<Appointment> UpdateAppointmentAsync(Appointment appointment2BUpdated);
        Task<Appointment> DeleteAppointmentAsync(Appointment appoitnment2BDeleted);

        //Patient CRUD Methods
        Task<Patient> AddPatientAsync(Patient patient2Add);
        Task<Patient> GetPatientByIDAsync(int patientID);
        Task<Patient> UpdatePatientAsync(Patient patient2BUpdated);
        Task<Patient> DeletePatientAsync(Patient patient2BDeleted);
        Task<Patient> GetPatientByUsernameAsync(string username);

        //Pharmacy CRUD Methods
        Task<Pharmacy> AddPharmacyAsync(Pharmacy pharmacy2Add);
        Task<Pharmacy> GetPharmacyByIDAsync(int pharmID);
        Task<Pharmacy> UpdatePharmacyAsync(Pharmacy pharmacy2BUpdated);
        Task<Pharmacy> DeletePharmacyAsync(Pharmacy pharmacy2BDeleted);

        //PharmacyVaccine CRUD Methods
        Task<PharmacyVaccine> AddPharmacyVaccineAsync(PharmacyVaccine pharmacyVaccine2Add);
        Task<PharmacyVaccine> GetPharmacyVaccineAsync(int pharmID, int vacID);
        Task<PharmacyVaccine> UpdatePharmacyVaccineAsync(PharmacyVaccine pharmacyVaccine2BUpdated);
        Task<PharmacyVaccine> DeletePharmacyVaccineAsync(PharmacyVaccine pharmacyVaccine2BDeleted);

        //Vaccine CRUD Methods
        Task<Vaccine> AddVaccineAsync(Vaccine vaccine2Add);
        Task<Vaccine> GetVaccineByIDAsync(int vacID);
        Task<Vaccine> UpdateVaccineAsync(Vaccine vaccine2Update);
        Task<Vaccine> DeleteVaccineAsync(Vaccine vaccine2Bdeleted);
    }
}
