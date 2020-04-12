using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models.ViewModels
{
    public class BasicGMI
    {
        public UserData UserData { get; set; }

        public BasicClinicalSymptom BasicClinicalSymptom { get; set; }

        public BasicComorbidity BasicComorbidity { get; set; }

        public BasicPersonal BasicPersonal { get; set; }

        public BasicGeneralExamination BasicGeneralExamination { get; set; }

        public BasicCNS BasicCNS { get; set; }

        public BasicRespSystem BasicRespSystem { get; set; }

        public BasicAbdExam BasicAbdExam { get; set; }

        public BasicCVS BasicCVS { get; set; }

        public BasicInvestigation BasicInvestigation { get; set; }

        public BasicOther BasicOther { get; set; }
    }
}
