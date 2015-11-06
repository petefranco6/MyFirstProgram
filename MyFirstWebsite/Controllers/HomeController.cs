using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstWebsite.Models;

namespace MyFirstWebsite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sum(int a, int b, string name)
        {
            var result = a + b;
            
            NumberModel numberModel = new NumberModel();
            numberModel.MyNumber = result;
            numberModel.Name = name;

            return View(numberModel); 
        }

    }
}
