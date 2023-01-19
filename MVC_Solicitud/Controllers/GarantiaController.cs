using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Solicitud.ProxyGarantia;


namespace MVC_Solicitud.Controllers
{
    public class GarantiaController : Controller
    {
        ServicioGarantiaClient miservGarantia = new ServicioGarantiaClient();
        public ActionResult Index()
        {
            ViewBag.GetAllGarantias = miservGarantia.GetAllGarantias();
            return View();
        }
    }
}