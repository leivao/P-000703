using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace P_000703.Web.Controllers
{
    
    public class HomeController : Controller
    {
        [Authorize(Roles = "Administrador,Configurador")]
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult PolizaCliente()
        {
            ViewBag.Message = "Seguros P-000703";

            return View("_PolizaCliente");
        }
        [Authorize(Roles = "Colaborador")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto.";

            return View();
        }
    }
}