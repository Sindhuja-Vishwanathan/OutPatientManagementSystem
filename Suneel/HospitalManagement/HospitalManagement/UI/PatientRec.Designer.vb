<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientRec
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
        Me.ListToolStripMenuItem = New System.Windows.Forms.Button()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.Button()
        Me.FindToolStripMenuItem = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Location = New System.Drawing.Point(269, 71)
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(175, 54)
        Me.ListToolStripMenuItem.TabIndex = 0
        Me.ListToolStripMenuItem.Text = "List"
        Me.ListToolStripMenuItem.UseVisualStyleBackColor = True
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Location = New System.Drawing.Point(269, 165)
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(175, 59)
        Me.RegisterToolStripMenuItem.TabIndex = 1
        Me.RegisterToolStripMenuItem.Text = "Register"
        Me.RegisterToolStripMenuItem.UseVisualStyleBackColor = True
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Location = New System.Drawing.Point(269, 263)
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(175, 65)
        Me.FindToolStripMenuItem.TabIndex = 2
        Me.FindToolStripMenuItem.Text = "Search"
        Me.FindToolStripMenuItem.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(269, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 65)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PatientRec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FindToolStripMenuItem)
        Me.Controls.Add(Me.RegisterToolStripMenuItem)
        Me.Controls.Add(Me.ListToolStripMenuItem)
        Me.Name = "PatientRec"
        Me.Text = "PatientRec"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListToolStripMenuItem As Button
    Friend WithEvents RegisterToolStripMenuItem As Button
    Friend WithEvents FindToolStripMenuItem As Button
    Friend WithEvents Button1 As Button
End Class
