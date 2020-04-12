using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RamaMed.Models.ViewModels
{
    public class Endocrinology
    {
        public UserData UserData { get; set; }

        public EndocrinoClinicalSymptom EndocrinoClinicalSymptom { get; set; }

        public EndocrinoComorbidity EndocrinoComorbidity { get; set; }

        public EndocrinoPersonalHabit EndocrinoPersonalHabit { get; set; }

        public EndocrinoGeneralExamination EndocrinoGeneralExamination { get; set; }

        public EndocrinoCNS EndocrinoCNS { get; set; }

        public EndocrinoRespSystem EndocrinoRespSystem { get; set; }

        public EndocrinoAbdExam EndocrinoAbdExam { get; set; }

        public EndocrinoCVS EndocrinoCVS { get; set; }

        public EndocrinoInvestigation EndocrinoInvestigation { get; set; }

        public EndocrinoOther EndocrinoOther { get; set; }
    }
}
