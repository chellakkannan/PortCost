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
using PortCostApp.Web.Models;

namespace PortCostApp.Web.Controllers
{
    public class PortCostsController : Controller
    {
        private PortCostRepository db = new PortCostRepository();
        private VesselRepository dbVessel = new VesselRepository();
        
        private Vessels vesselModel = new Vessels();

        // GET: PortCosts
        public ActionResult Index()
        {
            



            return View(db.GetPortCost());
        }

        //public ActionResult DatabaseFill()
        //{
            
        //    DigitalDocEntities entity = new DigitalDocEntities();
        //    var portCostCategoryList = entity.PortCostCategories.ToList();
        //    SelectList list = new SelectList(portCostCategoryList, "PortCostCategoryID", "PortCostCategoryName");
        //    ViewBag.portCostCategoryName = list;

        //    return View();
        //}


        public ActionResult VesselList()
        {
            PortCost pcEntity = new PortCost();
            var vesselList = pcEntity.VesselCode.ToList();
            SelectList list = new SelectList(vesselList, "Id", "Name");
            
            return View();
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
            MasterData();
            return View();
        }

        // POST: PortCosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,VesselCode,PortCode,PortCostCategory,PortCostSubCategory,Cost,ContractID,ContractFilePath,CurrencyCode")] PortCost portCost)
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
            MasterData();
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
        public ActionResult Edit([Bind(Include = "ID,VesselCode,PortCode,PortCostCategory,PortCostSubCategory,Cost,ContractID,ContractFilePath,CurrencyCode")] PortCost portCost)
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


        private void MasterData()
        {
            //Entities entity = new Entities();

            DigitalDocEntitiesMasterData entity = new DigitalDocEntitiesMasterData();

            var portCostCategoryList = entity.PortCostCategories.ToList();
            SelectList categorylist = new SelectList(portCostCategoryList, "PortCostCategoryName", "PortCostCategoryName");
            ViewBag.portCostCategoryName = categorylist;

            var portCostSubCategoryList = entity.PortCostSubCategories.ToList();
            SelectList subCategorylist = new SelectList(portCostSubCategoryList, "PortCostSubCategoryName", "PortCostSubCategoryName");
            ViewBag.portCostSubCategoryName = subCategorylist;
            
            var currenciesList = entity.Currencies.ToList();
            SelectList currencyList = new SelectList(currenciesList, "CurrencyCode", "CurrencyCode");
            ViewBag.CurrencyCode = currencyList;
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
