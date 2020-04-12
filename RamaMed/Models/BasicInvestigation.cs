using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class BasicInvestigation
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

        [Display(Name = "URINE KETONES BODIES")]
        public string URINE_KETONES_BODIES { get; set; }

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

        [Display(Name = "USG NECK")]
        public string USG_NECK { get; set; }

        [Display(Name = "UGI_ENDOSCOPY")]
        public string UGI_ENDOSCOPY { get; set; }

        [Display(Name = "ASCITIC FLUID ANALYSIS")]
        public string ASCITIC_FLUID_ANALYSIS { get; set; }

        [Display(Name = "SR AMYLASE")]
        public string SR_AMYLASE { get; set; }

        public string LIPASE { get; set; }

        public string TUMOR_MARKERS { get; set; }

        public string CRP { get; set; }

        public string ESR { get; set; }

        public string ASO_TITRE { get; set; }

        public string LIPID_PROFILE { get; set; }

        public string THYROID_PROFILE { get; set; }

        public string CPK_MB { get; set; }

        public string TROPONIN_T { get; set; }

        public string TROPONIN_I { get; set; }

        public string PERICARDIAL_FLUID_EXAMINATION { get; set; }

        public string HOLTER { get; set; }

        public string TMT { get; set; }

        public string STRESS_ECHOCARDIOGRAPHY { get; set; }

        public string ANGIOGRAPHY { get; set; }

        public string CARDIAC_CT { get; set; }

        public string CARDIAC_MRI { get; set; }

        public string TEE { get; set; }

        [Display(Name = "CT_ABDOMEN_PLAIN")]
        public string CT_ABDOMEN_PLAIN { get; set; }

        [Display(Name = "CT ABDOMEN CONTRAST")]
        public string CT_ABDOMEN_CONTRAST { get; set; }

        public string HBA1C { get; set; }

        public string FUNDUS_EXAMINATION { get; set; }

        public string MRCP { get; set; }

        public string ERCP { get; set; }

        public string ANTI_GAD_ANTIBODY { get; set; }

        public string C_PEPTIDE { get; set; }

        public string ANTI_TPO { get; set; }

        public string ANTI_THYROGLOBULIN_ANTI_BODY { get; set; }

        public string THYROID_FNAC { get; set; }

        public string MRI_BRAIN_WITH_CONTRAST { get; set; }

        public string RIU { get; set; }

        public string PROLACTIN { get; set; }

        public string TESTOSTERONE { get; set; }

        public string LH { get; set; }

        public string FSH { get; set; }

        public string ESTROGEN { get; set; }

        public string CORTISOL_LEVEL { get; set; }

        public string GROWTH_HORMONE { get; set; }

        public string COLONOSCOPY { get; set; }

        public string LIVER_BIOPSY { get; set; }

        public string OTHERS { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }

    }
}
