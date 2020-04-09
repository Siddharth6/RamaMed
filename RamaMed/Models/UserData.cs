using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class UserData
    {
        [Key]
        public int Id { get; set; }
    
        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNo { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Dept { get; set; }

        [Required]
        public string Doctor { get; set; }

        [Required]
        public string Clinic { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
