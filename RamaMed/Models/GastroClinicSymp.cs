using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class GastroClinicSymp
    {

        #region Clinical Symptoms
        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }

        public string NAUSEA_DURATION { get; set; }

        public string INVOLUNTARY_MOVEMENTS_DURATION { get; set; }

        public string VOMITING_DURATION { get; set; }

        public string ALTERED_SENSORIUM_DURATION { get; set; }

        public string ALTERED_BOWEL_HABITS_DURATION { get; set; }

        public string PERSONALITY_CHANGES_DURATION { get; set; }

        public string HEMATEMESIS_DURATION { get; set; }

        public string ALTERED_SLEEP_PATTERN_DURATION { get; set; }

        public string MALENA_DURATION { get; set; }

        public string HEMATOCHEZIA_DURATION { get; set; }

        public string DYSPESIA_DURATION { get; set; }

        public string OLIGURIA_DURATION { get; set; }

        public string FEVER_DURATION { get; set; }

        public string DYSPHAGIA_DURATION { get; set; }

        public string WEIGHT_LOSS_DURATION { get; set; }

        public string ODYNOPHAGIA_DURATION { get; set; }

        public string ICTERUS_DURATION { get; set; }

        public string FACIAL_PUFFINESS_DURATION { get; set; }

        public string ABDOMINAL_DISTENSION_DURATION { get; set; }

        public string SWELLING_OF_BOTH_LEGS_DURATION { get; set; }

        public string ABDOMINAL_PAIN_DURATION { get; set; }

        public string YELLOWISH_DISCOLORATION_OF_URINE_DURATION { get; set; }

        public string EASY_FATIGUABILITY_DURATION { get; set; }

        public string BREATHELESSNESS_DURATION { get; set; }

        #endregion

    }
}
