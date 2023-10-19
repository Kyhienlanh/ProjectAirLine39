using ProjectAirLine39.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectAirLine39.Controllers
{
    public class HomePageController : Controller
    {
        private Airline1Entities db=new Airline1Entities();
        // GET: HomePage
        public ActionResult Index()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult FindFlights()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult FindFlights(String fromAirport, String toAirport, DateTime Tungay, DateTime Denngay)
        {

            return RedirectToAction("SearchResult", new { fromAirport, toAirport, Tungay , Denngay });
        }
        public ActionResult SearchResult(String fromAirport, String toAirport, DateTime Tungay, DateTime Denngay)
        {
            var data = from s in db.Flights
                       where s.fromAirport.Equals(fromAirport) && s.toAirport.Equals(toAirport) && (s.FlightDate >= Tungay && s.FlightDate <= Denngay)
                       select s;
            return View(data);
        }



    }
}