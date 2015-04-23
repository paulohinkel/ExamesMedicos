using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clinicaExameMedicos.Controllers
{
    public class ExaminadorController : Controller
    {
        //
        // GET: /Examinador/

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
            ViewBag.Nome = form["Nome"];
            ViewBag.Email = form["Email"];
            ViewBag.Cremers = form["Cremers"];
            ViewBag.Especialidade = form["Especialidade"];
            ViewBag.Telefone = form["Telefone"];
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
