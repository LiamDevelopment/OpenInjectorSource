Module FileSizeConversion
    Public Function GetFileSize(ByVal TheFile As String) As String
        '// Function to convert file sizes in much more readable format.'

        Dim DoubleBytes As Double

        If TheFile.Length = 0 Then Return ""
        Dim TheSize As ULong = TheFile
        Dim SizeType As String = ""
        Try
            Select Case TheSize
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(TheSize / 1099511627776)
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(TheSize / 1073741824)
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(TheSize / 1048576)
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(TheSize / 1024)
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = TheSize
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try
    End Function
End Module
