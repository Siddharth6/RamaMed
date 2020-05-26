using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using RamaMed.Data;
using RamaMed.Models;
using RamaMed.Models.ViewModels;

namespace RamaMed.Controllers
{
    public class BasiGMIController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly GMIAllDbContext _gmidb;

        //[BindProperty]
        //public BasicClinic BasicClinic { get; set; }

        public BasiGMIController(ApplicationDbContext db, GMIAllDbContext gmidb)
        {
            _db = db;
            _gmidb = gmidb;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Session.GetString("UserId") != null && HttpContext.Session.GetString("Role") == "Basic")
                base.OnActionExecuting(filterContext);
            else
                RedirectToAction("Index");
        }



        #region index page

        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("Basic_OPDNO") != null)
            {
                HttpContext.Session.SetString("Basic_OPDNO", "");
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
                    HttpContext.Session.SetString("Basic_OPDNO", searchString);
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
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
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
        public ActionResult ClinicalSymptoms()
        {
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.BasicClinicalSymptoms.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.BasicClinicalSymptoms
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    //var data = _gmidb.DiabetesClinicalSymptoms.Where(c => c.OPDNO == OPDNO).FirstOrDefault();
                    var data = _gmidb.BasicClinicalSymptoms.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "Please Enter OPDNO first" });
        }



        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult ClinicalSave(int? id, BasicClinicalSymptom model)
        {
            var opd = model.OPDNO;
            bool OpdExists = _gmidb.BasicClinicalSymptoms.Any(m => m.OPDNO == opd);
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
                _gmidb.BasicClinicalSymptoms.Add(model);
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
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.BasicComorbidities.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.BasicComorbidities
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    //var data = _gmidb.DiabetesComorbidities.Where(c => c.OPDNO == OPDNO).FirstOrDefault();
                    var data = _gmidb.BasicComorbidities.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult ComorbiditySave(int? id, BasicComorbidity model)
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
                _gmidb.BasicComorbidities.Add(model);
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
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.BasicPersonals.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.BasicPersonals
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.BasicPersonals.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult PersonalSave(int? id, BasicPersonal model)
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
                _gmidb.BasicPersonals.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("GeneralExam");
            }
            return RedirectToAction("Personal");
        }


        #endregion


        #region General Examinations
        public IActionResult GeneralExam()
        {
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.BasicGeneralExaminations.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.BasicGeneralExaminations
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.BasicGeneralExaminations.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult GeneralExamSave(int? id, BasicGeneralExamination model)
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
                _gmidb.BasicGeneralExaminations.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("CNS");
            }
            return RedirectToAction("GeneralExam");
        }

        #endregion


        #region CNS
        public IActionResult CNS()
        {
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;


                bool OpdExists = _gmidb.BasicCNSs.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.BasicCNSs
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.BasicCNSs.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CNS_Save(int? id, BasicCNS model)
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
                _gmidb.BasicCNSs.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("GeneralExam");
            }
            return RedirectToAction("CNS");
        }
        #endregion


        #region RespSys
        public IActionResult RespSys()
        {
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.BasicRespSystems.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.BasicRespSystems
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.BasicRespSystems.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult RespSysSave(int? id, BasicRespSystem model)
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
                _gmidb.BasicRespSystems.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("AbdExam");
            }
            return RedirectToAction("RespSys");
        }
        #endregion


        #region AbdExam
        public IActionResult AbdExam()
        {
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.BasicAbdExams.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.BasicAbdExams
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.BasicAbdExams.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AbdExamSave(int? id, BasicAbdExam model)
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
                _gmidb.BasicAbdExams.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("CVS");
            }
            return RedirectToAction("AbdExam");
        }
        #endregion


        #region CVS
        public IActionResult CVS()
        {
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;


                bool OpdExists = _gmidb.BasicCVSs.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.BasicCVSs
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.BasicCVSs.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CVS_Save(int? id, BasicCVS model)
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
                _gmidb.BasicCVSs.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Investigations");
            }
            return RedirectToAction("CVS");
        }
        #endregion


        #region Investigations
        public IActionResult Investigations()
        {
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.BasicInvestigations.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.BasicInvestigations
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.BasicInvestigations.Find(Id);
                    return View(data);
                }
                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult InvestigationSave(int? id, BasicInvestigation model)
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
                _gmidb.BasicInvestigations.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Other");
            }
            return RedirectToAction("Investigation");
        }
        #endregion


        #region Others
        public IActionResult Other()
        {
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.BasicOthers.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.BasicOthers
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.BasicOthers.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult OtherSave(int? id, BasicOther model)
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
                _gmidb.BasicOthers.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Report");
            }
            return RedirectToAction("Other");
        }
        #endregion

        #region Report
        public IActionResult Report()
        {
            string OPDNO = HttpContext.Session.GetString("Basic_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                BasicGMI data = new BasicGMI
                {
                    UserData = _db.UserDatas.Where(c => c.OPDNo == OPDNO).FirstOrDefault(),
                    BasicClinicalSymptom = _gmidb.BasicClinicalSymptoms.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    BasicComorbidity = _gmidb.BasicComorbidities.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    BasicPersonal = _gmidb.BasicPersonals.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    BasicGeneralExamination = _gmidb.BasicGeneralExaminations.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    BasicCNS = _gmidb.BasicCNSs.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    BasicRespSystem = _gmidb.BasicRespSystems.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    BasicAbdExam = _gmidb.BasicAbdExams.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    BasicCVS = _gmidb.BasicCVSs.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    BasicInvestigation = _gmidb.BasicInvestigations.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    BasicOther = _gmidb.BasicOthers.Where(c => c.OPDNO == OPDNO).FirstOrDefault()
                };
                return View(data);
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }
        #endregion
    }
}
