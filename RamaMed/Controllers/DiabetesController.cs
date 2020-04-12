using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RamaMed.Data;
using RamaMed.Models;
using RamaMed.Models.ViewModels;

namespace RamaMed.Controllers
{
    public class DiabetesController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly GMIAllDbContext _gmidb;

        //[BindProperty]
        //public DiabetesClinic DiabetesClinic { get; set; }

        public DiabetesController(ApplicationDbContext db, GMIAllDbContext gmidb)
        {
            _db = db;
            _gmidb = gmidb;
        }


        #region index page

        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("Diabetes_OPDNO") != null)
            {
                HttpContext.Session.SetString("Diabetes_OPDNO", "");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(string searchString)
        {
            if (searchString != null)
            {
                var count = _db.UserDatas.Where(c => c.Dept == "GMI" && c.Clinic == "Diabetes").Count(c => c.OPDNo == searchString);

                //_db.UserDatas
                //        .Where(c => c.OPDNo == "1")
                //        .SelectMany(c => c.OPDNo).Count();
                if (count == 1)
                {
                    //var OPDNO = _db.UserDatas.Where(c => c.OPDNo == SearchString).FirstOrDefault().ToString();
                    //var UHID = _db.UserDatas.Where(c => c.OPDNo == SearchString).FirstOrDefault().ToString();
                    //ViewBag.OPDNO = OPDNO;
                    //var userdata = new UserData();
                    //userdata = _db.UserDatas
                    //           .Where(c => c.OPDNo == SearchString)
                    //           .FirstOrDefault();
                    HttpContext.Session.SetString("Diabetes_OPDNO", searchString);
                    //TempData["OPDNO"] = SearchString;
                    return RedirectToAction("Detail");
                }
                ViewBag.Msg = "OPD Number didn't matched PLease try again";
                return View();
            }
            ViewBag.Msg = "OPD Number Not Found PLease try again";
            return View();
        }

        #endregion

        #region personal details
        public ActionResult Detail()
        {
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                var data = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                //ViewBag.userData = userdata;

                return View(data);
            }
            return RedirectToAction("Index", new { res = "Please Enter OPDNO first" });
        }

        #endregion


        #region clinical
        public ActionResult Clinical()
        {
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.DiabetesClinicalSymptoms.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.DiabetesClinicalSymptoms
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    //var data = _gmidb.DiabetesClinicalSymptoms.Where(c => c.OPDNO == OPDNO).FirstOrDefault();
                    var data = _gmidb.DiabetesClinicalSymptoms.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "Please Enter OPDNO first" });
        }



        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult ClinicalSave(int? id, DiabetesClinicalSymptom model)
        {
            var opd = model.OPDNO;
            bool OpdExists = _gmidb.GastroClinicalSymptoms.Any(m => m.OPDNO == opd);
            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    model.UPDATEDATE = DateTime.Now;
                    _gmidb.Update(model);
                    _gmidb.SaveChanges();
                    return RedirectToAction("Comorbidities");
                }
                model.CREATEDATE = DateTime.Now;
                _gmidb.DiabetesClinicalSymptoms.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Comorbidities");
            }
            return RedirectToAction("Clinical");
        }
        #endregion


        #region comorbididty
        public IActionResult Comorbidities()
        {
            //var data = _db.GastroClinics.Where(c => c.Heading == "COMORBITIES").ToList();
            //return View(data);
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.DiabetesComorbidities.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.DiabetesComorbidities
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    //var data = _gmidb.DiabetesComorbidities.Where(c => c.OPDNO == OPDNO).FirstOrDefault();
                    var data = _gmidb.DiabetesComorbidities.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult ComorbiditySave(int? id, DiabetesComorbidity model)
        {
            //var opd = model.OPDNO;
            //bool OpdExists = _gmidb.DiabetesComorbidities.Any(m => m.OPDNO == opd);
            //if (OpdExists)
            //{
            //    return Content($"Already Exists");
            //}

            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    model.UPDATEDATE = DateTime.Now;
                    _gmidb.Update(model);
                    _gmidb.SaveChanges();
                    return RedirectToAction("Personal");
                }
                model.CREATEDATE = DateTime.Now;
                _gmidb.DiabetesComorbidities.Add(model);
                _gmidb.SaveChanges();
                //ViewData["opdno"] = opd;
                return RedirectToAction("Personal");
            }
            return RedirectToAction("Comorbidities");
            }
        #endregion


        #region personal habits
        public IActionResult Personal()
        {
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.DiabetesPersonalHabits.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.DiabetesPersonalHabits
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.DiabetesPersonalHabits.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult PersonalSave(int? id, DiabetesPersonalHabit model)
        {
            //var opd = model.OPDNO;
            //bool OpdExists = _gmidb.GastroPersonalHabits.Any(m => m.OPDNO == opd);
            //if (OpdExists)
            //{
            //    //var data = _gmidb.GastroClinicalSymptoms.Where(m => m.OPDNO == opd);
            //    return Content($"Already Exists");
            //}

            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    model.UPDATEDATE = DateTime.Now;
                    _gmidb.Update(model);
                    _gmidb.SaveChanges();
                    return RedirectToAction("GeneralExam");
                }
                model.CREATEDATE = DateTime.Now;
                _gmidb.DiabetesPersonalHabits.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("GeneralExam");
            }
            return RedirectToAction("Personal");
        }


        #endregion


        #region General Examinations
        public IActionResult GeneralExam()
        {
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.DiabetesGeneralExaminations.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.DiabetesGeneralExaminations
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.DiabetesGeneralExaminations.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult GeneralExamSave(int? id, DiabetesGeneralExamination model)
        {
            //var opd = model.OPDNO;
            //bool OpdExists = _gmidb.GastroGeneralExaminations.Any(m => m.OPDNO == opd);
            //if (OpdExists)
            //{
            //    return Content($"Already Exists");
            //}

            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    model.UPDATEDATE = DateTime.Now;
                    _gmidb.Update(model);
                    _gmidb.SaveChanges();
                    return RedirectToAction("CNS");
                }
                model.CREATEDATE = DateTime.Now;
                _gmidb.DiabetesGeneralExaminations.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("CNS");
            }
            return RedirectToAction("GeneralExam");
        }

        #endregion


        #region CNS
        public IActionResult CNS()
        {
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;


                bool OpdExists = _gmidb.DiabetesCNSs.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.DiabetesCNSs
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.DiabetesCNSs.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CNS_Save(int? id, DiabetesCNS model)
        {
            //var opd = model.OPDNO;
            //bool OpdExists = _gmidb.GastroCNSs.Any(m => m.OPDNO == opd);
            //if (OpdExists)
            //{
            //    return Content($"Already Exists");
            //}
            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    model.UPDATEDATE = DateTime.Now;
                    _gmidb.Update(model);
                    _gmidb.SaveChanges();
                    return RedirectToAction("RespSys");
                }
                model.CREATEDATE = DateTime.Now;
                _gmidb.DiabetesCNSs.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("GeneralExam");
            }
            return RedirectToAction("CNS");
        }
        #endregion


        #region RespSys
        public IActionResult RespSys()
        {
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.DiabetesRespSystems.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.DiabetesRespSystems
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.DiabetesRespSystems.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult RespSysSave(int? id, DiabetesRespSystem model)
        {
            //var opd = model.OPDNO;
            //bool OpdExists = _gmidb.GastroRespSystems.Any(m => m.OPDNO == opd);
            //if (OpdExists)
            //{
            //    return Content($"Already Exists");
            //}
            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    model.UPDATEDATE = DateTime.Now;
                    _gmidb.Update(model);
                    _gmidb.SaveChanges();
                    return RedirectToAction("AbdExam");
                }
                model.CREATEDATE = DateTime.Now;
                _gmidb.DiabetesRespSystems.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("AbdExam");
            }
            return RedirectToAction("RespSys");
        }
        #endregion


        #region AbdExam
        public IActionResult AbdExam()
        {
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.DiabetesAbdExams.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.DiabetesAbdExams
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.DiabetesAbdExams.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AbdExamSave(int? id, DiabetesAbdExam model)
        {
            //var opd = model.OPDNO;
            //bool OpdExists = _gmidb.GastroAbdExams.Any(m => m.OPDNO == opd);
            //if (OpdExists)
            //{
            //    return Content($"Already Exists");
            //}
            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    model.UPDATEDATE = DateTime.Now;
                    _gmidb.Update(model);
                    _gmidb.SaveChanges();
                    return RedirectToAction("CVS");
                }
                model.CREATEDATE = DateTime.Now;
                _gmidb.DiabetesAbdExams.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("CVS");
            }
            return RedirectToAction("AbdExam");
        }
        #endregion


        #region CVS
        public IActionResult CVS()
        {
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;


                bool OpdExists = _gmidb.DiabetesCVSs.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.DiabetesCVSs
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.DiabetesCVSs.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CVS_Save(int? id, DiabetesCVS model)
        {
            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    model.UPDATEDATE = DateTime.Now;
                    _gmidb.Update(model);
                    _gmidb.SaveChanges();
                    return RedirectToAction("Investigations");
                }
                model.CREATEDATE = DateTime.Now;
                _gmidb.DiabetesCVSs.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Investigations");
            }
            return RedirectToAction("CVS");
        }
        #endregion


        #region Investigations
        public IActionResult Investigations()
        {
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.DiabetesInvestigations.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.DiabetesInvestigations
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.DiabetesInvestigations.Find(Id);
                    return View(data);
                }
                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult InvestigationSave(int? id, DiabetesInvestigation model)
        {
            //var opd = model.OPDNO;
            //bool OpdExists = _gmidb.GastroInvestigations.Any(m => m.OPDNO == opd);
            //if (OpdExists)
            //{
            //    return Content($"Already Exists");
            //}
            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    model.UPDATEDATE = DateTime.Now;
                    _gmidb.Update(model);
                    _gmidb.SaveChanges();
                    return RedirectToAction("Other");
                }
                model.CREATEDATE = DateTime.Now;
                _gmidb.DiabetesInvestigations.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Other");
            }
            return RedirectToAction("Investigation");
        }
        #endregion


        #region Others
        public IActionResult Other()
        {
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.CardioOthers.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.CardioOthers
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.CardioOthers.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult OtherSave(int? id, CardioOther model)
        {
            //var opd = model.OPDNO;
            //bool OpdExists = _gmidb.GastroOthers.Any(m => m.OPDNO == opd);
            //if (OpdExists)
            //{
            //    return Content($"Already Exists");
            //}
            if (ModelState.IsValid)
            {
                if (id != null)
                {
                    model.UPDATEDATE = DateTime.Now;
                    _gmidb.Update(model);
                    _gmidb.SaveChanges();
                    return RedirectToAction("Report");
                }
                model.CREATEDATE = DateTime.Now;
                _gmidb.CardioOthers.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Report");
            }
            return RedirectToAction("Other");
        }
        #endregion

        #region Report
        public IActionResult Report()
        {
            string OPDNO = HttpContext.Session.GetString("Diabetes_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                Diabetes data = new Diabetes
                {
                    UserData = _db.UserDatas.Where(c => c.OPDNo == OPDNO).FirstOrDefault(),
                    DiabetesClinicalSymptom = _gmidb.DiabetesClinicalSymptoms.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    DiabetesComorbidity = _gmidb.DiabetesComorbidities.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    DiabetesPersonalHabit = _gmidb.DiabetesPersonalHabits.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    DiabetesGeneralExamination = _gmidb.DiabetesGeneralExaminations.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    DiabetesCNS = _gmidb.DiabetesCNSs.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    DiabetesRespSystem = _gmidb.DiabetesRespSystems.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    DiabetesAbdExam = _gmidb.DiabetesAbdExams.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    DiabetesCVS = _gmidb.DiabetesCVSs.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    DiabetesInvestigation = _gmidb.DiabetesInvestigations.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    DiabetesOther = _gmidb.DiabetesOthers.Where(c => c.OPDNO == OPDNO).FirstOrDefault()
                };
                return View(data);
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }
        #endregion
    }
}
