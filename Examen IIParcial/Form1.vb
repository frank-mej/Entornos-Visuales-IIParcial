Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form1

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
            adaptador = New SqlDataAdapter("select ve.idVenta, ve.fechaVenta, ve.precio, ve.cantidad, pro.nombreProducto, pro.descripcion, cli.nombre, cli.apellido, cli.direccion from factura.Venta as ve inner join factura.producto as pro on ve.idproducto = pro.idProducto inner join factura.cliente as cli on cli.idCliente = ve.idCliente", cn)
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
            llenarDataGridVentas(dtgVentas)
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
        txtCantidad.Clear()
        txtCodigo.Clear()
        txtCodigoCliente.Clear()
        txtCodigoProducto.Clear()
        txtPrecio.Clear()
        mskFecha.Clear()
        desactivacion()
        txtCodigo.Enabled = True
    End Sub

    Function validarVenta(ByVal codigo As String) As Boolean
        Dim ventas As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from factura.Venta where idVenta= '" + codigo + "'", conexion)
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
            If (validarVenta(txtCodigo.Text) = False) Then
                Dim agregar As String = "insert into factura.Venta values(" + txtCodigo.Text + ",'" + mskFecha.Text + "','" + txtPrecio.Text + "','" + txtCantidad.Text + "','" + txtCodigoCliente.Text + "','" + txtCodigoProducto.Text + "')"
                If (Insertar(agregar)) Then
                    MessageBox.Show("Venta guardada exitosamente", "Ingreso de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    llenarDataGridVentas(dtgVentas)
                    limpiar()
                    conexion.Close()

                Else
                    MessageBox.Show("Error al agregar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    conexion.Close()
                End If
            Else
                MsgBox("Esta venta ya fue realizada con el mismo codigo", vbObjectError)

            End If
        Catch ex As Exception
            MessageBox.Show("No se lleno por: " + ex.ToString)
        Finally
            conexion.Close()
        End Try




        Dim valor As Int16
        If txtCantidad.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtCantidad.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtCantidad.Text)
            If valor = 0 Then
                MsgBox("Ingrese una edad valida", vbInformation)
            ElseIf valor < 1 Then
                MsgBox("Ingrese una edad valida", vbInformation)
            End If
        End If

        If txtPrecio.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtPrecio.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtPrecio.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtPrecio.Text)
            If valor = 0 Then
                MsgBox("Ingrese una edad valida", vbInformation)
            ElseIf valor < 1 Then
                MsgBox("Ingrese una edad valida", vbInformation)
            End If
        End If
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Private Sub busquedaDeDatosVentas()
        Consulta("select * from factura.Venta where idVenta= '" + txtCodigo.Text + "'", "factura.Venta")
        dtgVentas.DataSource = ds.Tables("factura.Venta")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Consulta("select * from factura.Venta where idVenta= '" + txtCodigo.Text + "'", "factura.Venta")

        If (validarVenta(txtCodigo.Text) = False) Then
            MessageBox.Show("Error en la busqueda, la venta no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            busquedaDeDatosVentas()

        End If
    End Sub

    Private Sub dtgVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVentas.CellContentClick
        Try
            Dim dthVentasRealizadas As DataGridViewRow = dtgVentas.Rows(e.RowIndex)
            txtCodigo.Text = dthVentasRealizadas.Cells(0).Value.ToString()
            mskFecha.Text = dthVentasRealizadas.Cells(1).Value.ToString()
            txtCantidad.Text = dthVentasRealizadas.Cells(2).Value.ToString()
            txtPrecio.Text = dthVentasRealizadas.Cells(3).Value.ToString()
            txtCodigoCliente.Text = dthVentasRealizadas.Cells(4).Value.ToString()
            txtCodigoProducto.Text = dthVentasRealizadas.Cells(5).Value.ToString()
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
            txtCodigo.Enabled = False
            Dim modificar As String =
           "idVenta='" + txtCodigo.Text + "', fechaVenta='" + mskFecha.Text + "', precio='" + txtPrecio.Text + "', cantidad='" + txtCantidad.Text + "', idCliente='" + txtCodigoCliente.Text + "', idProducto='" + txtCodigoProducto.Text + "'"
            If (modifica("factura.Venta", modificar, " idVenta=" + txtCodigo.Text)) Then
                MessageBox.Show("Actualizado")
                llenarDataGridVentas(dtgVentas)
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
            MessageBox.Show("Elimine la venta")
        End Try
    End Function

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (eliminar("factura.Venta", "idVenta=" + txtCodigo.Text)) Then
                MessageBox.Show("Registro de venta eliminado correctamente")
                llenarDataGridVentas(dtgVentas)

            Else
                MessageBox.Show("Error al eliminar")
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
            conexion.Close()
        End Try
    End Sub



    Private Sub txtCodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrimerApellido_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtSegundoApellido_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub MaskedTextBox1_Validating(sender As Object, e As CancelEventArgs) Handles mskFecha.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCodigoCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigoCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCodigoProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigoProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCodigo_MouseHover(sender As Object, e As EventArgs) Handles txtCodigo.MouseHover
        ToolTip.SetToolTip(txtCodigo, "Ingrese el codigo")
        ToolTip.ToolTipTitle = "Codigo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mskFecha_MouseHover(sender As Object, e As EventArgs) Handles mskFecha.MouseHover
        ToolTip.SetToolTip(mskFecha, "Ingrese fecha del producto")
        ToolTip.ToolTipTitle = "Fecha"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        ToolTip.SetToolTip(txtPrecio, "Ingrese el precio del producto")
        ToolTip.ToolTipTitle = "Precio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        ToolTip.SetToolTip(txtCantidad, "Ingrese la cantidad del producto")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCodigoCliente_MouseHover(sender As Object, e As EventArgs) Handles txtCodigoCliente.MouseHover
        ToolTip.SetToolTip(txtCodigoCliente, "Ingrese el codigo del cliente")
        ToolTip.ToolTipTitle = "Codigo Cliente"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCodigoProducto_MouseHover(sender As Object, e As EventArgs) Handles txtCodigoProducto.MouseHover
        ToolTip.SetToolTip(txtCodigoProducto, "Ingrese el codigo del producto")
        ToolTip.ToolTipTitle = "Codigo Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


End Class
