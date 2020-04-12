using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class EndocrinoInvestigation
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }

        public string CBC { get; set; }

        public string PBS { get; set; }

        public string RFT { get; set; }

        public string RBS { get; set; }

        public string LFT { get; set; }

        public string BS { get; set; }

        [Display(Name = "SR. ELECTROLYTES")]
        public string SR_ELECTROLYTE { get; set; }

        [Display(Name = "URINE ROUTINE MICROSCOPIC")]
        public string URINE_ROUTINE_MICROSCOPIC { get; set; }

        [Display(Name = "URINE CULTURE SESNSITIVITY")]
        public string URINE_CULTURE_SESNSITIVITY { get; set; }

        [Display(Name = "ANTI TPO")]
        public string ANTI_TPO { get; set; }

        [Display(Name = "ANTI THYROGLOBULIN ANTI BODY")]
        public string ANTI_THYROGLOBULIN_ANTI_BODY { get; set; }

        public string ECG { get; set; }

        [Display(Name = "2D ECHOCARDIOLOGY")]
        public string ECHOCARDIOLOGY_2D { get; set; }

        [Display(Name = "CHEST X-RAY")]
        public string CHEST_X_RAY { get; set; }

        [Display(Name = "USG ABDOMEN WHOLE")]
        public string USG_ABDOMEN_WHOLE { get; set; }

        [Display(Name = "USG NECK")]
        public string USG_NECK{ get; set; }

        [Display(Name = "CT_ABDOMEN_PLAIN")]
        public string CT_ABDOMEN_PLAIN { get; set; }

        [Display(Name = "CT_ABDOMEN_CONTRACT")]
        public string CT_ABDOMEN_CONTRACT { get; set; }

        [Display(Name = "UGI_ENDOSCOPY")]
        public string UGI_ENDOSCOPY { get; set; }

        public string THYROID_FNAC { get; set; }

        [Display(Name = "ASCITIC FLUID ANALYSIS")]
        public string ASCITIC_FLUID_ANALYSIS { get; set; }

        [Display(Name = "TUMOR MARKERS CA 19-9")]
        public string TUMOR_MARKERS { get; set; }

        public string LIPID_PROFILE { get; set; }

        [Display(Name = "SR AMYLASE")]
        public string SR_AMYLASE { get; set; }

        public string LIPASE { get; set; }

        public string MRCP { get; set; }

        public string ERCP { get; set; }

        public string MRI_BRAIN_EITH_CONTRAST { get; set; }

        public string RUI { get; set; }

        public string PROLACTIN { get; set; }

        public string TESTOSTERONE { get; set; }

        public string LH { get; set; }

        public string FSH { get; set; }

        public string ESTROGEN { get; set; }

        public string CORTISOL_LEVEL { get; set; }

        public string GROWTH_HORMONE { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }

    }
}
