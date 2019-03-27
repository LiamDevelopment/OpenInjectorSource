Module ProcessManipulation
    <Flags()>
    Public Enum ThreadAccess As Integer
        TERMINATE = (&H1)
        SUSPEND_RESUME = (&H2)
        GET_CONTEXT = (&H8)
        SET_CONTEXT = (&H10)
        SET_INFORMATION = (&H20)
        QUERY_INFORMATION = (&H40)
        SET_THREAD_TOKEN = (&H80)
        IMPERSONATE = (&H100)
        DIRECT_IMPERSONATION = (&H200)
    End Enum
    Private Declare Function OpenThread Lib "kernel32.dll" (ByVal dwDesiredAccess As ThreadAccess, ByVal bInheritHandle As Boolean, ByVal dwThreadId As UInteger) As IntPtr
    Private Declare Function SuspendThread Lib "kernel32.dll" (ByVal hThread As IntPtr) As UInteger
    Private Declare Function ResumeThread Lib "kernel32.dll" (ByVal hThread As IntPtr) As UInteger
    Private Declare Function CloseHandle Lib "kernel32.dll" (ByVal hHandle As IntPtr) As Boolean
    Public Function SuspendProcess(ByVal process As System.Diagnostics.Process)
        Try
            For Each t As ProcessThread In process.Threads
                Dim th As IntPtr
                th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
                If th <> IntPtr.Zero Then
                    SuspendThread(th)
                    CloseHandle(th)
                End If
            Next
            LogDebug("Process succesfully suspended: " & process.ProcessName & ".exe", ConsoleColor.Green)
        Catch ex As Exception
            LogDebug("Error while suspending process: " & ex.Message, ConsoleColor.Red)
            Return False
        End Try
        Return True
    End Function
    Public Function ResumeProcess(ByVal process As System.Diagnostics.Process)
        Try
            For Each t As ProcessThread In process.Threads
                Dim th As IntPtr
                th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
                If th <> IntPtr.Zero Then
                    ResumeThread(th)
                    CloseHandle(th)
                End If
            Next
            LogDebug("Process succesfully resumed: " & process.ProcessName & ".exe", ConsoleColor.Green)
        Catch ex As Exception
            LogDebug("Error while resuming process: " & ex.Message, ConsoleColor.Red)
            Return False
        End Try
        Return True
    End Function
End Module
