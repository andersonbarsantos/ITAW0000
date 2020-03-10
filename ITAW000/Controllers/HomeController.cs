﻿using ITAW000.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITAW000.Controllers
{
    public class HomeController : Controller
    {
        private PendenciaRepository pendenciaRespository = new PendenciaRepository();

        public ActionResult Index()
        {
            List<int> valor = pendenciaRespository.GetTotal();

            ViewBag.TotalRecebidos = valor[0];
            ViewBag.TotalClassificado = valor[1];
            ViewBag.TotalNaoClassificado = valor[2];

            ViewBag.AprovacaoAutomica = valor[3];
            ViewBag.AprovacaoManual = valor[4];

            
            ViewBag.ListaTempoPermanencia = pendenciaRespository.GetTempoPermanencia();
            ViewBag.ListaDescricaoGroupBy = pendenciaRespository.GetDescricaoGroupBy();

            ViewBag.ListaClassProdutoGroupBy = pendenciaRespository.GetClassProdutoGroupBy();
            ViewBag.ListaNoClassProdutoGroupBy = pendenciaRespository.GetNoClassProdutoGroupBy();
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}