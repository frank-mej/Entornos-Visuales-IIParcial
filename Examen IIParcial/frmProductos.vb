Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class frmProductos

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
            adaptador = New SqlDataAdapter("select * from factura.producto", cn)
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
            llenarDataGridVentas(dtgProductos)
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
        txtIdProducto.Clear()
        txtNombreProducto.Clear()
        txtDescripcion.Clear()
        desactivacion()
        txtIdProducto.Enabled = True
    End Sub

    Function validarVenta(ByVal codigo As String) As Boolean
        Dim ventas As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from factura.producto where idProducto= '" + codigo + "'", conexion)
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
            If (validarVenta(txtIdProducto.Text) = False) Then
                Dim agregar As String = "insert into factura.producto values(" + txtIdProducto.Text + ",'" + txtNombreProducto.Text + "','" + txtDescripcion.Text + "')"
                If (Insertar(agregar)) Then
                    MessageBox.Show("El producto se guardo exitosamente", "Ingreso de Producto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    llenarDataGridVentas(dtgProductos)
                    limpiar()
                    conexion.Close()

                Else
                    MessageBox.Show("Error al agregar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    conexion.Close()
                End If
            Else
                MsgBox("Este producto ya fue creado", vbObjectError)

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
        Consulta("select * from factura.producto where idProducto= '" + txtIdProducto.Text + "'", "factura.producto")
        dtgProductos.DataSource = ds.Tables("factura.producto")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Consulta("select * from factura.producto where idProducto= '" + txtIdProducto.Text + "'", "factura.producto")

        If (validarVenta(txtIdProducto.Text) = False) Then
            MessageBox.Show("Error en la busqueda, El producto no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            busquedaDeDatosVentas()

        End If
    End Sub

    Private Sub dtgProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProductos.CellContentClick
        Try
            Dim dthClente As DataGridViewRow = dtgProductos.Rows(e.RowIndex)
            txtIdProducto.Text = dthClente.Cells(0).Value.ToString()
            txtNombreProducto.Text = dthClente.Cells(1).Value.ToString()
            txtDescripcion.Text = dthClente.Cells(2).Value.ToString()
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
            txtIdProducto.Enabled = False
            Dim modificar As String =
           "idProducto='" + txtIdProducto.Text + "', nombreProducto='" + txtNombreProducto.Text + "', descripcion='" + txtDescripcion.Text + "'"
            If (modifica("factura.producto", modificar, " idProducto=" + txtIdProducto.Text)) Then
                MessageBox.Show("Actualizado")
                llenarDataGridVentas(dtgProductos)
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
            If (eliminar("factura.producto", "idProducto=" + txtIdProducto.Text)) Then
                MessageBox.Show("Producto eliminado correctamente")
                llenarDataGridVentas(dtgProductos)

            Else
                MessageBox.Show("Error al eliminar")
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
            conexion.Close()
        End Try
    End Sub

    Private Sub txtIdCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtIdProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion2.SetError(sender, "")
        Else
            Me.ErrorValidacion2.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtNombreCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion2.SetError(sender, "")
        Else
            Me.ErrorValidacion2.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion2.SetError(sender, "")
        Else
            Me.ErrorValidacion2.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtIdProducto_MouseHover(sender As Object, e As EventArgs) Handles txtIdProducto.MouseHover
        ToolTip.SetToolTip(txtIdProducto, "Ingrese el id del producto")
        ToolTip.ToolTipTitle = "Id Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombreProducto_MouseHover(sender As Object, e As EventArgs) Handles txtNombreProducto.MouseHover
        ToolTip.SetToolTip(txtNombreProducto, "Ingrese el nombre del producto")
        ToolTip.ToolTipTitle = "Producto"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip.SetToolTip(txtDescripcion, "Ingrese la descripcion")
        ToolTip.ToolTipTitle = "Descripcion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class