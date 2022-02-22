Imports System.IO
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class Login
    Dim ar As String
    Dim cont As Integer = 0
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=ABM; integrated security=true")

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Para Guardar los Errores que Surjan

        Dim errores As String = ""

        'Guardamos el caracter del enter

        Dim enter As String = vbCrLf

        'el usuario debe tener 5 caracteres minimos
        If tUsuario.Text.Trim.Length < 5 Then
            errores &= "Debe Ingresar un Usuario de al menos 5 caracteres." & enter
            cont = cont + 1
            If cont >= 3 Then
                End
            End If

        End If
        'el password debe tener 6 caracteres minimos
        If tPassword.Text.Trim.Length < 6 Then

            errores &= "Debe Ingresar una Contraseña de al menos 6 caracteres.." & enter
            cont = cont + 1
            If cont >= 3 Then
                End
            End If
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, Por Favor Verifique y Corrija Antes de Intentar de Nuevo:" & enter & enter & errores, MsgBoxStyle.Information, "Errores")
            Exit Sub
        Else
            iniciarSesion()
        End If

    End Sub


    Sub iniciarSesion()

        tUsuario.Text = tUsuario.Text.Replace("'", "").Replace(" ", "").Replace("""", "").ToUpper()
        tPassword.Text = tPassword.Text.Replace("'", "").Replace(" ", "").Replace("""", "").ToUpper()
        'hace la conexion con la base de datos y comprueba si el usuario y password ingresados coniciden con la tabla
        Dim dataAdapter As New SqlDataAdapter("SELECT Usuario, Password,Apellidousu,Nombreusu  FROM usuario WHERE Usuario ='" & tUsuario.Text & "' AND Password='" & tPassword.Text & "'", con)

        Dim dataSet As New DataSet

        dataAdapter.Fill(dataSet, "usuario")

        If dataSet.Tables("usuario").Rows.Count > 0 Then
            Module1.ape = dataSet.Tables("usuario").Rows(0)("Apellidousu")
            Module1.nom = dataSet.Tables("usuario").Rows(0)("Nombreusu")
            Dim menu As New Form1
            Me.Hide()
            menu.ShowDialog()
            Me.Close()
        Else
            MsgBox("El Usuario o Contraseña no son Correctos. Intentelo de Nuevo.", MsgBoxStyle.Information, "Iniciar Sesión")
            cont = cont + 1
            If cont >= 3 Then
                MsgBox("Ha introducido incorrectamente 3 veces sus datos", MsgBoxStyle.Critical, "Intente de nuevo")
                Me.Close()
                End

            End If
        End If
    End Sub


    'boton salir
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("¿Seguro que desea salir?", "SALIR DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
            End
        End If

    End Sub

    'link de la pagina web
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://estampadotextil.com.ar/")
    End Sub

    'arrastar formulario
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub Sendmessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    'que se pueda arrastar el form desde la barra de titulo
    Private Sub pnlBarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
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
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class