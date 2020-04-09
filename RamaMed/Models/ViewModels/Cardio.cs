using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RamaMed.Models;
namespace RamaMed.Models.ViewModels
{
    public class Cardio
    {
        public UserData UserData { get; set; }

        public CardioClinicalSymptom CardioClinicalSymptom { get; set; }

        public CardioComorbidity CardioComorbidity { get; set; }

        public CardioCNS CardioCNS { get; set; }

        public CardioCVS CardioCVS { get; set; }

        public CardioAbdExam CardioAbdExam { get; set; }

        public CardioGeneralExamination CardioGeneralExamination { get; set; }

        public CardioInvestigation CardioInvestigation { get; set; }

        public CardioOther CardioOther { get; set; }

        public CardioPersonal CardioPersonal { get; set; }

        public CardioRespSystem CardioRespSystem { get; set; }

    }
}
