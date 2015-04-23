using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clinicaExameMedicos.Controllers
{
    public class AtendimentoController : Controller
    {
        //
        // GET: /Atendimento/

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
            ViewBag.NomePaciente = form["NomePaciente"];
            ViewBag.TipoExame = form["TipoExame"];
            return View();
        }

        public ActionResult BuscarExaminadorSalaDataDisponivel()
        {
            return View();
        }
     
        public ActionResult Alterar()
        {
            return View();
        }

        public ActionResult Cancelar()
        {
            return View();
        }

        public ActionResult Localiza()
        {
            return View();
        }
        public ActionResult ImprimirAgendamento()
        {
            return View();
        }

    }
}
