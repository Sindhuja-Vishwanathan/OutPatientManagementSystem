Imports ClassLib

Public Class PatientList

    Private Shared component As IDBComponent = DataFactory.GetComponent
    Dim log As New EventLog
    Private Sub PatientList_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            HomePage.PatientListClose()
            FindPatients.pageList = Nothing
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

    Public table
    Private Sub PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            grdPatient.DataSource = table
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

    Private rowindex As DataGridViewRow
    Private Sub grdPatient_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdPatient.CellMouseUp
        Try
            If e.RowIndex >= 0 And e.Button = MouseButtons.Right Then
                grdPatient.Rows(e.RowIndex).Selected = True
                rowindex = grdPatient.Rows(e.RowIndex)
                ContextMenuStrip1.Show(grdPatient, e.Location)
                ContextMenuStrip1.Show(Cursor.Position)
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
    Public page As PatientUpdate
    Private Sub UpdatePatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdatePatientToolStripMenuItem.Click
        Try
            page = New PatientUpdate
            page.MdiParent = HomePage
            page.txtID.Text = rowindex.Cells(0).Value.ToString
            page.Patient3.txtName.Text = rowindex.Cells(1).Value.ToString
            page.Patient3.txtAddress.Text = rowindex.Cells(2).Value.ToString
            page.Patient3.txtPhNo.Text = rowindex.Cells(3).Value.ToString
            page.Patient3.dtPickerDOB.Text = rowindex.Cells(4).Value.ToString
            page.Patient3.cmbboxVisit.Text = rowindex.Cells(5).Value.ToString
            page.Patient3.txtDoctor.Text = rowindex.Cells(6).Value.ToString
            page.Patient3.txtFees.Text = rowindex.Cells(7).Value.ToString
            page.Show()

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

    Private Sub DeletePatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePatientToolStripMenuItem.Click
        Try

            Dim id = rowindex.Cells(0).Value
            component.DeletePatient(id)
            grdPatient.Rows.RemoveAt(rowindex.Index)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class