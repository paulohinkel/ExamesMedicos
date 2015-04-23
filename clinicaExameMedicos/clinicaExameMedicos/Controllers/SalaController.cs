using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clinicaExameMedicos.Controllers
{
    public class SalaController : Controller
    {
        //
        // GET: /Sala/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AgendarBloqueio()
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
            ViewBag.NrSala = form["NrSala"];
            ViewBag.Descricao = form["Descricao"];
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

    }
}
