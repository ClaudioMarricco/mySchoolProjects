<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ViewBook.aspx.vb" Inherits="ViewBook" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell RowSpan="2"><asp:Image ID="imgLeft" runat="server" src="images/books3.JPG" alt="" width="128" height="75"/>
            </asp:TableCell>        
            <asp:TableCell VerticalAlign="Middle"><asp:Image ID="imgCenter" runat="server" src="images/banner.JPG" Width="750" Height="75"/>
            </asp:TableCell>
            <asp:TableCell HorizontalAlign="Right"><asp:Image ID="imgRight" runat="server" src="images/books3.JPG" Width="128" Height="75"/>
            </asp:TableCell>         
        </asp:TableRow>
    </asp:Table>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ISBN" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Author" HeaderText="Author" 
                SortExpression="Author" />
            <asp:BoundField DataField="AuthorInfo" HeaderText="AuthorInfo" 
                SortExpression="AuthorInfo" />
            <asp:CheckBoxField DataField="Available" HeaderText="Available" 
                SortExpression="Available" />
            <asp:BoundField DataField="ISBN" HeaderText="ISBN" ReadOnly="True" 
                SortExpression="ISBN" />
            <asp:BoundField DataField="DateAvailable" HeaderText="DateAvailable" 
                SortExpression="DateAvailable" />
            <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
            <asp:BoundField DataField="Synopsis" HeaderText="Synopsis" 
                SortExpression="Synopsis" />
            <asp:ImageField DataImageUrlField="Thumbnail" ControlStyle-Width="125" ControlStyle-Height="200">
            </asp:ImageField>
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:MetroLibraryConnectionString %>" 
        
        SelectCommand="SELECT [Title], [Author], [AuthorInfo], [Available], [ISBN], [DateAvailable], [Genre], [Synopsis], [Thumbnail] FROM [Books] WHERE ([ISBN] = @ISBN)">
        <SelectParameters>
            <asp:QueryStringParameter Name="ISBN" QueryStringField="view" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
    </form>
</body>
</html>
