using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class EndocrinoOther
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }

        [Display(Name = "Clinical Diagnosis")]
        public string CLINICAL_DIAGNOSIS { get; set; }

        [Display(Name = "Differential Diagnosis")]
        public string DIFFERENTIAL_DIAGNOSIS { get; set; }

        [Display(Name = "Final Diagnosis")]
        public string FINAL_DIAGNOSIS { get; set; }

        [Display(Name = "Treatment")]
        public string TREATMENT { get; set; }

        [Display(Name = "Follow Up")]
        public string FOLLOW_UP { get; set; }

        [Display(Name = "Refer To Other Speciality Department")]
        public string REFER_TO_OTHER { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }

    }
}
