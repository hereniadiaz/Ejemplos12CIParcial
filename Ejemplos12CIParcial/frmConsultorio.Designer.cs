namespace Ejemplos12CIParcial
{
    partial class frmConsultorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultorio));
            System.Windows.Forms.Label idconsultorioLabel;
            System.Windows.Forms.Label numero_consultorioLabel;
            System.Windows.Forms.Label num_piso_consultorioLabel;
            System.Windows.Forms.Label idpacienteLabel;
            this.hospitalmedykalsystemDataSet = new Ejemplos12CIParcial.hospitalmedykalsystemDataSet();
            this.consultorioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultorioTableAdapter = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.consultorioTableAdapter();
            this.tableAdapterManager = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager();
            this.consultorioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultorioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.consultorioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idconsultorioTextBox = new System.Windows.Forms.TextBox();
            this.numero_consultorioTextBox = new System.Windows.Forms.TextBox();
            this.num_piso_consultorioTextBox = new System.Windows.Forms.TextBox();
            this.idpacienteTextBox = new System.Windows.Forms.TextBox();
            idconsultorioLabel = new System.Windows.Forms.Label();
            numero_consultorioLabel = new System.Windows.Forms.Label();
            num_piso_consultorioLabel = new System.Windows.Forms.Label();
            idpacienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioBindingNavigator)).BeginInit();
            this.consultorioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalmedykalsystemDataSet
            // 
            this.hospitalmedykalsystemDataSet.DataSetName = "hospitalmedykalsystemDataSet";
            this.hospitalmedykalsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultorioBindingSource
            // 
            this.consultorioBindingSource.DataMember = "consultorio";
            this.consultorioBindingSource.DataSource = this.hospitalmedykalsystemDataSet;
            // 
            // consultorioTableAdapter
            // 
            this.consultorioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.consultaTableAdapter = null;
            this.tableAdapterManager.consultorioTableAdapter = this.consultorioTableAdapter;
            this.tableAdapterManager.especialidadTableAdapter = null;
            this.tableAdapterManager.facturaTableAdapter = null;
            this.tableAdapterManager.farmaciaTableAdapter = null;
            this.tableAdapterManager.pacienteTableAdapter = null;
            this.tableAdapterManager.personalmedicoTableAdapter = null;
            this.tableAdapterManager.salaTableAdapter = null;
            this.tableAdapterManager.turnoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consultorioBindingNavigator
            // 
            this.consultorioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultorioBindingNavigator.BindingSource = this.consultorioBindingSource;
            this.consultorioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultorioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultorioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.consultorioBindingNavigatorSaveItem});
            this.consultorioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultorioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultorioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultorioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultorioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultorioBindingNavigator.Name = "consultorioBindingNavigator";
            this.consultorioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultorioBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.consultorioBindingNavigator.TabIndex = 0;
            this.consultorioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // consultorioDataGridView
            // 
            this.consultorioDataGridView.AutoGenerateColumns = false;
            this.consultorioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultorioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.consultorioDataGridView.DataSource = this.consultorioBindingSource;
            this.consultorioDataGridView.Location = new System.Drawing.Point(349, 81);
            this.consultorioDataGridView.Name = "consultorioDataGridView";
            this.consultorioDataGridView.Size = new System.Drawing.Size(300, 220);
            this.consultorioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Idconsultorio";
            this.dataGridViewTextBoxColumn1.HeaderText = "Idconsultorio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "numero_consultorio";
            this.dataGridViewTextBoxColumn2.HeaderText = "numero_consultorio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "num_piso_consultorio";
            this.dataGridViewTextBoxColumn3.HeaderText = "num_piso_consultorio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idpaciente";
            this.dataGridViewTextBoxColumn4.HeaderText = "idpaciente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // consultorioBindingNavigatorSaveItem
            // 
            this.consultorioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultorioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultorioBindingNavigatorSaveItem.Image")));
            this.consultorioBindingNavigatorSaveItem.Name = "consultorioBindingNavigatorSaveItem";
            this.consultorioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.consultorioBindingNavigatorSaveItem.Text = "Guardar datos";
            this.consultorioBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultorioBindingNavigatorSaveItem_Click);
            // 
            // idconsultorioLabel
            // 
            idconsultorioLabel.AutoSize = true;
            idconsultorioLabel.Location = new System.Drawing.Point(75, 142);
            idconsultorioLabel.Name = "idconsultorioLabel";
            idconsultorioLabel.Size = new System.Drawing.Size(70, 13);
            idconsultorioLabel.TabIndex = 2;
            idconsultorioLabel.Text = "Idconsultorio:";
            // 
            // idconsultorioTextBox
            // 
            this.idconsultorioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultorioBindingSource, "Idconsultorio", true));
            this.idconsultorioTextBox.Location = new System.Drawing.Point(187, 139);
            this.idconsultorioTextBox.Name = "idconsultorioTextBox";
            this.idconsultorioTextBox.Size = new System.Drawing.Size(100, 20);
            this.idconsultorioTextBox.TabIndex = 3;
            // 
            // numero_consultorioLabel
            // 
            numero_consultorioLabel.AutoSize = true;
            numero_consultorioLabel.Location = new System.Drawing.Point(75, 168);
            numero_consultorioLabel.Name = "numero_consultorioLabel";
            numero_consultorioLabel.Size = new System.Drawing.Size(99, 13);
            numero_consultorioLabel.TabIndex = 4;
            numero_consultorioLabel.Text = "numero consultorio:";
            // 
            // numero_consultorioTextBox
            // 
            this.numero_consultorioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultorioBindingSource, "numero_consultorio", true));
            this.numero_consultorioTextBox.Location = new System.Drawing.Point(187, 165);
            this.numero_consultorioTextBox.Name = "numero_consultorioTextBox";
            this.numero_consultorioTextBox.Size = new System.Drawing.Size(100, 20);
            this.numero_consultorioTextBox.TabIndex = 5;
            // 
            // num_piso_consultorioLabel
            // 
            num_piso_consultorioLabel.AutoSize = true;
            num_piso_consultorioLabel.Location = new System.Drawing.Point(75, 194);
            num_piso_consultorioLabel.Name = "num_piso_consultorioLabel";
            num_piso_consultorioLabel.Size = new System.Drawing.Size(106, 13);
            num_piso_consultorioLabel.TabIndex = 6;
            num_piso_consultorioLabel.Text = "num piso consultorio:";
            // 
            // num_piso_consultorioTextBox
            // 
            this.num_piso_consultorioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultorioBindingSource, "num_piso_consultorio", true));
            this.num_piso_consultorioTextBox.Location = new System.Drawing.Point(187, 191);
            this.num_piso_consultorioTextBox.Name = "num_piso_consultorioTextBox";
            this.num_piso_consultorioTextBox.Size = new System.Drawing.Size(100, 20);
            this.num_piso_consultorioTextBox.TabIndex = 7;
            // 
            // idpacienteLabel
            // 
            idpacienteLabel.AutoSize = true;
            idpacienteLabel.Location = new System.Drawing.Point(75, 220);
            idpacienteLabel.Name = "idpacienteLabel";
            idpacienteLabel.Size = new System.Drawing.Size(59, 13);
            idpacienteLabel.TabIndex = 8;
            idpacienteLabel.Text = "idpaciente:";
            // 
            // idpacienteTextBox
            // 
            this.idpacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultorioBindingSource, "idpaciente", true));
            this.idpacienteTextBox.Location = new System.Drawing.Point(187, 217);
            this.idpacienteTextBox.Name = "idpacienteTextBox";
            this.idpacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idpacienteTextBox.TabIndex = 9;
            // 
            // frmConsultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(idconsultorioLabel);
            this.Controls.Add(this.idconsultorioTextBox);
            this.Controls.Add(numero_consultorioLabel);
            this.Controls.Add(this.numero_consultorioTextBox);
            this.Controls.Add(num_piso_consultorioLabel);
            this.Controls.Add(this.num_piso_consultorioTextBox);
            this.Controls.Add(idpacienteLabel);
            this.Controls.Add(this.idpacienteTextBox);
            this.Controls.Add(this.consultorioDataGridView);
            this.Controls.Add(this.consultorioBindingNavigator);
            this.Name = "frmConsultorio";
            this.Text = "frmConsultorio";
            this.Load += new System.EventHandler(this.frmConsultorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioBindingNavigator)).EndInit();
            this.consultorioBindingNavigator.ResumeLayout(false);
            this.consultorioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalmedykalsystemDataSet hospitalmedykalsystemDataSet;
        private System.Windows.Forms.BindingSource consultorioBindingSource;
        private hospitalmedykalsystemDataSetTableAdapters.consultorioTableAdapter consultorioTableAdapter;
        private hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultorioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton consultorioBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView consultorioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox idconsultorioTextBox;
        private System.Windows.Forms.TextBox numero_consultorioTextBox;
        private System.Windows.Forms.TextBox num_piso_consultorioTextBox;
        private System.Windows.Forms.TextBox idpacienteTextBox;
    }
}