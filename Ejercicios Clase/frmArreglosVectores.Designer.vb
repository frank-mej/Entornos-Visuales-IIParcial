<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArreglosVectores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbPrecios = New System.Windows.Forms.ComboBox()
        Me.btnGenerarPrecio = New System.Windows.Forms.Button()
        Me.cmbComputadoras = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCompus = New System.Windows.Forms.ComboBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.cmbPrecios)
        Me.GroupBox1.Controls.Add(Me.btnGenerarPrecio)
        Me.GroupBox1.Controls.Add(Me.cmbComputadoras)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidimensionales"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(124, 172)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cmbPrecios
        '
        Me.cmbPrecios.FormattingEnabled = True
        Me.cmbPrecios.Location = New System.Drawing.Point(194, 86)
        Me.cmbPrecios.Name = "cmbPrecios"
        Me.cmbPrecios.Size = New System.Drawing.Size(121, 21)
        Me.cmbPrecios.TabIndex = 3
        '
        'btnGenerarPrecio
        '
        Me.btnGenerarPrecio.Location = New System.Drawing.Point(219, 32)
        Me.btnGenerarPrecio.Name = "btnGenerarPrecio"
        Me.btnGenerarPrecio.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerarPrecio.TabIndex = 2
        Me.btnGenerarPrecio.Text = "Precio"
        Me.btnGenerarPrecio.UseVisualStyleBackColor = True
        '
        'cmbComputadoras
        '
        Me.cmbComputadoras.FormattingEnabled = True
        Me.cmbComputadoras.Location = New System.Drawing.Point(6, 86)
        Me.cmbComputadoras.Name = "cmbComputadoras"
        Me.cmbComputadoras.Size = New System.Drawing.Size(121, 21)
        Me.cmbComputadoras.TabIndex = 1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(25, 32)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 39)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Computador"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbCompus)
        Me.GroupBox2.Controls.Add(Me.btnSolicitar)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(428, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 280)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Multidimensionales"
        '
        'cmbCompus
        '
        Me.cmbCompus.FormattingEnabled = True
        Me.cmbCompus.Location = New System.Drawing.Point(78, 145)
        Me.cmbCompus.Name = "cmbCompus"
        Me.cmbCompus.Size = New System.Drawing.Size(121, 21)
        Me.cmbCompus.TabIndex = 4
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(100, 102)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 23)
        Me.btnSolicitar.TabIndex = 2
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(171, 42)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad Computadoras"
        '
        'frmArreglosVectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmArreglosVectores"
        Me.Text = "frmArreglosVectores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cmbPrecios As ComboBox
    Friend WithEvents btnGenerarPrecio As Button
    Friend WithEvents cmbComputadoras As ComboBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbCompus As ComboBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label1 As Label
End Class
