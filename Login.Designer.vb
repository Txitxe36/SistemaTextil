<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlLogo = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMax = New FontAwesome.Sharp.IconButton()
        Me.btnMin = New FontAwesome.Sharp.IconButton()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.tPassword = New System.Windows.Forms.TextBox()
        Me.tUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlLogo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlLogo
        '
        Me.pnlLogo.Controls.Add(Me.Panel2)
        Me.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLogo.Location = New System.Drawing.Point(0, 0)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(1214, 134)
        Me.pnlLogo.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.Controls.Add(Me.btnMax)
        Me.Panel2.Controls.Add(Me.btnMin)
        Me.Panel2.Controls.Add(Me.picLogo)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1214, 134)
        Me.Panel2.TabIndex = 27
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackColor = System.Drawing.Color.Transparent
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMax.IconColor = System.Drawing.Color.Cyan
        Me.btnMax.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMax.IconSize = 35
        Me.btnMax.Location = New System.Drawing.Point(1159, 3)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(52, 35)
        Me.btnMax.TabIndex = 23
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMin.IconColor = System.Drawing.Color.Cyan
        Me.btnMin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMin.IconSize = 35
        Me.btnMin.Location = New System.Drawing.Point(1105, 3)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(36, 35)
        Me.btnMin.TabIndex = 22
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.picLogo.Image = Global.NuevoSistema.My.Resources.Resources.estampadotextil
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(201, 134)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(334, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(771, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "EN ESTAMPADO TEXTIL LE OFRECEMOS ESTAMPADOS DE SERIGRAFIA TEXTIL"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(506, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(374, 41)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = """ESTAMPADO TEXTIL"""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(394, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(559, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "DE LA MÁS ALTA CALIDAD Y A UN PRECIO INIGUALABLE."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.LawnGreen
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel1.Location = New System.Drawing.Point(545, 104)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(262, 24)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://estampadotextil.com.ar/"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.IconPictureBox2)
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Controls.Add(Me.tPassword)
        Me.Panel1.Controls.Add(Me.tUsuario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Location = New System.Drawing.Point(323, 237)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 336)
        Me.Panel1.TabIndex = 26
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.Black
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt
        Me.IconPictureBox2.IconColor = System.Drawing.Color.Black
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 57
        Me.IconPictureBox2.Location = New System.Drawing.Point(75, 136)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(57, 62)
        Me.IconPictureBox2.TabIndex = 15
        Me.IconPictureBox2.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Black
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Black
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 58
        Me.IconPictureBox1.Location = New System.Drawing.Point(74, 48)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(58, 61)
        Me.IconPictureBox1.TabIndex = 14
        Me.IconPictureBox1.TabStop = False
        '
        'tPassword
        '
        Me.tPassword.BackColor = System.Drawing.Color.White
        Me.tPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPassword.Location = New System.Drawing.Point(188, 162)
        Me.tPassword.Name = "tPassword"
        Me.tPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tPassword.Size = New System.Drawing.Size(213, 26)
        Me.tPassword.TabIndex = 11
        '
        'tUsuario
        '
        Me.tUsuario.BackColor = System.Drawing.Color.White
        Me.tUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tUsuario.Location = New System.Drawing.Point(188, 74)
        Me.tUsuario.Name = "tUsuario"
        Me.tUsuario.Size = New System.Drawing.Size(213, 26)
        Me.tUsuario.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(149, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(295, 30)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "INGRESE SU PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(159, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 30)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "INGRESE SU USUARIO"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(322, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 46)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(74, 258)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(122, 46)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "INGRESAR"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(328, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(526, 56)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "ACCESO AL SISTEMA"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(323, 570)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(532, 10)
        Me.Panel3.TabIndex = 27
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel4.Location = New System.Drawing.Point(845, 237)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 343)
        Me.Panel4.TabIndex = 28
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.NuevoSistema.My.Resources.Resources.tallerdeserigrafía
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1214, 621)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlLogo)
        Me.MinimumSize = New System.Drawing.Size(1230, 660)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnlLogo.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tPassword As TextBox
    Friend WithEvents tUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnMax As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMin As FontAwesome.Sharp.IconButton
End Class
