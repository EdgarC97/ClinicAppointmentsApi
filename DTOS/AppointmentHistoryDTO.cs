using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicAppointmentsApi.DTOS
{
    public class AppointmentHistoryDTO
    {
        public string DoctorName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string MedicalProblem { get; set; }
    }
}