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
    /// API for Appointments
    /// </summary>
    
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IVacBL _vacBL;
        public AppointmentController(IVacBL vacBL)
        {
            _vacBL = vacBL;
        }
        // GET: api/<AppointmentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{appId}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetAppointmentByIdAsync(int appId)
        {
            var appointment = await _vacBL.GetAppointmentByID(appId);
            if (appointment == null) return NotFound();
            return Ok(appointment);
        }

        // POST api/<AppointmentController>
        [HttpPost]
        [Consumes("application/json")]
        public async Task<IActionResult> AddAppointmentAsync([FromBody] Appointment appointment)
        {
            try
            {
                await _vacBL.AddAppointmentAsync(appointment);
                return CreatedAtAction("AddAppointmentAsync", appointment);
            }
            catch(Exception)
            {
                return StatusCode(400);
            }
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{appId}")]
        public async Task<IActionResult> UpdateAppointmentAsync(int appId, [FromBody] Appointment appointment)
        {
            try
            {
                await _vacBL.UpdateAppointmentAsync(appointment);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{appId}")]
        public async Task<IActionResult> DeleteAppointmentAsync(int appId)
        {
            try
            {
                await _vacBL.DeleteAppointmentAsync(await _vacBL.GetAppointmentByID(appId));
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
