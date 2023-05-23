namespace Ejemplos12CIParcial
{
    partial class frmAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.grbAcceso = new System.Windows.Forms.GroupBox();
            this.lnkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.lnkRestablecer = new System.Windows.Forms.LinkLabel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(162, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Usuario de la Plataforma";
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.Location = new System.Drawing.Point(17, 32);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(221, 25);
            this.lblNombreUser.TabIndex = 1;
            this.lblNombreUser.Text = "Nombre de Usuario:";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(17, 79);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(140, 25);
            this.lblContrasena.TabIndex = 2;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUser.Location = new System.Drawing.Point(253, 38);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(237, 29);
            this.txtNombreUser.TabIndex = 3;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(253, 85);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(237, 29);
            this.txtContrasena.TabIndex = 4;
            // 
            // grbAcceso
            // 
            this.grbAcceso.Controls.Add(this.txtContrasena);
            this.grbAcceso.Controls.Add(this.lblNombreUser);
            this.grbAcceso.Controls.Add(this.txtNombreUser);
            this.grbAcceso.Controls.Add(this.lblContrasena);
            this.grbAcceso.Location = new System.Drawing.Point(22, 86);
            this.grbAcceso.Name = "grbAcceso";
            this.grbAcceso.Size = new System.Drawing.Size(510, 135);
            this.grbAcceso.TabIndex = 5;
            this.grbAcceso.TabStop = false;
            this.grbAcceso.Text = "Acceso";
            // 
            // lnkRegistrarse
            // 
            this.lnkRegistrarse.AutoSize = true;
            this.lnkRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegistrarse.Location = new System.Drawing.Point(247, 309);
            this.lnkRegistrarse.Name = "lnkRegistrarse";
            this.lnkRegistrarse.Size = new System.Drawing.Size(133, 25);
            this.lnkRegistrarse.TabIndex = 7;
            this.lnkRegistrarse.TabStop = true;
            this.lnkRegistrarse.Text = "Registrarse";
            // 
            // lnkRestablecer
            // 
            this.lnkRestablecer.AutoSize = true;
            this.lnkRestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRestablecer.Location = new System.Drawing.Point(173, 363);
            this.lnkRestablecer.Name = "lnkRestablecer";
            this.lnkRestablecer.Size = new System.Drawing.Size(261, 25);
            this.lnkRestablecer.TabIndex = 8;
            this.lnkRestablecer.TabStop = true;
            this.lnkRestablecer.Text = "¿Olvidó su contraseña?";
            this.lnkRestablecer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = global::Ejemplos12CIParcial.Properties.Resources.adim;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAceptar.Location = new System.Drawing.Point(95, 227);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 58);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Ejemplos12CIParcial.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCancelar.Location = new System.Drawing.Point(308, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 58);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(576, 415);
            this.Controls.Add(this.lnkRestablecer);
            this.Controls.Add(this.lnkRegistrarse);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbAcceso);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al sistema";
            this.grbAcceso.ResumeLayout(false);
            this.grbAcceso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.GroupBox grbAcceso;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.LinkLabel lnkRegistrarse;
        private System.Windows.Forms.LinkLabel lnkRestablecer;
    }
}