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
    public partial class ClienteMan03 : Form
    {

        ProxyClientes.ServicioClienteClient objCliente = new ProxyClientes.ServicioClienteClient();
        ProxyClientes.ClienteBE objClienteBE = new ProxyClientes.ClienteBE();

        ProxyUbigeo.ServicioUbigeoClient objUbigeo = new ProxyUbigeo.ServicioUbigeoClient();
        ProxyUbigeo.UbigeoBE objUbigeoBE = new ProxyUbigeo.UbigeoBE();

        public ClienteMan03()
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

        private void ClienteMan03_Load(object sender, EventArgs e)
        {
            try
            {

                objClienteBE = objCliente.GetClient(Codigo);

                lblCodigo.Text = objClienteBE.Id_cliente;
                txtNombre.Text = objClienteBE.Nom_cli;
                txtApellido.Text = objClienteBE.Ape_cli;
                mskDNI.Text = objClienteBE.Dni_cli;
                mskRUC.Text = objClienteBE.Ruc_cli;
                if (objClienteBE.Sexo == "M")
                {
                    rbdMasculino.Checked = true;
                    rbdFemenino.Checked = false;
                }
                else
                {
                    rbdMasculino.Checked = false;
                    rbdFemenino.Checked = true;
                }
                dtpFecNacimiento.Value = objClienteBE.Fec_nacimiento;
                txtEducacion.Text = objClienteBE.Nivel_Educacion;
                //cboEstCivil.SelectedItem = objClienteBE.Estado_civil;

                if (objClienteBE.EstCivil.Equals("Soltero/a"))
                {
                    //cboEstCivil.SelectedItem = 1;
                    cboEstCivil.Text = "Soltero/a";
                }
                else if (objClienteBE.EstCivil.Equals("Casado/a"))
                {
                    //cboEstCivil.SelectedItem = 2;
                    cboEstCivil.Text = "Casado/a";
                }
                else if (objClienteBE.EstCivil.Equals("Viudo/a"))
                {
                    //cboEstCivil.SelectedItem = 3;
                    cboEstCivil.Text = "Viudo/a";
                }
                else
                {
                    //cboEstCivil.SelectedItem = 4;
                    cboEstCivil.Text = "Divorciado/a";
                }

                txtEmail.Text = objClienteBE.Email;

                if (objClienteBE.Est_cli == 1)
                {
                    chkActivo.Checked = true;
                }
                else
                {
                    chkActivo.Checked = false;
                }

                String Id_Ubigeo = objClienteBE.Id_ubigeo;

                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));


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
                if (txtNombre.Text.Length == 0)
                {
                    MessageBox.Show("El Nombre no puede estar vacio.");
                }
                if (txtApellido.Text.Length == 0)
                {
                    MessageBox.Show("El Apellido no puede estar vacio.");
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
                if (rbdMasculino.Checked == true)
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

                objClienteBE.Usu_ult_mod = "administrador";
                objClienteBE.Id_ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() 
                                            + cboDistrito.SelectedValue.ToString();
                //objClienteBE.Id_ubigeo = "140105";

                if (objCliente.UpdateClient(objClienteBE) == true)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }
    }
}
