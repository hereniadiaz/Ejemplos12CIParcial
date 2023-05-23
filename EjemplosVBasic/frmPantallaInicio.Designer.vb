<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPantallaInicio
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
        Me.label2 = New System.Windows.Forms.Label()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Peru
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(450, 327)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(214, 42)
        Me.label2.TabIndex = 20
        Me.label2.Text = "Bienvenido"
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(42, 290)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(622, 25)
        Me.progressBar1.TabIndex = 19
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(575, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(132, 25)
        Me.label1.TabIndex = 18
        Me.label1.Text = "Versión 1.1"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = Global.EjemplosVBasic.My.Resources.Resources.FOTO_COMUNICADO_HIS
        Me.pictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(709, 372)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 17
        Me.pictureBox1.TabStop = False
        '
        'frmPantallaInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(731, 392)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPantallaInicio"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents progressBar1 As ProgressBar
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
End Class
