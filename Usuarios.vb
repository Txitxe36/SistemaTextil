Imports System.IO
Imports System.Data.SqlClient
Public Class Usuarios
    Dim ar As String
    Dim nom As String
    Dim ape As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=ABM; integrated security=true")

    Function leerarchivo(ByVal archivo As String) As String
        If File.Exists("c:\ABM\ip.txt") = True Then
            Dim SR As StreamReader = File.OpenText("c:\ABM\ip.txt")
            Dim Line As String = SR.ReadLine()
            SR.Close()
            Return Line
        Else
            MsgBox("Verifique Falta Archivo de Configuracion")
            Me.Close()
        End If
    End Function
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub

    Sub buscar(ByVal condicion As String)

        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT Nusu,apeynom from Usuario_búsqueda where " & condicion & " order by apeynom", con)
        Dim ds As New DataSet
        da.Fill(ds, "usuario")
        If ds.Tables("usuario").Rows.Count = 0 Then

            Grilla.Visible = False

            pBotones.Visible = False
            pCampos.Visible = False
            lLegajo.Visible = False
        Else

            Grilla.DataSource = ds.Tables("usuario")
            Grilla.Refresh()
            Grilla.Visible = True

            lLegajo.Visible = True
        End If

    End Sub
    Private Sub Grilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.CellContentClick
        FilaClick(e)
    End Sub

    Private Sub Grilla_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Grilla.RowEnter
        FilaClick(e)
    End Sub
    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(Grilla.Rows(fila).Cells(0).Value) Then
            lLegajo.Text = "0"
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = Grilla.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            CargarCamposUsuarios()
        End If

    End Sub

    Sub CargarCamposUsuarios()
        If Val(lLegajo.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim da As New SqlDataAdapter("SELECT  upper(ltrim(rtrim(isnull(apellidousu,'****')))) as apellido, upper(ltrim(rtrim(isnull(nombreusu,'****')))) as nombres,  upper(ltrim(rtrim(isnull(Usuario,'****')))) as usuario,  upper(ltrim(rtrim(isnull(Password,'****')))) as password  ,isnull([documento-usu],0) as doc, ltrim(rtrim(isnull(domiciliousu,''))) as dirección,ltrim(rtrim(isnull(localidadusu,''))) as localidad,ltrim(rtrim(isnull(provinciausu,''))) as provincia,ltrim(rtrim(isnull(teléfonosusu,''))) as teléfonos,Fechanacimientousu as fechanacimiento,ltrim(rtrim(isnull(comentariosusu,''))) as comentarios,ltrim(rtrim(isnull([E-Mail-usu],''))) as email, isnull(estado,0) as Estado  from usuario where nusu=" & Val(lLegajo.Text), con)
            Dim ds As New DataSet
            da.Fill(ds, "usuario")
            TextBox1.Text = ds.Tables("usuario").Rows(0)("apellido")
            TextBox2.Text = ds.Tables("usuario").Rows(0)("nombres")
            TextBox3.Text = ds.Tables("usuario").Rows(0)("doc")

            TextBox4.Text = ds.Tables("usuario").Rows(0)("Dirección")
            TextBox5.Text = ds.Tables("usuario").Rows(0)("localidad")
            TextBox8.Text = ds.Tables("usuario").Rows(0)("provincia")
            TextBox6.Text = ds.Tables("usuario").Rows(0)("teléfonos")
            TextBox7.Text = ds.Tables("usuario").Rows(0)("email")
            CheckBox1.Checked = IIf(ds.Tables("usuario").Rows(0)("estado") = 0, False, True)
            TextBox9.Text = ds.Tables("usuario").Rows(0)("usuario")
            TextBox10.Text = ds.Tables("usuario").Rows(0)("password")

            TextBox12.Text = ds.Tables("usuario").Rows(0)("comentarios")

            DateTimePicker1.Value = ds.Tables("usuario").Rows(0)("fechanacimiento")

        End If
    End Sub

    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        tApellido.Text = ""
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub

    Private Sub bSalir_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("¿Seguro que desea salir?", "SALIR DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then End
    End Sub

    Private Sub bNuevoAlumno_Click(sender As Object, e As EventArgs) Handles bNuevoAlumno.Click
        If SQL_Accion("insert into usuario (apellidousu, nombreusu,usuario,password, [documento-usu],domiciliousu, localidadusu, teléfonosusu, fechanacimientousu, comentariosusu,[e-mail-usu],estado) values ('*****','*****',             '',              '',                  0,           '',           '',             '',           getdate(),               ''       ,      ''    ,     1   )  ") Then


            buscar(" apeynom like '****%' ")
            MsgBox("Se ha creado un nuevo registro para Usuario que desea ingresar, seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente al USUARIO: " & TextBox1.Text.Trim.ToUpper & ", " & TextBox2.Text.Trim.ToUpper & ". Es algo EXTREMO. Está SEGURO?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from usuario  where  nusu=" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al Usuario, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        Else

            buscar(" nusu=" & Val(lLegajo.Text))
            MsgBox("El Usuario fue ELIMINADO de la base de datos.")

        End If
    End Sub

    Private Sub bCambios_Click(sender As Object, e As EventArgs) Handles bCambios.Click
        Dim errores As String = "", en As String = vbCrLf
        If TextBox1.Text.Trim.Length < 3 Then
            errores &= "Debe completar el Apellido del Usuario." & en
        End If
        If TextBox2.Text.Trim.Length < 3 Then
            errores &= "Debe completar el o los nombres del Usuario." & en
        End If
        TextBox3.Text = Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", ""))
        If TextBox3.Text.Trim.Length < 4 Or TextBox3.Text.IndexOf("11111") > -1 Or TextBox3.Text.IndexOf("12345") > -1 Or TextBox3.Text.IndexOf("000000") > -1 Then
            errores &= "Debe completar CORRECTAMENTE el documento del Usuario." & en
        End If
        If TextBox7.Text.Trim.Length <> 0 And (TextBox7.Text.IndexOf("@") < 0 Or TextBox7.Text.IndexOf(".") < 0) Then
            errores &= "Verifique por favor el email del Usuario. No es obligatorio, pero si lo escribe debe ser correcto." & en
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If
        ' TextBox12.Text = "update Profesores set apellidos='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombres='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', sexo='" & Sexo.SelectedItem & "', doc=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", nacionalidad='" & TextBox10.Text.Trim.ToUpper & "', dirección='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', localidad='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', teléfparticular='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', emailalumno='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimiento=" & FechaSQL(DateTimePicker1.Value) & ", ocupación='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', colegio='" & TextBox9.Text.Trim.ToUpper.Replace("'", "´") & "', turno='" & TextBox11.Text.Trim.ToUpper.Replace("'", "´") & "', comentarios='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "' where legajo=" & VNum(lLegajo.Text)
        If SQL_Accion("update usuario set estado=" & IIf(CheckBox1.Checked, 1, 0) & ", apellidousu='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombreusu='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "',  usuario='" & TextBox9.Text.Trim.ToUpper.Replace("'", "´") & "', password='" & TextBox10.Text.Trim.ToUpper.Replace("'", "´") & "' , [documento-usu]=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", domiciliousu='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', localidadusu='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', provinciausu='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', teléfonosusu='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', [e-mail-usu]='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimientousu=" & FechaSQL(DateTimePicker1.Value) & ", comentariosusu='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "' where nusu=" & VNum(lLegajo.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar(" nusu=" & VNum(lLegajo.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos del Usuario, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim menu As New Form1
        Me.Hide()

        menu.ShowDialog()
        Me.Close()
    End Sub

End Class