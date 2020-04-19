Public Class Listados
    Private Sub bVolver_Click(sender As Object, e As EventArgs) Handles bVolver.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        If MessageBox.Show("¿Estás seguro que deseas salir?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) Then End
    End Sub
End Class