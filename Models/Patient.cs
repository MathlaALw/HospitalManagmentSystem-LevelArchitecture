using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem_LevelArchitecture.Models
{
    public class Patient
    {
        [Key]
        public int PId { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string PName { get; set; }
        [Required]
        public int PAge { get; set; }
       

    }
}
