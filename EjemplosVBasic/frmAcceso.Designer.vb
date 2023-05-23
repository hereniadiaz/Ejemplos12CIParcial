<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcceso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lnkRestablecer = New System.Windows.Forms.LinkLabel()
        Me.lnkRegistrarse = New System.Windows.Forms.LinkLabel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grbAcceso = New System.Windows.Forms.GroupBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lblNombreUser = New System.Windows.Forms.Label()
        Me.txtNombreUser = New System.Windows.Forms.TextBox()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.grbAcceso.SuspendLayout()
        Me.SuspendLayout()
        '
        'lnkRestablecer
        '
        Me.lnkRestablecer.AutoSize = True
        Me.lnkRestablecer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkRestablecer.Location = New System.Drawing.Point(212, 375)
        Me.lnkRestablecer.Name = "lnkRestablecer"
        Me.lnkRestablecer.Size = New System.Drawing.Size(261, 25)
        Me.lnkRestablecer.TabIndex = 14
        Me.lnkRestablecer.TabStop = True
        Me.lnkRestablecer.Text = "¿Olvidó su contraseña?"
        '
        'lnkRegistrarse
        '
        Me.lnkRegistrarse.AutoSize = True
        Me.lnkRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkRegistrarse.Location = New System.Drawing.Point(286, 321)
        Me.lnkRegistrarse.Name = "lnkRegistrarse"
        Me.lnkRegistrarse.Size = New System.Drawing.Size(133, 25)
        Me.lnkRegistrarse.TabIndex = 13
        Me.lnkRegistrarse.TabStop = True
        Me.lnkRegistrarse.Text = "Registrarse"
        '
        'btnAceptar
        '
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnAceptar.Location = New System.Drawing.Point(134, 239)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(150, 58)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnCancelar.Location = New System.Drawing.Point(347, 239)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(150, 58)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grbAcceso
        '
        Me.grbAcceso.Controls.Add(Me.txtContrasena)
        Me.grbAcceso.Controls.Add(Me.lblNombreUser)
        Me.grbAcceso.Controls.Add(Me.txtNombreUser)
        Me.grbAcceso.Controls.Add(Me.lblContrasena)
        Me.grbAcceso.Location = New System.Drawing.Point(61, 98)
        Me.grbAcceso.Name = "grbAcceso"
        Me.grbAcceso.Size = New System.Drawing.Size(510, 135)
        Me.grbAcceso.TabIndex = 11
        Me.grbAcceso.TabStop = False
        Me.grbAcceso.Text = "Acceso"
        '
        'txtContrasena
        '
        Me.txtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasena.Location = New System.Drawing.Point(253, 85)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(237, 29)
        Me.txtContrasena.TabIndex = 4
        '
        'lblNombreUser
        '
        Me.lblNombreUser.AutoSize = True
        Me.lblNombreUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreUser.Location = New System.Drawing.Point(17, 32)
        Me.lblNombreUser.Name = "lblNombreUser"
        Me.lblNombreUser.Size = New System.Drawing.Size(221, 25)
        Me.lblNombreUser.TabIndex = 1
        Me.lblNombreUser.Text = "Nombre de Usuario:"
        '
        'txtNombreUser
        '
        Me.txtNombreUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUser.Location = New System.Drawing.Point(253, 38)
        Me.txtNombreUser.Name = "txtNombreUser"
        Me.txtNombreUser.Size = New System.Drawing.Size(237, 29)
        Me.txtNombreUser.TabIndex = 3
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasena.Location = New System.Drawing.Point(17, 79)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(140, 25)
        Me.lblContrasena.TabIndex = 2
        Me.lblContrasena.Text = "Contraseña:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(201, 51)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(272, 25)
        Me.lblTitulo.TabIndex = 9
        Me.lblTitulo.Text = "Usuario de la Plataforma"
        '
        'frmAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(636, 450)
        Me.Controls.Add(Me.lnkRestablecer)
        Me.Controls.Add(Me.lnkRegistrarse)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grbAcceso)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmAcceso"
        Me.Text = "Acceso"
        Me.grbAcceso.ResumeLayout(False)
        Me.grbAcceso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lnkRestablecer As LinkLabel
    Private WithEvents lnkRegistrarse As LinkLabel
    Private WithEvents btnAceptar As Button
    Private WithEvents btnCancelar As Button
    Private WithEvents grbAcceso As GroupBox
    Private WithEvents txtContrasena As TextBox
    Private WithEvents lblNombreUser As Label
    Private WithEvents txtNombreUser As TextBox
    Private WithEvents lblContrasena As Label
    Private WithEvents lblTitulo As Label
End Class
