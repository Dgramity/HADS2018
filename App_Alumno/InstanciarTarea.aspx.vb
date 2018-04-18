Imports System.Data.SqlClient
Imports WebApplication7.accesodatosSQL


Public Class InstanciarTarea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim usuario = Request.QueryString("usuario")
        Dim codigo = Request.QueryString("codigo")
        Dim horas = Request.QueryString("horas")
        Dim da = ObtenerInstanciadas(usuario)
        Dim ds As New DataSet
        da.Fill(ds, "EstudiantesTareas")
        Dim dt = ds.Tables("EstudiantesTareas")
        Session("dsInstanciar") = ds
        GridViewTareas.DataSource = dt
        GridViewTareas.DataBind()

        textoUsuario.Text = usuario
        textoUsuario.Enabled = False
        textoTarea.Text = codigo
        textoTarea.Enabled = False
        textoEstimadas.Text = horas
        textoEstimadas.Enabled = False

        Session("adapter") = da

        Dim builder As New SqlCommandBuilder(da)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario = Request.QueryString("usuario")
        Dim codigo = Request.QueryString("codigo")
        Dim horasEst = Request.QueryString("horas")
        Dim horasReal As String = textoReales.Text

        Dim da As SqlDataAdapter
        da = Session("adapter")

        Dim ds As DataSet
        ds = Session("dsInstanciar")
        Dim dt As DataTable
        dt = ds.Tables("EstudiantesTareas")
        Dim rowMbrs As DataRow = dt.NewRow()
        rowMbrs("Email") = usuario
        rowMbrs("CodTarea") = codigo
        rowMbrs("HEstimadas") = horasEst
        rowMbrs("HReales") = horasReal
        dt.Rows.Add(rowMbrs)
        GridViewTareas.DataSource = dt
        GridViewTareas.DataBind()
        da.Update(ds, "EstudiantesTareas")

        textoReales.Enabled = False
        Button1.Enabled = False


    End Sub

End Class