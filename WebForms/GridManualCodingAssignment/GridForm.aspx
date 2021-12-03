<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridForm.aspx.cs" Inherits="WebApplicationGrid.GridForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="Empno" DataSourceID="SqlDataSource1" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="Empno" HeaderText="Empno" ReadOnly="True" SortExpression="Empno" />
                <asp:BoundField DataField="Ename" HeaderText="Ename" SortExpression="Ename" />
                <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
                <asp:BoundField DataField="salary" HeaderText="salary" SortExpression="salary" />
                <asp:BoundField DataField="Deptno" HeaderText="Deptno" SortExpression="Deptno" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" DataKeyNames="Empno" DataSourceID="SqlDataSource1">
            <EditItemTemplate>
                Empno:
                <asp:Label ID="EmpnoLabel1" runat="server" Text='<%# Eval("Empno") %>' />
                <br />
                Ename:
                <asp:TextBox ID="EnameTextBox" runat="server" Text='<%# Bind("Ename") %>' />
                <br />
                Designation:
                <asp:TextBox ID="DesignationTextBox" runat="server" Text='<%# Bind("Designation") %>' />
                <br />
                salary:
                <asp:TextBox ID="salaryTextBox" runat="server" Text='<%# Bind("salary") %>' />
                <br />
                Deptno:
                <asp:TextBox ID="DeptnoTextBox" runat="server" Text='<%# Bind("Deptno") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                Empno:
                <asp:TextBox ID="EmpnoTextBox" runat="server" Text='<%# Bind("Empno") %>' />
                <br />
                Ename:
                <asp:TextBox ID="EnameTextBox" runat="server" Text='<%# Bind("Ename") %>' />
                <br />
                Designation:
                <asp:TextBox ID="DesignationTextBox" runat="server" Text='<%# Bind("Designation") %>' />
                <br />
                salary:
                <asp:TextBox ID="salaryTextBox" runat="server" Text='<%# Bind("salary") %>' />
                <br />
                Deptno:
                <asp:TextBox ID="DeptnoTextBox" runat="server" Text='<%# Bind("Deptno") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                Empno:
                <asp:Label ID="EmpnoLabel" runat="server" Text='<%# Eval("Empno") %>' />
                <br />
                Ename:
                <asp:Label ID="EnameLabel" runat="server" Text='<%# Bind("Ename") %>' />
                <br />
                Designation:
                <asp:Label ID="DesignationLabel" runat="server" Text='<%# Bind("Designation") %>' />
                <br />
                salary:
                <asp:Label ID="salaryLabel" runat="server" Text='<%# Bind("salary") %>' />
                <br />
                Deptno:
                <asp:Label ID="DeptnoLabel" runat="server" Text='<%# Bind("Deptno") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString %>" SelectCommand="SELECT * FROM [Employee]" InsertCommand="InsertEmployee" InsertCommandType="StoredProcedure" UpdateCommand="UpdateInfo" UpdateCommandType="StoredProcedure" DeleteCommand="DeleteEmpInfo" DeleteCommandType="StoredProcedure"></asp:SqlDataSource>
        <br />
    </form>
</body>
</html>
