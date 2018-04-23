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

    'Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim wrapper As New Simple3Des(TextBox2.Text)
    '    Dim cipherText As String = wrapper.EncryptData(TextBox1.Text)
    '    Dim result3 As Boolean
    '    Dim result As Boolean
    '    Dim result2 As SqlDataReader

    '    ' Logins encriptados.
    '    result = HacerLogin(TextBox1.Text, TextBox2.Text)
    '    ' Logins no encriptados.
    '    result3 = HacerLogin(TextBox1.Text, cipherText)


    '    result2 = estaConfirmado(TextBox1.Text)


    '    result2.Read()

    '    If result = True Or result3 = True Then


    '        If result2.HasRows And result2.Item(5).ToString.Equals("Alumno") = 0 And TextBox1.Text.Equals("vadillo@ehu.es") Then
    '            Session("email") = TextBox1.Text
    '            Dim arrayPr As ArrayList
    '            Application.Lock()
    '            arrayPr = Application.Contents("Profesores")
    '            arrayPr.Add(TextBox1.Text)
    '            Application.Contents("Profesores") = arrayPr
    '            Application.UnLock()
    '            FormsAuthentication.SetAuthCookie("vadillo", True)
    '            Response.Redirect("App_Profesor/profesor.aspx")
    '        ElseIf result2.HasRows And result2.Item(5).ToString.Equals("Alumno") = 0 And TextBox1.Text.Equals("admin@ehu.es") Then
    '            Session("email") = TextBox1.Text
    '            Dim arrayPr As ArrayList
    '            Application.Lock()
    '            arrayPr = Application.Contents("Profesores")
    '            arrayPr.Add(TextBox1.Text)
    '            Application.Contents("Profesores") = arrayPr
    '            Application.UnLock()
    '            FormsAuthentication.SetAuthCookie("admin", True)
    '            Response.Redirect("App_Admin/.aspx")
    '        ElseIf result2.Item(5).ToString = "Alumno" Then
    '            Session("UserID") = TextBox1.Text()
    '            Dim arrayAl As ArrayList
    '            Application.Lock()
    '            arrayAl = Application.Contents("Alumnos")
    '            arrayAl.Add(TextBox1.Text)
    '            Application.Contents("Alumnos") = arrayAl
    '            Application.UnLock()
    '            FormsAuthentication.SetAuthCookie("alumno", True)
    '            Response.Redirect("App_Alumno/Alumno.aspx")
    '        ElseIf result2.HasRows And result2.Item(5).ToString = "Profesor" Then
    '            Session("UserID") = TextBox1.Text()
    '            Dim arrayPr As ArrayList
    '            Application.Lock()
    '            arrayPr = Application.Contents("Profesores")
    '            arrayPr.Add(TextBox1.Text)
    '            Application.Contents("Profesores") = arrayPr
    '            Application.UnLock()
    '            FormsAuthentication.SetAuthCookie("profesor", True)
    '            Response.Redirect("App_Profesor/Profesor.aspx")

    '        Else
    '            LabelError.Visible = True
    '            LabelError.Text = "Error, cuenta no confirmada"


    '        End If


    '    Else
    '        LabelError.Visible = True
    '        LabelError.Text = "Error, datos incorrectos"
    '    End If

    '    result2.Close()

    'End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim c As Boolean = False
        Dim wrapper As New Simple3Des(TextBox2.Text)
        Dim pass As String = wrapper.EncryptData(TextBox1.Text)
        Dim st = "SELECT * FROM Usuarios WHERE email='" & TextBox1.Text & "'"
        Dim RS As SqlDataReader
        Try
            RS = getDatos(st)

        Catch ex As Exception
            LabelError.Visible = True
            LabelError.Text = "Usuario o contraseña incorrecto. Intentelo de nuevo"
            c = True
            Exit Sub
        End Try

        If Not (c) Then

            RS.Read()
            Dim tipo As String = RS.Item("tipo")
            Dim password As String = RS.Item("pass")

            RS.Close()

            If (password.Equals(pass)) Or (password.Equals(TextBox2.Text)) Then
                LabelError.Visible = True
                LabelError.Text = "asdasdasd"
                If (TextBox1.Text.Equals("vadillo@ehu.es")) Then
                    Session("UserID") = TextBox1.Text
                    Session("tipo") = "P"
                    Dim arrayPr As ArrayList
                    Application.Lock()
                    arrayPr = Application.Contents("Profesores")
                    arrayPr.Add(TextBox1.Text)
                    Application.Contents("Profesores") = arrayPr
                    Application.UnLock()
                    FormsAuthentication.SetAuthCookie("vadillo", True)
                    Response.Redirect("App_Profesor/profesor.aspx")
                ElseIf (TextBox1.Text.Equals("admin@ehu.es")) Then
                    Session("UserID") = TextBox1.Text
                    Session("tipo") = "P"
                    Dim arrayPr As ArrayList
                    Application.Lock()
                    arrayPr = Application.Contents("Profesores")
                    arrayPr.Add(TextBox1.Text)
                    Application.Contents("Profesores") = arrayPr
                    Application.UnLock()
                    FormsAuthentication.SetAuthCookie("admin", True)
                    Response.Redirect("App_Admin/.aspx")
                ElseIf (tipo = "Alumno") Then
                    Session("UserID") = TextBox1.Text
                    Session("tipo") = "A"
                    Dim arrayAl As ArrayList
                    Application.Lock()
                    arrayAl = Application.Contents("Alumnos")
                    arrayAl.Add(TextBox1.Text)
                    Application.Contents("Alumnos") = arrayAl
                    Application.UnLock()
                    FormsAuthentication.SetAuthCookie("alumno", True)
                    Response.Redirect("/App_Alumno/alumno.aspx")
                Else
                    Session("UserID") = TextBox1.Text
                    Session("tipo") = "P"
                    Dim arrayPr As ArrayList
                    Application.Lock()
                    arrayPr = Application.Contents("Profesores")
                    arrayPr.Add(TextBox1.Text)
                    Application.Contents("Profesores") = arrayPr
                    Application.UnLock()
                    FormsAuthentication.SetAuthCookie("profesor", True)
                    Response.Redirect("App_Profesor/profesor.aspx")
                End If
            End If
            LabelError.Visible = True
            LabelError.Text = "Error, datos incorrectos"
        End If

    End Sub

End Class