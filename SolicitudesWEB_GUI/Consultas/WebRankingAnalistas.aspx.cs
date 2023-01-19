using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//
using SolicitudesWEB_GUI.ProxyAnalistaP;

namespace SolicitudesWEB_GUI.Consultas
{
    public partial class WebRankingAnalistas : System.Web.UI.Page
    {

        ProxyAnalistas.IservicioAnalistaClient objAnalista = new ProxyAnalistas.IservicioAnalistaClient();
        ProxyAnalistas.AnalistaBE objAnalistaBE = new ProxyAnalistas.AnalistaBE();

        //IservicioAnalistaClient objAnalista = new ProxyAnalistaP.IservicioAnalistaClient();
        //AnalistaBE objAnalistaBE = new ProxyAnalistaP.AnalistaBE();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt16(txtTop.Text) < 0)
            {
                lblMensaje.Text = "Digite un numero mayor a 0";
            }
            else
            {
                lblMensaje.Text = "";
                grvSolicitudes.DataSource = objAnalista.GetRankingAnalista(Convert.ToInt32(txtTop.Text), Convert.ToInt32(cboEstado.SelectedValue));
                grvSolicitudes.DataBind();
            }

        }

        protected void grvSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}