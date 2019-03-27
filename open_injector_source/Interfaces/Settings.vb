Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettingsValue()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim n As String = MsgBox("Are you sure that you want to reset all settings to their default values?" & vbNewLine & vbNewLine & "This action can not be undone.", MsgBoxStyle.Question.YesNo, "Open Injector" & Variables.ProductVersion)
        If n = vbYes Then
            ResetSettingsValue()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        SaveSettingsValue()
        Main.Refresh() 'Reloads the gradient background also
        Me.Hide()
    End Sub
    Private Sub pTextColor_Click(sender As Object, e As EventArgs) Handles pTextColor.Click
        Dim cDialog As New ColorDialog
        cDialog.ShowDialog()
        pTextColor.BackColor = cDialog.Color()
        LogDebug("Font color changed to: " & cDialog.Color.ToString)
        My.Settings.Save()
        Main.Refresh()
    End Sub
    Private Sub pBackground1_Click(sender As Object, e As EventArgs) Handles pBackground1.Click
        Dim cDialog As New ColorDialog
        cDialog.ShowDialog()
        pBackground1.BackColor = cDialog.Color()
        LogDebug("Background color 1 changed to: " & cDialog.Color.ToString)
        My.Settings.Save()
        Main.Refresh()
    End Sub
    Private Sub pBackground2_Click(sender As Object, e As EventArgs) Handles pBackground2.Click
        Dim cDialog As New ColorDialog
        cDialog.ShowDialog()
        pBackground2.BackColor = cDialog.Color()
        LogDebug("Background color 2 changed to: " & cDialog.Color.ToString)
        My.Settings.Save()
        Main.Refresh()
    End Sub
    Private Sub CheckDebug_CheckedChanged(sender As Object, e As EventArgs) Handles CheckDebug.CheckedChanged
        If CheckDebug.CheckState = CheckState.Checked Then
            If Not My.Settings.SettingsShowDebug = True Then
                MsgBox("You need to press 'OK' and restart the application in order to this take a effect.", MsgBoxStyle.Information, "Open Injector" & Variables.ProductVersion)
            End If
        Else
        End If
    End Sub
    Private Sub btnProcessInformation_Click(sender As Object, e As EventArgs) Handles btnProcessInformation.Click
        ProcessInformation.ShowDialog()
    End Sub
    Private Sub cbInjectionMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbInjectionMethod.SelectedIndexChanged
        LogDebug("Injection method value changed to " & cbInjectionMethod.SelectedIndex)
    End Sub
    Private Sub cbScrambling_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbScrambling.SelectedIndexChanged
        LogDebug("Scrambling value changed to " & cbScrambling.SelectedIndex)
    End Sub
    Private Sub CheckAutoInject_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAutoInject.CheckedChanged
        LogDebug("Auto Inject value changed to: " & CheckAutoInject.Checked)
    End Sub
    Private Sub CheckCloseInject_CheckedChanged(sender As Object, e As EventArgs) Handles CheckCloseInject.CheckedChanged
        LogDebug("Close on inject value changed to: " & CheckCloseInject.Checked)
    End Sub
    Private Sub CheckStealth_CheckedChanged(sender As Object, e As EventArgs) Handles CheckStealth.CheckedChanged
        LogDebug("Stealth inject value changed to: " & CheckStealth.Checked)
    End Sub
    Private Sub nudInjectDelay_ValueChanged(sender As Object, e As EventArgs) Handles nudInjectDelay.ValueChanged
        LogDebug("Inject delay value changed to: " & nudInjectDelay.Value)
    End Sub
    Private Sub nudBetween_ValueChanged(sender As Object, e As EventArgs) Handles nudBetween.ValueChanged
        LogDebug("Delay between value changed to: " & nudBetween.Value)
    End Sub
    Private Sub CheckAutoUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAutoUpdate.CheckedChanged
        LogDebug("Check for updates value changed to: " & CheckAutoUpdate.Checked)
    End Sub
End Class