
Imports System.IO
Imports System.Data.SqlClient
Public Class Proveedores
    Dim ar As String
    Dim con As New SqlConnection("data source=" & CStr(leerarchivo(ar)) & "; initial catalog=ABM; integrated security=true")
    'CREAR LA BASE ABM EN SQL SERVER
    'SCRIPT PARA CREAR LA TABLA PROFESORES
    'use abm
    'go
    'if exists (select * from dbo.sysobjects where id = object_id(N'[clientes]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
    'drop table [clientes]
    'GO


    'SET ANSI_NULLS ON
    'GO

    'SET QUOTED_IDENTIFIER ON
    'GO

    'CREATE TABLE [dbo].[Clientes](
    '	[Ncli] [int] IDENTITY(1,1) NOT NULL,
    '	[Apellidocli] [nvarchar](30) NULL,
    '	[Nombrecli] [nvarchar](30) NULL,
    '	[Documento-cli] [int] NULL default 0,
    '	[Domiciliocli] [nvarchar](50) NULL default '',
    '	[Postalcli] [nvarchar](10) NULL default 1900,
    '	[Localidadcli] [nvarchar](10) NULL default 'La Plata',
    '	[Provinciacli] [nvarchar](20) NULL default 'Bs. As.',
    '	[Teléfonoscli] [nvarchar](30) NULL default '',
    '	[FechaNacimientocli] [datetime] NULL default getdate(),
    '	[Comentarioscli] [nvarchar](200) NULL default '',
    '	[E-Mail-cli] [nvarchar](35) NULL default '',
    '	[Estado] [bit] NULL default 0,
    ' CONSTRAINT [aaaaaProfesores2_PK] PRIMARY KEY NONCLUSTERED 
    '(
    '	[Ncli] ASC
    ')
    ') ON [PRIMARY]

    'GO
    'CREATE VIEW [dbo].[Clientes_Búsqueda]
    'AS
    'SELECT     TOP (100) PERCENT Ncli, UPPER(LTRIM(Apellidocli) + ',  ' + LTRIM(Nombrecli)) AS ApeYNom
    'FROM         dbo.Clientes
    'where Ncli<>68 and Ncli<>74 and Ncli<>2
    'order by UPPER(LTRIM(Apellidocli) + ',  ' + LTRIM(Nombrecli))
    'GO

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



    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscar(" apeynom like '" & tApellido.Text & "%' ")
    End Sub
    Sub buscar(ByVal condicion As String)

        Dim da As New SqlDataAdapter("SELECT TOP (100) PERCENT Npro,apeynom from Proveedores_Búsqueda where " & condicion & " order by apeynom", con)
        Dim ds As New DataSet
        da.Fill(ds, "Proveedores")
        If ds.Tables("Proveedores").Rows.Count = 0 Then

            DataGridView1.Visible = False

            pBotones.Visible = False
            pCampos.Visible = False
            lLegajo.Visible = False
        Else

            DataGridView1.DataSource = ds.Tables("Proveedores")
            DataGridView1.Refresh()
            DataGridView1.Visible = True

            lLegajo.Visible = True
        End If

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FilaClick(e)
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        FilaClick(e)
    End Sub
    Sub FilaClick(ByVal e As Object)
        Dim fila As Integer = e.RowIndex
        Dim tfila As String

        If IsNothing(DataGridView1.Rows(fila).Cells(0).Value) Then
            lLegajo.Text = "0"
            pBotones.Visible = False
            pCampos.Visible = False
            Exit Sub
        Else
            tfila = DataGridView1.Rows(fila).Cells(0).Value
            lLegajo.Text = tfila.ToString()
            CargarCamposProveedores()
        End If

    End Sub

    Sub CargarCamposProveedores()
        If Val(lLegajo.Text) = 0 Then
            pBotones.Visible = False
            pCampos.Visible = False

            Exit Sub
        Else
            pBotones.Visible = True
            pCampos.Visible = True
            Dim da As New SqlDataAdapter("SELECT  upper(ltrim(rtrim(isnull(apellidopro,'****')))) as apellido, upper(ltrim(rtrim(isnull(nombrepro,'****')))) as nombres,isnull([documento-pro],0) as doc, ltrim(rtrim(isnull(domiciliopro,''))) as dirección,ltrim(rtrim(isnull(localidadpro,''))) as localidad,ltrim(rtrim(isnull(provinciapro,''))) as provincia,ltrim(rtrim(isnull(teléfonospro,''))) as teléfonos,Fechanacimientopro as fechanacimiento,ltrim(rtrim(isnull(comentariospro,''))) as comentarios,ltrim(rtrim(isnull([E-Mail-pro],''))) as email, isnull(estado,0) as Estado  from proveedores where npro=" & Val(lLegajo.Text), con)
            Dim ds As New DataSet
            da.Fill(ds, "Proveedores")
            TextBox1.Text = ds.Tables("Proveedores").Rows(0)("apellido")
            TextBox2.Text = ds.Tables("Proveedores").Rows(0)("nombres")
            TextBox3.Text = ds.Tables("Proveedores").Rows(0)("doc")

            TextBox4.Text = ds.Tables("Proveedores").Rows(0)("Dirección")
            TextBox5.Text = ds.Tables("Proveedores").Rows(0)("localidad")
            TextBox8.Text = ds.Tables("Proveedores").Rows(0)("provincia")
            TextBox6.Text = ds.Tables("Proveedores").Rows(0)("teléfonos")
            TextBox7.Text = ds.Tables("Proveedores").Rows(0)("email")
            CheckBox1.Checked = IIf(ds.Tables("Proveedores").Rows(0)("estado") = 0, False, True)


            TextBox12.Text = ds.Tables("Proveedores").Rows(0)("comentarios")

            DateTimePicker1.Value = ds.Tables("Proveedores").Rows(0)("fechanacimiento")
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

    Private Sub bCambios_Click(sender As Object, e As EventArgs) Handles bCambios.Click
        Dim errores As String = "", en As String = vbCrLf
        If TextBox1.Text.Trim.Length < 3 Then
            errores &= "Debe completar el Apellido del Proveeedor." & en
        End If
        If TextBox2.Text.Trim.Length < 3 Then
            errores &= "Debe completar el o los nombres del Proveedor." & en
        End If
        TextBox3.Text = Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", ""))
        If TextBox3.Text.Trim.Length < 4 Or TextBox3.Text.IndexOf("11111") > -1 Or TextBox3.Text.IndexOf("12345") > -1 Or TextBox3.Text.IndexOf("000000") > -1 Then
            errores &= "Debe completar CORRECTAMENTE el documento del Proveedor." & en
        End If
        If TextBox7.Text.Trim.Length <> 0 And (TextBox7.Text.IndexOf("@") < 0 Or TextBox7.Text.IndexOf(".") < 0) Then
            errores &= "Verifique por favor el email del Proveedor. No es obligatorio, pero si lo escribe debe ser correcto." & en
        End If
        If errores.Length > 0 Then
            MsgBox("Hubo errores, por favor verifique y corrija antes de intentar de nuevo:" & en & en & errores)
            Exit Sub
        End If
        ' TextBox12.Text = "update Profesores set apellidos='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombres='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', sexo='" & Sexo.SelectedItem & "', doc=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", nacionalidad='" & TextBox10.Text.Trim.ToUpper & "', dirección='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', localidad='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', teléfparticular='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', emailalumno='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimiento=" & FechaSQL(DateTimePicker1.Value) & ", ocupación='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', colegio='" & TextBox9.Text.Trim.ToUpper.Replace("'", "´") & "', turno='" & TextBox11.Text.Trim.ToUpper.Replace("'", "´") & "', comentarios='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "' where legajo=" & VNum(lLegajo.Text)
        If SQL_Accion("update Proveedores set estado=" & IIf(CheckBox1.Checked, 1, 0) & ", apellidopro='" & TextBox1.Text.Trim.ToUpper.Replace("'", "´") & "', nombrepro='" & TextBox2.Text.Trim.ToUpper.Replace("'", "´") & "', [documento-pro]=" & Val(TextBox3.Text.Trim.Replace(".", "").Replace(" ", "").Replace(",", "")) & ", domiciliopro='" & TextBox4.Text.Trim.ToUpper.Replace("'", "´") & "', localidadpro='" & TextBox5.Text.Trim.ToUpper.Replace("'", "´") & "', provinciapro='" & TextBox8.Text.Trim.ToUpper.Replace("'", "´") & "', teléfonospro='" & TextBox6.Text.Trim.ToUpper.Replace("'", "´") & "', [e-mail-pro]='" & TextBox7.Text.Trim.ToUpper.Replace("'", "´") & "', fechanacimientopro=" & FechaSQL(DateTimePicker1.Value) & ", comentariospro='" & TextBox12.Text.Trim.ToUpper.Replace("'", "´") & "' where npro=" & VNum(lLegajo.Text)) = True Then
            MsgBox("Cambios realizados correctamente.")

            buscar(" Npro=" & VNum(lLegajo.Text))
        Else
            MsgBox("Se produjo un error al querer guardar los datos del Proveedor, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        End If
    End Sub

    Private Sub bNuevoProveedor_Click(sender As Object, e As EventArgs) Handles bNuevoProveedor.Click
        If SQL_Accion("insert into Proveedores (apellidopro, nombrepro, [documento-pro],domiciliopro, localidadpro, teléfonospro, fechanacimientopro, comentariospro,[e-mail-pro],estado) values ('*****','*****',                  0,           '',           '',             '',           getdate(),               ''       ,      ''    ,     1   )  ") Then


            buscar(" apeynom like '****%' ")
            MsgBox("Se ha creado un nuevo registro para Proveedores que desea ingresar, seleccione la línea nueva, cargue los datos y luego confirme con el botón 'Aceptar Cambios'.")
        End If
    End Sub

    Private Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        If MessageBox.Show("Está por ELIMINAR definitivamente al PROVEEDOR: " & TextBox1.Text.Trim.ToUpper & ", " & TextBox2.Text.Trim.ToUpper & ". Es algo EXTREMO. Está SEGURO?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

        If SQL_Accion("delete from Proveedores  where  Npro=" & Val(lLegajo.Text)) = False Then
            MsgBox("Hubo un error al intentar borrar al Proveedor, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
        Else

            buscar(" Npro=" & Val(lLegajo.Text))
            MsgBox("El Proveedor fue ELIMINADO de la base de datos.")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Dim menu As New Form1
        Me.Hide()

        menu.ShowDialog()
        Me.Close()
    End Sub


End Class