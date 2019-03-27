Imports System.IO

Module Architecture
    Public Enum MachineType
        Native = 0
        x86 = &H14C
        Itanium = &H200
        x64 = &H8664
    End Enum

    Public Function GetAppCompiledMachineType(ByVal fileName As String) As String
        Try
            Const PE_POINTER_OFFSET As Integer = 60
            Const MACHINE_OFFSET As Integer = 4
            Dim data As Byte() = New Byte(4095) {}

            Using s As Stream = New FileStream(fileName, FileMode.Open, FileAccess.Read)
                s.Read(data, 0, 4096)
            End Using

            Dim PE_HEADER_ADDR As Integer = BitConverter.ToInt32(data, PE_POINTER_OFFSET)
            Dim machineUint As Integer = BitConverter.ToUInt16(data, PE_HEADER_ADDR + MACHINE_OFFSET)
            Return (CType(machineUint, MachineType)).ToString()
        Catch ex As Exception
            Return "?" 'Return with '?' if there was error(s)
        End Try
        Return "?"
    End Function
End Module
