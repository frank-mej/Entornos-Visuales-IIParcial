'Imports System.Runtime.InteropServices
'Public Class Form1
'   <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
'Private Shared Sub ReleaseCapture()
'End Sub
'
'<'DllImport("user32.DLL", EntryPoint:="SendMessage")>
'  Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
'End ' Sub
'
'
'P 'rivate Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
'End
'
'E 'nd Sub
'
'P 'rivate Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
'btnMaximizar.Visible = False
'btnRestaurar.Visible = True
'Me.WindowState = FormWindowState.Maximized
'End Sub
''
'P 'rivate Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
'Me.WindowState = FormWindowState.Minimized
'End Sub
'
'P 'rivate Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
'btnRestaurar.Visible = False
'btnMaximizar.Visible = True
'Me.WindowState = FormWindowState.Normal
'End Sub
'
'P 'rivate Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
'ReleaseCapture()
'SendMessage(Me.Handle, &H112&, &HF012&, 0)
'End Sub
''
'P 'rivate Sub timerOcultarMenu_Tick(sender As Object, e As EventArgs) Handles timerOcultarMenu.Tick
'If PanelMenu.Width <= 60 Then
'Me.timerOcultarMenu.Enabled = False
'Else
'Me.PanelMenu.Width = PanelMenu.Width - 20
'End If
'End Sub
'
'P 'rivate Sub timerMostrarMenu_Tick(sender As Object, e As EventArgs) Handles timerMostrarMenu.Tick
'If PanelMenu.Width >= 210 Then
'Me.timerMostrarMenu.Enabled = False
'Else
'Me.PanelMenu.Width = PanelMenu.Width + 20
'End If
'End Sub
'
'P 'rivate Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
'If panelMenu.Width >= 165 Then
'timerOcultarMenu.Enabled = True
'ElseIf panelMenu.Width >= 45 Then
'timerMostrarMenu.Enabled = True
'End If
'End Sub
'
'P 'rivate Sub abrirFormulario(ByVal formHijo As Object)
'If panelForms.Controls.Count > 0 Then
'Me.panelForms.Controls.RemoveAt(0)
'End If
'Dim frm As Form = TryCast(formHijo, Form)
'frm.TopLevel = False
'frm.Dock = DockStyle.Fill
'Me.panelForms.Controls.Add(frm)
'Me.panelForms.Tag = frm
'frm.Show()
'
'E 'nd Sub
'
'P 'rivate Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
'abrirFormulario(frmProductos)
'End Sub
'E 'nd Class
