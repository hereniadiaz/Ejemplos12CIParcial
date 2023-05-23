namespace Ejemplos12CIParcial
{
    partial class frmEspecialidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEspecialidad));
            System.Windows.Forms.Label idespecialidadLabel;
            System.Windows.Forms.Label nombre_especialidadLabel;
            System.Windows.Forms.Label area_especialidadLabel;
            this.hospitalmedykalsystemDataSet = new Ejemplos12CIParcial.hospitalmedykalsystemDataSet();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especialidadTableAdapter = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.especialidadTableAdapter();
            this.tableAdapterManager = new Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager();
            this.especialidadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.especialidadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.especialidadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idespecialidadTextBox = new System.Windows.Forms.TextBox();
            this.nombre_especialidadTextBox = new System.Windows.Forms.TextBox();
            this.area_especialidadTextBox = new System.Windows.Forms.TextBox();
            idespecialidadLabel = new System.Windows.Forms.Label();
            nombre_especialidadLabel = new System.Windows.Forms.Label();
            area_especialidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingNavigator)).BeginInit();
            this.especialidadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hospitalmedykalsystemDataSet
            // 
            this.hospitalmedykalsystemDataSet.DataSetName = "hospitalmedykalsystemDataSet";
            this.hospitalmedykalsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // especialidadBindingSource
            // 
            this.especialidadBindingSource.DataMember = "especialidad";
            this.especialidadBindingSource.DataSource = this.hospitalmedykalsystemDataSet;
            // 
            // especialidadTableAdapter
            // 
            this.especialidadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.consultaTableAdapter = null;
            this.tableAdapterManager.consultorioTableAdapter = null;
            this.tableAdapterManager.especialidadTableAdapter = this.especialidadTableAdapter;
            this.tableAdapterManager.facturaTableAdapter = null;
            this.tableAdapterManager.farmaciaTableAdapter = null;
            this.tableAdapterManager.pacienteTableAdapter = null;
            this.tableAdapterManager.personalmedicoTableAdapter = null;
            this.tableAdapterManager.salaTableAdapter = null;
            this.tableAdapterManager.turnoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ejemplos12CIParcial.hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // especialidadBindingNavigator
            // 
            this.especialidadBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.especialidadBindingNavigator.BindingSource = this.especialidadBindingSource;
            this.especialidadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.especialidadBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.especialidadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.especialidadBindingNavigatorSaveItem});
            this.especialidadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.especialidadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.especialidadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.especialidadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.especialidadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.especialidadBindingNavigator.Name = "especialidadBindingNavigator";
            this.especialidadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.especialidadBindingNavigator.Size = new System.Drawing.Size(571, 25);
            this.especialidadBindingNavigator.TabIndex = 0;
            this.especialidadBindingNavigator.Text = "bindingNavigator1";
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
            // especialidadDataGridView
            // 
            this.especialidadDataGridView.AutoGenerateColumns = false;
            this.especialidadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.especialidadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.especialidadDataGridView.DataSource = this.especialidadBindingSource;
            this.especialidadDataGridView.Location = new System.Drawing.Point(87, 138);
            this.especialidadDataGridView.Name = "especialidadDataGridView";
            this.especialidadDataGridView.Size = new System.Drawing.Size(389, 220);
            this.especialidadDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Idespecialidad";
            this.dataGridViewTextBoxColumn1.HeaderText = "Idespecialidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_especialidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_especialidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "area_especialidad";
            this.dataGridViewTextBoxColumn3.HeaderText = "area_especialidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
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
            // especialidadBindingNavigatorSaveItem
            // 
            this.especialidadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.especialidadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("especialidadBindingNavigatorSaveItem.Image")));
            this.especialidadBindingNavigatorSaveItem.Name = "especialidadBindingNavigatorSaveItem";
            this.especialidadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.especialidadBindingNavigatorSaveItem.Text = "Guardar datos";
            this.especialidadBindingNavigatorSaveItem.Click += new System.EventHandler(this.especialidadBindingNavigatorSaveItem_Click);
            // 
            // idespecialidadLabel
            // 
            idespecialidadLabel.AutoSize = true;
            idespecialidadLabel.Location = new System.Drawing.Point(158, 42);
            idespecialidadLabel.Name = "idespecialidadLabel";
            idespecialidadLabel.Size = new System.Drawing.Size(78, 13);
            idespecialidadLabel.TabIndex = 2;
            idespecialidadLabel.Text = "Idespecialidad:";
            // 
            // idespecialidadTextBox
            // 
            this.idespecialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadBindingSource, "Idespecialidad", true));
            this.idespecialidadTextBox.Location = new System.Drawing.Point(271, 39);
            this.idespecialidadTextBox.Name = "idespecialidadTextBox";
            this.idespecialidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.idespecialidadTextBox.TabIndex = 3;
            // 
            // nombre_especialidadLabel
            // 
            nombre_especialidadLabel.AutoSize = true;
            nombre_especialidadLabel.Location = new System.Drawing.Point(158, 68);
            nombre_especialidadLabel.Name = "nombre_especialidadLabel";
            nombre_especialidadLabel.Size = new System.Drawing.Size(107, 13);
            nombre_especialidadLabel.TabIndex = 4;
            nombre_especialidadLabel.Text = "nombre especialidad:";
            // 
            // nombre_especialidadTextBox
            // 
            this.nombre_especialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadBindingSource, "nombre_especialidad", true));
            this.nombre_especialidadTextBox.Location = new System.Drawing.Point(271, 65);
            this.nombre_especialidadTextBox.Name = "nombre_especialidadTextBox";
            this.nombre_especialidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_especialidadTextBox.TabIndex = 5;
            // 
            // area_especialidadLabel
            // 
            area_especialidadLabel.AutoSize = true;
            area_especialidadLabel.Location = new System.Drawing.Point(158, 94);
            area_especialidadLabel.Name = "area_especialidadLabel";
            area_especialidadLabel.Size = new System.Drawing.Size(93, 13);
            area_especialidadLabel.TabIndex = 6;
            area_especialidadLabel.Text = "area especialidad:";
            // 
            // area_especialidadTextBox
            // 
            this.area_especialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadBindingSource, "area_especialidad", true));
            this.area_especialidadTextBox.Location = new System.Drawing.Point(271, 91);
            this.area_especialidadTextBox.Name = "area_especialidadTextBox";
            this.area_especialidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.area_especialidadTextBox.TabIndex = 7;
            // 
            // frmEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 372);
            this.Controls.Add(idespecialidadLabel);
            this.Controls.Add(this.idespecialidadTextBox);
            this.Controls.Add(nombre_especialidadLabel);
            this.Controls.Add(this.nombre_especialidadTextBox);
            this.Controls.Add(area_especialidadLabel);
            this.Controls.Add(this.area_especialidadTextBox);
            this.Controls.Add(this.especialidadDataGridView);
            this.Controls.Add(this.especialidadBindingNavigator);
            this.Name = "frmEspecialidad";
            this.Text = "frmEspecialidad";
            this.Load += new System.EventHandler(this.frmEspecialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalmedykalsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingNavigator)).EndInit();
            this.especialidadBindingNavigator.ResumeLayout(false);
            this.especialidadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hospitalmedykalsystemDataSet hospitalmedykalsystemDataSet;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private hospitalmedykalsystemDataSetTableAdapters.especialidadTableAdapter especialidadTableAdapter;
        private hospitalmedykalsystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator especialidadBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton especialidadBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView especialidadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox idespecialidadTextBox;
        private System.Windows.Forms.TextBox nombre_especialidadTextBox;
        private System.Windows.Forms.TextBox area_especialidadTextBox;
    }
}