Public Class Test

    Private Sub LabelShowMe_Click(sender As Object, e As EventArgs) Handles LabelShowMe.Click

    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonSaveExit_Click(sender As Object, e As EventArgs) Handles buttonSaveExit.Click
        Me.Close()
        UserHomePage.Show()
    End Sub
End Class