<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcessInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcessInformation))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tPriority = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StartAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewThreads = New System.Windows.Forms.ListView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.mSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mBase = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListViewModules = New System.Windows.Forms.ListView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ProcIcon = New System.Windows.Forms.PictureBox()
        Me.lblModulesAndThreads = New System.Windows.Forms.Label()
        Me.lblProcessID = New System.Windows.Forms.Label()
        Me.lblProcessFileName = New System.Windows.Forms.Label()
        Me.lblProcessName = New System.Windows.Forms.Label()
        Me.btnKill = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSuspend = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        CType(Me.ProcIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(317, 368)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 25)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tPriority
        '
        Me.tPriority.Text = "Priority"
        Me.tPriority.Width = 91
        '
        'StartAddress
        '
        Me.StartAddress.Text = "Start Address"
        Me.StartAddress.Width = 173
        '
        'tID
        '
        Me.tID.Text = "Thread ID"
        Me.tID.Width = 72
        '
        'ListViewThreads
        '
        Me.ListViewThreads.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.tID, Me.StartAddress, Me.tPriority})
        Me.ListViewThreads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewThreads.FullRowSelect = True
        Me.ListViewThreads.GridLines = True
        Me.ListViewThreads.Location = New System.Drawing.Point(3, 3)
        Me.ListViewThreads.Name = "ListViewThreads"
        Me.ListViewThreads.Size = New System.Drawing.Size(357, 180)
        Me.ListViewThreads.TabIndex = 1
        Me.ListViewThreads.UseCompatibleStateImageBehavior = False
        Me.ListViewThreads.View = System.Windows.Forms.View.Details
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListViewThreads)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(363, 186)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Threads"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'mSize
        '
        Me.mSize.Text = "Module Size"
        Me.mSize.Width = 105
        '
        'mBase
        '
        Me.mBase.Text = "Module Base"
        Me.mBase.Width = 108
        '
        'mName
        '
        Me.mName.Text = "Module Name"
        Me.mName.Width = 115
        '
        'ListViewModules
        '
        Me.ListViewModules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListViewModules.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.mName, Me.mBase, Me.mSize})
        Me.ListViewModules.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewModules.FullRowSelect = True
        Me.ListViewModules.GridLines = True
        Me.ListViewModules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewModules.Location = New System.Drawing.Point(3, 3)
        Me.ListViewModules.Name = "ListViewModules"
        Me.ListViewModules.Size = New System.Drawing.Size(357, 180)
        Me.ListViewModules.TabIndex = 0
        Me.ListViewModules.UseCompatibleStateImageBehavior = False
        Me.ListViewModules.View = System.Windows.Forms.View.Details
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListViewModules)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(363, 186)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Modules"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Location = New System.Drawing.Point(14, 150)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(371, 212)
        Me.TabControl.TabIndex = 6
        '
        'ProcIcon
        '
        Me.ProcIcon.Location = New System.Drawing.Point(11, 23)
        Me.ProcIcon.Name = "ProcIcon"
        Me.ProcIcon.Size = New System.Drawing.Size(35, 35)
        Me.ProcIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProcIcon.TabIndex = 5
        Me.ProcIcon.TabStop = False
        '
        'lblModulesAndThreads
        '
        Me.lblModulesAndThreads.AutoSize = True
        Me.lblModulesAndThreads.Location = New System.Drawing.Point(51, 95)
        Me.lblModulesAndThreads.Name = "lblModulesAndThreads"
        Me.lblModulesAndThreads.Size = New System.Drawing.Size(0, 13)
        Me.lblModulesAndThreads.TabIndex = 4
        '
        'lblProcessID
        '
        Me.lblProcessID.AutoSize = True
        Me.lblProcessID.Location = New System.Drawing.Point(51, 72)
        Me.lblProcessID.Name = "lblProcessID"
        Me.lblProcessID.Size = New System.Drawing.Size(0, 13)
        Me.lblProcessID.TabIndex = 3
        '
        'lblProcessFileName
        '
        Me.lblProcessFileName.AutoSize = True
        Me.lblProcessFileName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblProcessFileName.Location = New System.Drawing.Point(51, 49)
        Me.lblProcessFileName.Name = "lblProcessFileName"
        Me.lblProcessFileName.Size = New System.Drawing.Size(0, 13)
        Me.lblProcessFileName.TabIndex = 2
        '
        'lblProcessName
        '
        Me.lblProcessName.AutoSize = True
        Me.lblProcessName.Location = New System.Drawing.Point(51, 26)
        Me.lblProcessName.Name = "lblProcessName"
        Me.lblProcessName.Size = New System.Drawing.Size(0, 13)
        Me.lblProcessName.TabIndex = 1
        '
        'btnKill
        '
        Me.btnKill.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKill.Location = New System.Drawing.Point(235, 368)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(76, 25)
        Me.btnKill.TabIndex = 8
        Me.btnKill.Text = "Kill Process"
        Me.btnKill.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ProcIcon)
        Me.GroupBox1.Controls.Add(Me.lblModulesAndThreads)
        Me.GroupBox1.Controls.Add(Me.lblProcessID)
        Me.GroupBox1.Controls.Add(Me.lblProcessFileName)
        Me.GroupBox1.Controls.Add(Me.lblProcessName)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 134)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process"
        '
        'btnSuspend
        '
        Me.btnSuspend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSuspend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSuspend.Location = New System.Drawing.Point(6, 368)
        Me.btnSuspend.Name = "btnSuspend"
        Me.btnSuspend.Size = New System.Drawing.Size(105, 25)
        Me.btnSuspend.TabIndex = 9
        Me.btnSuspend.Text = "Suspend Process"
        Me.btnSuspend.UseVisualStyleBackColor = True
        '
        'btnResume
        '
        Me.btnResume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnResume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResume.Location = New System.Drawing.Point(117, 368)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(105, 25)
        Me.btnResume.TabIndex = 10
        Me.btnResume.Text = "Resume Process"
        Me.btnResume.UseVisualStyleBackColor = True
        '
        'ProcessInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 402)
        Me.Controls.Add(Me.btnResume)
        Me.Controls.Add(Me.btnSuspend)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.btnKill)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProcessInformation"
        Me.Text = "Process Information"
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        CType(Me.ProcIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents btnClose As Button
    Friend WithEvents tPriority As ColumnHeader
    Friend WithEvents StartAddress As ColumnHeader
    Friend WithEvents tID As ColumnHeader
    Friend WithEvents ListViewThreads As ListView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents mSize As ColumnHeader
    Friend WithEvents mBase As ColumnHeader
    Friend WithEvents mName As ColumnHeader
    Friend WithEvents ListViewModules As ListView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl As TabControl
    Friend WithEvents ProcIcon As PictureBox
    Friend WithEvents lblModulesAndThreads As Label
    Friend WithEvents lblProcessID As Label
    Friend WithEvents lblProcessFileName As Label
    Friend WithEvents lblProcessName As Label
    Friend WithEvents btnKill As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSuspend As Button
    Friend WithEvents btnResume As Button
End Class
