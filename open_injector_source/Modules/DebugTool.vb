Imports System.Runtime.InteropServices

Module DebugTool
    Public Sub LogDebug(ByVal log As String, Optional ByVal color As ConsoleColor = ConsoleColor.Gray)

        '##############
        Dim ShowConsole As Boolean = My.Settings.SettingsShowDebug ' to disable the console change the value to false
        '##############

        If ShowConsole = True Then Win32.AllocConsole()
        Dim CurrentTime As DateTime = DateTime.Now
        Dim Output As String = "[" & CurrentTime & "] > " & log
        Debug.WriteLine(Output)
        Console.ForegroundColor = color
        Console.WriteLine(Output)
    End Sub
End Module
Public Class Win32
    <DllImport("kernel32.dll")> Public Shared Function AllocConsole() As Boolean
    End Function
    <DllImport("kernel32.dll")> Public Shared Function FreeConsole() As Boolean
    End Function
End Class
