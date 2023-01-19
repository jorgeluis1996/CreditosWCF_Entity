using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolicitudesAppWindows
{
    public partial class Garantia02 : Form
    {
        ProxyGarantia.ServicioGarantiaClient objGarantia = new ProxyGarantia.ServicioGarantiaClient();
        ProxyGarantia.GarantiaBE objGarantiaBE = new ProxyGarantia.GarantiaBE();

        ProxyClientes.ServicioClienteClient objCliente = new ProxyClientes.ServicioClienteClient();
        ProxyClientes.ClienteBE objClienteBE = new ProxyClientes.ClienteBE();

        public Garantia02()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if(txtDes.Text.Length == 0)
                {
                    throw new Exception("La descripcion no puede estar vacia");
                }
                if(mskValor.Text.Length  == 0)
                {
                    throw new Exception("No´puede estar vacio");
                }

                // -----

                objGarantiaBE.Id_cli = cboCliente.SelectedValue.ToString();
                objGarantiaBE.Des_garantia = txtDes.Text.Trim();
                objGarantiaBE.Valor_garantia = Convert.ToSingle(mskValor.Text);

                if (chkActivo.Checked == true)
                {
                    objGarantiaBE.Est_garantia = 1;
                }
                else
                {
                    objGarantiaBE.Est_garantia = 2;
                }

                objGarantiaBE.Tip_garantia = cboTipGarantia.SelectedItem.ToString();

                /*if(cboTipGarantia.SelectedItem.Equals("Mueble")){
                    objGarantiaBE.Tip_garantia = "Mueble";
                }

                if (cboTipGarantia.SelectedItem.Equals("Inmueble"))
                {
                    objGarantiaBE.Tip_garantia =  "Inmueble";
                }
                else
                {
                    objGarantiaBE.Tip_garantia =  "Automovil";
                }*/

                objGarantiaBE.Usu_registro = "admin";


                if (objGarantia.InsertGarantia(objGarantiaBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mensaje: " + ex.Message);
            }
        }

        private void Garantia02_Load(object sender, EventArgs e)
        {
            cboCliente.DataSource = objCliente.GetAllClientes();
            cboCliente.ValueMember = "Id_cliente";
            cboCliente.DisplayMember = "ApellNombre";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
