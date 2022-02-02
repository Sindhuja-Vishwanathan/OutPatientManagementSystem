Imports ClassLib

Public Class PatientUpdate

    Private Shared component As IDBComponent = DataFactory.GetComponent
    Dim log As New EventLog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim id = txtID.Text
            Dim name = Patient3.txtName.Text
            Dim address = Patient3.txtAddress.Text
            Dim phno = Long.Parse(Patient3.txtPhNo.Text)
            Dim dob = Date.Parse(Patient3.dtPickerDOB.Text)
            Dim reason = Patient3.cmbboxVisit.Text
            Dim doctor = Patient3.txtDoctor.Text
            Dim fees = Patient3.txtFees.Text
            'call the components
            component.UpdatePatient(id, name, address, phno, dob, reason, doctor, fees)
            MsgBox("Employee data Updated!")
            With log
                .Source = "OutPatientManagementSystem"
                .Log = "OPMSLog"
                .EnableRaisingEvents = True
                .WriteEntry("Employee data Updated!", EventLogEntryType.Information)
            End With

            'clear prev texts
            Patient3.txtName.Clear()
            Patient3.txtAddress.Clear()
            Patient3.txtPhNo.Clear()
            'Patient3.dtPickerDOB.Value = DateAndTime.Now
            Patient3.cmbboxVisit.Text = String.Empty
            Patient3.txtDoctor.Clear()
            Patient3.txtFees.Clear()
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class