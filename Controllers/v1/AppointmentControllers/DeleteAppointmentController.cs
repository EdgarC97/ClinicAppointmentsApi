using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAppointmentsApi.Controllers.v1.AppointmentControllers
{
    /// <summary>
    /// API controller for deleting appointment-related actions.
    /// </summary>
    [ApiController]
    [Route("api/v1/appointments")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags  ("Appointments")]
    public class DeleteAppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public DeleteAppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        /// <summary>
        /// Deletes an appointment by its ID. Only accessible by Admins.
        /// </summary>
        /// <param name="Id">The ID of the appointment to delete.</param>
        /// <returns>An IActionResult indicating the result of the delete operation.</returns>
        /// <response code="200">Returns a success message if the appointment was deleted successfully.</response>
        /// <response code="404">Returns an error message if the appointment is not found.</response>
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteAppointment(int id)
        {
            var result = await _appointmentService.DeleteAppointmentAsync(id);
            if (result.IsSuccess)
            {
                return Ok(new
                {
                    message = "Appointment deleted successfully."
                });
            }

            return NotFound(result.Message);
        }
    }
}