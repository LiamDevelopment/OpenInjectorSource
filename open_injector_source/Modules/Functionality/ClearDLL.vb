Module ClearDLL
    Public Function ClearDLLFromListView()
        Try
            Main.dllListView.Items.Clear()
            Variables.dllDictionary.Clear()
            LogDebug("dll list cleared succesfully")
            Return True
        Catch ex As Exception
            'Just here to prevent crashes
            Return False
        End Try
    End Function
End Module
