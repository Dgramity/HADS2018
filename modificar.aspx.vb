Imports System.Data.SqlClient
Imports WebApplication7.accesodatosSQL
Imports WebApplication7.EnvioEmail

Public Class WebForm3
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
    End Sub

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mail As New EnvioEmail()
        Dim result As Boolean
        Dim RS As SqlDataReader
        Try
            RS = accesodatosSQL.obtenerDatos(email.Text)
        Catch ex As Exception
            LabelB1.Text = ex.Message
            Exit Sub
        End Try

        RS.Read()
        Dim cod As String = RS.Item("numconfir")
        RS.Close()

        result = mail.enviarCodigo(email.Text, cod)

        If result Then
            LabelB1.Visible = True
            LabelB1.Text = "En breves instantes recibira un email con su codigo de verificacion"
        Else
            LabelB1.Visible = True
            LabelB1.Text = "Se ha producido un error, intentelo mas tarde"
        End If

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim mail As New EnvioEmail()
        Dim result As Integer
        Dim RS As SqlDataReader
        Try
            RS = accesodatosSQL.obtenerDatos(email.Text)
        Catch ex As Exception
            LabelB2.Text = ex.Message
            Exit Sub
        End Try

        RS.Read()
        Dim cod As String = RS.Item("numconfir")
        RS.Close()

        If codigo.Text.Equals(cod) Then

            result = cambiarContraseña(password.Text, email.Text)
            If (result = 1) Then
                Response.Redirect("https://hads11.azurewebsites.net/inicio.aspx")
            Else
                LabelB2.Visible = True
                LabelB2.Text = "No se ha podido actualizar las contraeña"
            End If

        Else
            LabelB2.Visible = True
            LabelB2.Text = "Codigo incorrecto"
        End If

    End Sub
End Class