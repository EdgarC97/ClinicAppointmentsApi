using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicAppointmentsApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAppointmentsApi.Controllers.v1.DoctorAvailabilityControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorAvailabilityController : ControllerBase
    {
        private readonly IDoctorAvailabilityService _availabilityService;

        // Constructor to inject the availability service
        public DoctorAvailabilityController(IDoctorAvailabilityService availabilityService)
        {
            _availabilityService = availabilityService;
        }

        /// <summary>
        /// Set a doctor's availability for a specific date and time range.
        /// </summary>
        /// <param name="doctorId">The ID of the doctor.</param>
        /// <param name="availableDate">The date the doctor is available.</param>
        /// <param name="startTime">The start time of availability.</param>
        /// <param name="endTime">The end time of availability.</param>
        /// <returns>A response message indicating success or failure.</returns>
        [HttpPost]
        [Route("set")]
        public async Task<IActionResult> SetDoctorAvailabilityAsync(
            [FromQuery] int doctorId,
            [FromQuery] DateTime availableDate,
            [FromQuery] TimeSpan startTime,
            [FromQuery] TimeSpan endTime)
        {
            var result = await _availabilityService.SetDoctorAvailabilityAsync(doctorId, availableDate, startTime, endTime);

            if (result == "Doctor's availability successfully set.")
            {
                return Ok(result);  // Return success message with 200 OK status
            }

            return BadRequest(result);  // Return failure message with 400 Bad Request status
        }

        /// <summary>
        /// Update an existing doctor's availability.
        /// </summary>
        /// <param name="availabilityId">The ID of the availability to be updated.</param>
        /// <param name="availableDate">The new date the doctor is available.</param>
        /// <param name="startTime">The new start time of availability.</param>
        /// <param name="endTime">The new end time of availability.</param>
        /// <returns>A response message indicating success or failure.</returns>
        [HttpPut]
        [Route("update/{availabilityId}")]
        public async Task<IActionResult> UpdateDoctorAvailabilityAsync(
            [FromRoute] int availabilityId,
            [FromQuery] DateTime availableDate,
            [FromQuery] TimeSpan startTime,
            [FromQuery] TimeSpan endTime)
        {
            var result = await _availabilityService.UpdateDoctorAvailabilityAsync(availabilityId, availableDate, startTime, endTime);

            if (result == "Doctor's availability successfully updated.")
            {
                return Ok(result);  // Return success message with 200 OK status
            }

            return BadRequest(result);  // Return failure message with 400 Bad Request status
        }
    }
}