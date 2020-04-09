using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RamaMed.Models;

namespace RamaMed.Controllers
{

    public class OpdController : Controller
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public UserData UserData { get; set; }

        public OpdController(ApplicationDbContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            return View();
        }
        
        
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult SubmitForm(UserData user)
        {
            if (ModelState.IsValid)
            {
                _db.UserDatas.Add(user);
                _db.SaveChanges();
                return RedirectToAction("Index", new { res = "success" });
            }
            return RedirectToAction("Index");
        }
    }
}