Imports System.Net
Public Class Form1

    Public WithEvents download As New WebClient

  

    Private Sub TextBox2_Clicked(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""
        FolderBrowserDialog1.ShowDialog()
        TextBox2.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        a = TextBox1.Text.ToString()
        If (Not a.StartsWith("http://")) Then
            TextBox1.Text = "http://" & TextBox1.Text
        End If

        download.DownloadFileAsync(New Uri(TextBox1.Text), TextBox2.Text + "\" + TextBox3.Text)

    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub download_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles download.DownloadFileCompleted

        MessageBox.Show("download complete")

    End Sub

 

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox3.Text = ""
    End Sub

    
    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class