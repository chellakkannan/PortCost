using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PortCostApp.Core;
using PortCostApp.Infrastructure;

namespace TESTWebApp.Controllers
{
    public class TestPortCostsController : Controller
    {
        private PortCostRepository db = new PortCostRepository();

        // GET: PortCosts
        public ActionResult Index()
        {
            return View(db.GetPortCost());
        }

        // GET: PortCosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PortCost portCost = db.FindById(Convert.ToInt32(id));
            if (portCost == null)
            {
                return HttpNotFound();
            }
            return View(portCost);
        }

        // GET: PortCosts/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: PortCosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,VesselCode,PortCode,PortCostCategory,PortCostSubCategory,Cost")] PortCost portCost)
        {
            if (ModelState.IsValid)
            {
                db.Add(portCost);
                return RedirectToAction("Index");
            }

            return View(portCost);
        }

        // GET: PortCosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PortCost portCost = db.FindById(Convert.ToInt32(id));
            if (portCost == null)
            {
                return HttpNotFound();
            }
            return View(portCost);
        }

        // POST: PortCosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,VesselCode,PortCode,PortCostCategory,PortCostSubCategory,Cost")] PortCost portCost)
        {
            if (ModelState.IsValid)
            {
                db.Edit(portCost);
                return RedirectToAction("Index");
            }
            return View(portCost);
        }

        // GET: PortCosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PortCost portCost = db.FindById(Convert.ToInt32(id));
            if (portCost == null)
            {
                return HttpNotFound();
            }
            return View(portCost);
        }

        // POST: PortCosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            db.Remove(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
