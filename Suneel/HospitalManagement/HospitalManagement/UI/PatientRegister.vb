Imports System.Configuration
Imports System.Data.SqlClient
Imports ClassLib

Public Class PatientRegister

    Private Shared component As IDBComponent = DataFactory.GetComponent
    Dim log As New EventLog
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            Dim name = Patient1.txtName.Text
            If (findDuplicacy(name)) Then
                Dim address = Patient1.txtAddress.Text
                Dim phno = Long.Parse(Patient1.txtPhNo.Text)
                Dim dob = Date.Parse(Patient1.dtPickerDOB.Text)
                Dim reason = Patient1.cmbboxVisit.Text
                Dim doctor = Patient1.txtDoctor.Text
                Dim fees = Patient1.txtFees.Text
                'Call the components
                component.AddPatient(Name, address, phno, dob, reason, doctor, fees)
                MsgBox("Employee data inserted!")
                With log
                    .Source = "OutPatientManagementSystem"
                    .Log = "OPMSLog"
                    .EnableRaisingEvents = True
                    .WriteEntry("Employee data inserted!", EventLogEntryType.Information)
                End With
            End If

            'clear prev texts
            Patient1.txtName.Clear()
            Patient1.txtAddress.Clear()
            Patient1.txtPhNo.Clear()
            'Patient1.dtPickerDOB.Value = DateAndTime.Now
            Patient1.cmbboxVisit.Text = String.Empty
            Patient1.txtDoctor.Clear()
            Patient1.txtFees.Clear()

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

    Private Function findDuplicacy(name As String) As Boolean
        Dim strconn As String = ConfigurationManager.ConnectionStrings("myConn").ConnectionString
        Const strSelect As String = "SELECT count(*) from tblPatient where Name = @name"
        Dim conn As New SqlConnection(strconn)
        Dim cmd As New SqlCommand(strSelect, conn)
        Try
            conn.Open()
            cmd.Parameters.AddWithValue("@name", name)
            Dim reader = cmd.ExecuteReader() 'SELECT Statement
            While reader.Read
                If (CInt(reader(0).ToString) > 0) Then
                    MsgBox("Data already Exisits", MsgBoxStyle.Critical)
                    With log
                        .Source = "OutPatientManagementSystem"
                        .Log = "OPMSLog"
                        .EnableRaisingEvents = True
                        .WriteEntry("Data already Exisits", EventLogEntryType.Error)
                    End With
                    Return False
                Else Return True
                End If
            End While
            Return False
        Catch ex As SqlException
            With log
                .Source = "OutPatientManagementSystem"
                .Log = "OPMSLog"
                .EnableRaisingEvents = True
                .WriteEntry(ex.Message, EventLogEntryType.Error)
            End With
            Throw ex
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class