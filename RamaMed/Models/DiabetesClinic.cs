using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class DiabetesClinic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Heading { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        public int InputType { get; set; }

        [Required]
        public string InputOptions { get; set; }

    }
}
