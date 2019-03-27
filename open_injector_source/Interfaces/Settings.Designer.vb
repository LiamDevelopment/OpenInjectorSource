<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.AutoUpdates = New System.Windows.Forms.GroupBox()
        Me.CheckAutoUpdate = New System.Windows.Forms.CheckBox()
        Me.Tools = New System.Windows.Forms.GroupBox()
        Me.CheckDebug = New System.Windows.Forms.CheckBox()
        Me.btnProcessInformation = New System.Windows.Forms.Button()
        Me.ThemeOptions = New System.Windows.Forms.GroupBox()
        Me.pBackground1 = New System.Windows.Forms.Panel()
        Me.pBackground2 = New System.Windows.Forms.Panel()
        Me.pTextColor = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InjectionOptions = New System.Windows.Forms.GroupBox()
        Me.nudBetween = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudInjectDelay = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckStealth = New System.Windows.Forms.CheckBox()
        Me.CheckCloseInject = New System.Windows.Forms.CheckBox()
        Me.CheckAutoInject = New System.Windows.Forms.CheckBox()
        Me.ScramblingOptions = New System.Windows.Forms.GroupBox()
        Me.btnScramblingAdvanced = New System.Windows.Forms.Button()
        Me.cbScrambling = New System.Windows.Forms.ComboBox()
        Me.InjectionMethdo = New System.Windows.Forms.GroupBox()
        Me.btnInjectionAdvanced = New System.Windows.Forms.Button()
        Me.cbInjectionMethod = New System.Windows.Forms.ComboBox()
        Me.AutoUpdates.SuspendLayout()
        Me.Tools.SuspendLayout()
        Me.ThemeOptions.SuspendLayout()
        Me.InjectionOptions.SuspendLayout()
        CType(Me.nudBetween, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInjectDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScramblingOptions.SuspendLayout()
        Me.InjectionMethdo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel4.Location = New System.Drawing.Point(93, 323)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(166, 2)
        Me.Panel4.TabIndex = 16
        '
        'btnOK
        '
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.Location = New System.Drawing.Point(265, 312)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 15
        Me.btnOK.TabStop = False
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Location = New System.Drawing.Point(12, 312)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.TabStop = False
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'AutoUpdates
        '
        Me.AutoUpdates.Controls.Add(Me.CheckAutoUpdate)
        Me.AutoUpdates.Location = New System.Drawing.Point(12, 250)
        Me.AutoUpdates.Name = "AutoUpdates"
        Me.AutoUpdates.Size = New System.Drawing.Size(161, 53)
        Me.AutoUpdates.TabIndex = 13
        Me.AutoUpdates.TabStop = False
        Me.AutoUpdates.Text = "Auto Updates:"
        '
        'CheckAutoUpdate
        '
        Me.CheckAutoUpdate.AutoSize = True
        Me.CheckAutoUpdate.Checked = True
        Me.CheckAutoUpdate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckAutoUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckAutoUpdate.Location = New System.Drawing.Point(9, 17)
        Me.CheckAutoUpdate.Name = "CheckAutoUpdate"
        Me.CheckAutoUpdate.Size = New System.Drawing.Size(112, 30)
        Me.CheckAutoUpdate.TabIndex = 0
        Me.CheckAutoUpdate.Text = "Automatically " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "check for updates"
        Me.CheckAutoUpdate.UseVisualStyleBackColor = True
        '
        'Tools
        '
        Me.Tools.Controls.Add(Me.CheckDebug)
        Me.Tools.Controls.Add(Me.btnProcessInformation)
        Me.Tools.Location = New System.Drawing.Point(179, 223)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(161, 80)
        Me.Tools.TabIndex = 12
        Me.Tools.TabStop = False
        Me.Tools.Text = "Tools:"
        '
        'CheckDebug
        '
        Me.CheckDebug.AutoSize = True
        Me.CheckDebug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckDebug.Location = New System.Drawing.Point(16, 51)
        Me.CheckDebug.Name = "CheckDebug"
        Me.CheckDebug.Size = New System.Drawing.Size(129, 17)
        Me.CheckDebug.TabIndex = 1
        Me.CheckDebug.Text = "Show Debug Console"
        Me.CheckDebug.UseVisualStyleBackColor = True
        '
        'btnProcessInformation
        '
        Me.btnProcessInformation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcessInformation.Location = New System.Drawing.Point(6, 19)
        Me.btnProcessInformation.Name = "btnProcessInformation"
        Me.btnProcessInformation.Size = New System.Drawing.Size(149, 24)
        Me.btnProcessInformation.TabIndex = 3
        Me.btnProcessInformation.TabStop = False
        Me.btnProcessInformation.Text = "View Process Information"
        Me.btnProcessInformation.UseVisualStyleBackColor = True
        '
        'ThemeOptions
        '
        Me.ThemeOptions.Controls.Add(Me.pBackground1)
        Me.ThemeOptions.Controls.Add(Me.pBackground2)
        Me.ThemeOptions.Controls.Add(Me.pTextColor)
        Me.ThemeOptions.Controls.Add(Me.Label4)
        Me.ThemeOptions.Controls.Add(Me.Label3)
        Me.ThemeOptions.Controls.Add(Me.Label1)
        Me.ThemeOptions.Location = New System.Drawing.Point(180, 96)
        Me.ThemeOptions.Name = "ThemeOptions"
        Me.ThemeOptions.Size = New System.Drawing.Size(160, 121)
        Me.ThemeOptions.TabIndex = 11
        Me.ThemeOptions.TabStop = False
        Me.ThemeOptions.Text = "Theme Options:"
        '
        'pBackground1
        '
        Me.pBackground1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.pBackground1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBackground1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pBackground1.Location = New System.Drawing.Point(123, 48)
        Me.pBackground1.Name = "pBackground1"
        Me.pBackground1.Size = New System.Drawing.Size(20, 20)
        Me.pBackground1.TabIndex = 5
        '
        'pBackground2
        '
        Me.pBackground2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.pBackground2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pBackground2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pBackground2.Location = New System.Drawing.Point(123, 71)
        Me.pBackground2.Name = "pBackground2"
        Me.pBackground2.Size = New System.Drawing.Size(20, 20)
        Me.pBackground2.TabIndex = 5
        '
        'pTextColor
        '
        Me.pTextColor.BackColor = System.Drawing.Color.White
        Me.pTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pTextColor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pTextColor.Location = New System.Drawing.Point(123, 25)
        Me.pTextColor.Name = "pTextColor"
        Me.pTextColor.Size = New System.Drawing.Size(20, 20)
        Me.pTextColor.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Background Color #2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Background Color #1:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Text Color:"
        '
        'InjectionOptions
        '
        Me.InjectionOptions.Controls.Add(Me.nudBetween)
        Me.InjectionOptions.Controls.Add(Me.Label5)
        Me.InjectionOptions.Controls.Add(Me.nudInjectDelay)
        Me.InjectionOptions.Controls.Add(Me.Label2)
        Me.InjectionOptions.Controls.Add(Me.CheckStealth)
        Me.InjectionOptions.Controls.Add(Me.CheckCloseInject)
        Me.InjectionOptions.Controls.Add(Me.CheckAutoInject)
        Me.InjectionOptions.Location = New System.Drawing.Point(12, 96)
        Me.InjectionOptions.Name = "InjectionOptions"
        Me.InjectionOptions.Size = New System.Drawing.Size(161, 148)
        Me.InjectionOptions.TabIndex = 9
        Me.InjectionOptions.TabStop = False
        Me.InjectionOptions.Text = "Injection Options:"
        '
        'nudBetween
        '
        Me.nudBetween.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nudBetween.Location = New System.Drawing.Point(92, 117)
        Me.nudBetween.Name = "nudBetween"
        Me.nudBetween.Size = New System.Drawing.Size(60, 20)
        Me.nudBetween.TabIndex = 7
        Me.nudBetween.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Delay between:"
        '
        'nudInjectDelay
        '
        Me.nudInjectDelay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nudInjectDelay.Location = New System.Drawing.Point(92, 91)
        Me.nudInjectDelay.Name = "nudInjectDelay"
        Me.nudInjectDelay.Size = New System.Drawing.Size(60, 20)
        Me.nudInjectDelay.TabIndex = 5
        Me.nudInjectDelay.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inject delay:"
        '
        'CheckStealth
        '
        Me.CheckStealth.AutoSize = True
        Me.CheckStealth.Checked = True
        Me.CheckStealth.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckStealth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckStealth.Location = New System.Drawing.Point(5, 71)
        Me.CheckStealth.Name = "CheckStealth"
        Me.CheckStealth.Size = New System.Drawing.Size(88, 17)
        Me.CheckStealth.TabIndex = 3
        Me.CheckStealth.TabStop = False
        Me.CheckStealth.Text = "Stealth Inject"
        Me.CheckStealth.UseVisualStyleBackColor = True
        '
        'CheckCloseInject
        '
        Me.CheckCloseInject.AutoSize = True
        Me.CheckCloseInject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckCloseInject.Location = New System.Drawing.Point(5, 48)
        Me.CheckCloseInject.Name = "CheckCloseInject"
        Me.CheckCloseInject.Size = New System.Drawing.Size(95, 17)
        Me.CheckCloseInject.TabIndex = 2
        Me.CheckCloseInject.TabStop = False
        Me.CheckCloseInject.Text = "Close on inject"
        Me.CheckCloseInject.UseVisualStyleBackColor = True
        '
        'CheckAutoInject
        '
        Me.CheckAutoInject.AutoSize = True
        Me.CheckAutoInject.Checked = True
        Me.CheckAutoInject.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckAutoInject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckAutoInject.Location = New System.Drawing.Point(6, 25)
        Me.CheckAutoInject.Name = "CheckAutoInject"
        Me.CheckAutoInject.Size = New System.Drawing.Size(77, 17)
        Me.CheckAutoInject.TabIndex = 1
        Me.CheckAutoInject.TabStop = False
        Me.CheckAutoInject.Text = "Auto Inject"
        Me.CheckAutoInject.UseVisualStyleBackColor = True
        '
        'ScramblingOptions
        '
        Me.ScramblingOptions.Controls.Add(Me.btnScramblingAdvanced)
        Me.ScramblingOptions.Controls.Add(Me.cbScrambling)
        Me.ScramblingOptions.Location = New System.Drawing.Point(179, 10)
        Me.ScramblingOptions.Name = "ScramblingOptions"
        Me.ScramblingOptions.Size = New System.Drawing.Size(161, 80)
        Me.ScramblingOptions.TabIndex = 10
        Me.ScramblingOptions.TabStop = False
        Me.ScramblingOptions.Text = "Scrambling Options:"
        '
        'btnScramblingAdvanced
        '
        Me.btnScramblingAdvanced.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnScramblingAdvanced.Location = New System.Drawing.Point(6, 46)
        Me.btnScramblingAdvanced.Name = "btnScramblingAdvanced"
        Me.btnScramblingAdvanced.Size = New System.Drawing.Size(150, 24)
        Me.btnScramblingAdvanced.TabIndex = 2
        Me.btnScramblingAdvanced.TabStop = False
        Me.btnScramblingAdvanced.Text = "Advanced"
        Me.btnScramblingAdvanced.UseVisualStyleBackColor = True
        '
        'cbScrambling
        '
        Me.cbScrambling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbScrambling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbScrambling.FormattingEnabled = True
        Me.cbScrambling.Items.AddRange(New Object() {"None", "Light"})
        Me.cbScrambling.Location = New System.Drawing.Point(6, 19)
        Me.cbScrambling.Name = "cbScrambling"
        Me.cbScrambling.Size = New System.Drawing.Size(150, 21)
        Me.cbScrambling.TabIndex = 1
        Me.cbScrambling.TabStop = False
        '
        'InjectionMethdo
        '
        Me.InjectionMethdo.Controls.Add(Me.btnInjectionAdvanced)
        Me.InjectionMethdo.Controls.Add(Me.cbInjectionMethod)
        Me.InjectionMethdo.Location = New System.Drawing.Point(12, 10)
        Me.InjectionMethdo.Name = "InjectionMethdo"
        Me.InjectionMethdo.Size = New System.Drawing.Size(161, 80)
        Me.InjectionMethdo.TabIndex = 8
        Me.InjectionMethdo.TabStop = False
        Me.InjectionMethdo.Text = "Injection Method:"
        '
        'btnInjectionAdvanced
        '
        Me.btnInjectionAdvanced.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInjectionAdvanced.Location = New System.Drawing.Point(6, 46)
        Me.btnInjectionAdvanced.Name = "btnInjectionAdvanced"
        Me.btnInjectionAdvanced.Size = New System.Drawing.Size(146, 24)
        Me.btnInjectionAdvanced.TabIndex = 1
        Me.btnInjectionAdvanced.TabStop = False
        Me.btnInjectionAdvanced.Text = "Advanced"
        Me.btnInjectionAdvanced.UseVisualStyleBackColor = True
        '
        'cbInjectionMethod
        '
        Me.cbInjectionMethod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbInjectionMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInjectionMethod.FormattingEnabled = True
        Me.cbInjectionMethod.Items.AddRange(New Object() {"Standard Injection", "ThreadHijacking", "Manual Map"})
        Me.cbInjectionMethod.Location = New System.Drawing.Point(6, 19)
        Me.cbInjectionMethod.Name = "cbInjectionMethod"
        Me.cbInjectionMethod.Size = New System.Drawing.Size(146, 21)
        Me.cbInjectionMethod.TabIndex = 0
        Me.cbInjectionMethod.TabStop = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 345)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.AutoUpdates)
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.ThemeOptions)
        Me.Controls.Add(Me.InjectionOptions)
        Me.Controls.Add(Me.ScramblingOptions)
        Me.Controls.Add(Me.InjectionMethdo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(368, 384)
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Settings"
        Me.AutoUpdates.ResumeLayout(False)
        Me.AutoUpdates.PerformLayout()
        Me.Tools.ResumeLayout(False)
        Me.Tools.PerformLayout()
        Me.ThemeOptions.ResumeLayout(False)
        Me.ThemeOptions.PerformLayout()
        Me.InjectionOptions.ResumeLayout(False)
        Me.InjectionOptions.PerformLayout()
        CType(Me.nudBetween, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInjectDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScramblingOptions.ResumeLayout(False)
        Me.InjectionMethdo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnOK As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents AutoUpdates As GroupBox
    Friend WithEvents CheckAutoUpdate As CheckBox
    Friend WithEvents Tools As GroupBox
    Friend WithEvents btnProcessInformation As Button
    Friend WithEvents ThemeOptions As GroupBox
    Friend WithEvents pBackground1 As Panel
    Friend WithEvents pBackground2 As Panel
    Friend WithEvents pTextColor As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents InjectionOptions As GroupBox
    Friend WithEvents nudInjectDelay As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckStealth As CheckBox
    Friend WithEvents CheckCloseInject As CheckBox
    Friend WithEvents CheckAutoInject As CheckBox
    Friend WithEvents ScramblingOptions As GroupBox
    Friend WithEvents btnScramblingAdvanced As Button
    Friend WithEvents cbScrambling As ComboBox
    Friend WithEvents InjectionMethdo As GroupBox
    Friend WithEvents btnInjectionAdvanced As Button
    Friend WithEvents cbInjectionMethod As ComboBox
    Friend WithEvents nudBetween As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckDebug As CheckBox
End Class
