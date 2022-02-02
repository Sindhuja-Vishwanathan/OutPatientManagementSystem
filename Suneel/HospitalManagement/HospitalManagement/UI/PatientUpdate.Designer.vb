<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientUpdate))
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Patient3 = New OutPatientManagementSystem.Patient()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(168, 714)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(211, 56)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.BackColor = System.Drawing.Color.Black
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(168, 46)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(196, 44)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "PatientID"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(488, 46)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(196, 26)
        Me.txtID.TabIndex = 3
        '
        'Patient3
        '
        Me.Patient3.BackColor = System.Drawing.SystemColors.GrayText
        Me.Patient3.Location = New System.Drawing.Point(168, 122)
        Me.Patient3.Name = "Patient3"
        Me.Patient3.Size = New System.Drawing.Size(559, 586)
        Me.Patient3.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(473, 714)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 56)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PatientUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(852, 860)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Patient3)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnUpdate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientUpdate"
        Me.Text = "PatientUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Patient1 As Patient
    Friend WithEvents Patient2 As Patient
    Friend WithEvents Patient3 As Patient
    Friend WithEvents Button1 As Button
End Class
