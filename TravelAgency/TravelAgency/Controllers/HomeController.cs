using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAgency.Models.TravelAgency;

namespace TravelAgency.Controllers
{
    public class HomeController : Controller
    {
        private VacationDb db = new VacationDb();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VacationSearch(string search)
        {
            return View(db.Vacations.Where(x => (x.City + ", " + x.Country).Contains(search) || search == null));
        }

    }
}