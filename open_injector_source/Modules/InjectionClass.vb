Imports InjectionLibrary 'Imports the open source injection library for injection methods
Imports JLibrary.PortableExecutable
Module InjectionClass
#Region "Functionality"
    Private Sub wait(ByVal seconds As Integer)
        LogDebug("Waiting: " & seconds & " seconds...")
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    Private Function StealthInjection()
        '// This is the poor way to do this, actually does not have any major impact on anything
        '// I would appreciate help with this.

        LogDebug("Starting stealth injection...")

        LogDebug("User is administrator --> " & IsUserAdministrator())

        Dim Target As Process()
        Try
            Target = Process.GetProcessesByName("PnkBstrA")
            If Target.Count = 0 Then LogDebug("Anti-cheat not running --> PnkBstrA.exe")
            For Each TProcess As Process In Target
                LogDebug(TProcess.ProcessName & " was killed succesfully --> 0x" & Hex(TProcess.Id), ConsoleColor.Green)
                TProcess.Kill()
            Next
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Try
            Target = Process.GetProcessesByName("EasyAntiCheat")
            If Target.Count = 0 Then LogDebug("Anti-cheat not running --> EasyAntiCheat.exe")
            For Each TProcess As Process In Target
                LogDebug(TProcess.ProcessName & " was killed succesfully --> 0x" & Hex(TProcess.Id), ConsoleColor.Green)
                TProcess.Kill()
            Next
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try
        Try
            Target = Process.GetProcessesByName("BattleEye")
            If Target.Count = 0 Then LogDebug("Anti-cheat not running --> BattleEye.exe")
            For Each TProcess As Process In Target
                LogDebug(TProcess.ProcessName & " was killed succesfully --> 0x" & Hex(TProcess.Id), ConsoleColor.Green)
                TProcess.Kill()
            Next
        Catch ex As Exception
            LogDebug(ex.Message)
        End Try
        Return True
    End Function
#End Region
    Public Function BeginInjection() As Boolean
        If CheckIfRunning(Variables.TargetProcess) = True Then
            If Main.dllListView.Items.Count > 0 Then

                If My.Settings.SettingsInjectionDelay > 0 Then wait(My.Settings.SettingsInjectionDelay)

                For Each inj As KeyValuePair(Of String, String) In Variables.dllDictionary

                    'At the first scramble dlls if the settings say so
                    If My.Settings.SettingsDLLScrambling = 1 Then ScrambleDLL(inj.Value)
                    If My.Settings.SettingsDLLScrambling = 1 Then wait(3)

                    'Sets the target count to match the dll count
                    Variables.TargetCount = Variables.dllDictionary.Count

                    'Reset the succes count to start counting again from 0
                    Variables.SuccessCount = 0

                    'Wait for the injection delay if it was set
                    If My.Settings.SettingsDelayBetween > 0 Then wait(My.Settings.SettingsDelayBetween)

                    'Use the selected injection method

                    'Check if the stealth injection is selected
                    If My.Settings.SettingsStealthInjection Then StealthInjection()

                    If My.Settings.SettingsInjectionMethod = 0 Then 'Standard Injection
                        Try
                            Dim p As Process = Process.GetProcessById(Variables.TargetProcessID)
                            LogDebug(p.Threads.Count & " " & p.Modules.Count)
                            If InjectionClass.StandardInjection(p.Id, inj.Value) = True Then
                                LogDebug("Injection was succesfully: " & inj.Key & " --> 0x" & Hex(p.Id) & " (Standard Injection)", ConsoleColor.Green)
                                LogDebug(p.Threads.Count & " " & p.Modules.Count)
                                Variables.SuccessCount = +1
                            Else
                                MsgBox("Something went wrong while trying to inject " & inj.Key & " with Standard Injection.", MsgBoxStyle.Critical, "Open Injector" & Variables.ProductVersion)
                                Return False
                            End If
                        Catch ex As Exception
                            LogDebug(ex.Message, ConsoleColor.Red)
                        End Try
                    ElseIf My.Settings.SettingsInjectionMethod = 1 Then 'ThreadHijacking
                        Try
                            Dim p As Process = Process.GetProcessById(Variables.TargetProcessID)
                            If InjectionClass.ThreadHijack(p.Id, inj.Value) = True Then
                                LogDebug("Injection was succesfully: " & inj.Key & " --> 0x" & Hex(p.Id) & " (ThreadHijacking)", ConsoleColor.Green)
                                Variables.SuccessCount = +1
                            Else
                                MsgBox("Something went wrong while trying to inject " & inj.Key & " with ThreadHijacking.", MsgBoxStyle.Critical, "Open Injector" & Variables.ProductVersion)
                                Return False
                            End If
                        Catch ex As Exception
                            LogDebug(ex.Message, ConsoleColor.Red)
                        End Try
                    ElseIf My.Settings.SettingsInjectionMethod = 2 Then 'Manual Map
                        Try
                            Dim p As Process = Process.GetProcessById(Variables.TargetProcessID)
                            If InjectionClass.ManualMap(p.Id, inj.Value) = True Then
                                LogDebug("Injection was succesfully: " & inj.Key & " --> 0x" & Hex(p.Id) & " (ManualMap)", ConsoleColor.Green)
                                Variables.SuccessCount = +1
                            Else
                                MsgBox("Something went wrong while trying to inject " & inj.Key & " with Manual Map.", MsgBoxStyle.Critical, "Open Injector" & Variables.ProductVersion)
                                Return False
                            End If
                        Catch ex As Exception
                            LogDebug(ex.Message, ConsoleColor.Red)
                        End Try
                    Else
                        MsgBox("Something went wrong with the setting please try to reset all the settings from the settings form.", MsgBoxStyle.Exclamation, "Open Injector" & Variables.ProductVersion)
                        Return False
                    End If

                Next
                If Variables.SuccessCount = Variables.TargetCount Then
                    MsgBox("Injection has completed succesfully!", MsgBoxStyle.Information, "Open Injector" & Variables.ProductVersion)
                Else
                    MsgBox("Injection has completed succesfully, but there was a error with some dll(s)!", MsgBoxStyle.Exclamation, "Open Injector" & Variables.ProductVersion)
                End If
            Else
                MsgBox("You don't have any dlls selected yet!", MsgBoxStyle.Critical, "Oopsie!")
                Return False
            End If
        Else
            MsgBox("There is no any processes called '" & Variables.TargetProcess & "' (0x" & Hex(Variables.TargetProcessID) & ") currently running!", MsgBoxStyle.Critical, "Open Injector" & Variables.ProductVersion)
            Main.tboxProcessName.Text = ""
            Return False
        End If
        'Check if the close after injection is set to true
        If My.Settings.SettingsAutoExit = True Then Application.Exit()
        Return True
    End Function
    Public Function ManualMap(ByVal targetProcessID As Integer, ByVal dllPath As String) As Boolean
        Dim injector As InjectionMethod = InjectionMethod.Create(InjectionMethodType.ManualMap)
        Dim hModule As IntPtr = IntPtr.Zero

        Try
            Using img As New PortableExecutable(dllPath)
                hModule = injector.Inject(img, targetProcessID)
            End Using
        Catch ex As Exception
            If ex.Message.Contains("CLR") Then MsgBox("The selected dll contains CLR runtime header. Currently only native binaries are supported; no .NET dependent libraries.", MsgBoxStyle.Exclamation, "CLR runtime error")
            LogDebug("Error --> ManualMap: " & ex.Message, ConsoleColor.Yellow)
            Return False
        End Try

        If hModule <> IntPtr.Zero Then
            Return True
        Else
            Return False
            If injector.GetLastError() IsNot Nothing Then
                MessageBox.Show(injector.GetLastError().Message)
            End If
        End If
    End Function
    Public Function StandardInjection(ByVal targetProcessID As Integer, ByVal dllPath As String) As Boolean
        Dim injector As InjectionMethod = InjectionMethod.Create(InjectionMethodType.Standard)
        Dim hModule As IntPtr = IntPtr.Zero

        Try
            Using img As New PortableExecutable(dllPath)
                hModule = injector.Inject(img, targetProcessID)
            End Using
        Catch ex As Exception
            If ex.Message.Contains("CLR") Then MsgBox("The selected dll contains CLR runtime header. Currently only native binaries are supported; no .NET dependent libraries.", MsgBoxStyle.Exclamation, "CLR runtime error")
            LogDebug("Error --> StandardInjection: " & ex.Message, ConsoleColor.Yellow)
            Return False
        End Try

        If hModule <> IntPtr.Zero Then
            Return True
        Else
            Return False
            If injector.GetLastError() IsNot Nothing Then
                MessageBox.Show(injector.GetLastError().Message)
            End If
        End If
    End Function
    Public Function ThreadHijack(ByVal targetProcessID As Integer, ByVal dllPath As String) As Boolean
        Dim injector As InjectionMethod = InjectionMethod.Create(InjectionMethodType.ThreadHijack)
        Dim hModule As IntPtr = IntPtr.Zero

        Try
            Using img As New PortableExecutable(dllPath)
                hModule = injector.Inject(img, targetProcessID)
            End Using
        Catch ex As Exception
            If ex.Message.Contains("CLR") Then MsgBox("The selected dll contains CLR runtime header. Currently only native binaries are supported; no .NET dependent libraries.", MsgBoxStyle.Exclamation, "CLR runtime error")
            LogDebug("Error --> ThreadHijack: " & ex.Message, ConsoleColor.Yellow)
            Return False
        End Try

        If hModule <> IntPtr.Zero Then
            Return True
        Else
            Return False
            If injector.GetLastError() IsNot Nothing Then
                MessageBox.Show(injector.GetLastError().Message)
            End If
        End If
    End Function
End Module
