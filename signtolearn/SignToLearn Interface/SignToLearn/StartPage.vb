Public Class StartPage

    Private Sub buttonCreateProfile_Click(sender As Object, e As EventArgs) Handles buttonCreateProfile.Click
        CreateUser.Show()


    End Sub

    Private Sub buttonLoadProfile_Click(sender As Object, e As EventArgs) Handles buttonLoadProfile.Click
        LoadProfile.Show()
    End Sub
End Class
