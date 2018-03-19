<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TareasProfesor.aspx.vb" Inherits="WebApplication7.TareasProfesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: #C0C0C0; height: 136px;">
            <h1 style="text-align: center">
                PROFESOR</h1>
            <h1 style="text-align: center">GESTIÓN DE TAREAS GENÉRICAS</h1>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Seleccionar asignatura:"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:hads-11ConnectionString %>" SelectCommand="SELECT g.codigoasig FROM GruposClase AS g INNER JOIN ProfesoresGrupo AS p ON g.codigo = p.codigogrupo WHERE (p.email = @email)">
                <SelectParameters>
                    <asp:SessionParameter Name="email" SessionField="UserID" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="59px" Text="Insertar Tarea" Width="130px" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Codigo" DataSourceID="SqlDataSource2" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo" />
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                    <asp:BoundField DataField="CodAsig" HeaderText="CodAsig" SortExpression="CodAsig" />
                    <asp:BoundField DataField="HEstimadas" HeaderText="HEstimadas" SortExpression="HEstimadas" />
                    <asp:CheckBoxField DataField="Explotacion" HeaderText="Explotacion" SortExpression="Explotacion" />
                    <asp:BoundField DataField="TipoTarea" HeaderText="TipoTarea" SortExpression="TipoTarea" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:hads-11ConnectionString %>" SelectCommand="select * from tareasgenericas where codasig = @codigo" UpdateCommand="UPDATE TareasGenericas SET Descripcion = @Descripcion, CodAsig = @CodAsig, HEstimadas = @HEstimadas, Explotacion = @Explotacion, TipoTarea = @TipoTarea where Codigo = @Codigo">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="codigo" PropertyName="SelectedValue" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Descripcion" />
                    <asp:Parameter Name="CodAsig" />
                    <asp:Parameter Name="HEstimadas" />
                    <asp:Parameter Name="Explotacion" />
                    <asp:Parameter Name="TipoTarea" />
                    <asp:Parameter Name="codigo" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>

        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Profesor.aspx">Inicio</asp:HyperLink>

    </form>
</body>
</html>
