using Business.Repository;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentUI.Controllers
{
    public class HomeController : Controller
    {

        UnitOfWork unitOfWork;
        public HomeController()
        {
            unitOfWork = new UnitOfWork(new ContextStudent());
        }
        public ActionResult Index()
        {

            var result = unitOfWork.LessonRepositories.GetAll();
            return View(result);
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