'Nancy Díaz, Corina Ruíz, Jeshua Arias, James Pico, Maicol Cuervo, Alejandro Espino
Public Class frmTienda
    Dim a, b As Integer
    'metodo para manejar los valores del ComboBox
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        'si se elige la opción con azuca, se muestra cuantas cucharas de azucar se desean
        If cbTipo.Text = "Con Azucar" Then
            nudAzucar.Visible = True
            lblAzucar.Visible = True
            'de otro modo no se muestran
        Else
            nudAzucar.Visible = False
            lblAzucar.Visible = False
        End If
    End Sub
    'para manejar la salida a través del botón salir y se muestra un mensaje antes de salir
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        MsgBox("Hasta Luego!")
        End
    End Sub
    'para manejar la limpiaza de los controles
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtTotal.Text = ""
        nudAzucar.Value = 1
        txtTotal.Visible = False
        nudAzucar.Visible = False
        lblTotal.Visible = False
        nudVasos.Value = 1
        lblAzucar.Visible = False
    End Sub
    'metodo para asignar la cantidad de vasos que se eligieron del control NumericUpDown
    Private Sub NudVasos_ValueChanged(sender As Object, e As EventArgs) Handles nudVasos.ValueChanged
        a = nudVasos.Value
    End Sub
    'metodo para asignar la cantidad de azucar que se eligieron del control NumericUpDown
    Private Sub NudAzucar_ValueChanged(sender As Object, e As EventArgs) Handles nudAzucar.ValueChanged
        b = nudAzucar.Value
    End Sub
    'metodo para manejar la comprar
    Private Sub BtnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        txtTotal.Visible = True 'muestra el mensaje de cuanto se debe pagar
        lblTotal.Visible = True
        Dim total As Double
        Dim pago As String
        total = (a * 0.45)
        If cbTipo.Text = "Con Azucar" Then
            total = total + (b * 0.05) * a 'si es con azucar se le cobra de mas por cada cucharada de azucar agregada
            txtTotal.Text = total
        Else
            txtTotal.Text = total
        End If
        pago = InputBox("Introduzca el monto a pagar", "Cuenta a Pagar", , 2, 2)
        If CInt(pago) > total Then 'si el valor a pagar es mayor a la deuda, se muestra el mensaje
            MsgBox("Gracias Por su compra! Su monto devuelto es: " & (CInt(pago) - total))
        Else 'de otro modo muestra otro mensaje
            MsgBox("Debe pagar con un monto mayor a su deuda!")
        End If

    End Sub
End Class
