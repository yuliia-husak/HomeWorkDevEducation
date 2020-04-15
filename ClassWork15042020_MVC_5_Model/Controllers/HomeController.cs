using ClassWork15042020_MVC_5_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassWork15042020_MVC_5_Model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Prod prod = new Prod
        {
            ProdId = 1,
            Name = "DDDD",
            Category = "game",
            Price = 100M
        };
        public ActionResult Index()
        {
            return View(prod);
        }

        public ActionResult NameAndPrice()
        {
            return View(prod);
        }

        public ActionResult DemoExpression()
        {
            ViewBag.ProdCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(prod);
        }

        public ActionResult DemoArray()
        {
            Prod[] array =
            {
                new Prod {Name="PPPPP",Price=275m },
                new Prod {Name="ZZZZZ",Price=48.95m },
                new Prod {Name="IIIII",Price=19.50m },
                new Prod {Name="EEEEE",Price=34.95m },

            };
            return View(array);
        }
    }
}