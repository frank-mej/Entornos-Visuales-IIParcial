Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmClientes

    Public cn As SqlConnection
    Public comando As SqlCommand
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-8VGV6BL;Initial Catalog=Tienda;Integrated Security=True")
    Public dr As SqlDataReader
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter

    Private Sub abrirConexion()
        Try
            cn = New SqlConnection("Data Source=DESKTOP-8VGV6BL;Initial Catalog=Tienda;Integrated Security=True")
            cn.Open()
        Catch ex As Exception
            MessageBox.Show("Nose pudo abrir" + ex.ToString)
            cn.Close()
        End Try
    End Sub

    Private Sub llenarDataGridVentas(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select * from factura.cliente", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            abrirConexion()
            llenarDataGridVentas(dtgClientes)
            conexion.Close()
            desactivacion()
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub desactivacion()
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub activacion()
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub limpiar()
        txtApellido.Clear()
        txtDireccion.Clear()
        txtNombreCliente.Clear()
        txtIdCliente.Clear()
        desactivacion()
        txtIdCliente.Enabled = True
    End Sub

    Function validarVenta(ByVal codigo As String) As Boolean
        Dim ventas As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from factura.cliente where idCliente= '" + codigo + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                ventas = True
                dr.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try

        Return ventas
    End Function

    Function Insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery
        conexion.Close()

        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If (validarVenta(txtIdCliente.Text) = False) Then
                Dim agregar As String = "insert into factura.cliente values(" + txtIdCliente.Text + ",'" + txtNombreCliente.Text + "','" + txtApellido.Text + "','" + txtDireccion.Text + "')"
                If (Insertar(agregar)) Then
                    MessageBox.Show("El cliente se guardo exitosamente", "Ingreso de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    llenarDataGridVentas(dtgClientes)
                    limpiar()
                    conexion.Close()

                Else
                    MessageBox.Show("Error al agregar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    conexion.Close()
                End If
            Else
                MsgBox("Este cliente ya fue creado", vbObjectError)

            End If
        Catch ex As Exception
            MessageBox.Show("No se lleno por: " + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Private Sub busquedaDeDatosVentas()
        Consulta("select * from factura.cliente where idCliente= '" + txtIdCliente.Text + "'", "factura.cliente")
        dtgClientes.DataSource = ds.Tables("factura.cliente")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Consulta("select * from factura.cliente where idCliente= '" + txtIdCliente.Text + "'", "factura.cliente")

        If (validarVenta(txtIdCliente.Text) = False) Then
            MessageBox.Show("Error en la busqueda, El cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            busquedaDeDatosVentas()

        End If
    End Sub





    Private Sub dtgClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgClientes.CellContentClick
        Try
            Dim dthClente As DataGridViewRow = dtgClientes.Rows(e.RowIndex)
            txtIdCliente.Text = dthClente.Cells(0).Value.ToString()
            txtNombreCliente.Text = dthClente.Cells(1).Value.ToString()
            txtApellido.Text = dthClente.Cells(2).Value.ToString()
            txtDireccion.Text = dthClente.Cells(3).Value.ToString()
            btnEliminar.Enabled = True
            btnModificar.Enabled = True

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    Function modifica(ByVal tabla, ByVal campos, ByVal condicion)
        Try
            conexion.Open()
            Dim modificarV As String = "update " + tabla + " set " + campos + " where " + condicion
            comando = New SqlCommand(modificarV, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)

        End Try

    End Function

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            txtIdCliente.Enabled = False
            Dim modificar As String =
           "idCliente='" + txtIdCliente.Text + "', nombre='" + txtNombreCliente.Text + "', apellido='" + txtApellido.Text + "', direccion='" + txtDireccion.Text + "'"
            If (modifica("factura.cliente", modificar, " idCliente=" + txtIdCliente.Text)) Then
                MessageBox.Show("Actualizado")
                llenarDataGridVentas(dtgClientes)
                conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub

    Function eliminar(ByVal tabla, ByVal condicion)
        Try
            conexion.Open()
            Dim elimina As String = "delete from " + tabla + " where " + condicion
            comando = New SqlCommand(elimina, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MessageBox.Show("Elimine el Cliente")
        End Try
    End Function

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (eliminar("factura.cliente", "idCliente=" + txtIdCliente.Text)) Then
                MessageBox.Show("Cliente eliminado correctamente")
                llenarDataGridVentas(dtgClientes)

            Else
                MessageBox.Show("Error al eliminar")
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
            conexion.Close()
        End Try
    End Sub

    Private Sub txtIdCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtIdCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion3.SetError(sender, "")
        Else
            Me.ErrorValidacion3.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombreCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion3.SetError(sender, "")
        Else
            Me.ErrorValidacion3.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion3.SetError(sender, "")
        Else
            Me.ErrorValidacion3.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion3.SetError(sender, "")
        Else
            Me.ErrorValidacion3.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdCliente_MouseHover(sender As Object, e As EventArgs) Handles txtIdCliente.MouseHover
        ToolTip.SetToolTip(txtIdCliente, "Ingrese el id del cliente")
        ToolTip.ToolTipTitle = "Id Cliente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombreCliente_MouseHover(sender As Object, e As EventArgs) Handles txtNombreCliente.MouseHover
        ToolTip.SetToolTip(txtNombreCliente, "Ingrese el nombre del cliente")
        ToolTip.ToolTipTitle = "Nombre Cliente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtApellido_MouseHover(sender As Object, e As EventArgs) Handles txtApellido.MouseHover
        ToolTip.SetToolTip(txtApellido, "Ingrese el apellido")
        ToolTip.ToolTipTitle = "Apellido"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDireccion_MouseHover(sender As Object, e As EventArgs) Handles txtDireccion.MouseHover
        ToolTip.SetToolTip(txtDireccion, "Ingrese la direccion del cliente")
        ToolTip.ToolTipTitle = "Direccion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


End Class