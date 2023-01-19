using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Solicitud.ProxyCliente;

namespace MVC_Solicitud.Controllers
{
    public class ClienteController : Controller
    {
        ServicioClienteClient miservCliente = new ServicioClienteClient();
        public ActionResult Index()
        {
            ViewBag.GetAllClientes = miservCliente.GetAllClientes();
            return View();
        }



    }
}