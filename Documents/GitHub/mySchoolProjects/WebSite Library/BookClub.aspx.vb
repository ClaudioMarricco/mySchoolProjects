
Partial Class BookClub
    Inherits System.Web.UI.Page

    Protected Sub LinkBookClub_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkBookClub.Click
        Response.Redirect("~/BookClub.aspx")
    End Sub

    Protected Sub LinkHome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkHome.Click
        Response.Redirect("~/Default.aspx")
    End Sub
End Class
