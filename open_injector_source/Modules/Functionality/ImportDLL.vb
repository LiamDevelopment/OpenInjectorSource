Module ImportDLL
    Public Function ImportDialog()
        Dim ofDialog As New OpenFileDialog
        ofDialog.Filter = "Dynamic Link Library (*.dll) |*.dll"
        ofDialog.Title = "Open Injector"
        If ofDialog.ShowDialog() = DialogResult.OK Then
            If IO.File.Exists(ofDialog.FileName) Then
                If IO.Path.GetExtension(ofDialog.FileName) <> ".dll" Then Return False
                Dim FilePath = ofDialog.FileName
                If Architecture.GetAppCompiledMachineType(FilePath) <> "x86" And Architecture.GetAppCompiledMachineType(FilePath) <> "x64" Then
                    MsgBox("Looks like that your dll is damaged due too many obfuscations. Please redownload the dll and try again." & vbNewLine & vbNewLine & "Architecture identified as: " & Architecture.GetAppCompiledMachineType(FilePath) & " (?)", MsgBoxStyle.Exclamation, "Architecture not identified!")
                    Return False
                End If
                Dim FileName As String = FilePath.Substring(FilePath.LastIndexOf("\")).Replace("\", "")
                Dim NewItem As New ListViewItem(FileName)
                NewItem.SubItems.Add(Architecture.GetAppCompiledMachineType(FilePath))
                Main.dllListView.Items.Add(NewItem)

                Variables.dllDictionary.Add(FileName, FilePath)

                LogDebug("dll was succesfully imported: " & FileName)
                Return True
            Else
                LogDebug("importing failed, dll not found: " & ofDialog.FileName, ConsoleColor.Red)
                Return False
            End If
        Else
            LogDebug("file dialog closed, there was no value to return", ConsoleColor.Red)
            Return False
        End If
    End Function
    Public Function ImportFromCommandLine(ByVal FilePath As String)
        Dim FileName As String = FilePath.Substring(FilePath.LastIndexOf("\")).Replace("\", "")
        Dim NewItem As New ListViewItem(FileName)
        NewItem.SubItems.Add(Architecture.GetAppCompiledMachineType(FilePath))
        Main.dllListView.Items.Add(NewItem)

        Variables.dllDictionary.Add(FileName, FilePath)
        LogDebug("DLL was succesfully loaded from CommandLineArgs: " & FilePath & " Architecture: " & Architecture.GetAppCompiledMachineType(FilePath), ConsoleColor.Cyan)
    End Function
End Module
