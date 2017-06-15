using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrsSolution.DAL;
using PrsSolution.Models;

namespace PrsSolution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var ctx = new TestDbContext())
            {
                var test = new Test()
                {

                    UserName = "username",
                    Email = "testemail@gmail.com"
                };

                ctx.Test.Add(test);
                ctx.SaveChanges();


            }
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login page.";

            return View();
        }

        public ActionResult HospitalMain()
        {
            ViewBag.Message = "Hospital Main Page";

            return View();
        }

        public ActionResult Patients()
        {
            ViewBag.Message = "Known Patients Page";

            return View();
        }

        public ActionResult InpatientMain()
        {
            ViewBag.Message = "Inpatients Page";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}