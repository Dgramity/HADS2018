<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Estadisticas.aspx.vb" Inherits="WebApplication7.Estadisticas" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div align="center" style="background-color: #C0C0C0; font-size: xx-large" >
        <h1 style="text-align: center">Estadisticas alumno</h1>

    </div>
         <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="email" DataValueField="email">
         </asp:DropDownList>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:hads-11ConnectionString %>" SelectCommand="SELECT [email] FROM [Usuarios] WHERE ([tipo] = @tipo)">
             <SelectParameters>
                 <asp:Parameter DefaultValue="Alumno" Name="tipo" Type="String" />
             </SelectParameters>
         </asp:SqlDataSource>
         <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource2">
             <series>
                 <asp:Series ChartType="StepLine" Name="Series1" XValueMember="HReales" YValueMembers="HEstimadas">
                 </asp:Series>
             </series>
             <chartareas>
                 <asp:ChartArea Name="ChartArea1">
                 </asp:ChartArea>
             </chartareas>
         </asp:Chart>
         <br />
         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:hads-11ConnectionString %>" SelectCommand="SELECT HEstimadas, HReales FROM EstudiantesTareas WHERE (Email = @email)">
             <SelectParameters>
                 <asp:ControlParameter ControlID="DropDownList1" DefaultValue="pepe@ikasle.ehu.es" Name="email" PropertyName="SelectedValue" />
             </SelectParameters>
         </asp:SqlDataSource>
    </form>
</body>
</html>
