
Partial Class CreateUser
    Inherits System.Web.UI.Page

    Protected Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
        Dim createStatus As MembershipCreateStatus
        Dim NewUser As MembershipUser = Membership.CreateUser(txtUserName.Text, txtPassword.Text)

        Select Case createStatus
            Case MembershipCreateStatus.Success
                lblCreateResults.Text = "New user created"
            Case MembershipCreateStatus.DuplicateUserName
                lblCreateResults.Text = "User already exists"
            Case MembershipCreateStatus.DuplicateEmail
                lblCreateResults.Text = "That Email already exists"
            Case MembershipCreateStatus.InvalidPassword
                lblCreateResults.Text = "Invalid Password: Must contain 6 characters and 1 non alphanumeric"
            Case Else
                lblCreateResults.Text = "Unknown error: Account not created"

        End Select


    End Sub
End Class
