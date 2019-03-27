Public Class Variables
    Public Shared ReadOnly ProductVersionRaw As String = Convert.ToString(My.Application.Info.Version)
    Public Shared ReadOnly ProductVersion As String = ProductVersionRaw.Remove(3, 4)

    Public Shared TargetProcess As String
    Public Shared TargetProcessID As Integer
    Public Shared dllDictionary As New Dictionary(Of String, String)

    Public Shared lbId As New ListBox

    Public Shared TargetCount As Integer
    Public Shared SuccessCount As Integer

End Class
