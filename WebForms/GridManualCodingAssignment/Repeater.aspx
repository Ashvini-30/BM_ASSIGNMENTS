<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="WebApplicationGrid.Repeater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString2 %>" SelectCommand="SELECT * FROM [Employee]"></asp:SqlDataSource>
        <asp:Repeater ID="Repeater2" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="Repeater2_ItemCommand">
            <ItemTemplate>
                <div>
                    <table>
                        <tr><th>Department no<%# Eval("Deptno") %></th></tr>
                        
                         <tr><td>Deaprtment name</td><td><%#Eval("Dname") %></td></tr>
                         <tr><td>Department location</td><td><%# Eval("Dlocation")%></td></tr>


                    </table>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
