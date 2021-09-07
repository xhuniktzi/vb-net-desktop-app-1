Imports System.IO
Imports System.Net
Imports System.Text

Public Class ConnectDatabase
    Public Shared Function ExecPost(Url As String, Content As String, ContentType As String) As String
        Dim req As WebRequest = WebRequest.Create(Url)
        req.Method = "POST"
        req.ContentType = ContentType
        Dim byteData As Byte() = Encoding.UTF8.GetBytes(Content)
        req.ContentLength = byteData.Length
        Dim dataStream As Stream = req.GetRequestStream()
        dataStream.Write(byteData, 0, byteData.Length)
        dataStream.Close()

        Dim res As WebResponse = req.GetResponse()
        Dim resStream As Stream = res.GetResponseStream()
        Dim reader As StreamReader = New StreamReader(resStream)
        Return reader.ReadToEnd()
    End Function
    Public Shared Function ExecGet(Url As String) As String
        Dim req As WebRequest = WebRequest.Create(Url)
        req.Method = "GET"
        Dim res As WebResponse = req.GetResponse()
        Dim reader As StreamReader = New StreamReader(res.GetResponseStream())
        Return reader.ReadToEnd()
    End Function

    Public Shared Sub ExecPut(Url As String, Content As String, ContentType As String)
        Dim req As WebRequest = WebRequest.Create(Url)
        req.Method = "PUT"
        req.ContentType = ContentType
        Dim byteData As Byte() = Encoding.UTF8.GetBytes(Content)
        req.ContentLength = byteData.Length
        Dim dataStream As Stream = req.GetRequestStream()
        dataStream.Write(byteData, 0, byteData.Length)
        dataStream.Close()
        req.GetResponse()
    End Sub

    Public Shared Sub ExeceDelete(Url As String)
        Dim req As WebRequest = WebRequest.Create(Url)
        req.Method = "DELETE"
        req.GetResponse()
    End Sub
End Class
