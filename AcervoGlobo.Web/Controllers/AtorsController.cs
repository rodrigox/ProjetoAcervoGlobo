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
    public class AtorsController : Controller
    {
        private AcervoGloboContext db = new AcervoGloboContext();

        // GET: Ators
        public ActionResult Index()
        {
            return View(db.Ators.ToList());
        }

        public class AutoComp
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
        public ActionResult Autocomplete(string term)
        {
            var filteredItems = db.Ators.ToList().Where(a => a.Nome.Contains(term));
            List<AutoComp> ators = new List<AutoComp>();
            foreach (var item in filteredItems)
            {
                ators.Add(new AutoComp
                {
                    Id = item.Id,
                    Nome = item.Nome
                });
            }
            return Json(ators, JsonRequestBehavior.AllowGet);
        }

        // GET: Ators/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ator ator = db.Ators.Find(id);
            if (ator == null)
            {
                return HttpNotFound();
            }
            return View(ator);
        }

        // GET: Ators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Papel,Nome,Idade,Cpf")] Ator ator)
        {
            if (ModelState.IsValid)
            {
                db.Ators.Add(ator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ator);
        }

        // GET: Ators/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ator ator = db.Ators.Find(id);
            if (ator == null)
            {
                return HttpNotFound();
            }
            return View(ator);
        }

        // POST: Ators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Papel,Nome,Idade,Cpf")] Ator ator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ator);
        }

        // GET: Ators/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ator ator = db.Ators.Find(id);
            if (ator == null)
            {
                return HttpNotFound();
            }
            return View(ator);
        }

        // POST: Ators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ator ator = db.Ators.Find(id);
            db.Ators.Remove(ator);
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
