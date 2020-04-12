using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models.ViewModels
{
    public class Diabetes
    {
        public UserData UserData { get; set; }

        public DiabetesClinicalSymptom DiabetesClinicalSymptom { get; set; }

        public DiabetesComorbidity DiabetesComorbidity { get; set; }

        public DiabetesPersonalHabit DiabetesPersonalHabit { get; set; }

        public DiabetesGeneralExamination DiabetesGeneralExamination { get; set; }

        public DiabetesCNS DiabetesCNS { get; set; }

        public DiabetesRespSystem DiabetesRespSystem { get; set; }

        public DiabetesAbdExam DiabetesAbdExam { get; set; }

        public DiabetesCVS DiabetesCVS { get; set; }

        public DiabetesInvestigation DiabetesInvestigation { get; set; }

        public DiabetesOther DiabetesOther { get; set; }
    }
}
