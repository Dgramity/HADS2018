Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports WebApplication7.accesodatosSQL


Partial Class ImportarTarea
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
        ListaAsig.AutoPostBack = True
        If Not Page.IsPostBack Then
            Dim dataset As DataSet = New DataSet
            Dim tabla As DataTable = New DataTable
            Dim adap As SqlDataAdapter
            Dim reader As SqlDataReader

            reader = AsignaturasProfesor(Session("UserID"))
            While reader.Read() = True
                ListaAsig.Items.Add(reader.Item("codigoasig"))
            End While
            reader.Close()
            adap = TareasGenericas()
            adap.Fill(dataset, "tarea")
            tabla = dataset.Tables("tarea")

            Dim exists As Boolean

            exists = System.IO.File.Exists(Server.MapPath("App_Data/" & ListaAsig.SelectedValue & ".xml"))
            If exists Then
                Button1.Enabled = True
                Xml1.DocumentSource = Server.MapPath("App_Data/" & ListaAsig.SelectedValue & ".xml")
                Xml1.TransformSource = Server.MapPath("App_Data/XSLTFile.xsl")
            Else
                Button1.Enabled = False
                Label1.Visible = True
                Label1.Text = "No hay tareas para esta asignatura."
            End If

            Session.Add("set", dataset)
            Session.Add("tabla", tabla)
            Session.Add("adap", adap)

        End If
    End Sub
    Private Sub DropDownList1_DataBound(sender As Object, e As EventArgs) Handles ListaAsig.DataBound
        Dim exists As Boolean

        exists = System.IO.File.Exists(Server.MapPath("App_Data/" & ListaAsig.SelectedValue & ".xml"))
        If exists Then
            Button1.Enabled = True
            Xml1.DocumentSource = Server.MapPath("App_Data/" & ListaAsig.SelectedValue & ".xml")
            Xml1.TransformSource = Server.MapPath("App_Data/XSLTFile.xsl")
        Else
            Button1.Enabled = False
            Label1.Visible = True
            Label1.Text = "No hay tareas para esta asignatura."
        End If
    End Sub


    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaAsig.SelectedIndexChanged
        Dim exists As Boolean

        exists = System.IO.File.Exists(Server.MapPath("App_Data/" & ListaAsig.SelectedValue & ".xml"))
        If exists Then
            Button1.Enabled = True
            Xml1.DocumentSource = Server.MapPath("App_Data/" & ListaAsig.SelectedValue & ".xml")
            Xml1.TransformSource = Server.MapPath("App_Data/XSLTFile.xsl")
        Else
            Button1.Enabled = False
            Label1.Visible = True
            Label1.Text = "No hay tareas para esta asignatura."
        End If


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim documento As XmlDocument = New XmlDocument
        Dim LasTareas As XmlNodeList


        Dim tabla As DataTable = New DataTable
        Dim dataset As DataSet = New DataSet
        Dim adap As SqlDataAdapter
        Dim rowTareas As DataRow
        Dim comando As SqlCommandBuilder

        dataset = Session("set")

        tabla = Session("tabla")


        documento.Load(Server.MapPath("App_Data/" & ListaAsig.SelectedValue & ".xml"))

        LasTareas = documento.GetElementsByTagName("tarea")

        Dim explotacion As String

        For Each p As XmlElement In LasTareas
            rowTareas = tabla.NewRow()
            rowTareas("Codigo") = p.Attributes.GetNamedItem("codigo").InnerText
            rowTareas("Descripcion") = p.ChildNodes(0).InnerText
            rowTareas("CodAsig") = ListaAsig.SelectedValue
            rowTareas("HEstimadas") = p.ChildNodes(1).InnerText
            explotacion = p.ChildNodes(2).InnerText
            If (explotacion.Equals("true")) Then
                rowTareas("Explotacion") = 1
            Else
                rowTareas("Explotacion") = 0
            End If

            rowTareas("TipoTarea") = p.ChildNodes(3).InnerText
            tabla.Rows.Add(rowTareas)

        Next
        Try
            adap = Session("adap")
            comando = New SqlCommandBuilder(adap)
            adap.Update(dataset, "tarea")

            dataset.AcceptChanges()
            Label1.Visible = True
            Label1.Text = "El xml ha sido importado"

        Catch ex As Exception
            Label1.Visible = True
            Label1.Text = "Alguna de las tareas del xml ya existia en la BD"
        End Try


    End Sub

End Class