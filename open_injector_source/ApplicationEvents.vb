Namespace My
    Partial Friend Class MyApplication
        Private Sub AppStart(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf ResolveAssemblies
        End Sub

        Private Function ResolveAssemblies(sender As Object, e As System.ResolveEventArgs) As Reflection.Assembly
            Dim desiredAssembly = New Reflection.AssemblyName(e.Name)

            If desiredAssembly.Name = "InjectionLibrary" Then
                Return Reflection.Assembly.Load(My.Resources.InjectionLibrary) 'replace with your assembly's resource name
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace
