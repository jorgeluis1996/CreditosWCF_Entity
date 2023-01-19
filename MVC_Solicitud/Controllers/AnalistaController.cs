using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Solicitud.ProxyAnalista;

namespace MVC_Solicitud.Controllers
{
    public class AnalistaController : Controller
    {
        IservicioAnalistaClient miservAnalista = new IservicioAnalistaClient();
        public ActionResult Index()
        {
            ViewBag.GetAllAnalista = miservAnalista.GetAllAnalista();
            return View();
        }
    }
}