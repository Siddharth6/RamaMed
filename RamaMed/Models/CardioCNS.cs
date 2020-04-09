using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models
{
    public class CardioCNS
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }

        public string HIGHER_FUNCTIONS_CONSCIOUS { get; set; }

        public string HIGHER_FUNCTIONS_UNCONSCIOUS_E { get; set; }

        public string HIGHER_FUNCTIONS_UNCONSCIOUS_V { get; set; }

        public string HIGHER_FUNCTIONS_UNCONSCIOUS_M { get; set; }

        public string HIGHER_FUNCTIONS_ORIENTATION { get; set; }

        public string HIGHER_FUNCTIONS_APPEARANCE { get; set; }

        public string HIGHER_FUNCTIONS_BEHAVIOUR { get; set; }

        public string HIGHER_FUNCTIONS_MEMORY { get; set; }

        public string HIGHER_FUNCTIONS_SPEECH { get; set; }

        public string HIGHER_FUNCTIONS_INTELLIGENCE { get; set; }

        public string HIGHER_FUNCTIONS_HALLUCINATION { get; set; }

        public string HIGHER_FUNCTIONS_DELUSION { get; set; }

        public string CRANIAL_NERVES { get; set; }

        public string MOTOR_SYSTEM_NEUTRITION { get; set; }

        public string MOTOR_SYSTEM_TONE { get; set; }

        public string MOTOR_SYSTEM_POWER { get; set; }

        public string MOTOR_SYSTEM_CO_ORDINATION { get; set; }

        public string MOTOR_SYSTEM_INVOLUNTRY_MOVEMENTS { get; set; }

        public string MOTOR_SYSTEM_REFLEXES { get; set; }

        public string MOTOR_SYSTEM_GAIT { get; set; }

        public string SENSORY_SYSTEM_SUPERFICIAL_SENSATION { get; set; }

        public string SENSORY_SYSTEM_DEEP_SENSATIONS { get; set; }

        public string SENSORY_SYSTEM_CORTICAL_SENSATION { get; set; }

        public string CRANIOVERTEBRAL_EXAMINATION { get; set; }

        public string CEREBELLAR_SIGNS { get; set; }

        public string AUTONOMIC_SYSTEM { get; set; }

        public string SIGNS_OF_MENINGIAL_IRRITATION { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }

    }
}
