using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VaccineModels;

namespace VaccineDL
{
    /// <summary>
    /// Used for modifying DB
    /// </summary>
    public class VaccineRepoDB : IVaccineRepoDB
    {
        private readonly VaccineDBContext _context;
        public VaccineRepoDB(VaccineDBContext context)
        {
            _context = context;
        }
        //Appointment CRUD Methods 
        public async Task<Appointment> AddAppointmentAsync(Appointment newAppointment)
        {
            await _context.Appointment.AddAsync(newAppointment);
            await _context.SaveChangesAsync();
            return newAppointment;
        }
        public async Task<Appointment> GetAppointmentByID(int appID)
        {
            return await _context.Appointment
                .AsNoTracking()
                .Where(x => x.AppID == appID)
                .FirstOrDefaultAsync();
        }
        public async Task<Appointment> UpdateAppointmentAsync(Appointment appointment2BUpdated)
        {
            Appointment oldAppointment = await _context.Appointment.Where(x => x.AppID == appointment2BUpdated.AppID).FirstOrDefaultAsync();
            _context.Entry(oldAppointment).CurrentValues.SetValues(appointment2BUpdated);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return appointment2BUpdated;
        }
        public async Task<Appointment> DeleteAppointmentAsync(Appointment appoitnment2BDeleted)
        {
            _context.Appointment.Remove(appoitnment2BDeleted);
            await _context.SaveChangesAsync();
            return appoitnment2BDeleted;
        }

        //Patient CRUD Methods
        public async Task<Patient> AddPatientAsync(Patient patient2Add)
        {
            await _context.Patient.AddAsync(patient2Add);
            await _context.SaveChangesAsync();
            return patient2Add;
        }
        public async Task<Patient> GetPatientByIDAsync(int patientID)
        {
            return await _context.Patient
                .AsNoTracking()
                .Where(x => x.PatientID == patientID)
                .FirstOrDefaultAsync();
        }
        public async Task<Patient> UpdatePatientAsync(Patient patient2BUpdated)
        {
            Patient oldPatient = await _context.Patient.Where(x => x.PatientID == patient2BUpdated.PatientID).FirstOrDefaultAsync();
            _context.Entry(oldPatient).CurrentValues.SetValues(patient2BUpdated);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return patient2BUpdated;
        }
        public async Task<Patient> DeletePatientAsync(Patient patient2BDeleted)
        {
            _context.Patient.Remove(patient2BDeleted);
            await _context.SaveChangesAsync();
            return patient2BDeleted;
        }
        //Pharmacy CRUD Methods
        public async Task<Pharmacy> AddPharmacyAsync(Pharmacy pharmacy2Add)
        {
            await _context.Pharmacy.AddAsync(pharmacy2Add);
            await _context.SaveChangesAsync();
            return pharmacy2Add;
        }
        public async Task<Pharmacy> GetPharmacyByIDAsync(int pharmID)
        {
            return await _context.Pharmacy
                .AsNoTracking()
                .Where(x => x.PharmID == pharmID)
                .FirstOrDefaultAsync();
        }
        public async Task<Pharmacy> UpdatePharmacyAsync(Pharmacy pharmacy2BUpdated)
        {
            Pharmacy oldPharmacy = await _context.Pharmacy.Where(x => x.PharmID == pharmacy2BUpdated.PharmID).FirstOrDefaultAsync();
            _context.Entry(oldPharmacy).CurrentValues.SetValues(pharmacy2BUpdated);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return pharmacy2BUpdated;
        }
        public async Task<Pharmacy> DeletePharmacyAsync(Pharmacy pharmacy2BDeleted)
        {
            _context.Pharmacy.Remove(pharmacy2BDeleted);
            await _context.SaveChangesAsync();
            return pharmacy2BDeleted;
        }
        //PharmacyVaccine CRUD Methods
        public async Task<PharmacyVaccine> AddPharmacyVaccineAsync(PharmacyVaccine pharmacyVaccine2Add)
        {
            await _context.PharmacyVaccine.AddAsync(pharmacyVaccine2Add);
            await _context.SaveChangesAsync();
            return pharmacyVaccine2Add;
        }
        public async Task<PharmacyVaccine> GetPharmacyVaccineAsync(int pharmID, int vacID)
        {
            return await _context.PharmacyVaccine
                .AsNoTracking()
                .Where(x => x.PharmID == pharmID && x.VacID == vacID)
                .FirstOrDefaultAsync();
        }
        public async Task<PharmacyVaccine> UpdatePharmacyVaccineAsync(PharmacyVaccine pharmacyVaccine2BUpdated)
        {
            PharmacyVaccine oldPharmacyVaccine = await _context.PharmacyVaccine.Where(x => x.PharmID == pharmacyVaccine2BUpdated.PharmID
            && x.VacID == pharmacyVaccine2BUpdated.VacID).FirstOrDefaultAsync();
            _context.Entry(oldPharmacyVaccine).CurrentValues.SetValues(pharmacyVaccine2BUpdated);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return pharmacyVaccine2BUpdated;
        }
        public async Task<PharmacyVaccine> DeletePharmacyVaccineAsync(PharmacyVaccine pharmacyVaccine2BDeleted)
        {
            _context.PharmacyVaccine.Remove(pharmacyVaccine2BDeleted);
            await _context.SaveChangesAsync();
            return pharmacyVaccine2BDeleted;
        }
        //Vaccine CRUD Methods
        public async Task<Vaccine> AddVaccineAsync(Vaccine vaccine2Add)
        {
            await _context.Vaccine.AddAsync(vaccine2Add);
            await _context.SaveChangesAsync();
            return vaccine2Add;
        }
        public async Task<Vaccine> GetVaccineByIDAsync(int vacID)
        {
            return await _context.Vaccine
                .AsNoTracking()
                .Where(x => x.VacID == vacID)
                .FirstOrDefaultAsync();
        }
        public async Task<Vaccine> UpdateVaccineAsync(Vaccine vaccine2Update)
        {
            Vaccine oldVaccine = await _context.Vaccine.Where(x => x.VacID == vaccine2Update.VacID).FirstOrDefaultAsync();
            _context.Entry(oldVaccine).CurrentValues.SetValues(vaccine2Update);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
            return vaccine2Update;
        }
        public async Task<Vaccine> DeleteVaccineAsync(Vaccine vaccine2Bdeleted)
        {
            _context.Vaccine.Remove(vaccine2Bdeleted);
            await _context.SaveChangesAsync();
            return vaccine2Bdeleted;
        }
    }
}
