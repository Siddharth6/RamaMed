using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RamaMed.Data;
using RamaMed.Models;
using RamaMed.Models.ViewModels;

namespace RamaMed.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        private readonly UserDbContext _ud;

        public HomeController(ILogger<HomeController> logger, UserDbContext ud)
        {
            _logger = logger;
            _ud = ud;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}


        public IActionResult Index()
        {
            //UserViewModel data = new UserViewModel
            //{
            //    RegistrationViewModel = new RegistrationViewModel { },
            //    IndexViewModel = new IndexViewModel { }
            //};
            return View();
        }
        
        [HttpPost]
        public async Task<ActionResult> Validate(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userDetail = await _ud.UserDetails.SingleOrDefaultAsync
                                        (m => m.UserId == model.LoginViewModel.UserId ||
                                        m.Email == model.LoginViewModel.UserId && 
                                        m.Password == model.LoginViewModel.Password);
                if (userDetail == null)
                {
                    TempData["validationmessage"] = "Password didn't matched";
                    return RedirectToAction("Index");
                }
                HttpContext.Session.SetInt32("Id", userDetail.Id);
                HttpContext.Session.SetString("UserId", userDetail.UserId);
                HttpContext.Session.SetString("Name", userDetail.Name);
                HttpContext.Session.SetString("Role", userDetail.Role);
                if (HttpContext.Session.GetString("Role") == "Gastro")
                {
                    return RedirectToAction("Index", "Gastro");
                }
                if (HttpContext.Session.GetString("Role") == "Cardiology")
                {
                    return RedirectToAction("Index", "Cardio");
                }
                if (HttpContext.Session.GetString("Role") == "Diabetes")
                {
                    return RedirectToAction("Index", "Diabetes");
                }
                if (HttpContext.Session.GetString("Role") == "Basic")
                {
                    return RedirectToAction("Index", "BasicGMI");
                }
                if (HttpContext.Session.GetString("Role") == "Endocrinology")
                {
                    return RedirectToAction("Index", "Endocrino");
                }
            }
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Register(UserViewModel model)
        {

            //var Name = model.Name;
            //var UserId = model.UserId;
            //var Email = model.Email;
            //var Mobile = model.Mobile;
            //var Password = model.Password;
            //var Role = model.Role;
            if (ModelState.IsValid)
            {
                UserDetail user = new UserDetail
                {
                    Name = model.RegistrationViewModel.Name,
                    UserId = model.RegistrationViewModel.UserId,
                    Email = model.RegistrationViewModel.Email,
                    Mobile = model.RegistrationViewModel.Mobile,
                    Password = model.RegistrationViewModel.Password,
                    Role = model.RegistrationViewModel.Role,
                    Status = true
                };
                bool MobileExists = _ud.UserDetails.Any(m => m.Mobile == user.Mobile);
                bool EmailExists = _ud.UserDetails.Any(m => m.Mobile == user.Email);
                bool UserIdExists = _ud.UserDetails.Any(m => m.UserId == user.UserId);

                if (MobileExists || EmailExists || UserIdExists)
                {
                    TempData["Name"] = user.Name;
                    TempData["UserId"] = user.UserId;
                    TempData["Email"] = user.Email;
                    TempData["Mobile"] = user.Mobile;
                    TempData["Role"] = user.Role;
                    //RegistrationViewModel data = new RegistrationViewModel
                    //{
                    //    Name = user.Name,
                    //    UserId = user.UserId,
                    //    Email = user.Email,
                    //    Mobile = user.Mobile,
                    //    Role = user.Role,
                    //};
                    //ViewBag.UserData = data;
                    if (MobileExists)
                    {
                        TempData["validationmessage"] = "Mobile Number Exists";
                    }
                    else if (EmailExists)
                    {
                        TempData["validationmessage"] = "Email Id Exists";
                    }
                    else if (UserIdExists)
                    {
                        TempData["validationmessage"] = "User Id Exists";
                    }
                }
                else
                {
                    _ud.UserDetails.Add(user);
                    _ud.SaveChanges();
                    TempData["successmessage"] = "Account Created Successfully";
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public  IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
