<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiempo
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.btnMostrarHora = New System.Windows.Forms.Button()
        Me.btnDetenerTiempo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmrHora
        '
        Me.tmrHora.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hora:"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(228, 25)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(101, 31)
        Me.lblHora.TabIndex = 1
        Me.lblHora.Text = "Label2"
        '
        'btnMostrarHora
        '
        Me.btnMostrarHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarHora.Location = New System.Drawing.Point(20, 90)
        Me.btnMostrarHora.Name = "btnMostrarHora"
        Me.btnMostrarHora.Size = New System.Drawing.Size(199, 101)
        Me.btnMostrarHora.TabIndex = 2
        Me.btnMostrarHora.Text = "Mostrar Hora"
        Me.btnMostrarHora.UseVisualStyleBackColor = True
        '
        'btnDetenerTiempo
        '
        Me.btnDetenerTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetenerTiempo.Location = New System.Drawing.Point(255, 90)
        Me.btnDetenerTiempo.Name = "btnDetenerTiempo"
        Me.btnDetenerTiempo.Size = New System.Drawing.Size(199, 101)
        Me.btnDetenerTiempo.TabIndex = 3
        Me.btnDetenerTiempo.Text = "Detener Tiempo"
        Me.btnDetenerTiempo.UseVisualStyleBackColor = True
        '
        'frmTiempo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(485, 217)
        Me.Controls.Add(Me.btnDetenerTiempo)
        Me.Controls.Add(Me.btnMostrarHora)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTiempo"
        Me.Text = "frmTiempo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrHora As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents btnMostrarHora As Button
    Friend WithEvents btnDetenerTiempo As Button
End Class
