Imports Microsoft.Win32
Module CreateRegistryKeys
    Public Sub CreateNewRegKey()
        Try
            'Creates all the SubKeys
            Dim mainReg As RegistryKey = My.Computer.Registry.CurrentUser.CreateSubKey("Software\Classes\dllfile\shell\OpenInjector\")
            mainReg.SetValue("", "Inject with Open Injector")
            mainReg.SetValue("Icon", (Environment.CommandLine).Trim().Substring(0, Environment.CommandLine.Length - 1))
            LogDebug("key value set to: " & Environment.CommandLine, ConsoleColor.Cyan)
            mainReg.Close()
            LogDebug("new SubKey created: HKEY_CURRENT_USER\Software\Classes\dllfile\shell\OpenInjector\", ConsoleColor.Cyan)
            My.Computer.Registry.CurrentUser.CreateSubKey("Software\Classes\dllfile\shell\OpenInjector\command").SetValue("", Environment.CommandLine & " ""%1""")
            LogDebug("new SubKey created: HKEY_CURRENT_USER\Software\Classes\dllfile\shell\OpenInjector\command", ConsoleColor.Cyan)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
