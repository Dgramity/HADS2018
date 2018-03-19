
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports WebApplication7.accesodatosSQL
Public Class InsertarTarea
    Inherits System.Web.UI.Page

    Protected Sub AñadirTarea_Click(sender As Object, e As EventArgs) Handles AñadirTarea.Click
        insertar.Insert()
        Label1.Visible = True
    End Sub

End Class