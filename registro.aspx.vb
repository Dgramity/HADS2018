﻿Imports WebApplication7.accesodatosSQL
Imports System.Net.Mail
Imports WebApplication7.EnvioEmail

Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub registro_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()

    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Boolean
        Dim NumConf As Integer
        Dim mail As New EnvioEmail()
        Dim enlace As String
        Dim m As New Matricula.Matriculas
        If (m.comprobar(TextBox1.Text) = "SI") Then

            Randomize()
            NumConf = CLng(Rnd() * 9000000) + 1000000
            enlace = String.Concat("https://hads11.azurewebsites.net/confirmacion.aspx?mbr=", TextBox1.Text, "&numconf=", CStr(NumConf))
            Dim wrapper As New Simple3Des(TextBox4.Text)
            Dim cipherText As String = wrapper.EncryptData(TextBox1.Text)
            result = insertar(TextBox1.Text, TextBox2.Text, TextBox3.Text, NumConf, 0, RadioButtonList1.Text, cipherText)
            mail.enviarEmail(TextBox1.Text, enlace)
            Response.Redirect("inicio.aspx")
        Else
            Label1.Text = "No estas matriculado"
        End If
    End Sub

    Private Sub registro_Unload(sender As Object, e As EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub


End Class