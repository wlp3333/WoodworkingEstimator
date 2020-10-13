Public Class Frm_SinglePiece
    Private Sub btn_solve_Click(sender As Object, e As EventArgs) Handles btn_solve.Click
        tb_console.Text = tb_console.Text + "You clicked on the SOLVE button!" + vbCrLf
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        tb_console.Text = ""
        MsgBox("The console was cleared!")
    End Sub
End Class