<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProgramSelectorWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgramSelectorWindow))
        Me.ProgramsPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'ProgramsPanel
        '
        Me.ProgramsPanel.AutoSize = True
        Me.ProgramsPanel.Location = New System.Drawing.Point(3, 2)
        Me.ProgramsPanel.Name = "ProgramsPanel"
        Me.ProgramsPanel.Size = New System.Drawing.Size(290, 78)
        Me.ProgramsPanel.TabIndex = 0
        '
        'ProgramSelectorWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(297, 81)
        Me.Controls.Add(Me.ProgramsPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProgramSelectorWindow"
        Me.Opacity = 0.97R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Program Selector"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgramsPanel As Panel
End Class
