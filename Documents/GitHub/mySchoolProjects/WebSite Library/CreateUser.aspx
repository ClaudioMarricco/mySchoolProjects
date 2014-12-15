<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CreateUser.aspx.vb" Inherits="CreateUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 61%;
        }
        .style2
        {
            width: 159px;
            text-align: right;
        }
        .style3
        {
            width: 309px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    UserName</td>
                <td class="style3">
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Password</td>
                <td class="style3">
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Email</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Security Question</td>
                <td class="style3">
                    What is your favorite book?</td>
            </tr>
            <tr>
                <td class="style2">
                    Answer</td>
                <td class="style3">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Label ID="lblCreateResults" runat="server" Text=""></asp:Label>
    </div>
    <asp:Button ID="btnCreate" runat="server" style="text-align: center" 
        Text="Create" />
    </form>
</body>
</html>
