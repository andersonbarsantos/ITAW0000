using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITAW000.Models;
using ITAW000.Repository;

namespace ITAW000.Controllers
{
    public class PendenciasController : Controller
    {
        private PendenciaRepository pendenciaRespository = new PendenciaRepository();
        // GET: Regra
        public ActionResult Index()
        {
            ViewBag.ListaAll = pendenciaRespository.GetAll();
            ViewBag.ListaClassificados = pendenciaRespository.GetNaoClassificados();
            
            return View();
        }

        public ActionResult Lista()
        {
            ViewBag.ListaAll = pendenciaRespository.GetAll();
            ViewBag.ListaClassificados = pendenciaRespository.GetNaoClassificados();

            return View(pendenciaRespository.GetNaoClassificados());
        }



        // GET: Regra/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        // POST: Regra/Create
        [HttpPost]
        public ActionResult Edit(Item431 objModel)
        {
            try
            {
                pendenciaRespository.Update(objModel); 

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }




    }
}
