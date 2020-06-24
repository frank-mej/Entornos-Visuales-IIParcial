Public Class frmBolsaSolidaria

    Private Sub desactivarMando()
        chkBolsaBasica.Enabled = True
        chkBolsaRegular.Enabled = False
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim cantPersona As Integer
        cantPersona = Val(txtCantFamiliar.Text)

        If cantPersona > 0 And cantPersona < 4 Then
            chkBolsaRegular.Enabled = False
        End If

        If cantPersona > 3 Then
            chkBolsaBasica.Enabled = False
        End If

    End Sub

    Private Sub limpiar()
        txtCantFamiliar.Clear()
        txtIdentidad.Clear()
        txtNombreCompleto.Clear()
        chkBolsaBasica.Checked = False
        chkBolsaRegular.Checked = False
        chkExtremaPobreza.Checked = False
        chkPobreza.Checked = False
    End Sub

End Class