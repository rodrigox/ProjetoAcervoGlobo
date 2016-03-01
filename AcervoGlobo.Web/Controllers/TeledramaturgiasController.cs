using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AcervoGlobo.Dominio;
using AcervoGlobo.Web.Models;

namespace AcervoGlobo.Web.Controllers
{
    public class TeledramaturgiasController : Controller
    {
        private AcervoGloboContext db = new AcervoGloboContext();

        // GET: Teledramaturgias
        public ActionResult Index()
        {
            return View(db.Teledramaturgias.ToList());
        }

        // GET: Teledramaturgias/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teledramaturgia teledramaturgia = db.Teledramaturgias.Find(id);
            if (teledramaturgia == null)
            {
                return HttpNotFound();
            }
            return View(teledramaturgia);
        }

        // GET: Teledramaturgias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teledramaturgias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Titulo,eGenero,AnoLancamento")] Teledramaturgia teledramaturgia)
        {
            if (ModelState.IsValid)
            {
                db.Teledramaturgias.Add(teledramaturgia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(teledramaturgia);
        }

        // GET: Teledramaturgias/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teledramaturgia teledramaturgia = db.Teledramaturgias.Find(id);
            if (teledramaturgia == null)
            {
                return HttpNotFound();
            }
            return View(teledramaturgia);
        }

        // POST: Teledramaturgias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Titulo,eGenero,AnoLancamento")] Teledramaturgia teledramaturgia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(teledramaturgia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(teledramaturgia);
        }

        // GET: Teledramaturgias/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Teledramaturgia teledramaturgia = db.Teledramaturgias.Find(id);
            if (teledramaturgia == null)
            {
                return HttpNotFound();
            }
            return View(teledramaturgia);
        }

        // POST: Teledramaturgias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Teledramaturgia teledramaturgia = db.Teledramaturgias.Find(id);
            db.Teledramaturgias.Remove(teledramaturgia);
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
