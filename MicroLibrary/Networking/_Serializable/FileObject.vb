﻿Namespace Networking.Serializable
    <Serializable>
    Public Class FileObject
        Public FileBytes() As Byte
        Public Property Extension As String
        Sub New() : End Sub
        Sub New(Stream As IO.FileStream)
            ReDim FileBytes(Stream.Length)
            Stream.Read(FileBytes, 0, Stream.Length)
        End Sub
    End Class
End Namespace