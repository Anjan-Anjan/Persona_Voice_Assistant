<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Assistant
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
        Me.Johntext = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Johntext
        '
        Me.Johntext.BackColor = System.Drawing.SystemColors.Info
        Me.Johntext.Cursor = System.Windows.Forms.Cursors.No
        Me.Johntext.Enabled = False
        Me.Johntext.ForeColor = System.Drawing.SystemColors.Info
        Me.Johntext.Location = New System.Drawing.Point(35, 55)
        Me.Johntext.Multiline = True
        Me.Johntext.Name = "Johntext"
        Me.Johntext.ReadOnly = True
        Me.Johntext.Size = New System.Drawing.Size(315, 75)
        Me.Johntext.TabIndex = 0
        '
        'Assistant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 461)
        Me.Controls.Add(Me.Johntext)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Assistant"
        Me.Text = "Assistant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Johntext As TextBox
End Class
