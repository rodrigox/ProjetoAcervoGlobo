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
    public class DiretorsController : Controller
    {
        private AcervoGloboContext db = new AcervoGloboContext();

        // GET: Diretors
        public ActionResult Index()
        {
            return View(db.Diretors.ToList());
        }

        // GET: Diretors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diretor diretor = db.Diretors.Find(id);
            if (diretor == null)
            {
                return HttpNotFound();
            }
            return View(diretor);
        }

        // GET: Diretors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Diretors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,RegistroDirecao,Nome,Idade,Cpf")] Diretor diretor)
        {
            if (ModelState.IsValid)
            {
                db.Diretors.Add(diretor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(diretor);
        }

        // GET: Diretors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diretor diretor = db.Diretors.Find(id);
            if (diretor == null)
            {
                return HttpNotFound();
            }
            return View(diretor);
        }

        // POST: Diretors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RegistroDirecao,Nome,Idade,Cpf")] Diretor diretor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(diretor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(diretor);
        }

        // GET: Diretors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Diretor diretor = db.Diretors.Find(id);
            if (diretor == null)
            {
                return HttpNotFound();
            }
            return View(diretor);
        }

        // POST: Diretors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Diretor diretor = db.Diretors.Find(id);
            db.Diretors.Remove(diretor);
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
