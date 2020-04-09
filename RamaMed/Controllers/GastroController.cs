using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RamaMed.Models;
using RamaMed.Data;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using RamaMed.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RamaMed.Controllers
{

    public class GastroController : Controller
    {
        //All the DbContext needed for this page
        private readonly ApplicationDbContext _db;
        private readonly GMIAllDbContext _gmidb;

        public GastroController(ApplicationDbContext db, GMIAllDbContext gmidb)
        {
            _db = db;
            _gmidb = gmidb;
        }


        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Session.GetString("UserId") != null)
                base.OnActionExecuting(filterContext);
            else
                RedirectToAction("Index");
        }


        #region index page

        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("Gastro_OPDNO") != null)
            {
                HttpContext.Session.SetString("Gastro_OPDNO", "");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(string SearchString)
        {
            if (SearchString != null)
            {
                var count = _db.UserDatas.Where(c => c.Dept=="GMI" && c.Clinic=="Gastro").Count(c => c.OPDNo == SearchString);

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
                    HttpContext.Session.SetString("Gastro_OPDNO", SearchString);
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
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
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
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.GastroClinicalSymptoms.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.GastroClinicalSymptoms
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    //var data = _gmidb.GastroClinicalSymptoms.Where(c => c.OPDNO == OPDNO).FirstOrDefault();
                    var data = _gmidb.GastroClinicalSymptoms.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "Please Enter OPDNO first" });
        }



        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult ClinicalSave(int? id, GastroClinicalSymptom model)
        {
            //var opd = model.OPDNO;
            //bool OpdExists = _gmidb.GastroClinicalSymptoms.Any(m => m.OPDNO == opd);
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
                _gmidb.GastroClinicalSymptoms.Add(model);
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
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.GastroComorbidities.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.GastroComorbidities
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    //var data = _gmidb.GastroClinicalSymptoms.Where(c => c.OPDNO == OPDNO).FirstOrDefault();
                    var data = _gmidb.GastroComorbidities.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult ComorbiditySave(int? id, GastroComorbidity model)
        {
            //var opd = model.OPDNO;
            //bool OpdExists = _gmidb.GastroComorbidities.Any(m => m.OPDNO == opd);
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
                _gmidb.GastroComorbidities.Add(model);
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
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.GastroPersonalHabits.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.GastroPersonalHabits
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.GastroPersonalHabits.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult PersonalSave(int? id, GastroPersonalHabit model)
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
                _gmidb.GastroPersonalHabits.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("GeneralExam");
            }
            return RedirectToAction("Personal");
        }


        #endregion



        #region General Examinations
        public IActionResult GeneralExam()
        {
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.GastroGeneralExaminations.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.GastroGeneralExaminations
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.GastroGeneralExaminations.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult GeneralExamSave(int? id, GastroGeneralExamination model)
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
                _gmidb.GastroGeneralExaminations.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("CNS");
            }
            return RedirectToAction("GeneralExam");
        }

        #endregion



        #region CNS
        public IActionResult CNS()
        {
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;


                bool OpdExists = _gmidb.GastroCNSs.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.GastroCNSs
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.GastroCNSs.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CNS_Save(int? id, GastroCNS model)
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
                    return RedirectToAction("Personal");
                }
                model.CREATEDATE = DateTime.Now;
                _gmidb.GastroCNSs.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("GeneralExam");
            }
            return RedirectToAction("CNS");
        }
        #endregion



        #region RespSys
        public IActionResult RespSys()
        {
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.GastroRespSystems.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.GastroRespSystems
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.GastroRespSystems.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult RespSysSave(int? id, GastroRespSystem model)
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
                _gmidb.GastroRespSystems.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("AbdExam");
            }
            return RedirectToAction("RespSys");
        }
        #endregion



        #region AbdExam
        public IActionResult AbdExam()
        {
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.GastroAbdExams.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.GastroAbdExams
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.GastroAbdExams.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AbdExamSave(int? id, GastroAbdExam model)
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
                _gmidb.GastroAbdExams.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("CVS");
            }
            return RedirectToAction("AbdExam");
        }
        #endregion



        #region CVS
        public IActionResult CVS()
        {
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;


                bool OpdExists = _gmidb.GastroCVSs.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.GastroCVSs
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.GastroCVSs.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CVS_Save(int? id, GastroCVS model)
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
                _gmidb.GastroCVSs.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Investigations");
            }
            return RedirectToAction("CVS");
        }
        #endregion



        #region Investigations
        public IActionResult Investigations()
        {
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.GastroInvestigations.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.GastroInvestigations
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.GastroInvestigations.Find(Id);
                    return View(data);
                }
                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult InvestigationSave(int? id, GastroInvestigation model)
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
                _gmidb.GastroInvestigations.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Other");
            }
            return RedirectToAction("Investigation");
        }
        #endregion



        #region Others
        public IActionResult Other()
        {
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.GastroOthers.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.GastroOthers
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.GastroOthers.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult OtherSave(int? id, GastroOther model)
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
                _gmidb.GastroOthers.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Report");
            }
            return RedirectToAction("Other");
        }
        #endregion



        #region Report
        public IActionResult Report()
        {
            string OPDNO = HttpContext.Session.GetString("Gastro_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                Gastro data = new Gastro
                {
                    UserData = _db.UserDatas.Where(c => c.OPDNo == OPDNO).FirstOrDefault(),
                    GastroClinicalSymptom = _gmidb.GastroClinicalSymptoms.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    GastroComorbidity = _gmidb.GastroComorbidities.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    GastroPersonalHabit = _gmidb.GastroPersonalHabits.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    GastroGeneralExamination = _gmidb.GastroGeneralExaminations.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    GastroCNS = _gmidb.GastroCNSs.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    GastroRespSystem = _gmidb.GastroRespSystems.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    GastroAbdExam = _gmidb.GastroAbdExams.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    GastroCVS = _gmidb.GastroCVSs.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    GastroInvestigation = _gmidb.GastroInvestigations.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    GastroOther = _gmidb.GastroOthers.Where(c => c.OPDNO == OPDNO).FirstOrDefault()
                };
                return View(data);
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }
        #endregion

        #region Json Call
        // [HttpGet]
        // public async Task<IActionResult> GenerateModel()
        // {
        //     var data = await _db.GastroClinics.Where(c => c.Heading == "COMORBITIES").ToListAsync();
        //     return View(data);
        // }

        #endregion

    }
}