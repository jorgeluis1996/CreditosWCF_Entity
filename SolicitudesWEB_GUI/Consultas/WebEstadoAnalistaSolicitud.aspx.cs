using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolicitudesWEB_GUI.ProxyAnalistaP;
using SolicitudesWEB_GUI.ProxySolicitudesP;


namespace SolicitudesWEB_GUI
{
    public partial class WebEstadoSolicitud : System.Web.UI.Page
    {

        ProxySolicitudes.ServicioSolicitudClient objSolicitud = new ProxySolicitudes.ServicioSolicitudClient();
        ProxySolicitudes.SolicitudBE objSolicitudBE = new ProxySolicitudes.SolicitudBE();

        ProxyAnalistas.IservicioAnalistaClient objAnalista = new ProxyAnalistas.IservicioAnalistaClient();
        ProxyAnalistas.AnalistaBE objAnalistaBE = new ProxyAnalistas.AnalistaBE();

        //ServicioSolicitudClient objSolicitud = new ProxySolicitudesP.ServicioSolicitudClient();
        //SolicitudBE objSolicitudBE = new ProxySolicitudesP.SolicitudBE();

        //IservicioAnalistaClient objAnalista = new ProxyAnalistaP.IservicioAnalistaClient();
        //AnalistaBE objAnalistaBE = new ProxyAnalistaP.AnalistaBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    // Enlazamos el cboAnalistas...
                    cboAnalistas.DataSource = objAnalista.GetAllAnalista();
                    cboAnalistas.DataTextField = "ApellNombre";
                    cboAnalistas.DataValueField = "Id_analista";
                    cboAnalistas.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                grvSolicitudes.DataSource = objSolicitud.GetSolicitudXEstadoxAnalista(Convert.ToInt16(cboEstado.SelectedValue), cboAnalistas.SelectedValue);
                grvSolicitudes.DataBind();

                if(cboEstado.SelectedValue == "1")
                {
                    lblInfo.Text = "Solicitudes rechazadas: " + grvSolicitudes.Rows.Count.ToString();
                }
                else if (cboEstado.SelectedValue == "2")
                {
                    lblInfo.Text = "Solicitudes por atender: " + grvSolicitudes.Rows.Count.ToString();
                }
                else
                {
                    lblInfo.Text = "Solicitudes aprobadas: " + grvSolicitudes.Rows.Count.ToString();
                }

                if (grvSolicitudes.Rows.Count == 0)
                {
                    lblInfo.Text = "No hay solicitudes";
                }

                objAnalistaBE = objAnalista.GetAnalista(cboAnalistas.SelectedValue);

                txtCod.Text = cboAnalistas.SelectedValue;
                txtNombre.Text = objAnalistaBE.Nom_analista;
                txtApellido.Text = objAnalistaBE.ApellNombre;

                txtDNI.Text = objAnalistaBE.DNI_analista;
                txtEmail.Text = objAnalistaBE.Email_analista;

            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        protected void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}