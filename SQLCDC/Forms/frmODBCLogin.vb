Public Class frmODBCLogin

    Private LoginObj As New clsLogin
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '   My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        LoginObj.UID = UsernameTextBox.Text
        LoginObj.PWD = PasswordTextBox.Text
        LoginObj.LoggedInChange = True

        Me.Close()
        DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        Me.Close()
        LoginObj.LoggedInChange = False
        DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

    Function getLogin() As clsLogin

        Try
            UsernameTextBox.SelectAll()

doAgain:
            Select Case Me.ShowDialog()
                Case Windows.Forms.DialogResult.OK
                    Return LoginObj
                Case Windows.Forms.DialogResult.Retry
                    GoTo doAgain
                Case Else
                    Return Nothing
            End Select

        Catch ex As Exception
            LogError(ex, "frmLogin")
            Return Nothing
        End Try

    End Function

   

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

        LoginObj.LoggedInChange = True

    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged

        LoginObj.LoggedInChange = True

    End Sub

    Private Sub frmODBCLogin_keydown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, PasswordTextBox.KeyDown

        If e.KeyCode = Keys.Enter Then
            OK_Click(sender, New EventArgs)
        ElseIf e.KeyCode = Keys.F1 Then
            '/// show help
        End If

    End Sub
End Class
