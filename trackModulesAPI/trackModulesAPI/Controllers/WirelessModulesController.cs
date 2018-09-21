using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using trackModulesAPI.Models;

namespace trackModulesAPI.Controllers
{
    public class WirelessModulesController : Controller
    {
        private DatabaseSSLEntities db = new DatabaseSSLEntities();

        // GET: WirelessModules
        public ActionResult Index()
        {
            return View(db.WirelessModules.ToList());
        }

        // GET: WirelessModules/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WirelessModule wirelessModule = db.WirelessModules.Find(id);
            if (wirelessModule == null)
            {
                return HttpNotFound();
            }
            return View(wirelessModule);
        }

        // GET: WirelessModules/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WirelessModules/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MacAddress,IssueDate")] WirelessModule wirelessModule)
        {
            if (ModelState.IsValid)
            {
                db.WirelessModules.Add(wirelessModule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wirelessModule);
        }

        // GET: WirelessModules/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WirelessModule wirelessModule = db.WirelessModules.Find(id);
            if (wirelessModule == null)
            {
                return HttpNotFound();
            }
            return View(wirelessModule);
        }

        // POST: WirelessModules/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MacAddress,IssueDate")] WirelessModule wirelessModule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wirelessModule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wirelessModule);
        }

        // GET: WirelessModules/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WirelessModule wirelessModule = db.WirelessModules.Find(id);
            if (wirelessModule == null)
            {
                return HttpNotFound();
            }
            return View(wirelessModule);
        }

        // POST: WirelessModules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            WirelessModule wirelessModule = db.WirelessModules.Find(id);
            db.WirelessModules.Remove(wirelessModule);
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
