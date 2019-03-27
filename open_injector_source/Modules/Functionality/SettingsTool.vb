Module SettingsTool
    Public Function LoadSettingsValue()
        Try

            LogDebug("Loading settings...")

            'Just to make sure that settings are loaded correctly
            My.Settings.Reload()

            Settings.cbInjectionMethod.SelectedIndex = My.Settings.SettingsInjectionMethod
            Settings.cbScrambling.SelectedIndex = My.Settings.SettingsDLLScrambling

            Settings.CheckAutoInject.Checked = My.Settings.SettingsAutoInject
            Settings.CheckCloseInject.Checked = My.Settings.SettingsAutoExit
            Settings.CheckStealth.Checked = My.Settings.SettingsStealthInjection
            Settings.nudInjectDelay.Value = My.Settings.SettingsInjectionDelay
            Settings.nudBetween.Value = My.Settings.SettingsDelayBetween

            Settings.pTextColor.BackColor = My.Settings.InterfaceFontColor
            Settings.pBackground1.BackColor = My.Settings.InterfaceColor1
            Settings.pBackground2.BackColor = My.Settings.InterfaceColor2

            Main.lblInfo.ForeColor = My.Settings.InterfaceFontColor
            Main.lblDesc.ForeColor = My.Settings.InterfaceFontColor
            Main.gpInjectList.ForeColor = My.Settings.InterfaceFontColor

            Settings.CheckDebug.Checked = My.Settings.SettingsShowDebug
            Settings.CheckAutoUpdate.Checked = My.Settings.SettingsAutoUpdate

        Catch ex As Exception
            Return False
            LogDebug("Error while loading settings: " & ex.Message, ConsoleColor.Red)
        End Try
        LogDebug("Settings was loaded succesfully", ConsoleColor.Green)
        Return True
    End Function
    Public Function SaveSettingsValue()
        Try
            LogDebug("Saving settings...")

            My.Settings.SettingsInjectionMethod = Settings.cbInjectionMethod.SelectedIndex
            My.Settings.SettingsDLLScrambling = Settings.cbScrambling.SelectedIndex

            My.Settings.SettingsAutoInject = Settings.CheckAutoInject.Checked
            My.Settings.SettingsAutoExit = Settings.CheckCloseInject.Checked
            My.Settings.SettingsStealthInjection = Settings.CheckStealth.Checked
            My.Settings.SettingsInjectionDelay = Settings.nudInjectDelay.Value
            My.Settings.SettingsDelayBetween = Settings.nudBetween.Value

            My.Settings.InterfaceFontColor = Settings.pTextColor.BackColor
            My.Settings.InterfaceColor1 = Settings.pBackground1.BackColor
            My.Settings.InterfaceColor2 = Settings.pBackground2.BackColor

            My.Settings.SettingsShowDebug = Settings.CheckDebug.Checked
            My.Settings.SettingsAutoUpdate = Settings.CheckAutoUpdate.Checked

            'Saves the values as set
            My.Settings.Save()
            My.Settings.Reload()

        Catch ex As Exception
            Return False
            LogDebug("Error while saving settings: " & ex.Message, ConsoleColor.Red)
        End Try
        LogDebug("Settings was saved succesully!", ConsoleColor.Green)
        Return True
    End Function
    Public Function ResetSettingsValue()
        Try
            My.Settings.Reset()
            My.Settings.Save()
            LoadSettingsValue()
        Catch ex As Exception
            Return False
            LogDebug("Error while saving settings: " & ex.Message, ConsoleColor.Red)
        End Try
        LogDebug("Settings was reseted succesfully", ConsoleColor.Green)
        Return True
    End Function
End Module

