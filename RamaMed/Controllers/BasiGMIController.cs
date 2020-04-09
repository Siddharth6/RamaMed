using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RamaMed.Models;

namespace RamaMed.Controllers
{
    public class BasiGMIController : Controller
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public BasicClinic BasicClinic { get; set; }

        public BasiGMIController(ApplicationDbContext db)
        {
            _db = db;
        }


        public async Task<IActionResult> Index()
        {
            //var data = await _db.GastroClinics.ToListAsync();
            var data = await _db.BasicClinics.Where(c => c.Heading == "Comorbities").ToListAsync();
            return View(data);
        }
    }
}
