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
    public partial class frmConsultorio : Form
    {
        public frmConsultorio()
        {
            InitializeComponent();
        }

        private void consultorioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultorioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalmedykalsystemDataSet);

        }

        private void frmConsultorio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalmedykalsystemDataSet.consultorio' Puede moverla o quitarla según sea necesario.
            this.consultorioTableAdapter.Fill(this.hospitalmedykalsystemDataSet.consultorio);

        }
    }
}
