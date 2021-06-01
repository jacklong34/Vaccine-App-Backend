using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineModels;
using VaccineDL;

namespace VaccineBL
{
    /// <summary>
    /// Business logic for Vaccine models
    /// </summary>
    public class VacBL : IVacBL
    {
        private IVaccineRepoDB _repo;
        public VacBL(IVaccineRepoDB repo)
        {
            _repo = repo;
        }
        //Appointment BL
        public async Task<Appointment> AddAppointmentAsync(Appointment newAppointment)
        {
            return await _repo.AddAppointmentAsync(newAppointment);
        }
        public async Task<Appointment> GetAppointmentByID(int appID)
        {
            return await _repo.GetAppointmentByID(appID);
        }
        public async Task<Appointment> UpdateAppointmentAsync(Appointment appointment2BUpdated)
        {
            return await _repo.UpdateAppointmentAsync(appointment2BUpdated);
        }
        public async Task<Appointment> DeleteAppointmentAsync(Appointment appoitnment2BDeleted)
        {
            return await _repo.DeleteAppointmentAsync(appoitnment2BDeleted);
        }

        //Patient BL
        public async Task<Patient> AddPatientAsync(Patient patient2Add)
        {
            return await _repo.AddPatientAsync(patient2Add);
        }
        public async Task<Patient> GetPatientByIDAsync(int patientID)
        {
            return await _repo.GetPatientByIDAsync(patientID);
        }
        public async Task<Patient> UpdatePatientAsync(Patient patient2BUpdated)
        {
            return await _repo.UpdatePatientAsync(patient2BUpdated);
        }
        public async Task<Patient> DeletePatientAsync(Patient patient2BDeleted)
        {
            return await _repo.DeletePatientAsync(patient2BDeleted);
        }
        public async Task<Patient> GetPatientByUsernameAsync(string username)
        {
            Patient patient2Return = await _repo.GetPatientByUsernameAsync(username);
            if(patient2Return == null)
            {
                patient2Return = new Patient();
                patient2Return.Username = username;
                return await _repo.AddPatientAsync(patient2Return);
            }
            else
            {
                return patient2Return;
            }
        }

        //Pharmacy BL
        public async Task<Pharmacy> AddPharmacyAsync(Pharmacy pharmacy2Add)
        {
            return await _repo.AddPharmacyAsync(pharmacy2Add);
        }
        public async Task<Pharmacy> GetPharmacyByIDAsync(int pharmID)
        {
            return await _repo.GetPharmacyByIDAsync(pharmID);
        }
        public async Task<Pharmacy> UpdatePharmacyAsync(Pharmacy pharmacy2BUpdated)
        {
            return await _repo.UpdatePharmacyAsync(pharmacy2BUpdated);
        }
        public async Task<Pharmacy> DeletePharmacyAsync(Pharmacy pharmacy2BDeleted)
        {
            return await _repo.DeletePharmacyAsync(pharmacy2BDeleted);
        }

        //PharmacyVaccine BL
        public async Task<PharmacyVaccine> AddPharmacyVaccineAsync(PharmacyVaccine pharmacyVaccine2Add)
        {
            return await _repo.AddPharmacyVaccineAsync(pharmacyVaccine2Add);
        }
        public async Task<PharmacyVaccine> GetPharmacyVaccineAsync(int pharmID, int vacID)
        {
            return await _repo.GetPharmacyVaccineAsync(pharmID, vacID);
        }
        public async Task<PharmacyVaccine> UpdatePharmacyVaccineAsync(PharmacyVaccine pharmacyVaccine2BUpdated)
        {
            return await _repo.UpdatePharmacyVaccineAsync(pharmacyVaccine2BUpdated);
        }
        public async Task<PharmacyVaccine> DeletePharmacyVaccineAsync(PharmacyVaccine pharmacyVaccine2BDeleted)
        {
            return await _repo.DeletePharmacyVaccineAsync(pharmacyVaccine2BDeleted);
        }

        //Vaccine BL
        public async Task<Vaccine> AddVaccineAsync(Vaccine vaccine2Add)
        {
            return await _repo.AddVaccineAsync(vaccine2Add);
        }
        public async Task<Vaccine> GetVaccineByIDAsync(int vacID)
        {
            return await _repo.GetVaccineByIDAsync(vacID);
        }
        public async Task<Vaccine> UpdateVaccineAsync(Vaccine vaccine2Update)
        {
            return await _repo.UpdateVaccineAsync(vaccine2Update);
        }
        public async Task<Vaccine> DeleteVaccineAsync(Vaccine vaccine2Bdeleted)
        {
            return await _repo.DeleteVaccineAsync(vaccine2Bdeleted);
        }
    }
}
