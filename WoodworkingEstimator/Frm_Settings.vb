Public Class Frm_Settings
    Private Sub Frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the CHECKBOX on open
        If My.Settings.BisRos = True Then cb_BisRos.Checked = True
        If My.Settings.BisRos = False Then cb_BisRos.Checked = False
        'Load the TEXTBOX on open
        Tb_BlaKer.Text = My.Settings.BlaKer
    End Sub

    Private Sub Frm_Settings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Save back the CHECKBOX on close
        If cb_BisRos.Checked = True Then My.Settings.BisRos = True
        If cb_BisRos.Checked = False Then My.Settings.BisRos = False
        'Save back the TEXTBOX on close
        My.Settings.BlaKer = Tb_BlaKer.Text
    End Sub
End Class