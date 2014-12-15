<%@ Page Language="VB" AutoEventWireup="false" CodeFile="BookClub.aspx.vb" Inherits="BookClub" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" 
            style="text-align: left" >
        <asp:TableRow>
            <asp:TableCell RowSpan="2"><asp:Image ID="imgLeft" runat="server" src="images/books3.JPG" alt="" width="128" height="75"/>
            
            </asp:TableCell>        
            <asp:TableCell VerticalAlign="Middle"><asp:Image ID="imgCenter" runat="server" src="images/banner.JPG" Width="750" Height="75"/>
            
            </asp:TableCell>
            <asp:TableCell HorizontalAlign="Right"><asp:Image ID="imgRight" runat="server" src="images/books3.JPG" Width="128" Height="75"/>
            
            </asp:TableCell>         
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:LinkButton ID="LinkHome" runat="server">Home</asp:LinkButton>
            </asp:TableCell>
            <asp:TableCell>
                <asp:LinkButton ID="LinkBookClub" runat="server">Book Club</asp:LinkButton>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
    <asp:GridView ID="GridViewBookClub" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
