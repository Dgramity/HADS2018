Imports WebApplication7.accesodatosSQL

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()

    End Sub


    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim result, result2 As String
        result = HacerLogin(TextBox1.Text, TextBox2.Text)
        result2 = estaConfirmado(TextBox1.Text)


        If result Then

            If result2.Equals("OK") Then
                Response.Redirect("https://hads11.azurewebsites.net/aplicacion.aspx")
            Else
                LabelError.Visible = True
                LabelError.Text = "Error, cuenta no confirmada"

            End If

        Else
            LabelError.Visible = True
            LabelError.Text = "Error, datos incorrectos"
        End If

    End Sub

End Class