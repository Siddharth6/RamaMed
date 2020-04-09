using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class CardioGeneralExamination
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }

        public string BUILT { get; set; }

        public string NEUTRITION { get; set; }

        public Nullable<int> PULSE_RATE { get; set; }

        public string PULSE_RADIO_FEROMAL_DELAY { get; set; }

        public string PULSE_RYTHM { get; set; }

        public string PULSE_VOLUME { get; set; }

        public string PULSE_CONDITION_OF_ARTERIAL_WALL { get; set; }

        public string PULSE_CHARACTER { get; set; }

        public string PULSE_PERIPHERAL_PULSES { get; set; }

        public Nullable<int> BLOOD_PRESSURE { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public Nullable<decimal> TEMPERATURE { get; set; }

        public string PALLOR { get; set; }

        public string ESTERUS { get; set; }

        public string CYNOSIS { get; set; }

        public string CLUBBING { get; set; }

        public string PEDAL_EDEMA { get; set; }

        public string LYMPH_NODE { get; set; }

        public string JVP { get; set; }

        public string NECK_SWELLING { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }
    }
}
