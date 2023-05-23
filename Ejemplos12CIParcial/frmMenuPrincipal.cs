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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            frmPaciente frm = new frmPaciente();
            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
