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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void consultaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalmedykalsystemDataSet);

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalmedykalsystemDataSet.consulta' Puede moverla o quitarla según sea necesario.
            this.consultaTableAdapter.Fill(this.hospitalmedykalsystemDataSet.consulta);

        }
    }
}
