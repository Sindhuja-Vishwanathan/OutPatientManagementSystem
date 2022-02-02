Imports ClassLib

Public Class HomePage

    Dim pageReg As PatientRegister
    Dim pageList As PatientList
    Dim docList As DoctorList
    Dim log As New EventLog

    Public Sub PatientRegisterClose()
        pageReg = Nothing
    End Sub


    Private Shared component As IDBComponent = DataFactory.GetComponent


    Public Sub PatientListClose()
        pageList = Nothing
    End Sub



    Public Sub DoctorListClose()
        docList = Nothing
    End Sub


    Public search As FindPatients

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not EventLog.SourceExists("OutPatientManagementSystem") Then
            EventLog.CreateEventSource("OutPatientManagementSystem", "OPMSLog")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PatientRec.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ViewDocList.Show()
    End Sub
End Class
