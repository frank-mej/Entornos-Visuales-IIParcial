Imports System.Runtime.InteropServices
Public Class MenuTienda
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub panelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles panelSuperior.Paint

    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        'Me.WindowState = FormWindowState.Maximized
        'Cambia el tamaño del formulario sin ocultar la barra
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        'El formulario se ubique en toda la pantalla
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click

        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        ' Me.WindowState = FormWindowState.Normal

        Me.Size = New System.Drawing.Size(900, 500)
        'Centrar el formulario en la pantalla
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub

    Private Sub panelSuperior_MouseHover(sender As Object, e As EventArgs) Handles panelSuperior.MouseHover
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelLateral.Width = 165 Then
            TimerOcultar.Enabled = True
        ElseIf PanelLateral.Width = 45 Then
            TimerMostrar.Enabled = True
        End If
    End Sub

    Private Sub TimerMostrar_Tick(sender As Object, e As EventArgs) Handles TimerMostrar.Tick
        If PanelLateral.Width >= 165 Then
            Me.TimerMostrar.Enabled = False
        Else
            Me.PanelLateral.Width = PanelLateral.Width + 20
        End If

    End Sub

    Private Sub TimerOcultar_Tick(sender As Object, e As EventArgs) Handles TimerOcultar.Tick
        If PanelLateral.Width <= 45 Then
            Me.TimerOcultar.Enabled = False
        Else
            Me.PanelLateral.Width = PanelLateral.Width - 20
        End If

    End Sub
    Private Sub abrirFormulario(ByVal formHijo As Object)
        If PanelForms.Controls.Count > 0 Then
            Me.PanelForms.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelForms.Controls.Add(frm)
        Me.PanelForms.Tag = frm
        frm.Show()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        abrirFormulario(frmClientes)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        abrirFormulario(Form1)
    End Sub

    Private Sub PanelLateral_Paint(sender As Object, e As PaintEventArgs) Handles PanelLateral.Paint

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        abrirFormulario(frmProductos)
    End Sub

    Private Sub PanelForms_Paint(sender As Object, e As PaintEventArgs) Handles PanelForms.Paint

    End Sub
End Class