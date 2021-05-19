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
    /// API for Vaccine
    /// </summary>
    
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        private readonly IVacBL _vacBL;
        public VaccineController(IVacBL vacBL)
        {
            _vacBL = vacBL;
        }
        // GET: api/<VaccineController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VaccineController>/5
        [HttpGet("{vacId}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetVaccineByIdAsync(int vacId)
        {
            var vaccine = await _vacBL.GetVaccineByIDAsync(vacId);
            if (vaccine == null) return NotFound();
            return Ok(vaccine);
        }

        // POST api/<VaccineController>
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> AddVaccineAsync([FromBody] Vaccine vaccine)
        {
            try
            {
                await _vacBL.AddVaccineAsync(vaccine);
                return CreatedAtAction("AddVaccineAsync", vaccine);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<VaccineController>/5
        [HttpPut("{vacId}")]
        public async Task<IActionResult> UpdateVaccineAsync(int vacId, [FromBody] Vaccine vaccine)
        {
            try
            {
                await _vacBL.UpdateVaccineAsync(vaccine);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<VaccineController>/5
        [HttpDelete("{vacId}")]
        public async Task<IActionResult> DeleteVaccineAsync(int vacId)
        {
            try
            {
                await _vacBL.DeleteVaccineAsync(await _vacBL.GetVaccineByIDAsync(vacId));
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
