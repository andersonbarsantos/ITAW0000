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
        private RegraRepository regraRespository = new RegraRepository();
        // GET: Regra
        public ActionResult Index()
        {
            return View(regraRespository.GetAll());
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
        public ActionResult Edit(RegraViewModel objModel)
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
