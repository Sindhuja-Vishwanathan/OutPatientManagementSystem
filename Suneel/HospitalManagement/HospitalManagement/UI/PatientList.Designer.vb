<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientList
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientList))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdatePatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletePatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grdPatient = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.grdPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdatePatientToolStripMenuItem, Me.DeletePatientToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(196, 68)
        '
        'UpdatePatientToolStripMenuItem
        '
        Me.UpdatePatientToolStripMenuItem.Name = "UpdatePatientToolStripMenuItem"
        Me.UpdatePatientToolStripMenuItem.Size = New System.Drawing.Size(195, 32)
        Me.UpdatePatientToolStripMenuItem.Text = "UpdatePatient"
        '
        'DeletePatientToolStripMenuItem
        '
        Me.DeletePatientToolStripMenuItem.Name = "DeletePatientToolStripMenuItem"
        Me.DeletePatientToolStripMenuItem.Size = New System.Drawing.Size(195, 32)
        Me.DeletePatientToolStripMenuItem.Text = "DeletePatient"
        '
        'grdPatient
        '
        Me.grdPatient.AllowUserToAddRows = False
        Me.grdPatient.AllowUserToDeleteRows = False
        Me.grdPatient.AllowUserToResizeColumns = False
        Me.grdPatient.AllowUserToResizeRows = False
        Me.grdPatient.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grdPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.grdPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPatient.GridColor = System.Drawing.SystemColors.GrayText
        Me.grdPatient.Location = New System.Drawing.Point(12, 12)
        Me.grdPatient.Name = "grdPatient"
        Me.grdPatient.ReadOnly = True
        Me.grdPatient.RowHeadersVisible = False
        Me.grdPatient.RowHeadersWidth = 62
        Me.grdPatient.RowTemplate.Height = 28
        Me.grdPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdPatient.Size = New System.Drawing.Size(1158, 475)
        Me.grdPatient.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(441, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 65)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PatientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(1231, 670)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grdPatient)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PatientList"
        Me.Text = "PatientList"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.grdPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents UpdatePatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeletePatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grdPatient As DataGridView
    Friend WithEvents Button1 As Button
End Class
