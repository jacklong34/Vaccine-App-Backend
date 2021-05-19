using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccineBL;
using VaccineModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VaccineREST.Controllers
{
    /// <summary>
    /// API for Patients
    /// </summary>
    
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IVacBL _vacBL;
        public PatientController(IVacBL vacBL)
        {
            _vacBL = vacBL;
        }
        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PatientController>/5
        [HttpGet("{patientId}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetPatientByIdAsync(int patientId)
        {
            var patient = await _vacBL.GetPatientByIDAsync(patientId);
            if (patient == null) return NotFound();
            return Ok(patient);
        }

        // POST api/<PatientController>
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> AddPatientAsync([FromBody] Patient patient)
        {
            try
            {
                await _vacBL.AddPatientAsync(patient);
                return CreatedAtAction("AddPatientAsync", patient);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<PatientController>/5
        [HttpPut("{patientId}")]
        public async Task<IActionResult> UpdatePatientAsync(int patientId, [FromBody] Patient patient)
        {
            try
            {
                await _vacBL.UpdatePatientAsync(patient);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{patientId}")]
        public async Task<IActionResult> DeletePatientAsync(int patientId)
        {
            try
            {
                await _vacBL.DeletePatientAsync(await _vacBL.GetPatientByIDAsync(patientId));
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
