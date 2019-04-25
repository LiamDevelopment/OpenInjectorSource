Imports InjectionLibrary 'Imports the open source injection library for injection methods
Imports JLibrary.PortableExecutable
Imports System.ComponentModel
Imports System.IO
Public Class Main
    Dim PCount As Integer = 0
#Region "Styling"
    Private Sub Main_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Try
            Dim g As Graphics = e.Graphics
            Dim p1 As Point = Me.ClientRectangle.Location
            Dim p2 As Point = New Point(Me.ClientRectangle.Right, Me.ClientRectangle.Bottom)
            Using brsGradient As New System.Drawing.Drawing2D.LinearGradientBrush(p1, p2, My.Settings.InterfaceColor1, My.Settings.InterfaceColor2)
                g.FillRectangle(brsGradient, e.ClipRectangle)
            End Using
        Catch ex As Exception
            '// Just to prevent crashes
        End Try
    End Sub
    Private Sub dllListView_ColumnWidthChanged(sender As Object, e As ColumnWidthChangedEventArgs) Handles dllListView.ColumnWidthChanged
        Static FireMe As Boolean = True
        If FireMe = True Then
            FireMe = False
            dllListView.Columns(e.ColumnIndex).Width = 133 'Keeps the column to stay at the same size
            FireMe = True
        End If
    End Sub
    Private Sub dllListView_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles dllListView.ColumnWidthChanging
        e.Cancel = True
    End Sub
    Private Sub dllListView_DragDrop(sender As Object, e As DragEventArgs) Handles dllListView.DragDrop
        Try
            Dim files() As String = e.Data.GetData(DataFormats.FileDrop) '// Create a list of the files
            For Each filepath In files '// For each loop trought all the items
                If Path.GetExtension(filepath) <> ".dll" Then Exit Sub
                If Architecture.GetAppCompiledMachineType(filepath) <> "x86" And Architecture.GetAppCompiledMachineType(filepath) <> "x64" Then
                    MsgBox("Looks like that your dll is damaged due too many obfuscations. Please redownload the dll and try again." & vbNewLine & vbNewLine & "Architecture identified as: " & Architecture.GetAppCompiledMachineType(filepath) & " (?)", MsgBoxStyle.Exclamation, "Architecture not identified!")
                    Exit Sub
                End If
                Dim DllFileName As String = filepath.Substring(filepath.LastIndexOf("\")).Replace("\", "")
                Dim item As New ListViewItem(DllFileName)
                item.SubItems.Add(Architecture.GetAppCompiledMachineType(filepath))
                dllListView.Items.Add(item)
                Variables.dllDictionary.Add(DllFileName, filepath)
                LogDebug("dll succesfully added via drag and drop: " & filepath)
            Next
        Catch ex As Exception
            '// Just to prevent errors
        End Try
    End Sub

    Private Sub dllListView_DragEnter(sender As Object, e As DragEventArgs) Handles dllListView.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
#End Region 'Edits to the interface
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False
        Me.Text = "Open Injector v" & Variables.ProductVersion
        If My.Settings.SettingsAutoUpdate = True Then
            If Not CheckLatest("https://www.dropbox.com/s/4socxab6fo92m6y/InjectorVersion.txt?dl=1", Application.ProductVersion) = True Then
                MsgBox("A new version of Open Injector has been detected." & vbNewLine & vbNewLine & "To obtain the latest version either visit the place where you downloaded the injector head over to GitHub." & vbNewLine & vbNewLine & "You can find the GitHub link from the 'About'.", MsgBoxStyle.Information, "Open Injector" & Variables.ProductVersion)
            End If
        End If
        LogDebug("Log started...")
        'Creates new registry keys
        Dim args = Environment.GetCommandLineArgs()
        Try
            If Not args(1).Length = 0 Then ImportDLL.ImportFromCommandLine(args(1).ToString)
        Catch ex As Exception
            LogDebug("there were no arguments found...")
            CreateNewRegKey()
        End Try
    End Sub
    Private Sub btnImportDLL_Click(sender As Object, e As EventArgs) Handles btnImportDLL.Click
        Try
            ImportDLL.ImportDialog()
        Catch ex As Exception
            If dllListView.Items.Count > Variables.dllDictionary.Count Then
                dllListView.Items.RemoveAt(dllListView.Items.Count - 1)
            End If
            LogDebug("Error at ImportDialog function, error message: " & ex.Message, ConsoleColor.Red)
        End Try
    End Sub
    Private Sub tboxProcessName_TextChanged(sender As Object, e As EventArgs) Handles tboxProcessName.TextChanged
        PCount = 0
    End Sub
    Private Sub tboxProcessName_KeyUp(sender As Object, e As KeyEventArgs) Handles tboxProcessName.KeyUp
        If tboxProcessName.Text.Contains("0x") Then tboxProcessName.Text = ""
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        RemoveDLLFromListView()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearDLLFromListView()
    End Sub
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ProcessList.ShowDialog()
    End Sub
    Private Sub btnInject_Click(sender As Object, e As EventArgs) Handles btnInject.Click
        lblInfo.Text = "Injecting to " & Variables.TargetProcess & ".exe..."
        BeginInjection()
        lblInfo.Text = ""
    End Sub
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        LogDebug("Loading about form")
        About.ShowDialog()
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        LogDebug("Loading settings form")
        Settings.ShowDialog()
    End Sub
    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LogDebug("Closing the application...")
        My.Settings.Save()
    End Sub
    Private Sub CPRunning_Tick(sender As Object, e As EventArgs) Handles CPRunning.Tick
        If PCount = 0 Or Not PCount = Process.GetProcesses.Count Then 'Runs this when ever process count changes
            PCount = Process.GetProcesses.Count 'Saves the current process count
            If Not tboxProcessName.Text.Contains("0x") Then
                If CheckIfRunning(tboxProcessName.Text) = True Or CheckIfRunning(tboxProcessName.Text.ToLower) Then
                    Dim pID As Integer = ProcessID(tboxProcessName.Text)
                    LogDebug("Process is running: " & tboxProcessName.Text & ".exe (0x" & Hex(pID) & ")")
                    If ProcessDescription(pID) = "" Then
                        lblInfo.Text = "No Description" & " (" & Architecture.GetAppCompiledMachineType(ProcessStartupPath(pID)) & ")"
                    Else
                        lblInfo.Text = ProcessDescription(pID) & " (" & Architecture.GetAppCompiledMachineType(ProcessStartupPath(pID)) & ")"
                    End If
                    lblDesc.Text = "Process ID: 0x" & Hex(pID) & " (" & pID & ")"
                    pbProcssIcon.Image = ProcessIcon(pID)

                    Dim p As Process = Process.GetProcessById(pID)
                    Variables.TargetProcess = p.ProcessName
                    Variables.TargetProcessID = pID
                Else
                    If Not Variables.TargetProcess = "" Then Variables.TargetProcess = ""
                    If Not Variables.TargetProcessID = 0 Then Variables.TargetProcessID = 0
                    lblInfo.Text = Nothing
                    lblDesc.Text = Nothing
                    pbProcssIcon.Image = Nothing
                End If
            End If
        End If
        If Variables.TargetProcess = "" Then
            btnInject.Enabled = False
        Else
            btnInject.Enabled = True
        End If
    End Sub
End Class

