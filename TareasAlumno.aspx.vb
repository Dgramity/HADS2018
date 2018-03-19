
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports WebApplication7.accesodatosSQL
Public Class TareasAlumno
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()

        Dim usuario = Session("UserID")
        LabelUser.Text = usuario
        ListAsig.AutoPostBack = True
        If Not Page.IsPostBack Then
            Dim dr As SqlDataReader
            dr = ObtenerAsignaturas(usuario)
            While dr.Read
                ListAsig.Items.Add(dr.Item(0).ToString)
            End While
            dr.Close()
            Dim da = ObtenerTareas(usuario, ListAsig.SelectedValue)
            Dim ds As New DataSet
            da.Fill(ds, "TareasGenericas")
            Dim dt = ds.Tables("tareasGenericas")


            GridViewTareas.DataSource = dt
            GridViewTareas.DataBind()
            Session("ds") = ds
            Session("tabla") = dt
        End If
    End Sub

    Protected Sub ListAsig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListAsig.SelectedIndexChanged
        Dim da = ObtenerTareas(Session("UserID"), ListAsig.SelectedValue)
        Dim ds As New DataSet
        da.Fill(ds, "TareasGenericas")
        Dim dt = ds.Tables("tareasGenericas")
        Session("tabla") = dt


        GridViewTareas.DataSource = dt
        GridViewTareas.DataBind()
    End Sub

    Protected Sub GridViewTareas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridViewTareas.SelectedIndexChanged

        Dim tabla = Session("tabla")

        Dim codigo = tabla.rows(GridViewTareas.SelectedIndex).item("codigo")
        Dim horas = tabla.rows(GridViewTareas.SelectedIndex).item("hestimadas")
        Dim usuario = Session("UserID")
        Response.Redirect("InstanciarTarea.aspx?codigo=" & codigo & "&usuario=" & usuario & "&horas=" & horas & "")
    End Sub

    Protected Sub SortRecords(ByVal sender As Object, ByVal e As GridViewSortEventArgs)
        Dim sortExpression As String = e.SortExpression
        Dim direction As String = String.Empty

        If SortDirection = SortDirection.Ascending Then

            SortDirection = SortDirection.Descending

            direction = " DESC"

        Else

            SortDirection = SortDirection.Ascending

            direction = " ASC"

        End If

        Dim table As DataTable = Session("tabla")

        table.DefaultView.Sort = sortExpression & direction

        GridViewTareas.DataSource = table

        GridViewTareas.DataBind()

    End Sub



    Public Property SortDirection() As SortDirection

        Get

            If ViewState("SortDirection") Is Nothing Then

                ViewState("SortDirection") = SortDirection.Ascending

            End If

            Return DirectCast(ViewState("SortDirection"), SortDirection)

        End Get

        Set(ByVal value As SortDirection)

            ViewState("SortDirection") = value

        End Set

    End Property
End Class