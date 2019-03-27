Module Scrambler
    Public Function ScrambleDLL(ByVal fileName As String)
        Dim rand As New Random
        Dim num As Long = rand.Next(200, 244)
        Dim BeginHash As String = CreateMD5StringFromFile(fileName)
        Dim ResultHash As String
        Dim HashEqual As Boolean

        'This will change the dll hash to make it undetected after injection
        Try
            Using myFileStream As New System.IO.FileStream(fileName, IO.FileMode.Open, IO.FileAccess.ReadWrite)
                myFileStream.Seek(num, IO.SeekOrigin.Begin)
                myFileStream.WriteByte(10)
                myFileStream.Close()
            End Using
        Catch ex As Exception
            LogDebug("Scrambling failed: " & ex.Message & "(" & fileName & ")", ConsoleColor.Red)
            Return False
            End Try
            ResultHash = CreateMD5StringFromFile(fileName)
            If BeginHash = ResultHash Then HashEqual = True
            LogDebug("Running scrambling function...")
            LogDebug("Hashes: " & BeginHash & " --> " & ResultHash & " = " & HashEqual)
        If HashEqual = True Then
            LogDebug("Error! Hashes remained as same.", ConsoleColor.Red)
        Else
            LogDebug("Scrambled succesfully file: " & fileName & " with offset: 0x" & Hex(num), ConsoleColor.Green)
        End If
        Return True
    End Function
End Module
