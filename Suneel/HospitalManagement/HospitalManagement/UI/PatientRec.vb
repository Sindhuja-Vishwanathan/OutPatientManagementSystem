Imports ClassLib
Public Class PatientRec
    Dim pageReg As PatientRegister
    Dim pageList As PatientList
    Dim docList As DoctorList
    Dim log As New EventLog
    Private Shared component As IDBComponent = DataFactory.GetComponent

    Private Sub ListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListToolStripMenuItem.Click
        Try
            If pageList Is Nothing Then
                pageList = New PatientList
                pageList.MdiParent = HomePage
                pageList.table = component.GetAllPatient
                pageList.Show()
            Else pageList.Activate()
            End If

        Catch ex As Exception
            With Log
                .Source = "OutPatientManagementSystem"
                .Log = "OPMSLog"
                .EnableRaisingEvents = True
                .WriteEntry(ex.Message, EventLogEntryType.Error)
            End With
            Throw ex
        End Try
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Try
            If pageReg Is Nothing Then
                pageReg = New PatientRegister
                pageReg.MdiParent = HomePage
                pageReg.Show()
            Else pageReg.Activate()
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

    Public search As FindPatients
    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Try
            If search Is Nothing Then
                search = New FindPatients
                search.MdiParent = HomePage
                search.Show()
            Else search.Activate()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class