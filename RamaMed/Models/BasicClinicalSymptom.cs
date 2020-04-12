using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class BasicClinicalSymptom
    {
        #region Clinical Symptoms

        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }

        public string WEIGHT_GAIN_DURATION { get; set; }

        public string GALACTRORRHOEA_DURATION { get; set; }

        public string INCREASED_APETITE_DURATION { get; set; }

        public string ABDOMEN_PAIN_DURATION { get; set; }

        public string PALPITATION_DURATION { get; set; }

        public string ENLARGRMENT_OF_FOOT_DURATION { get; set; }

        public string EXCESSIVE_SWEATING_DURATION { get; set; }

        public string LOSS_OF_LIBIDO_DURATION { get; set; }

        public string OLIGOMENOORHEA_DURATION { get; set; }

        public string SKIN_DRYNESS_DURATION { get; set; }

        public string GYNECOMASTIA_DURATION { get; set; }

        public string TREMOR_DURATION { get; set; }

        public string DIPLOPIA_DURATION { get; set; }

        public string DIARRHOEA_DURATION { get; set; }

        public string ENLARGEMENT_OF_HAND_DURATION { get; set; }

        public string DYSMEONORRHOEA_DURATION { get; set; }

        public string HIRSUTISM_DURATION { get; set; }

        public string AMENNORHOEA_DURATION { get; set; }

        public string WEIGHT_LOSS_DURATION { get; set; }

        public string HEADACHE_DURATION { get; set; }

        public string LOSS_OF_APETITE_DURATION { get; set; }

        public string SEIZURES_DURATION { get; set; }

        public string CONSTIPATION_DURATION { get; set; }

        public string INFERTILITY_DURATION { get; set; }

        public string FATIGUE_DURATION { get; set; }

        public string PAIN_OVER_FINGERS_DURATION { get; set; }

        public string POLYMENORRHEA_DURATION { get; set; }

        public string YELLOWISH_DISCOLORATION_OF_URINE_DURATION { get; set; }

        public string NAUSEA_DURATION { get; set; }

        public string VOMITING_DURATION { get; set; }

        public string ALTERED_BOWEL_HABITS_DURATION { get; set; }

        public string MALENA_DURATION { get; set; }

        public string HEMATEMESIS_DURATION { get; set; }

        public string DYSPESIA_DURATION { get; set; }

        public string FEVER_DURATION { get; set; }

        public string ICTERUS_DURATION { get; set; }

        public string ABDOMINAL_DISTENSION_DURATION { get; set; }

        public string EASY_FATIGUABILITY_DURATION { get; set; }

        public string BREATHLESSNESS_DURATION { get; set; }

        public string INVOLUNTARY_MOVEMENTS_DURATION { get; set; }

        public string ALTERED_SENSORIUM_DURATION { get; set; }

        public string PERSONALITY_CHANGES_DURATION { get; set; }

        public string ALTERED_SLEEP_PATTERN_DURATION { get; set; }

        public string HEMATOCHEZIA_DURATION { get; set; }

        public string OLIGURIA_DURATION { get; set; }

        public string DYSPHAGIA_DURATION { get; set; }

        public string FACIAL_PUFFINESS_DURATION { get; set; }

        public string ODYNOPHAGIA_DURATION { get; set; }

        public string SWELLING_OF_BOTH_LEGS_DURATION { get; set; }

        public string POLYPHAGIA_DURATION { get; set; }

        public string POLYDIPSIA_DURATION { get; set; }

        public string RADIATION_DURATION { get; set; }

        public string DYSURIA_DURATION { get; set; }

        public string IMPOTENCE_DURATION { get; set; }

        public string BURNING_FEET_DURATION { get; set; }

        public string ANGINAL_PAIN_DURATION { get; set; }

        public string BLURRING_OF_VISION_DURATION { get; set; }

        public string SITE_DURATION { get; set; }

        public string POSTURAL_DIZZINESS_DURATION { get; set; }

        public string SEVERITY_DURATION { get; set; }

        public string FATIGUE_GENERALISED_ITCHING_DURATION { get; set; }

        public string CHARACTER_DURATION { get; set; }

        public string NOCTURIA_DURATION { get; set; }

        public string TINGLING_NUMBNESS_DURATION { get; set; }

        public string GENITAL_ITCHING_DURATION { get; set; }

        public string WEAKNESS_DURATION { get; set; }

        public string COUGH_DURATION { get; set; }

        public string SPUTUM_DURATION { get; set; }

        public string GENITAL_ULCERS_DURATION { get; set; }

        public string PEDAL_EDEMA_DURATION { get; set; }

        public string NYHA_CLASS_DURATION { get; set; }

        public string PND_DURATION { get; set; }

        public string ORTHOPNOEA_DURATION { get; set; }

        public string PLATYPNOEA_DURATION { get; set; }

        public string SYNCOPE_DURATION { get; set; }

        public string CHEST_PAIN_DURATION { get; set; }

        public string HOARSENESS_DURATION { get; set; }

        public string OTHERS_DURATION { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }
        #endregion
    }
}
