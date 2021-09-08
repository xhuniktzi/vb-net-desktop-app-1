﻿Public Class ApiConnectException
    Inherits Exception

    Sub New(Message As String)
        MyBase.New(Message)
    End Sub
    Public Overrides ReadOnly Property Message As String
        Get
            Return $"Error de la API: {MyBase.Message}"
        End Get
    End Property
End Class
