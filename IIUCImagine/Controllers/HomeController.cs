using IIUCImagine.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IIUCImagine.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult Success()
        {
            return View();
        }

        // GET: Membership/Create
        public ActionResult Index()
        {
            ViewBag.DepartmentID = new SelectList(db.Departments, "ID", "Tittle");
            ViewBag.DoYouKnowID = new SelectList(db.DoYouKnows, "ID", "Tittle");
            ViewBag.ParticipateID = new SelectList(db.Participates, "ID", "Tittle");
            return View();
        }

        // POST: Membership/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(Membership membership)
        {

            if (ModelState.IsValid)
            {
                membership.SubmitDate = DateTime.Today;
                //membership.SubmitDate = DateTime.Now.Date;
                db.Memberships.Add(membership);
                await db.SaveChangesAsync();
                return RedirectToAction("Success");
            }

            ViewBag.DepartmentID = new SelectList(db.Departments, "ID", "Tittle", membership.DepartmentID);
            ViewBag.DoYouKnowID = new SelectList(db.DoYouKnows, "ID", "Tittle", membership.DoYouKnowID);
            ViewBag.ParticipateID = new SelectList(db.Participates, "ID", "Tittle", membership.ParticipateID);
            return View(membership);
        }

        public ActionResult Support()
        {
            return View();
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
