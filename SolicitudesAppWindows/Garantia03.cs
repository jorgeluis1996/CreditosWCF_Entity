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
    public partial class Garantia03 : Form
    {
        ProxyGarantia.ServicioGarantiaClient objGarantia = new ProxyGarantia.ServicioGarantiaClient();
        ProxyGarantia.GarantiaBE ObjGarantiaBE = new ProxyGarantia.GarantiaBE();

        ProxyClientes.ServicioClienteClient objCliente = new ProxyClientes.ServicioClienteClient();
        ProxyClientes.ClienteBE objClienteBE = new ProxyClientes.ClienteBE();

        public Garantia03()
        {
            InitializeComponent();
        }

        // Propiedad de Codigo de identificacion
        private String _Codigo;

        public String Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }

        }
        private void Garantia03_Load(object sender, EventArgs e)
        {
            try
            {
                ObjGarantiaBE = objGarantia.GetGarantia(Convert.ToInt16(Codigo));

                cboCliente.DataSource = objCliente.GetAllClientes();
                cboCliente.ValueMember = "Id_cliente";
                cboCliente.DisplayMember = "ApellNombre";
                cboCliente.SelectedValue = ObjGarantiaBE.Id_cli;

                txtDes.Text = ObjGarantiaBE.Des_garantia;
                lblCodigo.Text = Convert.ToString(ObjGarantiaBE.Id_garantia);
                cboTipGarantia.SelectedItem = ObjGarantiaBE.Tip_garantia;
                mskValor.Text = ObjGarantiaBE.Valor_garantia.ToString("###,##0.00");

                /*if (ObjGarantiaBE.Tip_garantia.Equals(1))
                {
                    cboTipGarantia.Text = "Mueble";
                } 
                else if(ObjGarantiaBE.Tip_garantia.Equals(2)){
                    cboTipGarantia.Text = "Inmueble";
                }
                else
                {
                    cboTipGarantia.Text = "Automovil";
                }*/

                if(ObjGarantiaBE.Est_garantia == 1)
                {
                    chkActivo.Checked = true;
                }
                else
                {
                    chkActivo.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones
                if (txtDes.Text.Length == 0)
                {
                    throw new Exception("La descripcion no puede estar vacia");
                }
                if (mskValor.Text.Length == 0)
                {
                    throw new Exception("No´puede estar vacio");
                }

                // -----

                ObjGarantiaBE.Id_cli = cboCliente.SelectedValue.ToString();

                ObjGarantiaBE.Tip_garantia = cboTipGarantia.SelectedItem.ToString();

                /*if (cboTipGarantia.SelectedItem.Equals(1))
                {
                    ObjGarantiaBE.Tip_garantia = "Mueble";
                }

                if (cboTipGarantia.SelectedItem.Equals(2))
                {
                    ObjGarantiaBE.Tip_garantia = "Inmueble";
                }
                else
                {
                    ObjGarantiaBE.Tip_garantia = "Automovil";
                }*/

                ObjGarantiaBE.Des_garantia = txtDes.Text.Trim();
                ObjGarantiaBE.Valor_garantia = Convert.ToSingle(mskValor.Text);

                if (chkActivo.Checked == true)
                {
                    ObjGarantiaBE.Est_garantia = 1;
                }
                else
                {
                    ObjGarantiaBE.Est_garantia = 2;
                }

                ObjGarantiaBE.Usu_ult_mod = "admin";

                if (objGarantia.UpdateGarantia(ObjGarantiaBE) == true)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

