<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.dllListView = New System.Windows.Forms.ListView()
        Me.Column1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Column2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnImportDLL = New System.Windows.Forms.Button()
        Me.tboxProcessName = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.gpInjectList = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnInject = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.lblProcessName = New System.Windows.Forms.Label()
        Me.pbProcssIcon = New System.Windows.Forms.PictureBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CPRunning = New System.Windows.Forms.Timer(Me.components)
        Me.gpInjectList.SuspendLayout()
        CType(Me.pbProcssIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dllListView
        '
        Me.dllListView.AllowDrop = True
        Me.dllListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Column1, Me.Column2})
        Me.dllListView.FullRowSelect = True
        Me.dllListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.dllListView.Location = New System.Drawing.Point(104, 17)
        Me.dllListView.MultiSelect = False
        Me.dllListView.Name = "dllListView"
        Me.dllListView.Scrollable = False
        Me.dllListView.ShowGroups = False
        Me.dllListView.Size = New System.Drawing.Size(209, 114)
        Me.dllListView.TabIndex = 0
        Me.dllListView.TabStop = False
        Me.dllListView.UseCompatibleStateImageBehavior = False
        Me.dllListView.View = System.Windows.Forms.View.Details
        '
        'Column1
        '
        Me.Column1.Text = "Name"
        Me.Column1.Width = 133
        '
        'Column2
        '
        Me.Column2.Text = "Architecture"
        Me.Column2.Width = 94
        '
        'btnImportDLL
        '
        Me.btnImportDLL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportDLL.ForeColor = System.Drawing.Color.Black
        Me.btnImportDLL.Location = New System.Drawing.Point(6, 19)
        Me.btnImportDLL.Name = "btnImportDLL"
        Me.btnImportDLL.Size = New System.Drawing.Size(92, 23)
        Me.btnImportDLL.TabIndex = 1
        Me.btnImportDLL.TabStop = False
        Me.btnImportDLL.Text = "Add"
        Me.btnImportDLL.UseVisualStyleBackColor = True
        '
        'tboxProcessName
        '
        Me.tboxProcessName.Location = New System.Drawing.Point(67, 26)
        Me.tboxProcessName.Name = "tboxProcessName"
        Me.tboxProcessName.Size = New System.Drawing.Size(186, 20)
        Me.tboxProcessName.TabIndex = 2
        Me.tboxProcessName.TabStop = False
        '
        'btnSelect
        '
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.Location = New System.Drawing.Point(259, 24)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.TabStop = False
        Me.btnSelect.Text = "Select"
        Me.ToolTip1.SetToolTip(Me.btnSelect, "Opens the process list dialog.")
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'gpInjectList
        '
        Me.gpInjectList.BackColor = System.Drawing.Color.Transparent
        Me.gpInjectList.Controls.Add(Me.Button1)
        Me.gpInjectList.Controls.Add(Me.btnClear)
        Me.gpInjectList.Controls.Add(Me.btnRemove)
        Me.gpInjectList.Controls.Add(Me.btnImportDLL)
        Me.gpInjectList.Controls.Add(Me.dllListView)
        Me.gpInjectList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gpInjectList.ForeColor = System.Drawing.Color.White
        Me.gpInjectList.Location = New System.Drawing.Point(10, 76)
        Me.gpInjectList.Name = "gpInjectList"
        Me.gpInjectList.Size = New System.Drawing.Size(324, 144)
        Me.gpInjectList.TabIndex = 5
        Me.gpInjectList.TabStop = False
        Me.gpInjectList.Text = "Inject List"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(6, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.TabStop = False
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(6, 80)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(6, 51)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(92, 23)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.TabStop = False
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnInject
        '
        Me.btnInject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInject.Location = New System.Drawing.Point(242, 225)
        Me.btnInject.Name = "btnInject"
        Me.btnInject.Size = New System.Drawing.Size(92, 23)
        Me.btnInject.TabIndex = 6
        Me.btnInject.TabStop = False
        Me.btnInject.Text = "Inject"
        Me.ToolTip1.SetToolTip(Me.btnInject, "Injects the selected DLL(s) to the targer process.")
        Me.btnInject.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.Location = New System.Drawing.Point(10, 225)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(92, 23)
        Me.btnAbout.TabIndex = 7
        Me.btnAbout.TabStop = False
        Me.btnAbout.Text = "About"
        Me.ToolTip1.SetToolTip(Me.btnAbout, "Open the about dialog.")
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.Location = New System.Drawing.Point(108, 225)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(92, 23)
        Me.btnSettings.TabIndex = 8
        Me.btnSettings.TabStop = False
        Me.btnSettings.Text = "Settings"
        Me.ToolTip1.SetToolTip(Me.btnSettings, "Opens a settings dialog.")
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'lblProcessName
        '
        Me.lblProcessName.AutoSize = True
        Me.lblProcessName.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessName.ForeColor = System.Drawing.Color.White
        Me.lblProcessName.Location = New System.Drawing.Point(69, 10)
        Me.lblProcessName.Name = "lblProcessName"
        Me.lblProcessName.Size = New System.Drawing.Size(79, 13)
        Me.lblProcessName.TabIndex = 9
        Me.lblProcessName.Text = "Process Name:"
        '
        'pbProcssIcon
        '
        Me.pbProcssIcon.BackColor = System.Drawing.Color.Transparent
        Me.pbProcssIcon.Location = New System.Drawing.Point(16, 14)
        Me.pbProcssIcon.Name = "pbProcssIcon"
        Me.pbProcssIcon.Size = New System.Drawing.Size(40, 40)
        Me.pbProcssIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbProcssIcon.TabIndex = 10
        Me.pbProcssIcon.TabStop = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(70, 49)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 13)
        Me.lblInfo.TabIndex = 11
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.White
        Me.lblDesc.Location = New System.Drawing.Point(69, 63)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(0, 13)
        Me.lblDesc.TabIndex = 12
        '
        'CPRunning
        '
        Me.CPRunning.Enabled = True
        Me.CPRunning.Interval = 200
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(344, 254)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.pbProcssIcon)
        Me.Controls.Add(Me.lblProcessName)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnInject)
        Me.Controls.Add(Me.gpInjectList)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.tboxProcessName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Text = "Open Injector"
        Me.gpInjectList.ResumeLayout(False)
        CType(Me.pbProcssIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dllListView As ListView
    Friend WithEvents btnImportDLL As Button
    Friend WithEvents Column1 As ColumnHeader
    Friend WithEvents Column2 As ColumnHeader
    Friend WithEvents tboxProcessName As TextBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents gpInjectList As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnInject As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents lblProcessName As Label
    Friend WithEvents pbProcssIcon As PictureBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CPRunning As Timer
End Class
