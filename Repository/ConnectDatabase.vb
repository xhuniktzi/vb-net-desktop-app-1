Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class ConnectDatabase
    Public Shared Function ExecPost(Url As String, Content As String, ContentType As String) As String
        Try
            Dim req As WebRequest = WebRequest.Create(Url)
            req.Method = "POST"
            req.ContentType = ContentType
            Dim byteData As Byte() = Encoding.UTF8.GetBytes(Content)
            req.ContentLength = byteData.Length
            Dim dataStream As Stream = req.GetRequestStream()
            dataStream.Write(byteData, 0, byteData.Length)
            dataStream.Close()

            Dim res As WebResponse = req.GetResponse()
            Dim reader As StreamReader = New StreamReader(res.GetResponseStream())
            Return reader.ReadToEnd()
        Catch ex As WebException
            Dim reader As StreamReader = New StreamReader(ex.Response.GetResponseStream())
            Throw New ApiConnectException(reader.ReadToEnd())
        End Try
    End Function
    Public Shared Function ExecGet(Url As String) As String
        Try
            Dim req As WebRequest = WebRequest.Create(Url)
            req.Method = "GET"
            Dim res As WebResponse = req.GetResponse()
            Dim reader As StreamReader = New StreamReader(res.GetResponseStream())
            Return reader.ReadToEnd()
        Catch ex As WebException
            Dim reader As StreamReader = New StreamReader(ex.Response.GetResponseStream())
            Throw New ApiConnectException(reader.ReadToEnd())
        End Try
    End Function

    Public Shared Sub ExecPut(Url As String, Content As String, ContentType As String)
        Try
            Dim req As WebRequest = WebRequest.Create(Url)
            req.Method = "PUT"
            req.ContentType = ContentType
            Dim byteData As Byte() = Encoding.UTF8.GetBytes(Content)
            req.ContentLength = byteData.Length
            Dim dataStream As Stream = req.GetRequestStream()
            dataStream.Write(byteData, 0, byteData.Length)
            dataStream.Close()
            req.GetResponse()
        Catch ex As WebException
            Dim reader As StreamReader = New StreamReader(ex.Response.GetResponseStream())
            Throw New ApiConnectException(reader.ReadToEnd())
        End Try
    End Sub

    Public Shared Sub ExeceDelete(Url As String)
        Try
            Dim req As WebRequest = WebRequest.Create(Url)
            req.Method = "DELETE"
            req.GetResponse()
        Catch ex As WebException
            Dim reader As StreamReader = New StreamReader(ex.Response.GetResponseStream())
            Throw New ApiConnectException(reader.ReadToEnd())
        End Try
    End Sub
End Class
