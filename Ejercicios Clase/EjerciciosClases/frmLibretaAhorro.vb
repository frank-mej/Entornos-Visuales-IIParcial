Public Class frmLibretaAhorro
    Private monto As Double
    'Procedimientos
    Private Sub activarControles()
        txtIdentidad.Enabled = False
        txtMonto.Enabled = False
        btnAperturarCuenta.Enabled = False
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
    End Sub

    Private Sub desactivarControles()
        txtIdentidad.Enabled = True
        txtMonto.Enabled = True
        btnAperturarCuenta.Enabled = True
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False
    End Sub

    Private Sub limpiar()
        desactivarControles()
        txtIdentidad.Clear()
        txtSaldo.Clear()
        txtMonto.Clear()
        lstDepositos.Items.Clear()
        lstRetiros.Items.Clear()
    End Sub

    Private Sub frmLibretaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub mostrarSaldo()
        txtSaldo.Text = monto
    End Sub

    Private Sub btnAperturarCuenta_Click(sender As Object, e As EventArgs) Handles btnAperturarCuenta.Click
        Dim clientes As String
        If Val(txtIdentidad.Text) <> 208200100471 Then
            MessageBox.Show("Identidad Incorrecta", "Ingresar cliente correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        monto = Val(txtMonto.Text)
        If (monto > 0) Then
            activarControles()
        Else
            MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a " & mensaje, "Operación")
        mostrarSaldo()
        Return cantidad
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double
        deposito = leer("Depositar")
        monto += deposito
        lstDepositos.Items.Add(deposito)
        mostrarSaldo()
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retiro As Double
        retiro = leer("Retirar")
        If (retiro > monto) Then
            MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            monto -= retiro
            lstRetiros.Items.Add(retiro)
            mostrarSaldo()
        End If
    End Sub
End Class