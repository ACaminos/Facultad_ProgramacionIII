<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cubilete = New System.Windows.Forms.PictureBox()
        Me.quintoDado = New System.Windows.Forms.PictureBox()
        Me.cuartoDado = New System.Windows.Forms.PictureBox()
        Me.tercerDado = New System.Windows.Forms.PictureBox()
        Me.segundoDado = New System.Windows.Forms.PictureBox()
        Me.primerDado = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.cubilete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quintoDado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cuartoDado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tercerDado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.segundoDado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.primerDado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cubilete
        '
        Me.cubilete.BackColor = System.Drawing.Color.Transparent
        Me.cubilete.Location = New System.Drawing.Point(474, 12)
        Me.cubilete.Name = "cubilete"
        Me.cubilete.Size = New System.Drawing.Size(300, 258)
        Me.cubilete.TabIndex = 1
        Me.cubilete.TabStop = False
        '
        'quintoDado
        '
        Me.quintoDado.BackgroundImage = Global.JuegoDadosClase5_VB.My.Resources.Resources.dado5
        Me.quintoDado.Location = New System.Drawing.Point(36, 135)
        Me.quintoDado.Name = "quintoDado"
        Me.quintoDado.Size = New System.Drawing.Size(94, 95)
        Me.quintoDado.TabIndex = 3
        Me.quintoDado.TabStop = False
        '
        'cuartoDado
        '
        Me.cuartoDado.BackgroundImage = Global.JuegoDadosClase5_VB.My.Resources.Resources.dado4
        Me.cuartoDado.Location = New System.Drawing.Point(410, 362)
        Me.cuartoDado.Name = "cuartoDado"
        Me.cuartoDado.Size = New System.Drawing.Size(94, 95)
        Me.cuartoDado.TabIndex = 4
        Me.cuartoDado.TabStop = False
        '
        'tercerDado
        '
        Me.tercerDado.BackgroundImage = Global.JuegoDadosClase5_VB.My.Resources.Resources.dado3
        Me.tercerDado.Location = New System.Drawing.Point(287, 73)
        Me.tercerDado.Name = "tercerDado"
        Me.tercerDado.Size = New System.Drawing.Size(94, 95)
        Me.tercerDado.TabIndex = 5
        Me.tercerDado.TabStop = False
        '
        'segundoDado
        '
        Me.segundoDado.BackgroundImage = Global.JuegoDadosClase5_VB.My.Resources.Resources.dado2
        Me.segundoDado.Location = New System.Drawing.Point(75, 377)
        Me.segundoDado.Name = "segundoDado"
        Me.segundoDado.Size = New System.Drawing.Size(94, 95)
        Me.segundoDado.TabIndex = 6
        Me.segundoDado.TabStop = False
        '
        'primerDado
        '
        Me.primerDado.BackgroundImage = Global.JuegoDadosClase5_VB.My.Resources.Resources.dado1
        Me.primerDado.Location = New System.Drawing.Point(189, 216)
        Me.primerDado.Name = "primerDado"
        Me.primerDado.Size = New System.Drawing.Size(94, 95)
        Me.primerDado.TabIndex = 7
        Me.primerDado.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.primerDado)
        Me.Controls.Add(Me.segundoDado)
        Me.Controls.Add(Me.tercerDado)
        Me.Controls.Add(Me.cuartoDado)
        Me.Controls.Add(Me.quintoDado)
        Me.Controls.Add(Me.cubilete)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apretá el cubilete para tirar los dados"
        CType(Me.cubilete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quintoDado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cuartoDado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tercerDado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.segundoDado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.primerDado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cubilete As PictureBox
    Friend WithEvents quintoDado As PictureBox
    Friend WithEvents cuartoDado As PictureBox
    Friend WithEvents tercerDado As PictureBox
    Friend WithEvents segundoDado As PictureBox
    Friend WithEvents primerDado As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
