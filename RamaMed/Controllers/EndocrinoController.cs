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
    public class EndocrinoController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly GMIAllDbContext _gmidb;

        //[BindProperty]
        //public DiabetesClinic DiabetesClinic { get; set; }

        public EndocrinoController(ApplicationDbContext db, GMIAllDbContext gmidb)
        {
            _db = db;
            _gmidb = gmidb;
        }


        #region index page

        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("Endocrino_OPDNO") != null)
            {
                HttpContext.Session.SetString("Endocrino_OPDNO", "");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(string searchString)
        {
            if (searchString != null)
            {
                var count = _db.UserDatas.Where(c => c.Dept == "GMI" && c.Clinic == "Endocrinology").Count(c => c.OPDNo == searchString);

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
                    HttpContext.Session.SetString("Endocrino_OPDNO", searchString);
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
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
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
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
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
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
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
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.EndocrinoPersonalHabits.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.EndocrinoPersonalHabits
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.EndocrinoPersonalHabits.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult PersonalSave(int? id, EndocrinoPersonalHabit model)
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
                _gmidb.EndocrinoPersonalHabits.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("GeneralExam");
            }
            return RedirectToAction("Personal");
        }


        #endregion


        #region General Examinations
        public IActionResult GeneralExam()
        {
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.EndocrinoGeneralExaminations.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.EndocrinoGeneralExaminations
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.EndocrinoGeneralExaminations.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult GeneralExamSave(int? id, EndocrinoGeneralExamination model)
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
                _gmidb.EndocrinoGeneralExaminations.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("CNS");
            }
            return RedirectToAction("GeneralExam");
        }

        #endregion


        #region CNS
        public IActionResult CNS()
        {
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;


                bool OpdExists = _gmidb.EndocrinoCNSs.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.EndocrinoCNSs
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.EndocrinoCNSs.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CNS_Save(int? id, EndocrinoCNS model)
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
                _gmidb.EndocrinoCNSs.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("GeneralExam");
            }
            return RedirectToAction("CNS");
        }
        #endregion


        #region RespSys
        public IActionResult RespSys()
        {
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.EndocrinoRespSystems.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.EndocrinoRespSystems
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.EndocrinoRespSystems.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult RespSysSave(int? id, EndocrinoRespSystem model)
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
                _gmidb.EndocrinoRespSystems.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("AbdExam");
            }
            return RedirectToAction("RespSys");
        }
        #endregion


        #region AbdExam
        public IActionResult AbdExam()
        {
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.EndocrinoAbdExams.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.EndocrinoAbdExams
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.EndocrinoAbdExams.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AbdExamSave(int? id, EndocrinoAbdExam model)
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
                _gmidb.EndocrinoAbdExams.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("CVS");
            }
            return RedirectToAction("AbdExam");
        }
        #endregion


        #region CVS
        public IActionResult CVS()
        {
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;


                bool OpdExists = _gmidb.EndocrinoCVSs.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.EndocrinoCVSs
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.EndocrinoCVSs.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CVS_Save(int? id, EndocrinoCVS model)
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
                _gmidb.EndocrinoCVSs.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Investigations");
            }
            return RedirectToAction("CVS");
        }
        #endregion


        #region Investigations
        public IActionResult Investigations()
        {
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.EndocrinoInvestigations.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.EndocrinoInvestigations
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.EndocrinoInvestigations.Find(Id);
                    return View(data);
                }
                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult InvestigationSave(int? id, EndocrinoInvestigation model)
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
                _gmidb.EndocrinoInvestigations.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Other");
            }
            return RedirectToAction("Investigation");
        }
        #endregion


        #region Others
        public IActionResult Other()
        {
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.EndocrinoOthers.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.EndocrinoOthers
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.EndocrinoOthers.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult OtherSave(int? id, EndocrinoOther model)
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
                _gmidb.EndocrinoOthers.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Report");
            }
            return RedirectToAction("Other");
        }
        #endregion

        #region Report
        public IActionResult Report()
        {
            string OPDNO = HttpContext.Session.GetString("Endocrino_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                Endocrinology data = new Endocrinology
                {
                    UserData = _db.UserDatas.Where(c => c.OPDNo == OPDNO).FirstOrDefault(),
                    EndocrinoClinicalSymptom = _gmidb.EndocrinoClinicalSymptoms.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    EndocrinoComorbidity = _gmidb.EndocrinoComorbidities.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    EndocrinoPersonalHabit = _gmidb.EndocrinoPersonalHabits.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    EndocrinoGeneralExamination = _gmidb.EndocrinoGeneralExaminations.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    EndocrinoCNS = _gmidb.EndocrinoCNSs.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    EndocrinoRespSystem = _gmidb.EndocrinoRespSystems.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    EndocrinoAbdExam = _gmidb.EndocrinoAbdExams.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    EndocrinoCVS = _gmidb.EndocrinoCVSs.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    EndocrinoInvestigation = _gmidb.EndocrinoInvestigations.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    EndocrinoOther = _gmidb.EndocrinoOthers.Where(c => c.OPDNO == OPDNO).FirstOrDefault()
                };
                return View(data);
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }
        #endregion
    }
}
