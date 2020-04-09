using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RamaMed.Models;
namespace RamaMed.Models.ViewModels
{
    public class Gastro
    {
        public UserData UserData { get; set; }
        public GastroClinicalSymptom GastroClinicalSymptom { get; set; }

        public GastroComorbidity GastroComorbidity { get; set; }

        public GastroPersonalHabit GastroPersonalHabit { get; set; }

        public GastroGeneralExamination GastroGeneralExamination { get; set; }

        public GastroCNS GastroCNS { get; set; }

        public GastroRespSystem GastroRespSystem { get; set; }

        public GastroAbdExam GastroAbdExam { get; set; }

        public GastroCVS GastroCVS { get; set; }

        public GastroInvestigation GastroInvestigation { get; set; }

        public GastroOther GastroOther { get; set; }
    }
}
