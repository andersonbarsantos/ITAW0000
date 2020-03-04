using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITAW000.Models;
using ITAW000.Repository;

namespace ITAW000.Controllers
{
    public class SistemaController : Controller
    {
        private readonly SistemaRepository respository = new SistemaRepository();

        // GET: Regra
        public ActionResult Index()
        {
            return View(respository.GetAll());
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
        public ActionResult Create(Sistema objModel)
        {
            try
            {
                respository.Add(objModel);
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
            var objModel = respository.GetById(id);
            return Json(objModel, JsonRequestBehavior.AllowGet);

        }

        // POST: Regra/Edit/5
        [HttpPost]
        public ActionResult Edit(Sistema objModel)
        {
            try
            {
                respository.Update(objModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Regra/Delete/5
        public ActionResult Delete(Sistema objModel)
        {
            respository.DeleteById(objModel.IdSistema);

            return RedirectToAction("Index");
        }

        // POST: Regra/Delete/5
        [HttpPost]
        public ActionResult DeleteRegra(int id, Tipo objModel)
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
    }
}
