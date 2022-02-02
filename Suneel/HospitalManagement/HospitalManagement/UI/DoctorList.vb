Public Class DoctorList

    Dim serialise As New Serialisation
    Dim log As New EventLog
    Private Sub DoctorList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            HomePage.DoctorListClose()
        Catch ex As Exception
            With log
                .Source = "OutPatientManagementSystem"
                .Log = "OPMSLog"
                .EnableRaisingEvents = True
                .WriteEntry(ex.Message, EventLogEntryType.Error)
            End With
            Throw ex
        End Try
    End Sub

    Private Sub DoctorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            serialise.XmlDeserialize()
            grdDoctors.DataSource = serialise.ds.Tables(0)
        Catch ex As Exception
            With log
                .Source = "OutPatientManagementSystem"
                .Log = "OPMSLog"
                .EnableRaisingEvents = True
                .WriteEntry(ex.Message, EventLogEntryType.Error)
            End With
            Throw ex
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class