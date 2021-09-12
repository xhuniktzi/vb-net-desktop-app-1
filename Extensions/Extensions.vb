Imports System.Runtime.CompilerServices

Namespace Extensions

    Module Extensions
        <Extension()>
        Public Function IsNotNullOrEmptyOrWhiteSpace(ByVal checkStr As String) As Boolean
            Return String.IsNullOrEmpty(checkStr) Or String.IsNullOrWhiteSpace(checkStr)
        End Function
    End Module

End Namespace
