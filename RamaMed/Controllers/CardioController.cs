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
    public class CardioController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly GMIAllDbContext _gmidb;

        //[BindProperty]
        //public CardioClinic GastroClinic { get; set; }

        public CardioController(ApplicationDbContext db, GMIAllDbContext gmidb)
        {
            _db = db;
            _gmidb = gmidb;
        }


        //public async Task<IActionResult> Index()
        //{
        //    //var data = await _db.GastroClinics.ToListAsync();
        //    var data = await _db.CardioClinics.Where( c => c.Heading == "COMORBITIES").ToListAsync();
        //    return View(data);
        ////}

        #region index page

        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("Cardio_OPDNO") != null)
            {
                HttpContext.Session.SetString("Cardio_OPDNO", "");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(string SearchString)
        {
            if (SearchString != null)
            {
                var count = _db.UserDatas.Where(c => c.Dept == "GMI" && c.Clinic == "Cardiology").Count(c => c.OPDNo == SearchString);

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
                    HttpContext.Session.SetString("Cardio_OPDNO", SearchString);
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
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
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
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.CardioClinicalSymptoms.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.CardioClinicalSymptoms
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    //var data = _gmidb.CardioClinicalSymptoms.Where(c => c.OPDNO == OPDNO).FirstOrDefault();
                    var data = _gmidb.CardioClinicalSymptoms.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "Please Enter OPDNO first" });
        }



        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult ClinicalSave(int? id, CardioClinicalSymptom model)
        {
            //var opd = model.OPDNO;
            //bool OpdExists = _gmidb.CardioClinicalSymptoms.Any(m => m.OPDNO == opd);
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
                _gmidb.CardioClinicalSymptoms.Add(model);
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
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.CardioComorbidities.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.CardioComorbidities
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    //var data = _gmidb.GastroClinicalSymptoms.Where(c => c.OPDNO == OPDNO).FirstOrDefault();
                    var data = _gmidb.CardioComorbidities.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult ComorbiditySave(int? id, CardioComorbidity model)
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
                _gmidb.CardioComorbidities.Add(model);
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
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.CardioPersonals.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.CardioPersonals
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.CardioPersonals.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult PersonalSave(int? id, CardioPersonal model)
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
                _gmidb.CardioPersonals.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("GeneralExam");
            }
            return RedirectToAction("Personal");
        }


        #endregion


        #region General Examinations
        public IActionResult GeneralExam()
        {
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                //string OPDNO = TempData["OPDNO"] as string;
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.CardioGeneralExaminations.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.CardioGeneralExaminations
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.CardioGeneralExaminations.Find(Id);
                    return View(data);
                }


                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult GeneralExamSave(int? id, CardioGeneralExamination model)
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
                _gmidb.CardioGeneralExaminations.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("CNS");
            }
            return RedirectToAction("GeneralExam");
        }

        #endregion


        #region CNS
        public IActionResult CNS()
        {
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;


                bool OpdExists = _gmidb.CardioCNSs.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.CardioCNSs
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.CardioCNSs.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CNS_Save(int? id, CardioCNS model)
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
                _gmidb.CardioCNSs.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("GeneralExam");
            }
            return RedirectToAction("CNS");
        }
        #endregion


        #region RespSys
        public IActionResult RespSys()
        {
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.CardioRespSystems.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.CardioRespSystems
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.CardioRespSystems.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult RespSysSave(int? id, CardioRespSystem model)
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
                _gmidb.CardioRespSystems.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("AbdExam");
            }
            return RedirectToAction("RespSys");
        }
        #endregion


        #region AbdExam
        public IActionResult AbdExam()
        {
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.CardioAbdExams.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.CardioAbdExams
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.CardioAbdExams.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult AbdExamSave(int? id, CardioAbdExam model)
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
                _gmidb.CardioAbdExams.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("CVS");
            }
            return RedirectToAction("AbdExam");
        }
        #endregion


        #region CVS
        public IActionResult CVS()
        {
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;


                bool OpdExists = _gmidb.CardioCVSs.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.CardioCVSs
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.CardioCVSs.Find(Id);
                    return View(data);
                }

                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CVS_Save(int? id, CardioCVS model)
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
                _gmidb.CardioCVSs.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Investigations");
            }
            return RedirectToAction("CVS");
        }
        #endregion


        #region Investigations
        public IActionResult Investigations()
        {
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                UserData userdata = _db.UserDatas
                               .Where(c => c.OPDNo == OPDNO)
                               .FirstOrDefault();
                ViewBag.userData = userdata;

                bool OpdExists = _gmidb.CardioInvestigations.Any(m => m.OPDNO == OPDNO);
                if (OpdExists)
                {
                    int Id = (from s in _gmidb.CardioInvestigations
                              where s.OPDNO == OPDNO
                              select s.ID).First();
                    var data = _gmidb.CardioInvestigations.Find(Id);
                    return View(data);
                }
                return View();
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult InvestigationSave(int? id, CardioInvestigation model)
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
                _gmidb.CardioInvestigations.Add(model);
                _gmidb.SaveChanges();
                return RedirectToAction("Other");
            }
            return RedirectToAction("Investigation");
        }
        #endregion


        #region Others
        public IActionResult Other()
        {
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
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


        #region report
        public IActionResult Report()
        {
            string OPDNO = HttpContext.Session.GetString("Cardio_OPDNO");
            if (OPDNO != null && OPDNO != String.Empty)
            {
                Cardio data = new Cardio
                {
                    UserData = _db.UserDatas.Where(c => c.OPDNo == OPDNO).FirstOrDefault(),
                    CardioClinicalSymptom = _gmidb.CardioClinicalSymptoms.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    CardioComorbidity = _gmidb.CardioComorbidities.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    CardioPersonal = _gmidb.CardioPersonals.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    CardioGeneralExamination = _gmidb.CardioGeneralExaminations.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    CardioCNS = _gmidb.CardioCNSs.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    CardioRespSystem = _gmidb.CardioRespSystems.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    CardioAbdExam = _gmidb.CardioAbdExams.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    CardioCVS = _gmidb.CardioCVSs.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    CardioInvestigation = _gmidb.CardioInvestigations.Where(c => c.OPDNO == OPDNO).FirstOrDefault(),
                    CardioOther = _gmidb.CardioOthers.Where(c => c.OPDNO == OPDNO).FirstOrDefault()
                };
                return View(data);
            }
            return RedirectToAction("Index", new { res = "First enter OPDNO" });
        }
        #endregion
    }
}