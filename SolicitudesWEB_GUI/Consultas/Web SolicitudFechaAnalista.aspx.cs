using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using SolicitudesWEB_GUI.ProxyAnalistaP;
using SolicitudesWEB_GUI.ProxySolicitudesP;

namespace SolicitudesWEB_GUI
{
    public partial class Web_SolicitudFechaAnalista : System.Web.UI.Page
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
                    // Enlazamos el cboClientes...
                    cboAnalista.DataSource = objAnalista.GetAllAnalista();
                    cboAnalista.DataTextField = "ApellNombre";
                    cboAnalista.DataValueField = "Id_analista";
                    cboAnalista.DataBind();
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

                objAnalistaBE = objAnalista.GetAnalista(cboAnalista.SelectedValue); 
                
                txtCod.Text = cboAnalista.SelectedValue;
                txtNombre.Text = objAnalistaBE.Nom_analista;
                txtApellido.Text = objAnalistaBE.ApellNombre;
                
                txtDNI.Text = objAnalistaBE.DNI_analista;
                txtEmail.Text = objAnalistaBE.Email_analista;
                


                grvSolicitudes.DataSource = objSolicitud.GetSolicitudXFechaXAnalista(cboAnalista.SelectedValue.ToString(),
                                            Convert.ToDateTime(txtFI.Text.Trim()), Convert.ToDateTime(txtFF.Text.Trim()));
                grvSolicitudes.DataBind();

            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }




    }
}