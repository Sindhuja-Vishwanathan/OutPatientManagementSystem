Imports ClassLib

Public Class FindPatients

    Dim serialise As New Serialisation
    Dim log As New EventLog
    Private Sub FindPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            serialise.XmlDeserialize()
            For Each row As DataRow In serialise.ds.Tables(0).Rows

                cmbDoctorName.Items.Add(row(1).ToString())
            Next
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
    Public pageList As PatientList
    Private Shared component As IDBComponent = DataFactory.GetComponent
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            'If pageList Is Nothing Then
            pageList = New PatientList
            pageList.MdiParent = HomePage
            pageList.table = component.GetSelectedPatients(txtPatientName.Text, cmbDoctorName.Text)
            pageList.Show()
            txtPatientName.Clear()
            cmbDoctorName.Text = String.Empty

            'Else pageList.Activate()
            'End If

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

    Private Sub FindPatients_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        HomePage.search = Nothing
    End Sub
End Class