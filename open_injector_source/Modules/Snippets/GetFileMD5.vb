Module GetFileMD5
    Public Function CreateMD5StringFromFile(ByVal Filename As String) As String
        Dim MD5 = System.Security.Cryptography.MD5.Create
        Dim Hash As Byte()
        Dim sb As New System.Text.StringBuilder

        Using st As New IO.FileStream(Filename, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Hash = MD5.ComputeHash(st)
        End Using

        For Each b In Hash
            sb.Append(b.ToString("X2"))
        Next

        Return sb.ToString
    End Function
End Module
