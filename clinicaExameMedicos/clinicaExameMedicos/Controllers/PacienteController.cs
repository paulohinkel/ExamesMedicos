using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;

namespace clinicaExameMedicos.Controllers
{
    public class PacienteController : Controller
    {
        //
        // GET: /Paciente/

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
            try {

                string conn = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                SqlConnection conectar = new SqlConnection(conn);

                conectar.Open();

                StringBuilder query = new StringBuilder();

                query.Append(" INSERT INTO Paciente1 (Nome, Email, Telefone) VALUES ('" + form["Nome"] + "', '" + form["Email"] + "', '" + form["Telefone"] + "' ) ");
                
                SqlCommand comando = new SqlCommand(query.ToString() , conectar);
                                
                comando.ExecuteNonQuery();

                ViewBag.MensagemSucesso = "Cadastro efetuado com sucesso!!";
            }
            catch (Exception ex){
                ViewBag.Mensagem = ex.Message;
            }
           

            ViewBag.Nome = form["Nome"];
            ViewBag.Email = form["Email"];
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
