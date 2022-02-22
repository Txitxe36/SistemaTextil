Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Form1

    Private btnActual As IconButton
    Private btnBordeIzq As Panel
    Private formHijoActual As Form

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        btnBordeIzq = New Panel
        btnBordeIzq.Size = New Size(7, 60)
        pnlMenuLateral.Controls.Add(btnBordeIzq)

        'formulario
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub

    Private Sub botonActivado(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            desactivarBoton()

            'boton
            btnActual = CType(senderBtn, IconButton)
            btnActual.BackColor = Color.FromArgb(37, 36, 81)
            btnActual.ForeColor = customColor
            btnActual.IconColor = customColor
            btnActual.TextAlign = ContentAlignment.MiddleCenter
            btnActual.ImageAlign = ContentAlignment.MiddleRight
            btnActual.TextImageRelation = TextImageRelation.TextBeforeImage

            'panel borde izquierdo del boton
            btnBordeIzq.BackColor = customColor
            btnBordeIzq.Location = New Point(0, btnActual.Location.Y)
            btnBordeIzq.Visible = True
            btnBordeIzq.BringToFront()

            'cambio del icono del form

            IconFormActual.IconChar = btnActual.IconChar
            IconFormActual.IconColor = customColor
        End If

    End Sub

    Private Sub desactivarBoton()
        If btnActual IsNot Nothing Then
            btnActual.BackColor = Color.MidnightBlue
            btnActual.ForeColor = Color.Silver
            btnActual.IconColor = Color.Silver
            btnActual.TextAlign = ContentAlignment.MiddleLeft
            btnActual.ImageAlign = ContentAlignment.MiddleLeft
            btnActual.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs)
        botonActivado(sender, Color.SeaGreen)
        abrirFormHijo(New Form1)
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        botonActivado(sender, Color.Aqua)
        abrirFormHijo(New Usuarios)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        botonActivado(sender, Color.Purple)
        abrirFormHijo(New Clientes)
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        botonActivado(sender, Color.Red)
        abrirFormHijo(New Proveedores)
    End Sub

    Private Sub abrirFormHijo(FormHijo As Form)
        If formHijoActual IsNot Nothing Then
            formHijoActual.Close()
        End If
        formHijoActual = FormHijo

        FormHijo.TopLevel = False
        FormHijo.FormBorderStyle = FormBorderStyle.None
        FormHijo.Dock = DockStyle.Fill
        pnlEscritorio.Controls.Add(FormHijo)
        pnlEscritorio.Tag = FormHijo
        FormHijo.BringToFront()
        FormHijo.Show()
        lblTituloForm.Text = FormHijo.Text
    End Sub

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click
        If formHijoActual IsNot Nothing Then
            formHijoActual.Close()
        End If
        reiniciar()
    End Sub

    Private Sub reiniciar()
        desactivarBoton()
        btnBordeIzq.Visible = False
        IconFormActual.IconChar = IconChar.Home
        IconFormActual.IconColor = Color.Cyan
        lblTituloForm.Text = "MENÚ PRINCIPAL"
    End Sub

    'arrastar formulario
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub Sendmessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    'que se pueda arrastar el form desde la barra de titulo
    Private Sub pnlBarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlBarraTitulo.MouseDown
        ReleaseCapture()
        Sendmessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    'quita los bordes del form
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable

        End If
    End Sub
    'boton maximizar
    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub
    'boton minimizar
    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        WindowState = FormWindowState.Minimized
    End Sub


    'cartel de bienvenida y nombre de usuario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNOM.Text = Module1.nom.Trim.ToUpper
        lblAPE.Text = Module1.ape.Trim.ToUpper
        lblUser.Text = Module1.nom.Trim.ToUpper
    End Sub

    'boton salir
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        botonActivado(sender, Color.Yellow)
        lblTituloForm.Text = "SALIR"
        If MessageBox.Show("¿Seguro que desea salir?", "¿SALIR DEL SISTEMA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    'fecha y hora
    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        lblHora.Text = DateTime.Now.ToLongTimeString
        lblFecha.Text = DateTime.Now.ToLongDateString
    End Sub

    'boton volver a login
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        botonActivado(sender, Color.SeaGreen)
        lblTituloForm.Text = "VOLVER AL LOGIN"
        If MessageBox.Show("¿Seguro que desea volver al login?", "¿VOLVER AL LOGIN?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            Dim reinicio As New Login

            Me.Hide()
            reinicio.ShowDialog()
            Me.Close()
        End If
        'abrirFormHijo(New Login)
    End Sub

    Private Sub pnlEscritorio_Paint(sender As Object, e As PaintEventArgs) Handles pnlEscritorio.Paint

    End Sub
End Class
