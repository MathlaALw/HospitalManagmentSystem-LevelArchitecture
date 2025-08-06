using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem_LevelArchitecture.Models
{
    public class Appointment
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }
        [Required]
        public string PatientId { get; set; }
        [Required]
        public string DoctorId { get; set; }
        [Required]

        public string ReasonForVisit { get; set; }

    }
}
