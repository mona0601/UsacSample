Public Class SampleEventForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' ボタンがクリックされたときの処理を記述
        MessageBox.Show("ボタンがクリックされました！")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' テキストボックスの内容が変更されたときの処理を記述
        Dim text As String = TextBox1.Text
        MessageBox.Show("テキストが変更されました：" & text)
    End Sub

    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick

    End Sub
End Class