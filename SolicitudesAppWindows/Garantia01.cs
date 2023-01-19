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
    public partial class Garantia01 : Form
    {

        ProxyGarantia.ServicioGarantiaClient objGarantia = new ProxyGarantia.ServicioGarantiaClient();
        public Garantia01()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            ProxyGarantia.GarantiaBE[] allGarantias = objGarantia.GetAllGarantias();
            dtgGarantia.DataSource = allGarantias;
            lblRegistros.Text = dtgGarantia.Rows.Count.ToString();
        }
        private void Garantia01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgGarantia.AutoGenerateColumns = false;
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Garantia02 insertForm = new Garantia02();
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
                Garantia03 updateForm = new Garantia03();
                String strCod = dtgGarantia.CurrentRow.Cells[0].Value.ToString();
                updateForm.Codigo = strCod;
                updateForm.ShowDialog();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
