Imports System.Diagnostics
Module GetProcessInformation
    Public Function ProcessName(ByVal ProcessID As Integer) As String
        Try
            Dim p As Process = Process.GetProcessById(ProcessID)
            Dim name As String = p.ProcessName & ".exe"
            Return name
        Catch ex As Exception
            LogDebug("Error at ProcessName: " & ex.Message, ConsoleColor.Red)
        End Try
        Return Nothing
    End Function
    Public Function ProcessID(ByVal ProcessName As String) As Integer
        If Not ProcessName.Length > 0 Then Return False
        Try
            Dim pID As Integer = Process.GetProcessesByName(ProcessName)(0).Id
            Return pID
        Catch ex As Exception
            LogDebug("Error at ProcessID: " & ex.Message, ConsoleColor.Red)
        End Try
        Return Nothing
    End Function
    Public Function ProcessIcon(ByVal ProcessID As Integer) As Bitmap
        Try
            Dim p As Process = Process.GetProcessById(ProcessID)
            Dim ico As Icon = Icon.ExtractAssociatedIcon(p.MainModule.FileName)
            Return ico.ToBitmap
        Catch ex As Exception
            Return My.Resources.exe_icon
            LogDebug("Error at ProcessIcon: " & ex.Message, ConsoleColor.Red)
        End Try
        Return Nothing
    End Function
    Public Function ProcessDescription(ByVal ProcessID As Integer) As String
        Try
            Dim p As Process = Process.GetProcessById(ProcessID)
            Dim desc As String = p.MainModule.FileVersionInfo.FileDescription
            Return desc
        Catch ex As Exception
            LogDebug("Error at ProcessDescription: " & ex.Message, ConsoleColor.Red)
        End Try
        Return Nothing
    End Function
    Public Function ProcessStartupPath(ByVal ProcessID As Integer) As String
        Try
            Dim p As Process = Process.GetProcessById(ProcessID)
            Dim path As String = p.MainModule.FileName
            Return path
        Catch ex As Exception
            LogDebug("Error at ProcessStartupPath: " & ex.Message, ConsoleColor.Red)
        End Try
        Return Nothing
    End Function
End Module
