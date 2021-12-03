<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StuRegistration.aspx.cs" Inherits="RegistrationForm.StuRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style type="text/css">
        .auto-style1 {
            width: 70%;
            background-color: #C0C0C0;
        }
        .auto-style2 {
            width: 270px;
        }
        .auto-style3 {
            width: 270px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 238px;
        }
        .auto-style6 {
            width: 270px;
            height: 40px;
        }
        .auto-style7 {
            height: 40px;
        }
        .auto-style8 {
            margin-top: 0px;
        }
        .auto-style9 {
            width: 270px;
            height: 174px;
        }
        .auto-style10 {
            height: 174px;
        }
        .auto-style11 {
            margin-left: 0px;
        }
        .auto-style12 {
            width: 270px;
            height: 30px;
        }
        .auto-style13 {
            height: 30px;
        }
        .auto-style14 {
            width: 270px;
            height: 45px;
        }
        .auto-style15 {
            height: 45px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <center>Registration form with Validation<table align="center" class="auto-style1">
                <tr>
                    <td class="auto-style2">First Name</td>
                    <td>
                        <asp:TextBox ID="Textfn" runat="server" Width="207px" CssClass="auto-style11" OnTextChanged="Textfn_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Textfn" Display="Dynamic" ErrorMessage="Fname can't be blank" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Last Name</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="Textln" runat="server" Width="229px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Textln" Display="Dynamic" ErrorMessage="Lname can't be blank" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">User Name</td>
                    <td>
                        <asp:TextBox ID="Textuser" runat="server" Width="232px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="Textuser" Display="Dynamic" ErrorMessage="User Name can't be blank" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="Textpass" runat="server" Height="16px" Width="229px" OnTextChanged="Textpass_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="Textpass" Display="Dynamic" ErrorMessage="Please enter password" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">Confirmed Password</td>
                    <td class="auto-style13">
                        <asp:TextBox ID="Textcpass" runat="server" Width="221px"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="Textcpass" Display="Dynamic" ErrorMessage="password didn't match" ForeColor="Red" ControlToCompare="Textpass"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                     <td class="auto-style14">Mobile No</td>
                    <td class="auto-style15">
                        <asp:TextBox ID="Textmn" runat="server" Width="219px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Textmn" Display="Dynamic" ErrorMessage="Please enter 10 digit no" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                        <br />
                    </td>
                </tr>
        </div>
    </form>
</body>
</html>
