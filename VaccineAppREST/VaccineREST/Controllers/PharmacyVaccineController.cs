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
    /// API for PharmacyVaccine
    /// </summary>
    
    [Route("api/[controller]")]
    [ApiController]
    public class PharmacyVaccineController : ControllerBase
    {
        private readonly IVacBL _vacBL;
        public PharmacyVaccineController(IVacBL vacBL)
        {
            _vacBL = vacBL;
        }
        // GET: api/<PharmacyVaccineController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PharmacyVaccineController>/5
        [HttpGet("{pharmId/vacId}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetPharmacyVaccineById(int pharmId, int vacId)
        {
            var pharmacyVaccine = await _vacBL.GetPharmacyVaccineAsync(pharmId, vacId);
            if (pharmacyVaccine == null) return NotFound();
            return Ok(pharmacyVaccine);
        }

        // POST api/<PharmacyVaccineController>
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> AddPharmacyVaccineAsync([FromBody] PharmacyVaccine pharmacyVaccine)
        {
            try
            {
                await _vacBL.AddPharmacyVaccineAsync(pharmacyVaccine);
                return CreatedAtAction("AddPharmacyVaccineAsync", pharmacyVaccine);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<PharmacyVaccineController>/5
        [HttpPut("{pharmId/vacId}")]
        public async Task<IActionResult> UpdatePharmacyVaccineAsync(int pharmId, int vacId, [FromBody] PharmacyVaccine pharmacyVaccine)
        {
            try
            {
                await _vacBL.UpdatePharmacyVaccineAsync(pharmacyVaccine);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<PharmacyVaccineController>/5
        [HttpDelete("{pharmId/vacId}")]
        public async Task<IActionResult> DeletePharmacyVaccineAsync(int pharmId, int vacId)
        {
            try
            {
                await _vacBL.DeletePharmacyVaccineAsync(await _vacBL.GetPharmacyVaccineAsync(pharmId, vacId));
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
