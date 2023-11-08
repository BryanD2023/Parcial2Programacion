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
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.cbMunicipio = New System.Windows.Forms.ComboBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(142, 101)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(100, 20)
        Me.tbApellido.TabIndex = 0
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(142, 45)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbNombre.TabIndex = 1
        '
        'cbMunicipio
        '
        Me.cbMunicipio.FormattingEnabled = True
        Me.cbMunicipio.Items.AddRange(New Object() {"Olucuilta", "Cabañas", "Chalatenango"})
        Me.cbMunicipio.Location = New System.Drawing.Point(142, 198)
        Me.cbMunicipio.Name = "cbMunicipio"
        Me.cbMunicipio.Size = New System.Drawing.Size(121, 21)
        Me.cbMunicipio.TabIndex = 2
        Me.cbMunicipio.Text = "Seleccione..."
        '
        'cbDepartamento
        '
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Items.AddRange(New Object() {"La Paz", "San Salvador", "San Vicente", "La Union"})
        Me.cbDepartamento.Location = New System.Drawing.Point(142, 152)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(121, 21)
        Me.cbDepartamento.TabIndex = 3
        Me.cbDepartamento.Text = "Seleccione..."
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(155, 253)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 4
        Me.btAceptar.Text = "Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apellido:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 318)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.cbDepartamento)
        Me.Controls.Add(Me.cbMunicipio)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbApellido)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents cbMunicipio As ComboBox
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents btAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
