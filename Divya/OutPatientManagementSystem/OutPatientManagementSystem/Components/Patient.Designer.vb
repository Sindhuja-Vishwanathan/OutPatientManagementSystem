<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhNo = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblVisitReason = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhNo = New System.Windows.Forms.TextBox()
        Me.dtPickerDOB = New System.Windows.Forms.DateTimePicker()
        Me.cmbboxVisit = New System.Windows.Forms.ComboBox()
        Me.lblDoctor = New System.Windows.Forms.Label()
        Me.lblFees = New System.Windows.Forms.Label()
        Me.txtDoctor = New System.Windows.Forms.TextBox()
        Me.txtFees = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Black
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(3, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(196, 44)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Black
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.White
        Me.lblAddress.Location = New System.Drawing.Point(3, 83)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(196, 44)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPhNo
        '
        Me.lblPhNo.BackColor = System.Drawing.Color.Black
        Me.lblPhNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhNo.ForeColor = System.Drawing.Color.White
        Me.lblPhNo.Location = New System.Drawing.Point(3, 166)
        Me.lblPhNo.Name = "lblPhNo"
        Me.lblPhNo.Size = New System.Drawing.Size(196, 44)
        Me.lblPhNo.TabIndex = 3
        Me.lblPhNo.Text = "Ph.No"
        Me.lblPhNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDOB
        '
        Me.lblDOB.BackColor = System.Drawing.Color.Black
        Me.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDOB.ForeColor = System.Drawing.Color.White
        Me.lblDOB.Location = New System.Drawing.Point(3, 249)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(196, 44)
        Me.lblDOB.TabIndex = 4
        Me.lblDOB.Text = "DOB"
        Me.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVisitReason
        '
        Me.lblVisitReason.BackColor = System.Drawing.Color.Black
        Me.lblVisitReason.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVisitReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitReason.ForeColor = System.Drawing.Color.White
        Me.lblVisitReason.Location = New System.Drawing.Point(3, 332)
        Me.lblVisitReason.Name = "lblVisitReason"
        Me.lblVisitReason.Size = New System.Drawing.Size(196, 44)
        Me.lblVisitReason.TabIndex = 5
        Me.lblVisitReason.Text = "Purpose Of Visit"
        Me.lblVisitReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(321, 0)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(196, 26)
        Me.txtName.TabIndex = 7
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(321, 82)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(196, 26)
        Me.txtAddress.TabIndex = 8
        '
        'txtPhNo
        '
        Me.txtPhNo.Location = New System.Drawing.Point(321, 164)
        Me.txtPhNo.Name = "txtPhNo"
        Me.txtPhNo.Size = New System.Drawing.Size(196, 26)
        Me.txtPhNo.TabIndex = 9
        '
        'dtPickerDOB
        '
        Me.dtPickerDOB.Location = New System.Drawing.Point(321, 246)
        Me.dtPickerDOB.Name = "dtPickerDOB"
        Me.dtPickerDOB.Size = New System.Drawing.Size(196, 26)
        Me.dtPickerDOB.TabIndex = 10
        Me.dtPickerDOB.Value = New Date(2021, 12, 31, 13, 15, 1, 0)
        '
        'cmbboxVisit
        '
        Me.cmbboxVisit.FormattingEnabled = True
        Me.cmbboxVisit.Items.AddRange(New Object() {"CheckUp", "Injury", "Surgery"})
        Me.cmbboxVisit.Location = New System.Drawing.Point(321, 328)
        Me.cmbboxVisit.MaxDropDownItems = 20
        Me.cmbboxVisit.Name = "cmbboxVisit"
        Me.cmbboxVisit.Size = New System.Drawing.Size(196, 28)
        Me.cmbboxVisit.TabIndex = 11
        '
        'lblDoctor
        '
        Me.lblDoctor.BackColor = System.Drawing.Color.Black
        Me.lblDoctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctor.ForeColor = System.Drawing.Color.White
        Me.lblDoctor.Location = New System.Drawing.Point(3, 415)
        Me.lblDoctor.Name = "lblDoctor"
        Me.lblDoctor.Size = New System.Drawing.Size(196, 44)
        Me.lblDoctor.TabIndex = 12
        Me.lblDoctor.Text = "Consult Doctor"
        Me.lblDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFees
        '
        Me.lblFees.BackColor = System.Drawing.Color.Black
        Me.lblFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFees.ForeColor = System.Drawing.Color.White
        Me.lblFees.Location = New System.Drawing.Point(3, 498)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(196, 44)
        Me.lblFees.TabIndex = 13
        Me.lblFees.Text = "Fees"
        Me.lblFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDoctor
        '
        Me.txtDoctor.Enabled = False
        Me.txtDoctor.Location = New System.Drawing.Point(321, 412)
        Me.txtDoctor.Name = "txtDoctor"
        Me.txtDoctor.Size = New System.Drawing.Size(196, 26)
        Me.txtDoctor.TabIndex = 14
        '
        'txtFees
        '
        Me.txtFees.Enabled = False
        Me.txtFees.Location = New System.Drawing.Point(321, 494)
        Me.txtFees.Name = "txtFees"
        Me.txtFees.Size = New System.Drawing.Size(196, 26)
        Me.txtFees.TabIndex = 15
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.Controls.Add(Me.txtFees)
        Me.Controls.Add(Me.txtDoctor)
        Me.Controls.Add(Me.lblFees)
        Me.Controls.Add(Me.lblDoctor)
        Me.Controls.Add(Me.cmbboxVisit)
        Me.Controls.Add(Me.dtPickerDOB)
        Me.Controls.Add(Me.txtPhNo)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblVisitReason)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblPhNo)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Patient"
        Me.Size = New System.Drawing.Size(559, 586)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhNo As Label
    Friend WithEvents lblDOB As Label
    Friend WithEvents lblVisitReason As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhNo As TextBox
    Friend WithEvents dtPickerDOB As DateTimePicker
    Friend WithEvents cmbboxVisit As ComboBox
    Friend WithEvents lblDoctor As Label
    Friend WithEvents lblFees As Label
    Friend WithEvents txtDoctor As TextBox
    Friend WithEvents txtFees As TextBox

    'Manually generated
    Dim serialise As New Serialisation
    Private Sub cmbboxVisit_TextChanged(sender As Object, e As EventArgs) Handles cmbboxVisit.TextChanged
        If Not cmbboxVisit.Text = String.Empty Then
            serialise.XmlDeserialize()
            Dim nameList As List(Of String) = New List(Of String)
            Dim feesList As List(Of Int16) = New List(Of Int16)
            For Each row As DataRow In serialise.ds.Tables(0).Rows
                If row(2).ToString() = cmbboxVisit.Text.ToString Then
                    nameList.Add(row(1).ToString)
                    feesList.Add(row(3).ToString)
                End If
            Next
            Dim rnd = New Random()
            txtDoctor.Text = nameList(rnd.Next(0, nameList.Count))
            txtFees.Text = feesList(rnd.Next(0, feesList.Count))
        End If
    End Sub
End Class
