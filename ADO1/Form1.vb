Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("data source=DESKTOP-CK9FJ93\SQLEXPRESS; initial catalog=Northwind; integrated security=true")

    Sub Buscar()
        Dim da As New SqlDataAdapter("select * from factura where nfact=" & CStr(Int(Val(NFact.Text))).Trim, con)
        Dim ds As New DataSet
        da.Fill(ds, "Facturas")
        Grilla.DataSource = ds.Tables("Facturas")
        Grilla.Refresh()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bBuscar_Click(sender As Object, e As EventArgs) Handles bBuscar.Click
        Buscar()
    End Sub
End Class
