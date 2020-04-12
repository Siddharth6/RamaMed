using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class EndocrinoClinicalSymptom
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

        public string ENLARGEMENT_OF_FOOT_DURATION { get; set; }

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

        public string PAIN_TINGLING_OVER_FINGERS_DURATION { get; set; }

        public string POLYMENORRHEA_DURATION { get; set; }

        public string OTHERS { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }
        #endregion
    }
}
