Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports WebApplication7.accesodatosSQL

Public Class ExportarTarea
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conectar()
        Lista.AutoPostBack = True
        If Not Page.IsPostBack Then
            Dim dataset As DataSet = New DataSet
            Dim tabla As DataTable = New DataTable
            Dim adap As SqlDataAdapter
            Dim reader As SqlDataReader

            reader = AsignaturasProfesor(Session("UserID"))
            While reader.Read() = True
                Lista.Items.Add(reader.Item("codigoasig"))
            End While
            reader.Close()
            adap = TareasAsi(Lista.SelectedItem.ToString)
            adap.Fill(dataset, "tareas")
            tabla = dataset.Tables("tareas")
            GridView1.DataSource = tabla
            GridView1.DataBind()
            GridView1.Visible = True
            Session.Add("set", dataset)
            Session.Add("adap", adap)
        End If

    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim dataset As DataSet = New DataSet
        Dim tabla As DataTable = New DataTable
        Dim adap As SqlDataAdapter
        Dim tareas As XmlElement
        Dim doc As XmlDocument = New XmlDocument

        dataset = Session("set")
        adap = Session("adap")
        tabla = dataset.Tables("Tareas")

        doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", "no"))
        tareas = doc.CreateElement("Tareas")
        tareas.SetAttribute("xmlns:has", "http://ji.ehu.es/has")
        doc.AppendChild(tareas)

        For Each p As DataRow In tabla.Rows
            Dim Tarea, Descripcion, Hestimadas, Explotacion, Tipotarea As XmlElement

            Dim Codigo As XmlAttribute

            Tarea = doc.CreateElement("tarea")
            Tarea.SetAttribute("codigo", p.Item(0))
            Descripcion = doc.CreateElement("descripcion")
            Hestimadas = doc.CreateElement("horasestimadas")
            Explotacion = doc.CreateElement("explotacion")
            Tipotarea = doc.CreateElement("tipotarea")

            Descripcion.AppendChild(doc.CreateTextNode(p.Item(1)))
            Hestimadas.AppendChild(doc.CreateTextNode(p.Item(3)))
            Explotacion.AppendChild(doc.CreateTextNode(p.Item(4).ToString))
            Tipotarea.AppendChild(doc.CreateTextNode(p.Item(5)))

            Tarea.AppendChild(Descripcion)
            Tarea.AppendChild(Hestimadas)
            Tarea.AppendChild(Explotacion)
            Tarea.AppendChild(Tipotarea)

            tareas.AppendChild(Tarea)

        Next
        doc.Save(Server.MapPath("xmlDoc_" & Lista.SelectedValue & ".xml"))
        Label2.Visible = True
        Label3.Text = "xmlDoc_" & Lista.SelectedValue.ToString & ".xml"

    End Sub



    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataset As DataSet = New DataSet
        Dim tabla As DataTable = New DataTable
        Dim adap As SqlDataAdapter
        Dim tareas As XmlElement
        Dim doc As XmlDocument = New XmlDocument
        Dim Codigo = Lista.SelectedValue
        Dim Datos = TareasAsi(Codigo)
        dataset.DataSetName = "tareas"
        Datos.Fill(dataset, "tarea")
        dataset.Tables("tarea").Columns.Item("CodAsig").ColumnMapping = MappingType.Hidden
        dataset.Tables("tarea").Columns.Item("Codigo").ColumnMapping = MappingType.Attribute
        For Each X In dataset.Tables("tarea").Columns
            X.ColumnName = X.ColumnName.ToLower
        Next
        dataset.WriteXml(Server.MapPath("DataSet_" & Lista.SelectedValue & ".xml"))
        Label2.Visible = True
        Label3.Text = "DataSet_" & Lista.SelectedValue.ToString & ".xml"


    End Sub

    Protected Sub Lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lista.SelectedIndexChanged
        Dim dataset As DataSet = New DataSet
        Dim tabla As DataTable = New DataTable
        Dim adap As SqlDataAdapter

        adap = TareasAsi(Lista.SelectedValue)
        adap.Fill(dataset, "tareas")
        tabla = dataset.Tables("tareas")
        GridView1.DataSource = tabla
        GridView1.DataBind()
        GridView1.Visible = True
        Session.Add("set", dataset)
        Session.Add("adap", adap)
        Label2.Text = ""
    End Sub
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub


End Class

