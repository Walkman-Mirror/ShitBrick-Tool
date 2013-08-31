Public Class SelectArch

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "32-Bit" Then
            YouAreASHit.Text = "You are shit."
        End If
        If ComboBox1.Text = "64-Bit" Then
            YouAreASHit.Text = "You are swagggg."
        End If
        If ComboBox1.Text = "69-Bit" Then
            YouAreASHit.Text = "3=> ;)"
            MsgBox("You disgust me.")
        End If
    End Sub

    Private Sub SelectArch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ComboBox1.Text = "32-Bit" Then
            My.Settings.SHITTTER = "32-Bit"
            My.Settings.Save()
        End If
        If ComboBox1.Text = "64-Bit" Then
            My.Settings.SHITTTER = "64-Bit"
            My.Settings.Save()
        End If
        If ComboBox1.Text = "69-Bit" Then
            My.Settings.SHITTTER = "69-Bit"
            My.Settings.Save()
        End If
    End Sub
End Class