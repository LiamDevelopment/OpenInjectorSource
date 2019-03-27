Imports System.IO
Public Class ProcessInformation
    Dim CurrentProcess As String '// Variables
    Private Sub ProcessInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Variables.TargetProcess = "" Then MsgBox("You haven't specified the target process.", MsgBoxStyle.Exclamation, "Open Injector" & Variables.ProductVersion)
            LogDebug("Loading process information...")
            LoadProcessInfoToTables() '// Calls the sub to refresh/load the new process information
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Open Injector" & Variables.ProductVersion) '// Tells to user if something went wrong
        End Try
    End Sub
    Public Sub LoadProcessInfoToTables()
        Try

            Dim p As Process = Process.GetProcessById(Variables.TargetProcessID) 'Define a process to get modules and threads from it

            Dim ico As Icon = Icon.ExtractAssociatedIcon(ProcessStartupPath(Variables.TargetProcessID))
            Me.Icon = ico
            Me.Text = ProcessName(Variables.TargetProcessID)

            ProcIcon.Image = ProcessIcon(Variables.TargetProcessID)

            '// Displays the information from the process in many different labels
            lblProcessName.Text = ProcessName(Variables.TargetProcessID)
            lblProcessFileName.Text = ProcessStartupPath(Variables.TargetProcessID)
            lblProcessID.Text = "Process ID: 0x" & Hex(Variables.TargetProcessID) & " (" & Variables.TargetProcessID & ")"
            lblModulesAndThreads.Text = "Modules: " & p.Modules.Count & "   Threads: " & p.Threads.Count

            'Sets the tool tips to match each item
            ToolTip.SetToolTip(lblProcessName, ProcessName(Variables.TargetProcessID) & ".exe")
            ToolTip.SetToolTip(lblProcessFileName, ProcessStartupPath(Variables.TargetProcessID))
            ToolTip.SetToolTip(lblProcessID, "Process ID: 0x" & Hex(Variables.TargetProcessID) & " (" & Variables.TargetProcessID & ")")
            ToolTip.SetToolTip(lblModulesAndThreads, "Modules: " & p.Modules.Count & "   Threads: " & p.Threads.Count)

            ToolTip.SetToolTip(btnKill, "Terminates all processes running on the system with name '" & p.ProcessName & "'.")

            'Load the modules to the table
            For Each _module As ProcessModule In p.Modules
                Dim mName As String = Convert.ToString(_module).Substring(Convert.ToString(_module).LastIndexOf("(") + 1).Replace(")", "")
                Dim newModuleItem As New ListViewItem(mName)
                Dim mBase As Integer = _module.BaseAddress
                Dim mSize As Integer = _module.ModuleMemorySize
                newModuleItem.SubItems.Add("0x" & Hex(mBase))
                newModuleItem.SubItems.Add(GetFileSize(mSize))
                ListViewModules.Items.Add(newModuleItem)
            Next

            'Load the threads to the table
            For Each _thread As ProcessThread In p.Threads
                Dim threadID As String = _thread.Id
                Dim newThreadItem As New ListViewItem(threadID)
                Dim tStartAddress As Integer = _thread.StartAddress
                newThreadItem.SubItems.Add("0x" & Hex(tStartAddress))
                newThreadItem.SubItems.Add(_thread.PriorityLevel.ToString)
                ListViewThreads.Items.Add(newThreadItem)
            Next
            LogDebug("Process information loaded!")
        Catch ex As Exception
            LogDebug("Error while loading process information: " & ex.Message) '// Displays any error messages in debug console
        End Try
    End Sub
    Private Sub btnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        If CurrentProcess = "" Then Exit Sub
        Try
            Dim Target As Process() = Process.GetProcessesByName(Variables.TargetProcess)
            For Each TProcess As Process In Target
                CurrentProcess = TProcess.ProcessName & " 0x" & Hex(TProcess.Id)
                TProcess.Kill()
            Next
            MsgBox("The process '" & CurrentProcess & "' was terminated succesfully!", MsgBoxStyle.Information, "Open Injector" & Variables.ProductVersion)
            Me.Hide()
        Catch ex As Exception
            MsgBox("There was a error when terminating process: " & CurrentProcess, MsgBoxStyle.Critical, "Open Injector" & Variables.ProductVersion)
        End Try
    End Sub
    Private Sub lblProcessFileName_Click(sender As Object, e As EventArgs) Handles lblProcessFileName.Click
        Try
            Process.Start(Path.GetDirectoryName(ProcessStartupPath(Variables.TargetProcessID)), "/root,Folder_Path") '// Opens the startup path folder of selected process
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Open Injector" & Variables.ProductVersion) '// Promts user if there was a error
        End Try
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide() '// Simple close form call
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSuspend.Click
        Dim p As Process = Process.GetProcessById(Variables.TargetProcessID)
        SuspendProcess(p)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSuspend.Click, btnResume.Click
        Dim p As Process = Process.GetProcessById(Variables.TargetProcessID)
        ResumeProcess(p)
    End Sub
End Class