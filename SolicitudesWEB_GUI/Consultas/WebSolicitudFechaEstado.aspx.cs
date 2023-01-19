using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using SolicitudesWEB_GUI.ProxySolicitudesP;

namespace SolicitudesWEB_GUI.Consultas
{
    public partial class WebSolicitudFechaEstado : System.Web.UI.Page
    {

        ProxySolicitudes.ServicioSolicitudClient objSolicitud = new ProxySolicitudes.ServicioSolicitudClient();
        ProxySolicitudes.SolicitudBE objSolicitudBE = new ProxySolicitudes.SolicitudBE();

        //ServicioSolicitudClient objSolicitud = new ProxySolicitudesP.ServicioSolicitudClient();
        //SolicitudBE objSolicitudBE = new ProxySolicitudesP.SolicitudBE();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            grvSolicitudes.DataSource = objSolicitud.GetSolicitudXFechaXEstado(Convert.ToInt16(cboEstado.SelectedValue),
                                            Convert.ToDateTime(txtFI.Text.Trim()), Convert.ToDateTime(txtFF.Text.Trim()));
            grvSolicitudes.DataBind();
        }
    }
}