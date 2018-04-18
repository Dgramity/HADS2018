Imports System.Data.SqlClient
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
        Dim wrapper As New Simple3Des(TextBox2.Text)
        Dim cipherText As String = wrapper.EncryptData(TextBox1.Text)

        Dim result As String
        Dim result2 As SqlDataReader
        result = HacerLogin(TextBox1.Text, TextBox2.Text)
        result2 = estaConfirmado(TextBox1.Text)

        result2.Read()


        If result Then

            If result2.HasRows And result2.Item(5).ToString.Equals("Alumno") = 0 And TextBox1.Text.Equals("vadillo@ehu.es") Then
                Session("email") = TextBox1.Text
                FormsAuthentication.SetAuthCookie("vadillo", True)
                Response.Redirect("App_Profesor/profesor.aspx")
            ElseIf result2.HasRows And result2.Item(5).ToString.Equals("Alumno") = 0 And TextBox1.Text.Equals("admin@ehu.es") Then
                Session("email") = TextBox1.Text
                FormsAuthentication.SetAuthCookie("admin", True)
                Response.Redirect("App_Admin/.aspx")
            ElseIf result2.HasRows And result2.Item(5).ToString.Equals("Alumno") = 0 Then
                Session("UserID") = TextBox1.Text()
                FormsAuthentication.SetAuthCookie("profesor", True)
                Response.Redirect("App_Profesor/Profesor.aspx")
            ElseIf result2.HasRows And result2.Item(5).ToString.Equals("Profesor") = 0 Then
                Session("UserID") = TextBox1.Text()
                FormsAuthentication.SetAuthCookie("alumno", True)
                Response.Redirect("App_Alumno/Alumno.aspx")

            Else
                LabelError.Visible = True
                LabelError.Text = "Error, cuenta no confirmada"

            End If

        Else
            LabelError.Visible = True
            LabelError.Text = "Error, datos incorrectos"
        End If

        result2.Close()

    End Sub

End Class