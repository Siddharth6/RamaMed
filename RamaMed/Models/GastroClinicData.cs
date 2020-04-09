using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class GastroClinicData
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string OPDID { get; set; }


    }
}
