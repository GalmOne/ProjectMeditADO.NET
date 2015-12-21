using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectBDAdvance.Models;

namespace ProjectBDAdvance.Controllers
{
    public class ExamenPratiquesController : Controller
    {
        private VisiteMedacleEntities db = new VisiteMedacleEntities();

        // GET: ExamenPratiques
        public ActionResult Index()
        {
            var examenPratiques = db.ExamenPratiques.Include(e => e.Examan).Include(e => e.VisiteMedicale);
            return View(examenPratiques.ToList());
        }

        // GET: ExamenPratiques/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExamenPratique examenPratique = db.ExamenPratiques.Find(id);
            if (examenPratique == null)
            {
                return HttpNotFound();
            }
            return View(examenPratique);
        }

        // GET: ExamenPratiques/Create
        public ActionResult Create()
        {
            ViewBag.codeExamen = new SelectList(db.Examen, "codeExamen", "description");
            ViewBag.idVisite = new SelectList(db.VisiteMedicales, "idVisite", "idVisite");
            return View();
        }

        // POST: ExamenPratiques/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idExaPrat,idVisite,codeExamen,duree,resultat,prixTotal")] ExamenPratique examenPratique)
        {
            if (ModelState.IsValid)
            {
                db.ExamenPratiques.Add(examenPratique);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.codeExamen = new SelectList(db.Examen, "codeExamen", "description", examenPratique.codeExamen);
            ViewBag.idVisite = new SelectList(db.VisiteMedicales, "idVisite", "idVisite", examenPratique.idVisite);
            return View(examenPratique);
        }

        // GET: ExamenPratiques/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExamenPratique examenPratique = db.ExamenPratiques.Find(id);
            if (examenPratique == null)
            {
                return HttpNotFound();
            }
            ViewBag.codeExamen = new SelectList(db.Examen, "codeExamen", "description", examenPratique.codeExamen);
            ViewBag.idVisite = new SelectList(db.VisiteMedicales, "idVisite", "idVisite", examenPratique.idVisite);
            return View(examenPratique);
        }

        // POST: ExamenPratiques/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idExaPrat,idVisite,codeExamen,duree,resultat,prixTotal")] ExamenPratique examenPratique)
        {
            if (ModelState.IsValid)
            {
                db.Entry(examenPratique).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.codeExamen = new SelectList(db.Examen, "codeExamen", "description", examenPratique.codeExamen);
            ViewBag.idVisite = new SelectList(db.VisiteMedicales, "idVisite", "idVisite", examenPratique.idVisite);
            return View(examenPratique);
        }

        // GET: ExamenPratiques/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExamenPratique examenPratique = db.ExamenPratiques.Find(id);
            if (examenPratique == null)
            {
                return HttpNotFound();
            }
            return View(examenPratique);
        }

        // POST: ExamenPratiques/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            ExamenPratique examenPratique = db.ExamenPratiques.Find(id);
            db.ExamenPratiques.Remove(examenPratique);
            db.SaveChanges();
            return RedirectToAction("Index");
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
