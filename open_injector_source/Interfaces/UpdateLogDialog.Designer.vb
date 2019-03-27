<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateLogDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateLogDialog))
        Me.LogBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'LogBox
        '
        Me.LogBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogBox.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogBox.Location = New System.Drawing.Point(0, 0)
        Me.LogBox.Margin = New System.Windows.Forms.Padding(7, 3, 3, 3)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.ReadOnly = True
        Me.LogBox.Size = New System.Drawing.Size(830, 675)
        Me.LogBox.TabIndex = 0
        Me.LogBox.TabStop = False
        Me.LogBox.Text = ""
        '
        'UpdateLogDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 675)
        Me.Controls.Add(Me.LogBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateLogDialog"
        Me.Text = "Update Log"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LogBox As RichTextBox
End Class
