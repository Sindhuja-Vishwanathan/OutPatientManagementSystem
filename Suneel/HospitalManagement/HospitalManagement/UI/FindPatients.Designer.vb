<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindPatients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindPatients))
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.lblDoctorName = New System.Windows.Forms.Label()
        Me.txtPatientName = New System.Windows.Forms.TextBox()
        Me.cmbDoctorName = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPatientName
        '
        Me.lblPatientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(86, 53)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(192, 53)
        Me.lblPatientName.TabIndex = 0
        Me.lblPatientName.Text = "Patient Name:"
        Me.lblPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDoctorName
        '
        Me.lblDoctorName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDoctorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoctorName.Location = New System.Drawing.Point(86, 137)
        Me.lblDoctorName.Name = "lblDoctorName"
        Me.lblDoctorName.Size = New System.Drawing.Size(192, 53)
        Me.lblDoctorName.TabIndex = 1
        Me.lblDoctorName.Text = "Doctor Name:"
        Me.lblDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPatientName
        '
        Me.txtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientName.Location = New System.Drawing.Point(423, 53)
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(192, 30)
        Me.txtPatientName.TabIndex = 2
        '
        'cmbDoctorName
        '
        Me.cmbDoctorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDoctorName.FormattingEnabled = True
        Me.cmbDoctorName.Location = New System.Drawing.Point(423, 137)
        Me.cmbDoctorName.Name = "cmbDoctorName"
        Me.cmbDoctorName.Size = New System.Drawing.Size(192, 33)
        Me.cmbDoctorName.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(86, 271)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(217, 77)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(398, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 77)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FindPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbDoctorName)
        Me.Controls.Add(Me.txtPatientName)
        Me.Controls.Add(Me.lblDoctorName)
        Me.Controls.Add(Me.lblPatientName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FindPatients"
        Me.Text = "FindPatients"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPatientName As Label
    Friend WithEvents lblDoctorName As Label
    Friend WithEvents txtPatientName As TextBox
    Friend WithEvents cmbDoctorName As ComboBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Button1 As Button
End Class
