using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class CardioClinicalSymptom
    {
        
        #region Clinical Symptoms
        
        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }

        public string BREATHLESNESS_DURATION { get; set; }

        public string PALPITATION_DURATION { get; set; }

        public string NYHA_CLASS_DURATION { get; set; }

        public string PEDAL_EDEMA_DURATION { get; set; }

        public string PND_DURATION { get; set; }

        public string SPUTUM_HAE_DURATION { get; set; }

        public string ORTHOPNOEA_DURATION { get; set; }

        public string ABDOMINAL_DISTENSION_DURATION { get; set; }

        public string PLATYPNOEA_DURATION { get; set; }

        public string DYSPESIA_DURATION { get; set; }

        public string CHEST_PAIN_DURATION { get; set; }

        public string NOCTURIA_DURATION { get; set; }

        public string SYNCOPE_DURATION { get; set; }

        public string NAUSEA_VOMITING_DURATION { get; set; }

        public string COUGH_DURATION { get; set; }

        public string OLIGURIA_DURATION { get; set; }

        public string ABDOMINAL_PAIN_DURATION { get; set; }

        public string HOARSENESS_OF_VOICE_DURATION { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }
        #endregion
    }
}
