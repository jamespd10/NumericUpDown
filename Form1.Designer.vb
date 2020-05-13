<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTienda
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
        Me.lblAzucar = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblVasos = New System.Windows.Forms.Label()
        Me.nudAzucar = New System.Windows.Forms.NumericUpDown()
        Me.nudVasos = New System.Windows.Forms.NumericUpDown()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        CType(Me.nudAzucar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAzucar
        '
        Me.lblAzucar.AutoSize = True
        Me.lblAzucar.Location = New System.Drawing.Point(132, 144)
        Me.lblAzucar.Name = "lblAzucar"
        Me.lblAzucar.Size = New System.Drawing.Size(100, 13)
        Me.lblAzucar.TabIndex = 1
        Me.lblAzucar.Text = "Cantidad de Azucar"
        Me.lblAzucar.Visible = False
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Sin Azucar", "Con Azucar"})
        Me.cbTipo.Location = New System.Drawing.Point(262, 76)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cbTipo.TabIndex = 2
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(132, 79)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(92, 13)
        Me.lblTipo.TabIndex = 3
        Me.lblTipo.Text = "Tipo de Limonada"
        '
        'lblVasos
        '
        Me.lblVasos.AutoSize = True
        Me.lblVasos.Location = New System.Drawing.Point(132, 113)
        Me.lblVasos.Name = "lblVasos"
        Me.lblVasos.Size = New System.Drawing.Size(96, 13)
        Me.lblVasos.TabIndex = 4
        Me.lblVasos.Text = "Cantidad de Vasos"
        '
        'nudAzucar
        '
        Me.nudAzucar.Location = New System.Drawing.Point(262, 142)
        Me.nudAzucar.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudAzucar.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAzucar.Name = "nudAzucar"
        Me.nudAzucar.Size = New System.Drawing.Size(121, 20)
        Me.nudAzucar.TabIndex = 5
        Me.nudAzucar.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAzucar.Visible = False
        '
        'nudVasos
        '
        Me.nudVasos.Location = New System.Drawing.Point(262, 111)
        Me.nudVasos.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudVasos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudVasos.Name = "nudVasos"
        Me.nudVasos.Size = New System.Drawing.Size(121, 20)
        Me.nudVasos.TabIndex = 6
        Me.nudVasos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(206, 39)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(104, 13)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Tienda de Limonada"
        '
        'btnComprar
        '
        Me.btnComprar.Location = New System.Drawing.Point(135, 211)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(75, 23)
        Me.btnComprar.TabIndex = 8
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(308, 211)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(132, 174)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(70, 13)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total a pagar"
        Me.lblTotal.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(262, 171)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(121, 20)
        Me.txtTotal.TabIndex = 11
        Me.txtTotal.Visible = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(221, 211)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 308)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.nudVasos)
        Me.Controls.Add(Me.nudAzucar)
        Me.Controls.Add(Me.lblVasos)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.lblAzucar)
        Me.Name = "frmTienda"
        Me.Text = "Tienda"
        CType(Me.nudAzucar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAzucar As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblVasos As Label
    Friend WithEvents nudAzucar As NumericUpDown
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnComprar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnLimpiar As Button
    Private WithEvents nudVasos As NumericUpDown
End Class
