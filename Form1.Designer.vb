<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlMenuLateral = New System.Windows.Forms.Panel()
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.btnSalir = New FontAwesome.Sharp.IconButton()
        Me.btnProveedores = New FontAwesome.Sharp.IconButton()
        Me.btnClientes = New FontAwesome.Sharp.IconButton()
        Me.btnUsuarios = New FontAwesome.Sharp.IconButton()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlBarraTitulo = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.btnMax = New FontAwesome.Sharp.IconButton()
        Me.btnMin = New FontAwesome.Sharp.IconButton()
        Me.lblTituloForm = New System.Windows.Forms.Label()
        Me.IconFormActual = New FontAwesome.Sharp.IconPictureBox()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.pnlEscritorio = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.lblAPE = New System.Windows.Forms.Label()
        Me.lblNOM = New System.Windows.Forms.Label()
        Me.pnlMenuLateral.SuspendLayout()
        Me.pnlLogo.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBarraTitulo.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconFormActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEscritorio.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMenuLateral
        '
        Me.pnlMenuLateral.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlMenuLateral.Controls.Add(Me.btnVolver)
        Me.pnlMenuLateral.Controls.Add(Me.btnSalir)
        Me.pnlMenuLateral.Controls.Add(Me.btnProveedores)
        Me.pnlMenuLateral.Controls.Add(Me.btnClientes)
        Me.pnlMenuLateral.Controls.Add(Me.btnUsuarios)
        Me.pnlMenuLateral.Controls.Add(Me.pnlLogo)
        Me.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenuLateral.Name = "pnlMenuLateral"
        Me.pnlMenuLateral.Size = New System.Drawing.Size(220, 621)
        Me.pnlMenuLateral.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.ForeColor = System.Drawing.Color.Silver
        Me.btnVolver.IconChar = FontAwesome.Sharp.IconChar.UndoAlt
        Me.btnVolver.IconColor = System.Drawing.Color.Silver
        Me.btnVolver.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(0, 501)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnVolver.Size = New System.Drawing.Size(220, 60)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "Volver al Login"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.Silver
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed
        Me.btnSalir.IconColor = System.Drawing.Color.Silver
        Me.btnSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 561)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSalir.Size = New System.Drawing.Size(220, 60)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnProveedores
        '
        Me.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.ForeColor = System.Drawing.Color.Silver
        Me.btnProveedores.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry
        Me.btnProveedores.IconColor = System.Drawing.Color.Silver
        Me.btnProveedores.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.Location = New System.Drawing.Point(0, 260)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnProveedores.Size = New System.Drawing.Size(220, 60)
        Me.btnProveedores.TabIndex = 4
        Me.btnProveedores.Text = "Proveedores"
        Me.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProveedores.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.ForeColor = System.Drawing.Color.Silver
        Me.btnClientes.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        Me.btnClientes.IconColor = System.Drawing.Color.Silver
        Me.btnClientes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(0, 200)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnClientes.Size = New System.Drawing.Size(220, 60)
        Me.btnClientes.TabIndex = 3
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.ForeColor = System.Drawing.Color.Silver
        Me.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserTie
        Me.btnUsuarios.IconColor = System.Drawing.Color.Silver
        Me.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 140)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnUsuarios.Size = New System.Drawing.Size(220, 60)
        Me.btnUsuarios.TabIndex = 2
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.picLogo)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(220, 140)
        Me.pnlLogo.TabIndex = 0
        '
        'picLogo
        '
        Me.picLogo.Image = Global.NuevoSistema.My.Resources.Resources.estampadotextil
        Me.picLogo.Location = New System.Drawing.Point(24, 25)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(166, 90)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'pnlBarraTitulo
        '
        Me.pnlBarraTitulo.BackColor = System.Drawing.Color.MidnightBlue
        Me.pnlBarraTitulo.Controls.Add(Me.Label6)
        Me.pnlBarraTitulo.Controls.Add(Me.lblUser)
        Me.pnlBarraTitulo.Controls.Add(Me.IconPictureBox1)
        Me.pnlBarraTitulo.Controls.Add(Me.btnMax)
        Me.pnlBarraTitulo.Controls.Add(Me.btnMin)
        Me.pnlBarraTitulo.Controls.Add(Me.lblTituloForm)
        Me.pnlBarraTitulo.Controls.Add(Me.IconFormActual)
        Me.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraTitulo.Location = New System.Drawing.Point(220, 0)
        Me.pnlBarraTitulo.Name = "pnlBarraTitulo"
        Me.pnlBarraTitulo.Size = New System.Drawing.Size(994, 59)
        Me.pnlBarraTitulo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(285, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(374, 41)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = """ESTAMPADO TEXTIL"""
        '
        'lblUser
        '
        Me.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUser.AutoSize = True
        Me.lblUser.ForeColor = System.Drawing.Color.Cyan
        Me.lblUser.Location = New System.Drawing.Point(719, 27)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(69, 16)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "USUARIO"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Silver
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Silver
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 46
        Me.IconPictureBox1.Location = New System.Drawing.Point(816, 13)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(54, 46)
        Me.IconPictureBox1.TabIndex = 4
        Me.IconPictureBox1.TabStop = False
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMax.IconColor = System.Drawing.Color.Cyan
        Me.btnMax.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMax.IconSize = 35
        Me.btnMax.Location = New System.Drawing.Point(930, 18)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(52, 35)
        Me.btnMax.TabIndex = 3
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMin.IconColor = System.Drawing.Color.Cyan
        Me.btnMin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMin.IconSize = 35
        Me.btnMin.Location = New System.Drawing.Point(876, 18)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(36, 35)
        Me.btnMin.TabIndex = 2
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'lblTituloForm
        '
        Me.lblTituloForm.AutoSize = True
        Me.lblTituloForm.ForeColor = System.Drawing.Color.Cyan
        Me.lblTituloForm.Location = New System.Drawing.Point(71, 25)
        Me.lblTituloForm.Name = "lblTituloForm"
        Me.lblTituloForm.Size = New System.Drawing.Size(120, 16)
        Me.lblTituloForm.TabIndex = 1
        Me.lblTituloForm.Text = "MENÚ PRINCIPAL"
        '
        'IconFormActual
        '
        Me.IconFormActual.BackColor = System.Drawing.Color.MidnightBlue
        Me.IconFormActual.ForeColor = System.Drawing.Color.Silver
        Me.IconFormActual.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconFormActual.IconColor = System.Drawing.Color.Silver
        Me.IconFormActual.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconFormActual.IconSize = 46
        Me.IconFormActual.Location = New System.Drawing.Point(18, 13)
        Me.IconFormActual.Name = "IconFormActual"
        Me.IconFormActual.Size = New System.Drawing.Size(47, 46)
        Me.IconFormActual.TabIndex = 0
        Me.IconFormActual.TabStop = False
        '
        'FechaHora
        '
        Me.FechaHora.Enabled = True
        '
        'pnlEscritorio
        '
        Me.pnlEscritorio.BackColor = System.Drawing.Color.DarkGray
        Me.pnlEscritorio.BackgroundImage = Global.NuevoSistema.My.Resources.Resources.fondoazul2
        Me.pnlEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlEscritorio.Controls.Add(Me.lblFecha)
        Me.pnlEscritorio.Controls.Add(Me.lblHora)
        Me.pnlEscritorio.Controls.Add(Me.PictureBox1)
        Me.pnlEscritorio.Controls.Add(Me.lblBienvenida)
        Me.pnlEscritorio.Controls.Add(Me.lblAPE)
        Me.pnlEscritorio.Controls.Add(Me.lblNOM)
        Me.pnlEscritorio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEscritorio.Location = New System.Drawing.Point(220, 59)
        Me.pnlEscritorio.MinimumSize = New System.Drawing.Size(894, 604)
        Me.pnlEscritorio.Name = "pnlEscritorio"
        Me.pnlEscritorio.Size = New System.Drawing.Size(994, 604)
        Me.pnlEscritorio.TabIndex = 2
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.DarkGray
        Me.lblFecha.Location = New System.Drawing.Point(187, 473)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(218, 56)
        Me.lblFecha.TabIndex = 29
        Me.lblFecha.Text = "lblFecha"
        '
        'lblHora
        '
        Me.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Arial", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Gray
        Me.lblHora.Location = New System.Drawing.Point(352, 398)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(253, 75)
        Me.lblHora.TabIndex = 28
        Me.lblHora.Text = "lblHora"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.NuevoSistema.My.Resources.Resources.estampadotextil
        Me.PictureBox1.Location = New System.Drawing.Point(292, 141)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(391, 263)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'lblBienvenida
        '
        Me.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenida.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.ForeColor = System.Drawing.Color.White
        Me.lblBienvenida.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblBienvenida.Location = New System.Drawing.Point(320, 3)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(352, 59)
        Me.lblBienvenida.TabIndex = 24
        Me.lblBienvenida.Text = "BIENVENIDO"
        Me.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAPE
        '
        Me.lblAPE.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAPE.BackColor = System.Drawing.Color.Transparent
        Me.lblAPE.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPE.ForeColor = System.Drawing.Color.White
        Me.lblAPE.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblAPE.Location = New System.Drawing.Point(475, 69)
        Me.lblAPE.Name = "lblAPE"
        Me.lblAPE.Size = New System.Drawing.Size(377, 58)
        Me.lblAPE.TabIndex = 26
        Me.lblAPE.Text = "BIENVENIDO"
        Me.lblAPE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNOM
        '
        Me.lblNOM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNOM.BackColor = System.Drawing.Color.Transparent
        Me.lblNOM.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNOM.ForeColor = System.Drawing.Color.White
        Me.lblNOM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNOM.Location = New System.Drawing.Point(74, 69)
        Me.lblNOM.Name = "lblNOM"
        Me.lblNOM.Size = New System.Drawing.Size(382, 60)
        Me.lblNOM.TabIndex = 25
        Me.lblNOM.Text = "BIENVENIDO"
        Me.lblNOM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 621)
        Me.Controls.Add(Me.pnlEscritorio)
        Me.Controls.Add(Me.pnlBarraTitulo)
        Me.Controls.Add(Me.pnlMenuLateral)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1230, 660)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlMenuLateral.ResumeLayout(False)
        Me.pnlLogo.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBarraTitulo.ResumeLayout(False)
        Me.pnlBarraTitulo.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconFormActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEscritorio.ResumeLayout(False)
        Me.pnlEscritorio.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenuLateral As Panel
    Friend WithEvents btnProveedores As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClientes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUsuarios As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlBarraTitulo As Panel
    Friend WithEvents lblTituloForm As Label
    Friend WithEvents IconFormActual As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pnlEscritorio As Panel
    Friend WithEvents btnMax As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMin As FontAwesome.Sharp.IconButton
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents lblAPE As Label
    Friend WithEvents lblNOM As Label
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FechaHora As Timer
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
    Friend WithEvents lblUser As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label6 As Label
End Class
