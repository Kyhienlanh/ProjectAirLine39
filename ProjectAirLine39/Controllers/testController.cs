using ProjectAirLine39.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectAirLine39.Controllers
{
    public class testController : Controller
    {
        // GET: test
        private Airline1Entities db=new Airline1Entities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string fromAirport)
        {
            return RedirectToAction("SearchResult", new { fromAirport });
        }

        public ActionResult SearchResult(string fromAirport)
        {
            var data = from s in db.Flights where s.fromAirport.Equals(fromAirport) select s.NameFlight;
            return View(data);
        }


    }
}