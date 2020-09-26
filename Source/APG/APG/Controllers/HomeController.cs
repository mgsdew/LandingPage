using APG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APG.Controllers
{
    public class HomeController : Controller
    {
        private APGDBEntities _entities = new APGDBEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LandingPage1()
        {
            return View();
        }

        public ActionResult LandingPage2()
        {
            return View();
        }


        [HttpPost]
        public ActionResult LandingPage1(UserDetailsViewModel details)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UserDetails_1 model = new UserDetails_1();
                    model.Id = details.Id;
                    model.FirstName = details.FirstName;
                    model.Address = details.Address;
                    model.HavePrescriptions = details.HavePrescriptions;
                    model.HaveAlliance = details.HaveAlliance;
                    if (details.Id == 0)
                    {
                        _entities.UserDetails_1.Add(model);
                    }
                    else
                    {
                        _entities.Entry(model).State = EntityState.Modified;
                    }
                    _entities.SaveChanges();
                }

                return Json(new { success = true, val = "Data Submitted. Thank you!! " }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult LandingPage2(UserDetailsViewModel details)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UserDetails_2 model = new UserDetails_2();
                    model.Id = details.Id;
                    model.FirstName = details.FirstName;
                    model.Address = details.Address;
                    model.TakingMedications = details.TakingMedications;
                    model.HaveAlliance = details.HaveAlliance;
                    if (details.Id == 0)
                    {
                        _entities.UserDetails_2.Add(model);
                    }
                    else
                    {
                        _entities.Entry(model).State = EntityState.Modified;
                    }
                    _entities.SaveChanges();
                }

                return Json(new { success = true, val = "Data Submitted. Thank you!! " }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}