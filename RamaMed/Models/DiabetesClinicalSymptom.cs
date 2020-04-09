using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class DiabetesClinicalSymptom
    {

        #region Clinical Symptoms

        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }

        public string WEIGHT_LOSS_DURATION { get; set; }

        public string FATIGUE_GENERALISED_ITCHING_DURATION { get; set; }

        public string POLYDIPSIA_DURATION { get; set; }

        public string POLYPHAGIA_DURATION { get; set; }

        public string DYSURIA_DURATION { get; set; }

        public string NOCTURIA_DURATION { get; set; }

        public string BURNING_FEET_DURATION { get; set; }

        public string TINGLING_NUMBNESS_DURATION { get; set; }

        public string IMPOTENCE_DURATION { get; set; }

        public string GENITAL_ITCHING_DURATION { get; set; }

        public string BLURRING_OF_VISION_DURATION { get; set; }

        public string FEVER_DURATION { get; set; }

        public string ANGINAL_PAIN_DURATION { get; set; }

        public string BREATHLESSNESS_DURATION { get; set; }

        public string POSTURAL_DIZZINESS_DURATION { get; set; }

        public string POLYURIA_DURATION { get; set; }

        public string PAIN_ABDOMEN_DURATION { get; set; }

        public string OLIGURIA_DURATION { get; set; }

        public string SITE_DURATION { get; set; }

        public string WEAKNESS_DURATION { get; set; }

        public string SEVERITY_DURATION { get; set; }

        public string GENITAL_ULCERS_DURATION { get; set; }

        public string RADIATION_DURATION { get; set; }

        public string COUGH_WITH_SPUTUM_DURATION { get; set; }

        public string CHARACTER_DURATION { get; set; }

        public string PALPITATION_DURATION { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }
        #endregion
    }
}
