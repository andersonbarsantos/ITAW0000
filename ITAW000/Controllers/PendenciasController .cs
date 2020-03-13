using System;
using System.Web.Mvc;
using ITAW000.Models;
using ITAW000.Repository;

namespace ITAW000.Controllers
{
    public class PendenciasController : Controller
    {
        private RegraRepository regraRespository = new RegraRepository();
        private PendenciaRepository pendenciaRespository = new PendenciaRepository();
        // GET: Regra
        public ActionResult Index()
        {
            ViewBag.ListaRegras = regraRespository.GetAll();

            ViewBag.ListaAll = pendenciaRespository.GetAll();
            ViewBag.ListaNaoClassificados = pendenciaRespository.GetNaoClassificados();
            ViewBag.ListaClassificados = pendenciaRespository.GetClassificados();

            return View();
        }

        [HttpPost]
        public ActionResult IndexProduto(ItemView item)
        {
            int id = Convert.ToInt16( item.Name); 
            ViewBag.ListaNaoClassificadosProduto = pendenciaRespository.GetNaoClassificadosProduto(id);

            return View();
        }


        public ActionResult Lista()
        {
            ViewBag.ListaAll = pendenciaRespository.GetAll();
            ViewBag.ListaClassificados = pendenciaRespository.GetNaoClassificados();

            return View(pendenciaRespository.GetNaoClassificados());
        }

        // GET: Regra/Details/5
        public ActionResult Detail(int id) {

            Item431 item431 = pendenciaRespository.GetById(id);

            if (item431 == null)
                return View("NotFound");
            else
                return View("Detail", item431);

        }

        // GET: Regra/Details/5
        public ActionResult Classificar(string ids) {
             ViewBag.ListaRegras = regraRespository.GetAll();

            Regra regra = new Regra
                {
                    IDs = ids
                };

                return View("Classificar", regra); 
        }

       // POST: ItemView/Classificar
       [HttpPost]
        public ActionResult Classificar(Regra objModel)
        {
            try
            {
                pendenciaRespository.UpdateToRegra(objModel);                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }




    }
}
