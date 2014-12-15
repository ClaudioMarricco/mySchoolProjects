
Partial Class Login
    Inherits System.Web.UI.Page


    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        BadCredential.Visible = False

        If Membership.ValidateUser(username:=txtUsername.Text, password:=txtPassword.Text) Then
            FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, True)
        End If
        BadCredential.Visible = True

        'Dim UserNameCollection() As String = {"Claudio", "Danny"}
        'Dim PasswordCollection() As String = {"Claudio", "Danny"}

        'For Iterator As Integer = 0 To UserNameCollection.Length = 1
        '    Dim UserNameIsValid As Boolean = (String.Compare(Username.Text, UserNameCollection(Iterator), True) = 0)
        '    Dim PasswordIsValid As Boolean = (String.Compare(Password.Text, PasswordCollection(Iterator), False) = 0)

        '    If UserNameIsValid AndAlso PasswordIsValid Then
        '        FormsAuthentication.RedirectFromLoginPage(Username.Text, False)

        '    Else
        '        BadCredential.Visible = True

        '    End If

        'Next



    End Sub

End Class
