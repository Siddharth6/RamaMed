using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class CardioPersonal
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }

        public string SMOKING { get; set; }

        public Nullable<int> SMOKING_PACK_YEARS { get; set; }

        public string SMOKING_DURATION { get; set; }

        public Nullable<int> SMOKING_YEARS { get; set; }

        public string ALCOHOL_INTAKE { get; set; }

        public string ALCOHOL_INTAKE_QUANTITY { get; set; }

        public string ALCOHOL_INTAKE_DURATION { get; set; }

        public Nullable<int> ALCOHOL_INTAKE_YEARS { get; set; }

        public string OTHER_SUBSTANCE_USE { get; set; }

        public string LIFE_STYLE { get; set; }

        public string FAMILY_HISTORY { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }
    }
}
