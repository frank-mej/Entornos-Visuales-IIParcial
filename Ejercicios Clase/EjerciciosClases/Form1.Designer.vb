<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panelSuperior = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.panelForms = New System.Windows.Forms.Panel()
        Me.timerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.timerMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.panelSuperior.SuspendLayout()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelForms.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSuperior
        '
        Me.panelSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.panelSuperior.Controls.Add(Me.btnRestaurar)
        Me.panelSuperior.Controls.Add(Me.btnMinimizar)
        Me.panelSuperior.Controls.Add(Me.btnMaximizar)
        Me.panelSuperior.Controls.Add(Me.btnCerrar)
        Me.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperior.Name = "panelSuperior"
        Me.panelSuperior.Size = New System.Drawing.Size(1000, 38)
        Me.panelSuperior.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = CType(resources.GetObject("btnRestaurar.Image"), System.Drawing.Image)
        Me.btnRestaurar.Location = New System.Drawing.Point(924, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(39, 38)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaurar.TabIndex = 1
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(885, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(39, 38)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 1
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(924, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(39, 38)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(960, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(39, 38)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.Button2)
        Me.panelMenu.Controls.Add(Me.Button1)
        Me.panelMenu.Controls.Add(Me.btnProductos)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 38)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(165, 462)
        Me.panelMenu.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(4, 134)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 24)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Programa3"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(4, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 24)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Programa2"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(0, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(35, 30)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.TabStop = False
        '
        'btnProductos
        '
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(4, 95)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(167, 24)
        Me.btnProductos.TabIndex = 0
        Me.btnProductos.Text = "Pograma1"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'panelForms
        '
        Me.panelForms.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.panelForms.Controls.Add(Me.btnMenu)
        Me.panelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelForms.Location = New System.Drawing.Point(165, 38)
        Me.panelForms.Name = "panelForms"
        Me.panelForms.Size = New System.Drawing.Size(835, 462)
        Me.panelForms.TabIndex = 2
        '
        'timerOcultarMenu
        '
        '
        'timerMostrarMenu
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.panelForms)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelSuperior.ResumeLayout(False)
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenu.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelForms.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSuperior As Panel
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelForms As Panel
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnProductos As Button
    Friend WithEvents timerOcultarMenu As Timer
    Friend WithEvents timerMostrarMenu As Timer
    Friend WithEvents btnMenu As PictureBox

    Private Sub panelMenu_Paint(sender As Object, e As PaintEventArgs) Handles panelMenu.Paint

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
