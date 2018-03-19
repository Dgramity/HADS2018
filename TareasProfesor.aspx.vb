Public Class TareasProfesor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim codigo = DropDownList1.SelectedValue
        Dim Usuario = Session("UserID")
        Response.Redirect("InsertarTarea.aspx")
    End Sub

End Class