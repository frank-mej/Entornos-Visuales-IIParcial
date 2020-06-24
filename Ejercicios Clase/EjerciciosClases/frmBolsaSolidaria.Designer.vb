<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBolsaSolidaria
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombreCompleto = New System.Windows.Forms.TextBox()
        Me.txtCantFamiliar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkExtremaPobreza = New System.Windows.Forms.CheckBox()
        Me.chkPobreza = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkBolsaRegular = New System.Windows.Forms.CheckBox()
        Me.chkBolsaBasica = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Integrantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoCanasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bolsa Solidaria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese Identidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Completo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cant. Integrantes"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(119, 30)
        Me.txtIdentidad.Mask = "0000000000000"
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(100, 20)
        Me.txtIdentidad.TabIndex = 4
        '
        'txtNombreCompleto
        '
        Me.txtNombreCompleto.Location = New System.Drawing.Point(119, 60)
        Me.txtNombreCompleto.Name = "txtNombreCompleto"
        Me.txtNombreCompleto.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreCompleto.TabIndex = 5
        '
        'txtCantFamiliar
        '
        Me.txtCantFamiliar.Location = New System.Drawing.Point(119, 96)
        Me.txtCantFamiliar.Name = "txtCantFamiliar"
        Me.txtCantFamiliar.Size = New System.Drawing.Size(100, 20)
        Me.txtCantFamiliar.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkExtremaPobreza)
        Me.GroupBox1.Controls.Add(Me.chkPobreza)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCantFamiliar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompleto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 255)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Familia"
        '
        'chkExtremaPobreza
        '
        Me.chkExtremaPobreza.AutoSize = True
        Me.chkExtremaPobreza.Location = New System.Drawing.Point(20, 215)
        Me.chkExtremaPobreza.Name = "chkExtremaPobreza"
        Me.chkExtremaPobreza.Size = New System.Drawing.Size(109, 17)
        Me.chkExtremaPobreza.TabIndex = 9
        Me.chkExtremaPobreza.Text = "Extrema Probreza"
        Me.chkExtremaPobreza.UseVisualStyleBackColor = True
        '
        'chkPobreza
        '
        Me.chkPobreza.AutoSize = True
        Me.chkPobreza.Location = New System.Drawing.Point(20, 179)
        Me.chkPobreza.Name = "chkPobreza"
        Me.chkPobreza.Size = New System.Drawing.Size(68, 17)
        Me.chkPobreza.TabIndex = 8
        Me.chkPobreza.Text = "Probreza"
        Me.chkPobreza.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Estado de la Familia"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnIngresar)
        Me.GroupBox2.Controls.Add(Me.chkBolsaRegular)
        Me.GroupBox2.Controls.Add(Me.chkBolsaBasica)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 322)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 120)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipos de Bolsa"
        '
        'chkBolsaRegular
        '
        Me.chkBolsaRegular.AutoSize = True
        Me.chkBolsaRegular.Location = New System.Drawing.Point(129, 40)
        Me.chkBolsaRegular.Name = "chkBolsaRegular"
        Me.chkBolsaRegular.Size = New System.Drawing.Size(92, 17)
        Me.chkBolsaRegular.TabIndex = 1
        Me.chkBolsaRegular.Text = "Bolsa Regular"
        Me.chkBolsaRegular.UseVisualStyleBackColor = True
        '
        'chkBolsaBasica
        '
        Me.chkBolsaBasica.AutoSize = True
        Me.chkBolsaBasica.Location = New System.Drawing.Point(16, 40)
        Me.chkBolsaBasica.Name = "chkBolsaBasica"
        Me.chkBolsaBasica.Size = New System.Drawing.Size(87, 17)
        Me.chkBolsaBasica.TabIndex = 0
        Me.chkBolsaBasica.Text = "Bolsa Basica"
        Me.chkBolsaBasica.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identidad, Me.Nombre, Me.Integrantes, Me.tipoCanasta})
        Me.DataGridView1.Location = New System.Drawing.Point(328, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(415, 223)
        Me.DataGridView1.TabIndex = 9
        '
        'Identidad
        '
        Me.Identidad.HeaderText = "Identidad"
        Me.Identidad.Name = "Identidad"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Integrantes
        '
        Me.Integrantes.HeaderText = "Integrantes"
        Me.Integrantes.Name = "Integrantes"
        '
        'tipoCanasta
        '
        Me.tipoCanasta.HeaderText = "tipoCanasta"
        Me.tipoCanasta.Name = "tipoCanasta"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(102, 91)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 10
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'frmBolsaSolidaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 454)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBolsaSolidaria"
        Me.Text = "frmBolsaSolidaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdentidad As MaskedTextBox
    Friend WithEvents txtNombreCompleto As TextBox
    Friend WithEvents txtCantFamiliar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkExtremaPobreza As CheckBox
    Friend WithEvents chkPobreza As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkBolsaRegular As CheckBox
    Friend WithEvents chkBolsaBasica As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Integrantes As DataGridViewTextBoxColumn
    Friend WithEvents tipoCanasta As DataGridViewTextBoxColumn
End Class
