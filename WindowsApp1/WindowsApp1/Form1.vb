Public Class pdfCreator
    Private Sub genarateButton_Click(sender As Object, e As EventArgs) Handles genarateButton.Click
        resumePanel.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        resumePanel.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
