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
    public partial class InicioSesion : Form
    {

        //Declaramos variables de intentos
        Int16 intentos = 0;

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el numero de intentos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtClave.Text != "" & txtUsuario.Text != "")
            {
                if(txtUsuario.Text != "Admin")
                {
                    MessageBox.Show("Usuario incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos = +1;
                    ValidaAccesos();
                }
                else
                {
                    if(txtUsuario.Text == "Admin" & txtClave.Text == "Admin1")
                    {
                        this.Hide();

                        MDIPrincipal mdi = new MDIPrincipal();
                        mdi.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Password incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        intentos++;
                        ValidaAccesos();
                    }
                }
            }
            else
            {
                MessageBox.Show("Usuario o password obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos++;
                ValidaAccesos();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InicioSesion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnIngresar.PerformClick();
            }
        }
    }
}
