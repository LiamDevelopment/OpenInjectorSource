Imports System.Threading
Public Class ProcessList
    Dim LoadingThread As Thread
    Dim imgs As New ImageList
    Dim index As Integer
#Region "Gigantic Loading Function"
    Private Sub LoadProcessList()
        'Clears everything if needed
        imgs = New ImageList()
        ProcessListView.Items.Clear()
        Variables.lbId.Items.Clear()
        'Setups everything to be ready
        Dim index As Integer = 0

        imgs.ImageSize = New Size(24, 24)
        imgs.ImageSize = New Size(24, 24)

        ProcessListView.View = View.Tile
        ProcessListView.MultiSelect = False
        ProcessListView.FullRowSelect = True
        ProcessListView.LargeImageList = imgs

        btnRefresh.Enabled = False

        LoadingBar.Maximum = Process.GetProcesses.Count

        For Each Proc As Process In Process.GetProcesses
            Try
                'Define variables
                Dim ico As Icon = Icon.ExtractAssociatedIcon(Proc.MainModule.FileName)
                Dim CharCount As Integer = 8 - Hex(Proc.Id).Length
                Dim procID As String = StrDup(CharCount, "0") + Hex(Proc.Id)

                'Add everything to the lists
                Variables.lbId.Items.Add(Proc.Id)
                imgs.Images.Add(ico.ToBitmap)
                ProcessListView.Items.Add(procID & "-" & Proc.ProcessName & ".exe", index)

                'Increases the values
                index += 1
                LoadingBar.Value += 1

                'Update the status label
                Dim prog As Double = Math.Round(LoadingBar.Value / Process.GetProcesses.Count * 100, 2)
                lblStatus.Text = "Loading process list... (" & prog & "%/100.00%)"

            Catch denied As Exception
                Try
                    'Increase the value anyway because this is caused by "acces denied" error
                    LoadingBar.Value += 1
                Catch ex As Exception
                    'If something goes wrong with the progressbar values then go to start
                    LoadProcessList()
                End Try
            End Try
        Next
        'Clear things afterwards
        lblStatus.Text = ""
        LoadingBar.Value = 0
        btnRefresh.Enabled = True
    End Sub
#End Region
    Private Sub ProcessList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disable crossthreadcall checking
        CheckForIllegalCrossThreadCalls = False
        'Setups everything
        LoadingThread = New Thread(AddressOf Me.LoadProcessList)
        LoadingThread.Start()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadingThread = New Thread(AddressOf Me.LoadProcessList)
        LoadingThread.Start()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try
            Dim p As Process = Process.GetProcessById(Convert.ToInt16(Variables.lbId.SelectedItem))

            'Checks if the target process is 64-bit
            Try
                If Architecture.GetAppCompiledMachineType(p.MainModule.FileName) = "x64" Then
                    MsgBox("You're trying to select 32-bit process. This injector works only with 64-bit softwares.", MsgBoxStyle.Exclamation, "Oopsie!")
                    Exit Sub
                End If
            Catch enumerateError As Exception
                'This is known error caused by acces violation
                LogDebug("failed to get process architecure: " & enumerateError.Message)
            End Try

            Dim name As String = p.ProcessName
            Dim pID As Integer = p.Id

            Variables.TargetProcess = name
            Variables.TargetProcessID = pID

            Main.tboxProcessName.Text = "0x" & Hex(pID)
            If CheckIfRunning(name) = True Then
                LogDebug("Process is running: " & name & ".exe")
                If ProcessDescription(pID) = "" Then
                    Main.lblInfo.Text = ProcessName(pID) & " (" & Architecture.GetAppCompiledMachineType(ProcessStartupPath(pID)) & ")"
                Else
                    Main.lblInfo.Text = ProcessDescription(pID) & " (" & Architecture.GetAppCompiledMachineType(ProcessStartupPath(pID)) & ")"
                End If
                Main.lblDesc.Text = "Process ID: 0x" & Hex(pID) & " (" & pID & ")"
                Main.pbProcssIcon.Image = ProcessIcon(pID)
            Else
                Main.lblInfo.Text = Nothing
                Main.lblDesc.Text = Nothing
                Main.pbProcssIcon.Image = Nothing
            End If
            Me.Hide()
        Catch ex As Exception
            'Just to prevent any crashes
        End Try
    End Sub

    Private Sub ProcessListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProcessListView.SelectedIndexChanged
        Try
            Variables.lbId.SelectedIndex = ProcessListView.SelectedIndices(0)
            lblStatus.Text = ProcessListView.SelectedItems(0).Text
        Catch ex As Exception
        End Try
    End Sub
End Class