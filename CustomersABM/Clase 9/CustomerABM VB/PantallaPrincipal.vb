Imports System.Data.SqlClient
Public Class PantallaPrincipal
    Dim ar As String
    Dim conection As New SqlConnection("data source=" & CStr(Leerarchivo(ar)) & "; initial catalog=Northwind; integrated security=true")
    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" CompanyName LIKE '" & tBuscar.Text & "%' ")
    End Sub
    Sub buscar(ByVal condicion As String)
        Dim dataAdapter As New SqlDataAdapter("SELECT TOP (100) PERCENT ID, CompanyName, ContactName FROM Customers WHERE " & condicion & " ORDER BY ID", conection)
        Dim dataSet As New DataSet
        dataAdapter.Fill(dataSet, "Customer")
        If dataSet.Tables("Customer").Rows.Count = 0 Then

            Grilla.Visible = False
            Panel.Visible = False
            ID_Cliente.Visible = False
        Else
            Grilla.DataSource = dataSet.Tables("Customer")
            Grilla.Refresh()
            Grilla.Visible = True
            ID_Cliente.Visible = True
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        buscar(" CompanyName LIKE '" & tBuscar.Text & "%' ")
    End Sub

    Private Sub NuevoCustomer_Click(sender As Object, e As EventArgs) Handles NuevoCustomer.Click
        If SqlAccion("INSERT INTO Customers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax) VALUES ('', '','','','', '', '', '', '', '')") Then
            buscar(" CompanyName LIKE '' ")
            MsgBox("Se ha Creado el Nuevo Registro para el Customer que va a ingresar", MsgBoxStyle.Information, "Nuevo Cliente")
            Panel.Visible = True
            PanelBotones.Visible = True
            Panel.Refresh()
            Grilla.Visible = True
        End If
    End Sub

    Private Sub EliminarCustomer_Click(sender As Object, e As EventArgs) Handles EliminarCustomer.Click
        If MessageBox.Show("Está por eliminar definitivamente al Customer: " & TextBoxEmpresa.Text.Trim.ToUpper & ", ¿Está seguro?", "Eliminar Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
        If SqlAccion("DELETE FROM Customers  WHERE  ID=" & Val(ID_Cliente.Text)) = False Then
            MsgBox("Hubo un Error al intentar Borrar al Customer", MsgBoxStyle.Information, "Eliminar Customer")
        Else
            buscar(" id=" & Val(ID_Cliente.Text))
            MsgBox("El Customer fue ELIMINADO correctamente")
        End If
    End Sub
    Private Sub GuardarCambios_Click(sender As Object, e As EventArgs) Handles GuardarCambios.Click
        Dim errores As String = ""
        Dim enter As String = vbCrLf
        If TextBoxEmpresa.Text.Trim.Length < 3 Then
            errores &= "Debe completar el nombre de la empresa" & enter
        End If
        If TextBoxCustomer.Text.Trim.Length < 3 Then
            errores &= "Debe Completar el nombre completo del Customer" & enter
        End If
        If TextBoxDireccion.Text.Trim.Length < 3 Then
            errores &= "Debe Completar la dirección del Customer" & enter
        End If
        TextBoxTelefono.Text = Val(TextBoxTelefono.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", ""))
        If TextBoxTelefono.Text.Trim.Length < 4 Or TextBoxTelefono.Text.IndexOf("11111") > -1 Or TextBoxTelefono.Text.IndexOf("12345") > -1 Or TextBoxTelefono.Text.IndexOf("000000") > -1 Then
            errores &= "Por favor, complete el Numero de Telefono." & enter
        End If
        TextBoxFax.Text = Val(TextBoxFax.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "").Replace("-", ""))
        If TextBoxFax.Text.Trim.Length < 4 Or TextBoxFax.Text.IndexOf("11111") > -1 Or TextBoxFax.Text.IndexOf("12345") > -1 Or TextBoxFax.Text.IndexOf("000000") > -1 Then
            errores &= "Por favo, complete el Numero de Fax." & enter
        End If
        If errores.Length > 0 Then
            MsgBox("Se han encontrado errores, por favor vuelva a intentar:" & enter & enter & errores)
            Exit Sub
        End If
        If SqlAccion("UPDATE Customers SET CompanyName='" & TextBoxEmpresa.Text.Trim.ToUpper.Replace("'", "´") & "', ContactName='" & TextBoxCustomer.Text.Trim.ToUpper.Replace("'", "´") & "', ContactTitle='" & TextBoxCargo.Text.Trim.ToUpper.Replace("'", "´") & "', Address='" & TextBoxDireccion.Text.Trim.ToUpper.Replace("'", "´") & "', City='" & TextBoxCiudad.Text.Trim.ToUpper.Replace("'", "´") & "', Region='" & TextBoxLocalidad.Text.Trim.ToUpper.Replace("'", "´") & "', PostalCode='" & TextBoxCP.Text.Trim.ToUpper.Replace("'", "´") & "', Country='" & TextBoxPais.Text.Trim.ToUpper.Replace("'", "´") & "', Phone=" & Val(TextBoxTelefono.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", Fax=" & Val(TextBoxFax.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & " WHERE ID=" & Vnum(ID_Cliente.Text)) = True Then
            MsgBox("Se ha actualizado correctamente los datos.", MsgBoxStyle.Information, "Editar Customer")

            buscar(" ID=" & Vnum(ID_Cliente.Text))
        Else
            MsgBox("Se Produjo un Error al Querer Guardar los Datos del Customer, reintente nuevamente", MsgBoxStyle.Information, "Editar Customer")
        End If
    End Sub

    Private Sub gridClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        FilaTabla(e)
    End Sub
    Private Sub gridClientes_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla.RowEnter
        FilaTabla(e)
    End Sub
    Sub FilaTabla(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(Grilla.Rows(fila).Cells(0).Value) Then
            ID_Cliente.Text = "0"
            Panel.Visible = False
            PanelBotones.Visible = False
            Exit Sub
        Else
            tfila = Grilla.Rows(fila).Cells(0).Value
            ID_Cliente.Text = tfila.ToString()
            CargarCamposCustomers()
        End If
    End Sub
    Sub CargarCamposCustomers()
        If Val(ID_Cliente.Text) = 0 Then
            Panel.Visible = False
            PanelBotones.Visible = False
            Exit Sub
        Else
            Panel.Visible = True
            PanelBotones.Visible = True
            Dim da As New SqlDataAdapter("SELECT UPPER(LTRIM(RTRIM(ISNULL(CompanyName,'****')))) AS CompanyName, UPPER(LTRIM(RTRIM(ISNULL(ContactName,'****')))) AS ContactName, LTRIM(RTRIM(ISNULL(ContactTitle,''))) AS ContactTitle , LTRIM(RTRIM(ISNULL(Address,''))) AS Address, LTRIM(RTRIM(ISNULL(Region,''))) AS Region , LTRIM(RTRIM(ISNULL(PostalCode,''))) AS PostalCode, LTRIM(RTRIM(ISNULL(City,''))) AS City, LTRIM(RTRIM(ISNULL(Country,''))) AS Country, LTRIM(RTRIM(ISNULL(Phone,''))) AS Phone, LTRIM(RTRIM(ISNULL(Fax,''))) AS Fax FROM Customers WHERE ID=" & Val(ID_Cliente.Text), conection)
            Dim ds As New DataSet
            da.Fill(ds, "Customer")
            TextBoxEmpresa.Text = ds.Tables("Customer").Rows(0)("CompanyName")
            TextBoxCustomer.Text = ds.Tables("Customer").Rows(0)("ContactName")
            TextBoxCargo.Text = ds.Tables("Customer").Rows(0)("ContactTitle")
            TextBoxDireccion.Text = ds.Tables("Customer").Rows(0)("Address")
            TextBoxLocalidad.Text = ds.Tables("Customer").Rows(0)("Region")
            TextBoxCP.Text = ds.Tables("Customer").Rows(0)("PostalCode")
            TextBoxCiudad.Text = ds.Tables("Customer").Rows(0)("City")
            TextBoxPais.Text = ds.Tables("Customer").Rows(0)("Country")
            TextBoxTelefono.Text = ds.Tables("Customer").Rows(0)("Phone")
            TextBoxFax.Text = ds.Tables("Customer").Rows(0)("Fax")
        End If
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Hide()
            InicioSesion.Show()
        End If
    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDelSistemaToolStripMenuItem.Click
        If MessageBox.Show("¿Está seguro que desea salir del sistema?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            End
        End If
    End Sub
End Class