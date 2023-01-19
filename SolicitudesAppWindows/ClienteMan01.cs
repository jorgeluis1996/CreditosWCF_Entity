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
    public partial class ClienteMan01 : Form
    {

        ProxyClientes.ServicioClienteClient objCliente = new ProxyClientes.ServicioClienteClient();

        public ClienteMan01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            ProxyClientes.ClienteBE[] allClientes = objCliente.GetAllClientes();
            dtgCliente.DataSource = allClientes;
            lblRegistros.Text = dtgCliente.Rows.Count.ToString();
        }

        private void ClienteMan01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgCliente.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                // Invocamos al formulario2
                ClienteMan02 insertForm = new ClienteMan02();
                insertForm.ShowDialog();
                CargarDatos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Codifique
                ClienteMan03 updateForm = new ClienteMan03();
                String strCod = dtgCliente.CurrentRow.Cells[0].Value.ToString();
                updateForm.Codigo = strCod;
                updateForm.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
