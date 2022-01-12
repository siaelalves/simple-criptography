Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox2.Text = ""
        For Each c As Char In RichTextBox1.Text
            MsgBox(Class1.ChangeChar(c))
            RichTextBox2.Text = Class1.ChangeChar(c)
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        i = 0
        j = 0
        For Each c As Char In "ABCDEFGHIJKLMNOPQRSTUVWXY"
            If i < 6 Then
                i += 1
            ElseIf i = 6 Then
                i = 0
                If j < 6 Then
                    Class1.board(i, j) = c
                    j += 1
                ElseIf j = 6 Then
                    j = 0
                End If
            End If
        Next
    End Sub
End Class
