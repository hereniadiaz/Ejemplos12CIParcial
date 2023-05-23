
Public Class frmAcceso
    Function Validar_Contrasena()
        If txtNombreUser.Text = "Supervisor" And txtContrasena.Text = "456" Then
            MsgBox("Bienvenido", , "Medykalsystem23")
            Me.Hide()
            frmMenuPrincipal.Show()
            txtNombreUser.BackColor = Color.White
            txtContrasena.BackColor = Color.White
        Else
            MsgBox("Usuario y contraseña incorrectos", , "Medykalsystem23")
            txtNombreUser.Text = ""
            txtContrasena.Text = ""
            txtNombreUser.Focus()
            txtNombreUser.BackColor = Color.Violet
            txtContrasena.BackColor = Color.Violet
            'comentarios  se usa comilla simple
        End If
    End Function
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Validar_Contrasena()
    End Sub
    Private Sub txtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            Validar_Contrasena()
        End If
    End Sub
End Class