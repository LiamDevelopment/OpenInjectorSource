Module RemoveDLL
    Public Function RemoveDLLFromListView()
        Try
            '// This removes the selected file from the listview and from the dll dictionary
            If Main.dllListView.SelectedIndices(0) >= 0 Then
                Variables.dllDictionary.Remove(Main.dllListView.SelectedItems(0).Text)
                For i As Integer = (Main.dllListView.SelectedItems.Count - 1) To 0 Step -1
                    Dim i2 As Integer = i + 2
                    LogDebug("dll removed succesfully: " & Main.dllListView.SelectedItems(0).Text)
                    Main.dllListView.Items.Remove(Main.dllListView.SelectedItems(i))
                Next
            End If
        Catch ex As Exception
            '// Just here to prevent crashes
            Return False
        End Try
        Return True
    End Function
End Module
