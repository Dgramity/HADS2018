Imports System.Data.SqlClient
Imports WebApplication7.accesodatosSQL
Imports WebApplication7.EnvioEmail
Public Class Aplicación
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
    End Sub



    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conectar()
        Dim email = Convert.ToString(Request.QueryString("mbr"))
        Dim RS As SqlDataReader
        Try
            RS = obtenerDatos(email)
        Catch ex As Exception
            Label1.Text = ex.Message
            Exit Sub
        End Try
        RS.Read()
        Dim cod As String = RS.Item("numconfir")
        RS.Close()
        Dim codigo = Convert.ToString(Request.QueryString("numconf"))
        If codigo.Equals(cod) Then
            Dim st2 = "UPDATE Usuarios SET confirmado = 1 WHERE email = '" & email & "'"
            Dim up = actualizarDatos(st2)
            If (up) Then

                Label1.Text = "Se ha realizado la confirmacion de tu registro"
            Else

                Label1.Text = "No se ha podido realizar la confirmacion de tu registro"
            End If
        Else

            Label1.Text = "El codigo NO es correcto"
        End If

    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub


End Class