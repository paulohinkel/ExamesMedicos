using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clinicaExameMedicos.Controllers
{
    public class AgendaExaminadorController : Controller
    {
        //
        // GET: /AgendaExaminador/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CadastrarGradeHorarios()
        {
            return View();
        }

        public ActionResult AlterarGradeHorarios()
        {
            return View();
        }

    }
}
