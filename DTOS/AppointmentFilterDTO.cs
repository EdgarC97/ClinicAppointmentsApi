using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAppointmentsApi.DTOS
{
    public class AppointmentFilterDTO
    {
        // Optional filter by appointment date
        public DateTime? AppointmentDate { get; set; }

        // Optional filter by doctor's specialty
        public string Specialty { get; set; }

        // Optional filter by medical problem
        public string MedicalProblem { get; set; }
    }
}