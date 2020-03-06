using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITAW000.Models;
using ITAW000.Repository;

namespace ITAW000.Controllers
{
    public class HistoricoController : Controller
    {
        

        // GET: Regra
        public ActionResult Index()
        {
            return View();
        }

        // GET: Regra/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Regra/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Regra/Create
        [HttpPost]
        public ActionResult Create(object objModel)
        {
            try
            {
              
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Regra/Edit/5
        public JsonResult Edit(int id)
        {

            return null;

        }

        // POST: Regra/Edit/5
        [HttpPost]
        public ActionResult Edit(Tipo objModel)
        {
            try
            {
                

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Regra/Delete/5
        public ActionResult Delete(Tipo objModel)
        {
            

            return RedirectToAction("Index");
        }

        // POST: Regra/Delete/5
        [HttpPost]
        public ActionResult DeleteRegra(int id, Tipo objModel)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
