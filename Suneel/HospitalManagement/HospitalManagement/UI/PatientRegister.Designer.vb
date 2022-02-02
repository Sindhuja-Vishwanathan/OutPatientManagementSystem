<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientRegister))
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Patient1 = New OutPatientManagementSystem.Patient()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(83, 645)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(198, 54)
        Me.btnInsert.TabIndex = 1
        Me.btnInsert.Text = "INSERT"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(395, 645)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 53)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Patient1
        '
        Me.Patient1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Patient1.Location = New System.Drawing.Point(83, 33)
        Me.Patient1.Name = "Patient1"
        Me.Patient1.Size = New System.Drawing.Size(559, 586)
        Me.Patient1.TabIndex = 2
        '
        'PatientRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(754, 739)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.Patient1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientRegister"
        Me.Text = "PatientRegister"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInsert As Button
    Friend WithEvents Patient1 As Patient
    Friend WithEvents Button1 As Button
End Class
