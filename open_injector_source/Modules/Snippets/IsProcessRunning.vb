Module IsProcessRunning
    Public Function CheckIfRunning(ByVal ProcessName As String) As Boolean
        If Not ProcessName.Length > 0 Then Return False
        Dim p() As Process
        p = Process.GetProcessesByName(ProcessName)
        If p.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
