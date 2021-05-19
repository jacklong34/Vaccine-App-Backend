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
    /// API for Pharmacy
    /// </summary>
    
    [Route("api/[controller]")]
    [ApiController]
    public class PharmacyController : ControllerBase
    {
        private readonly IVacBL _vacBL;
        public PharmacyController(IVacBL vacBL)
        {
            _vacBL = vacBL;
        }
        // GET: api/<PharmacyController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PharmacyController>/5
        [HttpGet("{pharmId}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetPharmacyByIdAsync(int pharmId)
        {
            var pharmacy = await _vacBL.GetPharmacyByIDAsync(pharmId);
            if (pharmacy == null) return NotFound();
            return Ok(pharmacy);
        }

        // POST api/<PharmacyController>
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> AddPharmacyAsync([FromBody] Pharmacy pharmacy)
        {
            try
            {
                await _vacBL.AddPharmacyAsync(pharmacy);
                return CreatedAtAction("AddPharmacyAsync", pharmacy);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<PharmacyController>/5
        [HttpPut("{pharmId}")]
        public async Task<IActionResult> UpdatePharmacyAsync(int pharmId, [FromBody] Pharmacy pharmacy)
        {
            try
            {
                await _vacBL.UpdatePharmacyAsync(pharmacy);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<PharmacyController>/5
        [HttpDelete("{pharmId}")]
        public async Task<IActionResult> DeletePharmacyAsync(int pharmId)
        {
            try
            {
                await _vacBL.DeletePharmacyAsync(await _vacBL.GetPharmacyByIDAsync(pharmId));
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
            
        }
    }
}
