Public Class Engineer

    Private Sub Txt_engineername_GotFocus(sender As Object, e As EventArgs) Handles Txt_engineername.GotFocus
        ToolTip1.Show("Enter Engineer Name", Txt_engineername)


    End Sub

    Private Sub Txt_engineername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_engineername.KeyPress
        ToolTip1.Hide(Txt_engineername)
    End Sub

    Private Sub Txt_engineername_LostFocus(sender As Object, e As EventArgs) Handles Txt_engineername.LostFocus
        ToolTip1.Hide(Txt_engineername)

    End Sub

    Private Sub Txt_engineername_TextChanged(sender As Object, e As EventArgs) Handles Txt_engineername.TextChanged

    End Sub
End Class