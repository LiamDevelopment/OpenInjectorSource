<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcessList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcessList))
        Me.ProcessListView = New System.Windows.Forms.ListView()
        Me.LoadingBar = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProcessListView
        '
        Me.ProcessListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProcessListView.FullRowSelect = True
        Me.ProcessListView.GridLines = True
        Me.ProcessListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ProcessListView.LabelWrap = False
        Me.ProcessListView.Location = New System.Drawing.Point(11, 12)
        Me.ProcessListView.Margin = New System.Windows.Forms.Padding(2, 3, 5, 5)
        Me.ProcessListView.Name = "ProcessListView"
        Me.ProcessListView.Size = New System.Drawing.Size(265, 205)
        Me.ProcessListView.TabIndex = 1
        Me.ProcessListView.TabStop = False
        Me.ProcessListView.UseCompatibleStateImageBehavior = False
        '
        'LoadingBar
        '
        Me.LoadingBar.Location = New System.Drawing.Point(11, 225)
        Me.LoadingBar.Name = "LoadingBar"
        Me.LoadingBar.Size = New System.Drawing.Size(262, 15)
        Me.LoadingBar.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(14, 245)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 3
        '
        'btnSelect
        '
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Location = New System.Drawing.Point(11, 261)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.TabStop = False
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Location = New System.Drawing.Point(92, 261)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(201, 261)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ProcessList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 292)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.LoadingBar)
        Me.Controls.Add(Me.ProcessListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProcessList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "ProcessList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProcessListView As ListView
    Friend WithEvents LoadingBar As ProgressBar
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClose As Button
End Class
