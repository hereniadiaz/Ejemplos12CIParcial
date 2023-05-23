namespace Ejemplos12CIParcial
{
    partial class frmConsulta
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
            System.Windows.Forms.Label idconsultaLabel;
            System.Windows.Forms.Label fecha_consultaLabel;
            System.Windows.Forms.Label hora_consultaLabel;
            System.Windows.Forms.Label diagnostico_consultaLabel;
            System.Windows.Forms.Label tratamiento_consultaLabel;
            System.Windows.Forms.Label idconsultorioLabel;
            System.Windows.Forms.Label idpersonalmedicoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.hospitalmedykalsystemDataSet = new Ejemplos12CIParcial.hospitalmedykalsystemDataSet();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaTableAdapter = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.consultaTableAdapter();
            this.tableAdapterManager = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager();
            this.consultaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaDataGridView = new System.Windows.Forms.DataGridView();
            this.idconsultaTextBox = new System.Windows.Forms.TextBox();
            this.fecha_consultaTextBox = new System.Windows.Forms.TextBox();
            this.hora_consultaTextBox = new System.Windows.Forms.TextBox();
            this.diagnostico_consultaTextBox = new System.Windows.Forms.TextBox();
            this.tratamiento_consultaTextBox = new System.Windows.Forms.TextBox();
            this.idconsultorioTextBox = new System.Windows.Forms.TextBox();
            this.idpersonalmedicoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.consultaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idconsultaLabel = new System.Windows.Forms.Label();
            fecha_consultaLabel = new System.Windows.Forms.Label();
            hora_consultaLabel = new System.Windows.Forms.Label();
            diagnostico_consultaLabel = new System.Windows.Forms.Label();
            tratamiento_consultaLabel = new System.Windows.Forms.Label();
            idconsultorioLabel = new System.Windows.Forms.Label();
            idpersonalmedicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).BeginInit();
            this.consultaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalmedykalsystemDataSet
            // 
            this.hospitalmedykalsystemDataSet.DataSetName = "hospitalmedykalsystemDataSet";
            this.hospitalmedykalsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataMember = "consulta";
            this.consultaBindingSource.DataSource = this.hospitalmedykalsystemDataSet;
            // 
            // consultaTableAdapter
            // 
            this.consultaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.consultaTableAdapter = this.consultaTableAdapter;
            this.tableAdapterManager.consultorioTableAdapter = null;
            this.tableAdapterManager.especialidadTableAdapter = null;
            this.tableAdapterManager.facturaTableAdapter = null;
            this.tableAdapterManager.farmaciaTableAdapter = null;
            this.tableAdapterManager.pacienteTableAdapter = null;
            this.tableAdapterManager.personalmedicoTableAdapter = null;
            this.tableAdapterManager.salaTableAdapter = null;
            this.tableAdapterManager.turnoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consultaBindingNavigator
            // 
            this.consultaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultaBindingNavigator.BindingSource = this.consultaBindingSource;
            this.consultaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultaBindingNavigatorSaveItem});
            this.consultaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultaBindingNavigator.Name = "consultaBindingNavigator";
            this.consultaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultaBindingNavigator.Size = new System.Drawing.Size(845, 25);
            this.consultaBindingNavigator.TabIndex = 0;
            this.consultaBindingNavigator.Text = "bindingNavigator1";
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
            // consultaDataGridView
            // 
            this.consultaDataGridView.AutoGenerateColumns = false;
            this.consultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.consultaDataGridView.DataSource = this.consultaBindingSource;
            this.consultaDataGridView.Location = new System.Drawing.Point(51, 205);
            this.consultaDataGridView.Name = "consultaDataGridView";
            this.consultaDataGridView.Size = new System.Drawing.Size(744, 201);
            this.consultaDataGridView.TabIndex = 1;
            // 
            // idconsultaLabel
            // 
            idconsultaLabel.AutoSize = true;
            idconsultaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idconsultaLabel.Location = new System.Drawing.Point(12, 109);
            idconsultaLabel.Name = "idconsultaLabel";
            idconsultaLabel.Size = new System.Drawing.Size(143, 20);
            idconsultaLabel.TabIndex = 2;
            idconsultaLabel.Text = "Código consulta:";
            // 
            // idconsultaTextBox
            // 
            this.idconsultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "Idconsulta", true));
            this.idconsultaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idconsultaTextBox.Location = new System.Drawing.Point(225, 103);
            this.idconsultaTextBox.Name = "idconsultaTextBox";
            this.idconsultaTextBox.Size = new System.Drawing.Size(100, 26);
            this.idconsultaTextBox.TabIndex = 3;
            // 
            // fecha_consultaLabel
            // 
            fecha_consultaLabel.AutoSize = true;
            fecha_consultaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_consultaLabel.Location = new System.Drawing.Point(92, 179);
            fecha_consultaLabel.Name = "fecha_consultaLabel";
            fecha_consultaLabel.Size = new System.Drawing.Size(137, 20);
            fecha_consultaLabel.TabIndex = 4;
            fecha_consultaLabel.Text = "Fecha consulta:";
            // 
            // fecha_consultaTextBox
            // 
            this.fecha_consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "fecha_consulta", true));
            this.fecha_consultaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_consultaTextBox.Location = new System.Drawing.Point(243, 173);
            this.fecha_consultaTextBox.Name = "fecha_consultaTextBox";
            this.fecha_consultaTextBox.Size = new System.Drawing.Size(100, 26);
            this.fecha_consultaTextBox.TabIndex = 5;
            // 
            // hora_consultaLabel
            // 
            hora_consultaLabel.AutoSize = true;
            hora_consultaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hora_consultaLabel.Location = new System.Drawing.Point(470, 176);
            hora_consultaLabel.Name = "hora_consultaLabel";
            hora_consultaLabel.Size = new System.Drawing.Size(126, 20);
            hora_consultaLabel.TabIndex = 6;
            hora_consultaLabel.Text = "Hora consulta:";
            // 
            // hora_consultaTextBox
            // 
            this.hora_consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "hora_consulta", true));
            this.hora_consultaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora_consultaTextBox.Location = new System.Drawing.Point(599, 173);
            this.hora_consultaTextBox.Name = "hora_consultaTextBox";
            this.hora_consultaTextBox.Size = new System.Drawing.Size(100, 26);
            this.hora_consultaTextBox.TabIndex = 7;
            // 
            // diagnostico_consultaLabel
            // 
            diagnostico_consultaLabel.AutoSize = true;
            diagnostico_consultaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diagnostico_consultaLabel.Location = new System.Drawing.Point(647, 106);
            diagnostico_consultaLabel.Name = "diagnostico_consultaLabel";
            diagnostico_consultaLabel.Size = new System.Drawing.Size(182, 20);
            diagnostico_consultaLabel.TabIndex = 8;
            diagnostico_consultaLabel.Text = "Diagnóstico consulta:";
            // 
            // diagnostico_consultaTextBox
            // 
            this.diagnostico_consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "diagnostico_consulta", true));
            this.diagnostico_consultaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnostico_consultaTextBox.Location = new System.Drawing.Point(651, 135);
            this.diagnostico_consultaTextBox.Name = "diagnostico_consultaTextBox";
            this.diagnostico_consultaTextBox.Size = new System.Drawing.Size(175, 26);
            this.diagnostico_consultaTextBox.TabIndex = 9;
            // 
            // tratamiento_consultaLabel
            // 
            tratamiento_consultaLabel.AutoSize = true;
            tratamiento_consultaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tratamiento_consultaLabel.Location = new System.Drawing.Point(343, 141);
            tratamiento_consultaLabel.Name = "tratamiento_consultaLabel";
            tratamiento_consultaLabel.Size = new System.Drawing.Size(183, 20);
            tratamiento_consultaLabel.TabIndex = 10;
            tratamiento_consultaLabel.Text = "Tratamiento consulta:";
            // 
            // tratamiento_consultaTextBox
            // 
            this.tratamiento_consultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "tratamiento_consulta", true));
            this.tratamiento_consultaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tratamiento_consultaTextBox.Location = new System.Drawing.Point(529, 135);
            this.tratamiento_consultaTextBox.Name = "tratamiento_consultaTextBox";
            this.tratamiento_consultaTextBox.Size = new System.Drawing.Size(100, 26);
            this.tratamiento_consultaTextBox.TabIndex = 11;
            // 
            // idconsultorioLabel
            // 
            idconsultorioLabel.AutoSize = true;
            idconsultorioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idconsultorioLabel.Location = new System.Drawing.Point(343, 109);
            idconsultorioLabel.Name = "idconsultorioLabel";
            idconsultorioLabel.Size = new System.Drawing.Size(163, 20);
            idconsultorioLabel.TabIndex = 12;
            idconsultorioLabel.Text = "Código consultorio:";
            // 
            // idconsultorioTextBox
            // 
            this.idconsultorioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "idconsultorio", true));
            this.idconsultorioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idconsultorioTextBox.Location = new System.Drawing.Point(529, 103);
            this.idconsultorioTextBox.Name = "idconsultorioTextBox";
            this.idconsultorioTextBox.Size = new System.Drawing.Size(100, 26);
            this.idconsultorioTextBox.TabIndex = 13;
            // 
            // idpersonalmedicoLabel
            // 
            idpersonalmedicoLabel.AutoSize = true;
            idpersonalmedicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idpersonalmedicoLabel.Location = new System.Drawing.Point(12, 141);
            idpersonalmedicoLabel.Name = "idpersonalmedicoLabel";
            idpersonalmedicoLabel.Size = new System.Drawing.Size(206, 20);
            idpersonalmedicoLabel.TabIndex = 14;
            idpersonalmedicoLabel.Text = "Código personal médico:";
            // 
            // idpersonalmedicoTextBox
            // 
            this.idpersonalmedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource, "idpersonalmedico", true));
            this.idpersonalmedicoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpersonalmedicoTextBox.Location = new System.Drawing.Point(225, 135);
            this.idpersonalmedicoTextBox.Name = "idpersonalmedicoTextBox";
            this.idpersonalmedicoTextBox.Size = new System.Drawing.Size(100, 26);
            this.idpersonalmedicoTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Consulta";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Ejemplos12CIParcial.Properties.Resources.logomedykal231;
            this.pictureBox2.Location = new System.Drawing.Point(651, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(845, 14);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
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
            // consultaBindingNavigatorSaveItem
            // 
            this.consultaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaBindingNavigatorSaveItem.Image")));
            this.consultaBindingNavigatorSaveItem.Name = "consultaBindingNavigatorSaveItem";
            this.consultaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.consultaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.consultaBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultaBindingNavigatorSaveItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Idconsulta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código consulta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha_consulta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha consulta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "hora_consulta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hora consulta";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "diagnostico_consulta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Diagnóstico consulta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tratamiento_consulta";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tratamiento consulta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idconsultorio";
            this.dataGridViewTextBoxColumn6.HeaderText = "Código consultorio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "idpersonalmedico";
            this.dataGridViewTextBoxColumn7.HeaderText = "Código personal médico";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(845, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(idconsultaLabel);
            this.Controls.Add(this.idconsultaTextBox);
            this.Controls.Add(fecha_consultaLabel);
            this.Controls.Add(this.fecha_consultaTextBox);
            this.Controls.Add(hora_consultaLabel);
            this.Controls.Add(this.hora_consultaTextBox);
            this.Controls.Add(diagnostico_consultaLabel);
            this.Controls.Add(this.diagnostico_consultaTextBox);
            this.Controls.Add(tratamiento_consultaLabel);
            this.Controls.Add(this.tratamiento_consultaTextBox);
            this.Controls.Add(idconsultorioLabel);
            this.Controls.Add(this.idconsultorioTextBox);
            this.Controls.Add(idpersonalmedicoLabel);
            this.Controls.Add(this.idpersonalmedicoTextBox);
            this.Controls.Add(this.consultaDataGridView);
            this.Controls.Add(this.consultaBindingNavigator);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).EndInit();
            this.consultaBindingNavigator.ResumeLayout(false);
            this.consultaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalmedykalsystemDataSet hospitalmedykalsystemDataSet;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private hospitalmedykalsystemDataSetTableAdapters.consultaTableAdapter consultaTableAdapter;
        private hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consultaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView consultaDataGridView;
        private System.Windows.Forms.TextBox idconsultaTextBox;
        private System.Windows.Forms.TextBox fecha_consultaTextBox;
        private System.Windows.Forms.TextBox hora_consultaTextBox;
        private System.Windows.Forms.TextBox diagnostico_consultaTextBox;
        private System.Windows.Forms.TextBox tratamiento_consultaTextBox;
        private System.Windows.Forms.TextBox idconsultorioTextBox;
        private System.Windows.Forms.TextBox idpersonalmedicoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}