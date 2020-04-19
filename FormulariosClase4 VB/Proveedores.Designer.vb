<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.bVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bVolver
        '
        Me.bVolver.Location = New System.Drawing.Point(255, 260)
        Me.bVolver.Name = "bVolver"
        Me.bVolver.Size = New System.Drawing.Size(253, 23)
        Me.bVolver.TabIndex = 0
        Me.bVolver.Text = "Volver"
        Me.bVolver.UseVisualStyleBackColor = True
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.bVolver)
        Me.Name = "Proveedores"
        Me.Text = "Proveedores"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bVolver As Button
End Class
