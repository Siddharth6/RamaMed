using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class DiabetesRespSystem
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }


        public Nullable<int> RATE { get; set; }

        public string RHYTHM { get; set; }

        //public string MOTOR_SYSTEM_INVOLUNTRY_MOVEMENTS { get; set; }

        public string MOVEMENTS { get; set; }

        public string POSITION_OF_TRACHEA { get; set; }

        public string BREATH_SOUND { get; set; }

        public string CREPTS { get; set; }

        public string RONCHI { get; set; }

        public string WHEEZING { get; set; }

        public string PLEURAL_RUB { get; set; }

        public string PLEURAL_FLUID { get; set; }

        public string PERCUSSION_NOTE { get; set; }

        public string BRONCHIAL_BREATH_SOUNDS { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }


    }
}
