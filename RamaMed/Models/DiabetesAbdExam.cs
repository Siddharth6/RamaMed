using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class DiabetesAbdExam
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }


        public string PAIN { get; set; }

        public string TEMPERATURE { get; set; }

        public string RIGIDITY { get; set; }

        public string VENOUS_DILATATION { get; set; }

        public string SCAR_MARKS { get; set; }

        public string COLOUR_OF_SKIN { get; set; }

        public string POSITION_OF_UMBILICUS { get; set; }

        public string MOVEMENT_OF_ABDOMEN { get; set; }

        public string SHAPE_OF_ABDOMEN { get; set; }

        public string SHIFTING_DULLNESS { get; set; }

        public string FLUID_THRILL { get; set; }

        public string SIGNS_OF_HERNIA { get; set; }

        public string TESTICULER_SWELLING { get; set; }

        public string HEMORRHOIDS { get; set; }

        public string FISSURE { get; set; }

        public string PROSTATE_CONDITION { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }


    }
}
