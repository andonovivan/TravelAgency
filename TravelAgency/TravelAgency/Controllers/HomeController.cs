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
            return View(db.Vacations.ToList());
        }

        public ActionResult VacationSearch()
        {
            return View();
        }

        public ActionResult VacationSearchPartial(string search)
        {
            var model =
                from v in db.Vacations
                orderby v.Reviews.Average(review => review.Rating) descending
                select v;
            return PartialView(model.Where(x => (x.City + ", " + x.Country).Contains(search) || search == null).ToList());
        }

        public ActionResult VacationDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var vacation = db.Vacations.Find(id);
            if (vacation == null)
            {
                return HttpNotFound();
            }
            return View(vacation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}