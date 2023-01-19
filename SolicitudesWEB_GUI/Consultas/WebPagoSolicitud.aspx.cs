using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using SolicitudesWEB_GUI.ProxySolicitudesP;

namespace SolicitudesWEB_GUI
{
    public partial class WebPagoSolicitud : System.Web.UI.Page
    {

        ProxySolicitudes.ServicioSolicitudClient objSolicitud = new ProxySolicitudes.ServicioSolicitudClient();
        ProxySolicitudes.SolicitudBE objSolicitudBE = new ProxySolicitudes.SolicitudBE();

        ProxyAnalistas.IservicioAnalistaClient objAnalista = new ProxyAnalistas.IservicioAnalistaClient();
        ProxyAnalistas.AnalistaBE objAnalistaBE = new ProxyAnalistas.AnalistaBE();

        //ServicioSolicitudClient objSolicitud = new ProxySolicitudesP.ServicioSolicitudClient();
        //SolicitudBE objSolicitudBE = new ProxySolicitudesP.SolicitudBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                /*objAnalistaBE = objAnalista.GetAnalista(cboAnalista.SelectedValue);

                txtCod.Text = cboAnalista.SelectedValue;
                txtNombre.Text = objAnalistaBE.Nom_analista;
                txtApellido.Text = objAnalistaBE.ApellNombre;

                txtDNI.Text = objAnalistaBE.DNI_analista;
                txtEmail.Text = objAnalistaBE.Email_analista;*/



                grvSolicitudes.DataSource = objSolicitud.GetPagoxSolicitud(txtIdSolicitud.Text.Trim());
                grvSolicitudes.DataBind();

            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}