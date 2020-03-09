using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITAW000.Models;
using ITAW000.Repository;

namespace ITAW000.Controllers
{
    public class RegraController : Controller
    {
        private RegraRepository regraRespository = new RegraRepository();
        private RetornoRepository retornoRespository = new RetornoRepository();
        private ResponsavelRepository responsavelRespository = new ResponsavelRepository();
        private TipoRepository tipoRespository = new TipoRepository();
        private SituacaoRepository situacaoRepository = new SituacaoRepository();
        private SistemaRepository sistemaRepository = new SistemaRepository();
               
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
            CarregaDropDrow();
            return View();
        }


        public void CarregaDropDrow()
        {
            List<SelectListItem> ListSistema = new List<SelectListItem>
            {
                new SelectListItem() { Value = "-1", Text = "" }
            };

            ListSistema.AddRange(sistemaRepository.GetAll().Select(x =>
                                 new SelectListItem()
                                 {
                                     Value = x.IdSistema.ToString(),
                                     Text = x.NomeSistema
                                 }).ToList());

            ViewBag.ListSistema = ListSistema;


            List<SelectListItem> ListRetorno = new List<SelectListItem>
            {
                new SelectListItem() { Value = "-1", Text = "" }
            };

            ListRetorno.AddRange(retornoRespository.GetAll().Select(x =>
                                 new SelectListItem()
                                 {
                                     Value = x.IdRetorno.ToString(),
                                     Text = x.NomeRetorno
                                 }).ToList());

            ViewBag.ListRetorno = ListRetorno;

            List<SelectListItem> ListResponsavel = new List<SelectListItem>
            {
                new SelectListItem() { Value = "-1", Text = "" }
            };

            ListResponsavel.AddRange(responsavelRespository.GetAll().Select(x =>
                                 new SelectListItem()
                                 {
                                     Value = x.IdResponsavel.ToString(),
                                     Text = x.NomeResponsavel
                                 }).ToList());

            ViewBag.ListResponsavel = ListResponsavel;


            List<SelectListItem> ListTipo = new List<SelectListItem>
            {
                new SelectListItem() { Value = "-1", Text = "" }
            };

            ListTipo.AddRange(tipoRespository.GetAll().Select(x =>
                                 new SelectListItem()
                                 {
                                     Value = x.IdTipo.ToString(),
                                     Text = x.NomeTipo
                                 }).ToList());

            ViewBag.ListTipo = ListTipo;

            List<SelectListItem> ListSituacao = new List<SelectListItem>
            {
                new SelectListItem() { Value = "-1", Text = "" }
            };

            ListSituacao.AddRange(situacaoRepository.GetAll().Select(x =>
                                 new SelectListItem()
                                 {
                                     Value = x.IdSituacao.ToString(),
                                     Text = x.NomeSituacao
                                 }).ToList());

            ViewBag.ListSituacao = ListSituacao;
        }

        // POST: Regra/Create
        [HttpPost]
        public ActionResult Create(Regra objModel)
        {
            try
            {
                regraRespository.Add(objModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Regra/Edit/5
        public ActionResult Edit(int id)
        {
            CarregaDropDrow();

            var objModel = regraRespository.GetById(id);
         //    return Json(objModel, JsonRequestBehavior.AllowGet);

            return View(objModel);
        }

        // POST: Regra/Edit/5
        [HttpPost]
        public ActionResult Edit(Regra objModel)
        {
            try
            {
                regraRespository.Update(objModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Regra/Delete/5
        public ActionResult DeleteRegra(int id)
        {
            regraRespository.DeleteById(id);

            return RedirectToAction("Index");
        }

        // POST: Regra/Delete/5
        [HttpPost]
        public ActionResult DeleteRegra(int id, FormCollection collection)
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