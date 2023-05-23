using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplos12CIParcial
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreUser.Text == "Supervisor" & txtContrasena.Text == "456")
            {
                MessageBox.Show("Bienvenido", "Medykalsystem23");
                // comentarios aquí explique
                // usamos código de C# instrucción If
                this.Hide();
                frmMenuPrincipal frm = new frmMenuPrincipal();
                frm.Show();
                txtNombreUser.BackColor = Color.White;
                txtContrasena.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos", "Medykalsystem23");
                txtNombreUser.Text = "";
                txtContrasena.Text = "";
                txtNombreUser.Focus();
                txtNombreUser.BackColor = Color.Violet;
                txtContrasena.BackColor = Color.Violet;
            }
        }
    }
}
