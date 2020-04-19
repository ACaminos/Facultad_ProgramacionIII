Public Class Form1
    Private Sub bSalir_Click(sender As Object, e As EventArgs) Handles bSalir.Click
        If MessageBox.Show("¿Está seguro que desea salir?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub bClientes_Click(sender As Object, e As EventArgs) Handles bClientes.Click
        Dim cli As New Clientes
        cli.ShowDialog()
        cli.BackColor = Color.Red
        cli.ShowDialog()
    End Sub

    Private Sub bProveedores_Click(sender As Object, e As EventArgs) Handles bProveedores.Click
        Dim Pro As New Proveedores
        Pro.ShowDialog()
        Pro.BackColor = Color.Green
        Pro.ShowDialog()
    End Sub

    Private Sub bListados_Click(sender As Object, e As EventArgs) Handles bListados.Click
        Dim List As New Listados
        List.ShowDialog()
        List.BackColor = Color.Blue
        List.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim cli As New Clientes
        cli.ShowDialog()
        cli.BackColor = Color.Red
        cli.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim Pro As New Proveedores
        Pro.ShowDialog()
        Pro.BackColor = Color.Green
        Pro.ShowDialog()
    End Sub

    Private Sub ListadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadosToolStripMenuItem.Click
        Dim List As New Listados
        List.ShowDialog()
        List.BackColor = Color.Blue
        List.ShowDialog()
    End Sub
End Class