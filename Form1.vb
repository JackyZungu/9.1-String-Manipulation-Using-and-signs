Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim text1, text2, text3, text4 As String
        text1 = "Visual"
        text2 = "basic"
        text3 = "2022"
        text4 = text1 + " " + text2 + " " + text3
        MsgBox(text4)
        Me.BackColor = Color.DarkOrchid
    End Sub
End Class
