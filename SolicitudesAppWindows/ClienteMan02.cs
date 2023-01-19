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
    public partial class ClienteMan02 : Form
    {

        ProxyClientes.ServicioClienteClient objCliente = new ProxyClientes.ServicioClienteClient();
        ProxyClientes.ClienteBE objClienteBE = new ProxyClientes.ClienteBE();

        ProxyUbigeo.ServicioUbigeoClient objUbigeo = new ProxyUbigeo.ServicioUbigeoClient();
        ProxyUbigeo.UbigeoBE objUbigeoBE = new ProxyUbigeo.UbigeoBE();

        public ClienteMan02()
        {
            InitializeComponent();
        }

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {

            cboDepartamento.DataSource = objUbigeo.GetDepartamentos();
            cboDepartamento.ValueMember = "idDepartamento";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeo.GetProvincias(IdDepa);
            cboProvincia.ValueMember = "idProvincia";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeo.GetDistritos(IdDepa, IdProv);
            cboDistrito.ValueMember = "idDistrito";
            cboDistrito.DisplayMember = "Distriro";
            cboDistrito.SelectedValue = IdDist;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClienteMan02_Load(object sender, EventArgs e)
        {
            CargarUbigeo("14", "01", "01");            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de llenado
                if (txtNombre.Text.Length == 0)
                {
                    throw new Exception("El Nombre no puede estar vacio.");
                }

                if (txtApellido.Text.Length == 0)
                {
                    throw new Exception("El Apellido no puede estar vacio.");
                }
                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres.");
                }

                // ----------

                objClienteBE.Nom_cli = txtNombre.Text.Trim();
                objClienteBE.Ape_cli = txtApellido.Text.Trim();
                objClienteBE.Dni_cli = mskDNI.Text;
                objClienteBE.Ruc_cli = mskRUC.Text;
                if(rdbMasculino.Checked == true)
                {
                    objClienteBE.Sexo = "M";
                }
                else
                {
                    objClienteBE.Sexo = "F";
                }

                objClienteBE.Fec_nacimiento = dtpFecNacimiento.Value.Date;
                objClienteBE.Nivel_Educacion = txtEducacion.Text.Trim();

                if (cboEstCivil.SelectedItem.Equals("Soltero/a"))
                {
                    objClienteBE.Estado_civil = 1;
                }
                else if (cboEstCivil.SelectedItem.Equals("Casado/a"))
                {
                    objClienteBE.Estado_civil = 2;
                }
                else if (cboEstCivil.SelectedItem.Equals("Viudo/a"))
                {
                    objClienteBE.Estado_civil = 3;
                }
                else
                {
                    objClienteBE.Estado_civil = 4;
                }

                objClienteBE.Email = txtEmail.Text.Trim();

                if (chkActivo.Checked == true)
                {
                    objClienteBE.Est_cli = 1;
                }
                else
                {
                    objClienteBE.Est_cli = 2;
                }

                objClienteBE.Usu_registro = "admin";
                objClienteBE.Id_ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() 
                                            + cboDistrito.SelectedValue.ToString();
                //objClienteBE.Id_ubigeo = "140105";


                if (objCliente.InsertClient(objClienteBE) == true)
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

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }
    }
}
