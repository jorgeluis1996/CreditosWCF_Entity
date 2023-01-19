using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Solicitud.ProxySolicitud;

namespace MVC_Solicitud.Controllers
{
    public class SolicitudController : Controller
    {
        ServicioSolicitudClient miservSolicitud = new ServicioSolicitudClient();
        public ActionResult Index()
        {
            ViewBag.GetAllSolicitud = miservSolicitud.GetAllSolicitud();
            return View();
        }
    }
}