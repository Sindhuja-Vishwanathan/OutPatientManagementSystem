Imports ClassLib

Public Class ViewDocList
    Dim pageReg As PatientRegister
    Dim pageList As PatientList
    Dim docList As DoctorList
    Dim log As New EventLog
    Private Shared component As IDBComponent = DataFactory.GetComponent
    Public Sub PatientListClose()
        pageList = Nothing
    End Sub

    Private Sub ListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem1.Click
        Try
            If docList Is Nothing Then
                docList = New DoctorList
                docList.MdiParent = HomePage
                docList.Show()
            Else docList.Activate()
            End If

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
End Class