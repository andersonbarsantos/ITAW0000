using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITAW000.Models;
using ITAW000.Repository;

namespace ITAW000.Controllers
{
    public class TipoController : Controller
    {
        private readonly TipoRepository respository = new TipoRepository();

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
        public ActionResult Create(Tipo objModel)
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
        public ActionResult Edit(Tipo objModel)
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
        public ActionResult Delete(Tipo objModel)
        {
            respository.DeleteById(objModel.IdTipo);

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
