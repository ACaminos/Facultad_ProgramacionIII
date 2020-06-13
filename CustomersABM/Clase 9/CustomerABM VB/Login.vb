Imports System.IO
Imports System.Data.SqlClient
Public Class Login
    Dim ar As String
    Dim conection As New SqlConnection("data source=" & CStr(Leerarchivo(ar)) & "; initial catalog=Northwind; integrated security=true")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Me.Hide()
        InicioSesion.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bSesion.Click
        iniciarSesion()
    End Sub

    Sub iniciarSesion() 'Se encarga de corroborar que el nombre de usuario y la clave sean los que estan en SQL, si existe da mensaje de bienvenida y el ingreso a la pantalla principal, caso contrario mensaje de Acceso denegado y NO avanza a la pantalla principal
        Dim sql As String
        TextBoxUsuario.Text = TextBoxUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", "").ToLower()
        sql = "SELECT * FROM NuevoUsuario WHERE Usuario='" & TextBoxUsuario.Text & "'AND Clave='" & TextBoxPassword.Text & "'"
        Dim cmd As New SqlCommand(sql, conection)
        Dim dataReader As SqlDataReader
        conection.Open()
        dataReader = cmd.ExecuteReader
        If dataReader.Read = True Then
            MessageBox.Show("Bienvenido al sistema de gestion", "Acceso Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            PantallaPrincipal.Show()
        Else
            MessageBox.Show("El usuario o la contraseña es incorrecta", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxUsuario.Text = ""
            TextBoxPassword.Text = ""
        End If
        conection.Close()

    End Sub
End Class