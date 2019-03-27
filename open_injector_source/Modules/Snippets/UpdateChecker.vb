Module UpdateChecker
    Public Function CheckLatest(ByVal httpUrl As String, ByVal applicationVersion As String) As Boolean
        '// This is a short code to check latest version of the application from remote host
        '// This is snippet from my other library, rather get just this part of the library than the whole thing.
        Try
            If httpUrl.Contains("https://") Or httpUrl.Contains("http://") Then
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(httpUrl)
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)
                Dim latestVersion = sr.ReadToEnd()
                Dim currentVersion = applicationVersion

                If currentVersion = latestVersion Then
                    'Application is running on latest version
                    Return True
                Else
                    'Applicaiton is not running on latest version
                    Return False
                End If
            Else
                MsgBox("You must enter a valid url to function 'LatestVersion'.", MsgBoxStyle.Critical, "Error Catcher")
                Exit Try
            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message, MsgBoxStyle.Critical, "Error Catcher")
        End Try
        Return True
    End Function
End Module
