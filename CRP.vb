Public Class CRP

    Private Sub cmdCry_Click_1(sender As System.Object, e As System.EventArgs) Handles cmdCry.Click
        txtCtx.Text = Key.Crypt(txtNtx.Text)
    End Sub

    Private Sub cmdDecry_Click(sender As System.Object, e As System.EventArgs) Handles cmdDecry.Click
        txtNtx.Text = Key.DeCrypt(txtCtx.Text)
    End Sub
End Class