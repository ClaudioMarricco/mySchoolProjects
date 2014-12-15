<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Please Login</h1>
    <p>UserName: 
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></p>
    <p>Password: 
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>&nbsp;</p>
    <p>
        <asp:Button ID="btnLogin" runat="server" Text="Login" style="height: 26px" />
        <asp:ObjectDataSource ID="Credentials" runat="server" 
            InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
            SelectMethod="GetData" 
            TypeName="DataSet1TableAdapters.LoginCredentialsTableAdapter">
            <InsertParameters>
                <asp:Parameter Name="UserLoginEmail" Type="String" />
                <asp:Parameter Name="UserLoginPassword" Type="String" />
            </InsertParameters>
        </asp:ObjectDataSource>
        </p>
    <p>
        <asp:LinkButton ID="lbtnCreate" runat="server"><a href="CreateUser.aspx">create new account</a></asp:LinkButton>
        <asp:Label ID="BadCredential" runat="server" Text="Invalid credentials" ForeColor="Red" Visible="false"></asp:Label></p>
    </div>
    </form>
</body>
</html>
