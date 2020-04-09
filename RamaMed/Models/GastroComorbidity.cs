using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RamaMed.Models
{
    public class GastroComorbidity
    {


        [Key]
        public int ID { get; set; }
    
        [Required]
        public string UHID { get; set; }

        [Required]
        public string OPDNO { get; set; }

        public string HYPERTENSION_DURATION { get; set; }

        public string HYPERTENSION_MEDICATION { get; set; }

        public string CORONARY_ARTERY_DISEASE_DURATION { get; set; }

        public string CORONARY_ARTERY_DISEASE_MEDICATION { get; set; }

        public string COPD_DURATION { get; set; }

        public string COPD_MEDICATION { get; set; }

        public string ASTHMA_DURATION { get; set; }

        public string ASTHMA_MEDICATION { get; set; }

        public string CKD_DURATION { get; set; }

        public string CKD_MEDICATION { get; set; }

        public string HEART_FAILURE_DURATION { get; set; }

        public string HEART_FAILURE_MEDICATION { get; set; }

        public string HYPOTHYROIDISM_DURATION { get; set; }

        public string HYPOTHYROIDISM_MEDICATION { get; set; }

        [BindProperty]
        public string PULMONARY_TB { get; set; }
        public string[] PULMONARY_TBs = new[] { "Yes", "No" };

        [DataType(DataType.Date)]
        public Nullable<DateTime> PULMONARY_TB_DATE_OF_DIAGNOSIS { get; set; }

        public string PULMONARY_TB_ATT_REGIMEN { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> PULMONARY_TB_DATE_OF_STARTING { get; set; }

        [DataType(DataType.Date)]
        public Nullable<DateTime> PULMONARY_TB_DATE_OF_ENDING { get; set; }

        public string HIV { get; set; }

        public string HBSAG { get; set; }

        public string ANTI_HCV { get; set; }

        public string DIABETES_MELLITUS { get; set; }

        public DateTime CREATEDATE { get; set; }

        public Nullable<DateTime> UPDATEDATE { get; set; }
    }
}
