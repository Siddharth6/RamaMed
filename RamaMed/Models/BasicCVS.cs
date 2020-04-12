using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class BasicCVS
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }

        public Nullable<int> HEART_RATE { get; set; }

        public string RHYTHM { get; set; }

        public string SHAPE_OF_CHEST { get; set; }

        public string DIALATED_VEINS_OVER_CHEST { get; set; }

        public string SCAR_MARKS_OVER_CHEST { get; set; }

        public string APEX { get; set; }

        public string THRILL { get; set; }

        public string HEART_SOUNDS_S1_S2 { get; set; }

        public string HEART_SOUNDS_S3 { get; set; }

        public string HEART_SOUNDS_S4 { get; set; }

        public string PERICARDIAL_RUB { get; set; }

        public string MURMUR_DIASTOLIC { get; set; }

        public string MURMUR_SYSTOLIC { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }

    }
}
