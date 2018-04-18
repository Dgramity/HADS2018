Public Class Profesor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ButtonCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Session.Abandon()
        Response.Redirect("../Inicio.aspx")


    End Sub

End Class