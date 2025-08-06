using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem_LevelArchitecture.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Name { get; set; }

        [Required]
        public string Specialization { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }




    }
}
