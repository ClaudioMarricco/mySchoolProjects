Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim strAppPath As String
        strAppPath = Request.ApplicationPath
        If Right(strAppPath, 1) = "/" Then
            strAppPath = strAppPath & "images/"
        Else
            strAppPath = strAppPath & "/images/"
        End If

        imgLeft.ImageUrl = strAppPath & imgLeft.ImageUrl
        imgCenter.ImageUrl = strAppPath & imgCenter.ImageUrl
        imgRight.ImageUrl = strAppPath & imgRight.ImageUrl


    End Sub

    Protected Sub AdRotator1_AdCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.AdCreatedEventArgs) Handles AdRotator1.AdCreated

    End Sub

    Protected Sub SearchTitleGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearchTitleGo.Click
        If txtSearchTitle.Text = "" Then
            lblTitleEmpty.Text = "Please enter a Title"
        Else
            GridView1.DataSourceID = ""
            GridView1.DataSource = SearchTitle
            GridView1.DataBind()
            txtSearchAuthor.Text = ""
            txtSearchTitle.Text = ""
            lblTitleEmpty.Text = ""
            lblAuthorEmpty.Text = ""
        End If
        

    End Sub

    Protected Sub ObjectDataSourceSearchTitle_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles SearchTitle.Selecting

    End Sub
    Protected Sub GridView1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        Response.Redirect("~/ViewBook.aspx?view=" + e.CommandArgument)
    End Sub

    Protected Sub btnSearchAuthorGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearchAuthorGo.Click
        If txtSearchAuthor.Text = "" Then
            lblAuthorEmpty.Text = "Please enter Author name"
        Else
            GridView1.DataSourceID = ""
            GridView1.DataSource = SearchAuthor
            GridView1.DataBind()
            txtSearchAuthor.Text = ""
            txtSearchTitle.Text = ""
            lblAuthorEmpty.Text = ""
            lblTitleEmpty.Text = ""
        End If
    End Sub

    Protected Sub LinkBookClub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkBookClub.Click
        Response.Redirect("~/BookClub.aspx")
    End Sub

    Protected Sub LinkHome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkHome.Click
        Response.Redirect("~/Default.aspx")
    End Sub

End Class
