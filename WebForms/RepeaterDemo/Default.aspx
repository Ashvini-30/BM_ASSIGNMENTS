<%@ Page Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RepeaterDemo.Default" %>


<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmployeeDBConnectionString %>" SelectCommand="SELECT * FROM [Department]"></asp:SqlDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
           <HeaderTemplate>Deaprtment Data
               </br>
               <table border="1">
                   <thead>
                       <th>Department ID</th
                        <th>Department Name</th>
                        <th>Department Location</th>
                        
                   </thead>
                   

                   </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td> <asp:Label ID="Label1" runat="server" Text='<%# Bind("Deptno")%>'></asp:Label> </td>
                      <td> <asp:Label ID="Label2" runat="server" Text='<%# Bind("Dname")%>'></asp:Label> </td>
                      <td> <asp:Label ID="Label3" runat="server" Text='<%# Eval("Dlocation")%>'></asp:Label> </td>
                   
                   
                </tr>


            </ItemTemplate>
            <AlternatingItemTemplate>
                  <tr style="background-color:bisque">
                    <td> <asp:Label ID="Label1" runat="server" Text='<%# Bind("Deptno")%>'></asp:Label> </td>
                      <td> <asp:Label ID="Label2" runat="server" Text='<%# Bind("Dname")%>'></asp:Label> </td>
                      <td> <asp:Label ID="Label3" runat="server" Text='<%# Eval("Dlocation")%>'></asp:Label> </td>
                   
                   
                </tr>


            </AlternatingItemTemplate>

            

         
             <FooterTemplate>  
                <tr>  
                    <td>  
                        Department Records displayed  
                    </td>  
                </tr>  
                </table>  
            </FooterTemplate>  

            
        </asp:Repeater>
    </asp:Content>
  
