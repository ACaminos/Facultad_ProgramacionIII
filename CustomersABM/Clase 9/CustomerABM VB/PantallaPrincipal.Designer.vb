<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCargo = New System.Windows.Forms.TextBox()
        Me.TextBoxLocalidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxCP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxFax = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxPais = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxCiudad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCustomer = New System.Windows.Forms.TextBox()
        Me.TextBoxEmpresa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GuardarCambios = New System.Windows.Forms.Button()
        Me.NuevoCustomer = New System.Windows.Forms.Button()
        Me.EliminarCustomer = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.tBuscar = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ID_Cliente = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        Me.Panel.SuspendLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.Label2)
        Me.Panel.Controls.Add(Me.TextBoxCargo)
        Me.Panel.Controls.Add(Me.TextBoxLocalidad)
        Me.Panel.Controls.Add(Me.Label10)
        Me.Panel.Controls.Add(Me.TextBoxCP)
        Me.Panel.Controls.Add(Me.Label9)
        Me.Panel.Controls.Add(Me.Label8)
        Me.Panel.Controls.Add(Me.TextBoxFax)
        Me.Panel.Controls.Add(Me.Label7)
        Me.Panel.Controls.Add(Me.TextBoxTelefono)
        Me.Panel.Controls.Add(Me.Label6)
        Me.Panel.Controls.Add(Me.TextBoxPais)
        Me.Panel.Controls.Add(Me.Label5)
        Me.Panel.Controls.Add(Me.TextBoxCiudad)
        Me.Panel.Controls.Add(Me.Label4)
        Me.Panel.Controls.Add(Me.TextBoxDireccion)
        Me.Panel.Controls.Add(Me.Label3)
        Me.Panel.Controls.Add(Me.TextBoxCustomer)
        Me.Panel.Controls.Add(Me.TextBoxEmpresa)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Location = New System.Drawing.Point(12, 59)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(343, 298)
        Me.Panel.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cargo"
        '
        'TextBoxCargo
        '
        Me.TextBoxCargo.Location = New System.Drawing.Point(102, 75)
        Me.TextBoxCargo.Name = "TextBoxCargo"
        Me.TextBoxCargo.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxCargo.TabIndex = 20
        '
        'TextBoxLocalidad
        '
        Me.TextBoxLocalidad.Location = New System.Drawing.Point(102, 135)
        Me.TextBoxLocalidad.Name = "TextBoxLocalidad"
        Me.TextBoxLocalidad.Size = New System.Drawing.Size(114, 20)
        Me.TextBoxLocalidad.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Empresa"
        '
        'TextBoxCP
        '
        Me.TextBoxCP.Location = New System.Drawing.Point(253, 135)
        Me.TextBoxCP.Name = "TextBoxCP"
        Me.TextBoxCP.Size = New System.Drawing.Size(73, 20)
        Me.TextBoxCP.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(222, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "C.P"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Fax"
        '
        'TextBoxFax
        '
        Me.TextBoxFax.Location = New System.Drawing.Point(102, 268)
        Me.TextBoxFax.Name = "TextBoxFax"
        Me.TextBoxFax.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxFax.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Teléfono"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(102, 238)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxTelefono.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "País"
        '
        'TextBoxPais
        '
        Me.TextBoxPais.Location = New System.Drawing.Point(102, 205)
        Me.TextBoxPais.Name = "TextBoxPais"
        Me.TextBoxPais.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxPais.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Ciudad"
        '
        'TextBoxCiudad
        '
        Me.TextBoxCiudad.Location = New System.Drawing.Point(102, 170)
        Me.TextBoxCiudad.Name = "TextBoxCiudad"
        Me.TextBoxCiudad.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxCiudad.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Localidad"
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Location = New System.Drawing.Point(102, 101)
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxDireccion.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dirección"
        '
        'TextBoxCustomer
        '
        Me.TextBoxCustomer.Location = New System.Drawing.Point(122, 41)
        Me.TextBoxCustomer.Name = "TextBoxCustomer"
        Me.TextBoxCustomer.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxCustomer.TabIndex = 2
        '
        'TextBoxEmpresa
        '
        Me.TextBoxEmpresa.Location = New System.Drawing.Point(102, 13)
        Me.TextBoxEmpresa.Name = "TextBoxEmpresa"
        Me.TextBoxEmpresa.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxEmpresa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre completo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del Customer"
        '
        'GuardarCambios
        '
        Me.GuardarCambios.Location = New System.Drawing.Point(16, 3)
        Me.GuardarCambios.Name = "GuardarCambios"
        Me.GuardarCambios.Size = New System.Drawing.Size(75, 69)
        Me.GuardarCambios.TabIndex = 1
        Me.GuardarCambios.Text = "Guardar datos"
        Me.GuardarCambios.UseVisualStyleBackColor = True
        '
        'NuevoCustomer
        '
        Me.NuevoCustomer.Location = New System.Drawing.Point(136, 4)
        Me.NuevoCustomer.Name = "NuevoCustomer"
        Me.NuevoCustomer.Size = New System.Drawing.Size(75, 69)
        Me.NuevoCustomer.TabIndex = 2
        Me.NuevoCustomer.Text = "Nuevo Customer"
        Me.NuevoCustomer.UseVisualStyleBackColor = True
        '
        'EliminarCustomer
        '
        Me.EliminarCustomer.Location = New System.Drawing.Point(253, 3)
        Me.EliminarCustomer.Name = "EliminarCustomer"
        Me.EliminarCustomer.Size = New System.Drawing.Size(75, 69)
        Me.EliminarCustomer.TabIndex = 3
        Me.EliminarCustomer.Text = "Eliminar Customer"
        Me.EliminarCustomer.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Location = New System.Drawing.Point(408, 59)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(380, 373)
        Me.Grilla.TabIndex = 4
        '
        'tBuscar
        '
        Me.tBuscar.BackColor = System.Drawing.Color.Silver
        Me.tBuscar.Location = New System.Drawing.Point(13, 27)
        Me.tBuscar.Name = "tBuscar"
        Me.tBuscar.Size = New System.Drawing.Size(625, 20)
        Me.tBuscar.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(645, 27)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 20)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Búsqueda"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ID_Cliente
        '
        Me.ID_Cliente.AutoSize = True
        Me.ID_Cliente.Location = New System.Drawing.Point(774, 61)
        Me.ID_Cliente.Name = "ID_Cliente"
        Me.ID_Cliente.Size = New System.Drawing.Size(13, 13)
        Me.ID_Cliente.TabIndex = 7
        Me.ID_Cliente.Text = "0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesiónToolStripMenuItem, Me.SalirDelSistemaToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del sistema"
        '
        'PanelBotones
        '
        Me.PanelBotones.Controls.Add(Me.EliminarCustomer)
        Me.PanelBotones.Controls.Add(Me.NuevoCustomer)
        Me.PanelBotones.Controls.Add(Me.GuardarCambios)
        Me.PanelBotones.Location = New System.Drawing.Point(12, 364)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(343, 76)
        Me.PanelBotones.TabIndex = 9
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 452)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelBotones)
        Me.Controls.Add(Me.ID_Cliente)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.tBuscar)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PantallaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxFax As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPais As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCiudad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCustomer As TextBox
    Friend WithEvents TextBoxEmpresa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GuardarCambios As Button
    Friend WithEvents NuevoCustomer As Button
    Friend WithEvents EliminarCustomer As Button
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents TextBoxCP As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tBuscar As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents ID_Cliente As Label
    Friend WithEvents TextBoxLocalidad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCargo As TextBox
    Friend WithEvents PanelBotones As Panel
End Class
