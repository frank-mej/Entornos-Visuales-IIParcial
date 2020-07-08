Imports System.Data.SqlClient

Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-8VGV6BL;Initial Catalog=Tienda; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub



End Class
