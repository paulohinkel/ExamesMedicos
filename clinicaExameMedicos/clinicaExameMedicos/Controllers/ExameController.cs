using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clinicaExameMedicos.Controllers
{
    public class ExameController : Controller
    {
        //
        // GET: /Exame/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastrar()
        {
            return View();
        }

         
        [HttpPost]
        public ActionResult Cadastrar(FormCollection form)
        {
            ViewBag.Tipo = form["tipo"];
            ViewBag.Examinador = form["examinador"];
            return View();
        }



        public ActionResult Alterar()
        {
            return View();
        }
        public ActionResult Inativar()
        {
            return View();
        }
        public ActionResult Localizar()
        {
            return View();
        }
        public ActionResult LocalizarSala()
        {
            return View();
        }
        public ActionResult LocalizarMedico()
        {
            return View();
        }


    }
}
