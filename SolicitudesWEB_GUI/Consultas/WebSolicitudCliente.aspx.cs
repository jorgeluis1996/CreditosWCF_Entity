using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using SolicitudesWEB_GUI.ProxySolicitudesP;
using SolicitudesWEB_GUI.ProxyClienteP;

namespace SolicitudesWEB_GUI
{
    public partial class WebSolicitudCliente : System.Web.UI.Page
    {

        ProxySolicitudes.ServicioSolicitudClient objSolicitud = new ProxySolicitudes.ServicioSolicitudClient();
        ProxySolicitudes.SolicitudBE objSolicitudBE = new ProxySolicitudes.SolicitudBE();

        ProxyClientes.ServicioClienteClient objCliente = new ProxyClientes.ServicioClienteClient();
        ProxyClientes.ClienteBE objClienteBE = new ProxyClientes.ClienteBE();

        //ServicioSolicitudClient objSolicitud = new ProxySolicitudesP.ServicioSolicitudClient();
        //SolicitudBE objSolicitudBE = new ProxySolicitudesP.SolicitudBE();

        //ServicioClienteClient objCliente = new ProxyClienteP.ServicioClienteClient();
        //ProxyClienteP.ClienteBE objClienteBE = new ProxyClienteP.ClienteBE();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Page.IsPostBack == false)
                {
                    // Enlazamos el cboClientes...
                    cboClientes.DataSource = objCliente.GetAllClientes();
                    cboClientes.DataTextField = "ApellNombre";
                    cboClientes.DataValueField = "Id_cliente";
                    cboClientes.DataBind();
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

                objClienteBE = objCliente.GetClient(cboClientes.SelectedValue);

                txtNombre.Text = objClienteBE.Nom_cli;
                txtApellido.Text = objClienteBE.Ape_cli;
                txtCorreo.Text = objClienteBE.Email;
                txtDNI.Text = objClienteBE.Dni_cli;
                txtRUC.Text = objClienteBE.Ruc_cli;
                txtEstCivil.Text = objClienteBE.EstCivil;

                grvSolicitudes.DataSource = objSolicitud.GetAllSolicitudXCliente(cboClientes.SelectedValue.ToString());
                grvSolicitudes.DataBind();

                lblPrueba.Text = "El cliente cuenta con: " + grvSolicitudes.Rows.Count.ToString() + " solicitudes";
                if (grvSolicitudes.Rows.Count == 0)
                {
                    lblPrueba.Text = "El cliente no cuenta con solicitudes";
                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}