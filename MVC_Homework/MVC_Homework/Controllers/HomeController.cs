using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Homework.Models;

namespace MVC_Homework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Class1> ViewModl = new List<Class1>();
            Random rMoney = new Random() ;
            for(int i = 1; i <= 100; i++)
            {
                ViewModl.Add(new Class1 { Id = i, Type = "支出", Date = DateTime.Now.ToString("yyyy-MM-dd"), Money = rMoney.Next(1,2000) });
            }

            //var result = new Class1
            //{
            //    Id = 1,
            //    Type = "支出",
            //    Date = string.Format("{0:yyyy-MM-dd}",DateTime.Now),
            //    Money = 1600
            //};
            return View(ViewModl);
        }

        //public ActionResult Index()
        //{
        //    return View();
        //}

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