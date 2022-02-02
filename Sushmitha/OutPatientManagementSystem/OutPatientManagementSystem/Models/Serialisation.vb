Imports System.IO
Imports System.Xml.Serialization

Public Class Serialisation
    Public obj
    Public ds As New DataSet
    Public Sub XmlDeserialize()

        Dim xmlSerializer As XmlSerializer = New XmlSerializer(ds.GetType)
        Dim readStream As FileStream = New FileStream("DoctorsDetails.xml", FileMode.Open)
        ds = CType(xmlSerializer.Deserialize(readStream), DataSet)
        readStream.Close()

    End Sub

End Class
