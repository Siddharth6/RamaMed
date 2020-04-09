using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class DiabetesInvestigation
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

        [Display(Name = "BT/CT")]
        public string BT_CT { get; set; }

        [Display(Name = "PT INR")]
        public string PT_INR { get; set; }

        public string ECG { get; set; }

        [Display(Name = "2D ECHOCARDIOLOGY")]
        public string ECHOCARDIOLOGY_2D { get; set; }

        [Display(Name = "CHEST X-RAY")]
        public string CHEST_X_RAY { get; set; }

        [Display(Name = "USG ABDOMEN WHOLE")]
        public string USG_ABDOMEN_WHOLE { get; set; }

        [Display(Name = "USG ABDOMEN PELVIS")]
        public string USG_ABDOMEN_PELVIS { get; set; }

        [Display(Name = "CT_ABDOMEN_PLAIN")]
        public string CT_ABDOMEN_PLAIN { get; set; }

        [Display(Name = "CT_ABDOMEN_CONTRACT")]
        public string CT_ABDOMEN_CONTRACT { get; set; }

        [Display(Name = "UGI_ENDOSCOPY")]
        public string UGI_ENDOSCOPY { get; set; }

        public string LIPID_PROFILE { get; set; }

        [Display(Name = "ASCITIC FLUID ANALYSIS")]
        public string ASCITIC_FLUID_ANALYSIS { get; set; }

        public string HBA1C { get; set; }

        public string FUNDUS_EXAMINATION { get; set; }

        [Display(Name = "SR AMYLASE")]
        public string SR_AMYLASE { get; set; }

        public string LIPASE { get; set; }

        public string MRCP { get; set; }

        public string ERCP { get; set; }

        public string THYROID_PROFILE { get; set; }

        public string ANTI_GAD_ANTIBODY { get; set; }

        public string C_PEPTIDE { get; set; }

        public string OTHERS { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }


    }
}
