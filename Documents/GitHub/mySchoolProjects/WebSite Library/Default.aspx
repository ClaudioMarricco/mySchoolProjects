<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="text-align: left">

    <form id="form1" runat="server">
    <div id="MasterLogIn">
        <asp:LoginView ID="MasterLoginView" runat="server">
            <LoggedInTemplate>Welcome 
                <asp:LoginName ID="MasterLoginName" runat="server" />
            </LoggedInTemplate>
            <AnonymousTemplate>Welcome Guest</AnonymousTemplate>
        </asp:LoginView>
        &nbsp;&nbsp;[&nbsp;<asp:LoginStatus ID="MasterLoginStatus" runat="server" LogoutAction="Redirect" LogoutPageUrl="~/LoggedOut.aspx" />&nbsp;]&nbsp;&nbsp;
    </div>
    
    <div>
    
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
                <asp:LinkButton ID="LinkBookClub" runat="server" >Book Club</asp:LinkButton>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <br />
    </div>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Search By Title"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;<asp:TextBox ID="txtSearchTitle" runat="server"></asp:TextBox>
        &nbsp;<asp:Button ID="btnSearchTitleGo" runat="server" Text="Go" />
        &nbsp;<asp:Label ID="lblTitleEmpty" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Search By Author"></asp:Label>
    &nbsp; <asp:TextBox ID="txtSearchAuthor" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnSearchAuthorGo" runat="server" Text="Go" 
            style="height: 26px" />
        <asp:Label ID="lblAuthorEmpty" runat="server" Text=""></asp:Label>
    </p>
    <p style="text-align: left">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataSourceID="ObjectDataSource1" AllowSorting="True" 
            style="text-align: left; margin-right: 0px;" DataKeyNames="ISBN">
            <Columns>
                <asp:TemplateField HeaderText="ISBN" SortExpression="ISBN">
                    <EditItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("ISBN") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="View" runat="server" CommandName="View" CommandArgument= '<%# Bind("ISBN") %>'>View</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" >
                <ItemStyle Width="100px" />
                </asp:BoundField>
                <asp:BoundField DataField="Author" HeaderText="Author" 
                    SortExpression="Author" />
                <asp:BoundField DataField="AuthorInfo" HeaderText="AuthorInfo" 
                    SortExpression="AuthorInfo" >
                <ItemStyle HorizontalAlign="Left" Width="300px" />
                </asp:BoundField>
                <asp:CheckBoxField DataField="Available" HeaderText="Available" 
                    SortExpression="Available" />
                <asp:BoundField DataField="DateAvailable" HeaderText="DateAvailable" 
                    SortExpression="DateAvailable" />
                <asp:BoundField DataField="Genre" HeaderText="Genre" 
                    SortExpression="Genre" />
                  
                <asp:BoundField DataField="Synopsis" HeaderText="Synopsis"
                    SortExpression="Synopsis" >
                <ItemStyle HorizontalAlign="Left" Width="600px" />
                </asp:BoundField>
                <asp:ImageField DataAlternateTextField="Thumbnail"  ControlStyle-Height="200" ControlStyle-Width="125"
                    DataImageUrlField="Thumbnail">
<ControlStyle Height="200px" Width="125px"></ControlStyle>
                </asp:ImageField>
                  
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" 
            SelectMethod="GetData" TypeName="DataSet1TableAdapters.BooksTableAdapter" 
            DeleteMethod="Delete" UpdateMethod="Update" InsertMethod="Insert">
            <DeleteParameters>
                <asp:Parameter Name="Original_ISBN" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Author" Type="String" />
                <asp:Parameter Name="AuthorInfo" Type="String" />
                <asp:Parameter Name="Available" Type="Boolean" />
                <asp:Parameter Name="DateAvailable" Type="DateTime" />
                <asp:Parameter Name="Genre" Type="String" />
                <asp:Parameter Name="Synopsis" Type="String" />
                <asp:Parameter Name="Thumbnail" Type="String" />
                <asp:Parameter Name="Original_ISBN" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Author" Type="String" />
                <asp:Parameter Name="AuthorInfo" Type="String" />
                <asp:Parameter Name="Available" Type="Boolean" />
                <asp:Parameter Name="ISBN" Type="Int32" />
                <asp:Parameter Name="DateAvailable" Type="DateTime" />
                <asp:Parameter Name="Genre" Type="String" />
                <asp:Parameter Name="Synopsis" Type="String" />
                <asp:Parameter Name="Thumbnail" Type="String" />
            </InsertParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="SearchTitle" runat="server" 
            InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
            SelectMethod="GetDataBy" TypeName="DataSet1TableAdapters.BooksTableAdapter">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtSearchTitle" Name="Title" PropertyName="Text" 
                    Type="String" />
            </SelectParameters>
            <InsertParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Author" Type="String" />
                <asp:Parameter Name="AuthorInfo" Type="String" />
                <asp:Parameter Name="Available" Type="Boolean" />
                <asp:Parameter Name="ISBN" Type="Int32" />
                <asp:Parameter Name="DateAvailable" Type="DateTime" />
                <asp:Parameter Name="Genre" Type="String" />
                <asp:Parameter Name="Synopsis" Type="String" />
            </InsertParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="SearchAuthor" runat="server" 
            InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" 
            SelectMethod="GetDataBy1" TypeName="DataSet1TableAdapters.BooksTableAdapter">
            <SelectParameters>
                <asp:ControlParameter ControlID="txtSearchAuthor" Name="Author" 
                    PropertyName="Text" Type="String" />
            </SelectParameters>
            <InsertParameters>
                <asp:Parameter Name="Title" Type="String" />
                <asp:Parameter Name="Author" Type="String" />
                <asp:Parameter Name="AuthorInfo" Type="String" />
                <asp:Parameter Name="Available" Type="Boolean" />
                <asp:Parameter Name="ISBN" Type="Int32" />
                <asp:Parameter Name="DateAvailable" Type="DateTime" />
                <asp:Parameter Name="Genre" Type="String" />
                <asp:Parameter Name="Synopsis" Type="String" />
            </InsertParameters>
        </asp:ObjectDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p style="text-align: center">
        <asp:AdRotator ID="AdRotator1" runat="server" Height="100" Width="775" 
            AdvertisementFile="~/Adverts.xml" style="text-align: center"/>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
