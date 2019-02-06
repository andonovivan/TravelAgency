using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelAgency.Models;
using TravelAgency.Models.TravelAgency;

namespace TravelAgency.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private VacationDb db = new VacationDb();
        private ApplicationDbContext db1 = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(db.Vacations.ToList());
        }

        public ActionResult VacationSearch()
        {
            return View();
        }

        public ActionResult VacationSearchPartial(string search, int? page)
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

        public ActionResult WriteReviewPartial(Vacation vacation)
        {
            var currUser = db1.Users.Find(User.Identity.GetUserId());

            var model = new Review
            {
                VacationId = vacation.VacationId,
                ReviewerName = currUser.Name
            };
            return PartialView(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult WriteReviewPartial([Bind(Include = "ReviewId,Rating,Description,ReviewerName,VacationId")] Review review)
        {
            if (ModelState.IsValid)
            {
                review.Rating = Math.Round(review.Rating, 1);
                db.Reviews.Add(review);
                db.SaveChanges();
            }
            var model = db.Vacations.Find(review.VacationId);
            return View("VacationDetails", model);
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