<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorList))
        Me.grdDoctors = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grdDoctors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdDoctors
        '
        Me.grdDoctors.AllowUserToAddRows = False
        Me.grdDoctors.AllowUserToDeleteRows = False
        Me.grdDoctors.AllowUserToResizeColumns = False
        Me.grdDoctors.AllowUserToResizeRows = False
        Me.grdDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDoctors.GridColor = System.Drawing.SystemColors.GrayText
        Me.grdDoctors.Location = New System.Drawing.Point(22, 12)
        Me.grdDoctors.Name = "grdDoctors"
        Me.grdDoctors.ReadOnly = True
        Me.grdDoctors.RowHeadersVisible = False
        Me.grdDoctors.RowHeadersWidth = 62
        Me.grdDoctors.RowTemplate.Height = 28
        Me.grdDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDoctors.Size = New System.Drawing.Size(1094, 524)
        Me.grdDoctors.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(442, 578)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DoctorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(1153, 671)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grdDoctors)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DoctorList"
        Me.Text = "DoctorList"
        CType(Me.grdDoctors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdDoctors As DataGridView
    Friend WithEvents Button1 As Button
End Class
