using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public ActionResult VacationSearch()
        {
            return View();
        }

        public ActionResult VacationSearchPartial(string search)
        {
            return PartialView(db.Vacations.Where(x => (x.City + ", " + x.Country).Contains(search) || search == null).ToList());
        }

        public ActionResult VacationDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vacation vacation = db.Vacations.Find(id);
            if (vacation == null)
            {
                return HttpNotFound();
            }
            return View(vacation);
        }

    }
}