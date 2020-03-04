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

            RegraViewModel view = new RegraViewModel();
            view.ListRetorno = retornoRespository.GetAll();
            view.ListResponsavel = responsavelRespository.GetAll();
            view.ListTipo = tipoRespository.GetAll();
            view.ListSituacao = situacaoRepository.GetAll();
            view.ListSistema = sistemaRepository.GetAll();
            return View(view);
        }

        // POST: Regra/Create
        [HttpPost]
        public ActionResult Create(RegraViewModel objModel)
        {
            try
            {

                Regra regra = new Regra();

                regra.Descricao = objModel.Descricao;
                regra.IdTipo = Convert.ToInt32( objModel.SelectedTipo);
                regra.IdRetorno = Convert.ToInt32(objModel.SelectedRetorno);
                regra.IdResponsavel = Convert.ToInt32(objModel.SelectedResponsavel);
                regra.IdSistema = Convert.ToInt32(objModel.SelectedSistema);
                regra.IdSituacao = Convert.ToInt32(objModel.SelectedSituacao);

                // TODO: Add insert logic here
                regraRespository.Add(regra);
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
            return View();
        }

        // POST: Regra/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        private void SetViewBagRetornoType(Retorno itemSelected)
        {

            IEnumerable<Retorno> values =

                              Enum.GetValues(typeof(Retorno))

                              .Cast<Retorno>();

            IEnumerable<SelectListItem> items =

                from value in values

                select new SelectListItem
                {
                    Text = value.ToString(),
                    Value = value.ToString(),
                    Selected = value == itemSelected,
                };

            ViewBag.MovieType = items;

        }

        public ActionResult SelectRetornoEnum()
        {

            SetViewBagRetornoType(new Retorno());

            return View("SelectCategory");

        }


    }
}
