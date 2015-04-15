<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Screen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Screen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AutoUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker
        Me.BackgroundWorker4 = New System.ComponentModel.BackgroundWorker
        Me.BackgroundWorker5 = New System.ComponentModel.BackgroundWorker
        Me.BackgroundWorker6 = New System.ComponentModel.BackgroundWorker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SSR_FolderBrowseButton = New System.Windows.Forms.Button
        Me.SSR_RootFolder = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SSR_FileTypes = New System.Windows.Forms.ListBox
        Me.SSR_TermModifierTitleCase = New System.Windows.Forms.CheckBox
        Me.SSR_TermModifierLowercase = New System.Windows.Forms.CheckBox
        Me.SSR_TermModifierUppercase = New System.Windows.Forms.CheckBox
        Me.SSR_TermModifierAsIs = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SSR_ReplaceTerm = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SSR_SearchTerm = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.SSR_StatusLabel = New System.Windows.Forms.Label
        Me.SSR_CancelButton = New System.Windows.Forms.Button
        Me.SSR_StartButton = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SSR_Step8ProgressBar = New System.Windows.Forms.ProgressBar
        Me.SSR_Step7ProgressBar = New System.Windows.Forms.ProgressBar
        Me.SSR_Step6ProgressBar = New System.Windows.Forms.ProgressBar
        Me.SSR_Step3Label = New System.Windows.Forms.Label
        Me.SSR_Step5ProgressBar = New System.Windows.Forms.ProgressBar
        Me.SSR_Step4ProgressBar = New System.Windows.Forms.ProgressBar
        Me.SSR_Step2ProgressBar = New System.Windows.Forms.ProgressBar
        Me.SSR_Step8Label = New System.Windows.Forms.Label
        Me.SSR_Step7Label = New System.Windows.Forms.Label
        Me.SSR_Step6Label = New System.Windows.Forms.Label
        Me.SSR_Step5Label = New System.Windows.Forms.Label
        Me.SSR_Step4Label = New System.Windows.Forms.Label
        Me.SSR_Step2Label = New System.Windows.Forms.Label
        Me.SSR_Step1Label = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BackgroundWorker7 = New System.ComponentModel.BackgroundWorker
        Me.BackgroundWorker8 = New System.ComponentModel.BackgroundWorker
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(626, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.AutoUpdateToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'AutoUpdateToolStripMenuItem
        '
        Me.AutoUpdateToolStripMenuItem.Name = "AutoUpdateToolStripMenuItem"
        Me.AutoUpdateToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.AutoUpdateToolStripMenuItem.Text = "AutoUpdate"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select the folder currently housing your completed CodeUnit projects:"
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'BackgroundWorker3
        '
        Me.BackgroundWorker3.WorkerReportsProgress = True
        Me.BackgroundWorker3.WorkerSupportsCancellation = True
        '
        'BackgroundWorker4
        '
        Me.BackgroundWorker4.WorkerReportsProgress = True
        Me.BackgroundWorker4.WorkerSupportsCancellation = True
        '
        'BackgroundWorker5
        '
        Me.BackgroundWorker5.WorkerReportsProgress = True
        Me.BackgroundWorker5.WorkerSupportsCancellation = True
        '
        'BackgroundWorker6
        '
        Me.BackgroundWorker6.WorkerReportsProgress = True
        Me.BackgroundWorker6.WorkerSupportsCancellation = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SSR_FolderBrowseButton)
        Me.GroupBox1.Controls.Add(Me.SSR_RootFolder)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.SSR_FileTypes)
        Me.GroupBox1.Controls.Add(Me.SSR_TermModifierTitleCase)
        Me.GroupBox1.Controls.Add(Me.SSR_TermModifierLowercase)
        Me.GroupBox1.Controls.Add(Me.SSR_TermModifierUppercase)
        Me.GroupBox1.Controls.Add(Me.SSR_TermModifierAsIs)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.SSR_ReplaceTerm)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SSR_SearchTerm)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 151)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operation Parameters"
        '
        'SSR_FolderBrowseButton
        '
        Me.SSR_FolderBrowseButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSR_FolderBrowseButton.Location = New System.Drawing.Point(275, 106)
        Me.SSR_FolderBrowseButton.Name = "SSR_FolderBrowseButton"
        Me.SSR_FolderBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.SSR_FolderBrowseButton.TabIndex = 13
        Me.SSR_FolderBrowseButton.Text = "Browse"
        Me.SSR_FolderBrowseButton.UseVisualStyleBackColor = True
        '
        'SSR_RootFolder
        '
        Me.SSR_RootFolder.AutoEllipsis = True
        Me.SSR_RootFolder.BackColor = System.Drawing.Color.White
        Me.SSR_RootFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SSR_RootFolder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSR_RootFolder.Location = New System.Drawing.Point(17, 108)
        Me.SSR_RootFolder.Name = "SSR_RootFolder"
        Me.SSR_RootFolder.Size = New System.Drawing.Size(252, 19)
        Me.SSR_RootFolder.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(14, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Root Folder to Search:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(368, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Term Modifiers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(475, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Files to Examine:"
        '
        'SSR_FileTypes
        '
        Me.SSR_FileTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SSR_FileTypes.FormattingEnabled = True
        Me.SSR_FileTypes.Location = New System.Drawing.Point(478, 52)
        Me.SSR_FileTypes.Name = "SSR_FileTypes"
        Me.SSR_FileTypes.Size = New System.Drawing.Size(108, 80)
        Me.SSR_FileTypes.TabIndex = 8
        '
        'SSR_TermModifierTitleCase
        '
        Me.SSR_TermModifierTitleCase.AutoSize = True
        Me.SSR_TermModifierTitleCase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSR_TermModifierTitleCase.Location = New System.Drawing.Point(371, 120)
        Me.SSR_TermModifierTitleCase.Name = "SSR_TermModifierTitleCase"
        Me.SSR_TermModifierTitleCase.Size = New System.Drawing.Size(73, 17)
        Me.SSR_TermModifierTitleCase.TabIndex = 7
        Me.SSR_TermModifierTitleCase.Text = "Title Case"
        Me.SSR_TermModifierTitleCase.UseVisualStyleBackColor = True
        '
        'SSR_TermModifierLowercase
        '
        Me.SSR_TermModifierLowercase.AutoSize = True
        Me.SSR_TermModifierLowercase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSR_TermModifierLowercase.Location = New System.Drawing.Point(371, 97)
        Me.SSR_TermModifierLowercase.Name = "SSR_TermModifierLowercase"
        Me.SSR_TermModifierLowercase.Size = New System.Drawing.Size(74, 17)
        Me.SSR_TermModifierLowercase.TabIndex = 6
        Me.SSR_TermModifierLowercase.Text = "lowercase"
        Me.SSR_TermModifierLowercase.UseVisualStyleBackColor = True
        '
        'SSR_TermModifierUppercase
        '
        Me.SSR_TermModifierUppercase.AutoSize = True
        Me.SSR_TermModifierUppercase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSR_TermModifierUppercase.Location = New System.Drawing.Point(371, 74)
        Me.SSR_TermModifierUppercase.Name = "SSR_TermModifierUppercase"
        Me.SSR_TermModifierUppercase.Size = New System.Drawing.Size(91, 17)
        Me.SSR_TermModifierUppercase.TabIndex = 5
        Me.SSR_TermModifierUppercase.Text = "UPPERCASE"
        Me.SSR_TermModifierUppercase.UseVisualStyleBackColor = True
        '
        'SSR_TermModifierAsIs
        '
        Me.SSR_TermModifierAsIs.AutoSize = True
        Me.SSR_TermModifierAsIs.Checked = True
        Me.SSR_TermModifierAsIs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SSR_TermModifierAsIs.Enabled = False
        Me.SSR_TermModifierAsIs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSR_TermModifierAsIs.Location = New System.Drawing.Point(371, 51)
        Me.SSR_TermModifierAsIs.Name = "SSR_TermModifierAsIs"
        Me.SSR_TermModifierAsIs.Size = New System.Drawing.Size(48, 17)
        Me.SSR_TermModifierAsIs.TabIndex = 4
        Me.SSR_TermModifierAsIs.Text = "As is"
        Me.SSR_TermModifierAsIs.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(14, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Replace Term:"
        '
        'SSR_ReplaceTerm
        '
        Me.SSR_ReplaceTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SSR_ReplaceTerm.Location = New System.Drawing.Point(91, 52)
        Me.SSR_ReplaceTerm.Name = "SSR_ReplaceTerm"
        Me.SSR_ReplaceTerm.Size = New System.Drawing.Size(259, 20)
        Me.SSR_ReplaceTerm.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Term:"
        '
        'SSR_SearchTerm
        '
        Me.SSR_SearchTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SSR_SearchTerm.Location = New System.Drawing.Point(91, 26)
        Me.SSR_SearchTerm.Name = "SSR_SearchTerm"
        Me.SSR_SearchTerm.Size = New System.Drawing.Size(259, 20)
        Me.SSR_SearchTerm.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SSR_StatusLabel)
        Me.GroupBox2.Controls.Add(Me.SSR_CancelButton)
        Me.GroupBox2.Controls.Add(Me.SSR_StartButton)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 59)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operation Controller"
        '
        'SSR_StatusLabel
        '
        Me.SSR_StatusLabel.Location = New System.Drawing.Point(332, 27)
        Me.SSR_StatusLabel.Name = "SSR_StatusLabel"
        Me.SSR_StatusLabel.Size = New System.Drawing.Size(254, 18)
        Me.SSR_StatusLabel.TabIndex = 2
        Me.SSR_StatusLabel.Text = "Please enter the desired parameters to begin"
        '
        'SSR_CancelButton
        '
        Me.SSR_CancelButton.Enabled = False
        Me.SSR_CancelButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSR_CancelButton.Location = New System.Drawing.Point(169, 22)
        Me.SSR_CancelButton.Name = "SSR_CancelButton"
        Me.SSR_CancelButton.Size = New System.Drawing.Size(146, 23)
        Me.SSR_CancelButton.TabIndex = 1
        Me.SSR_CancelButton.Text = "Cancel Operation"
        Me.SSR_CancelButton.UseVisualStyleBackColor = True
        '
        'SSR_StartButton
        '
        Me.SSR_StartButton.Enabled = False
        Me.SSR_StartButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SSR_StartButton.Location = New System.Drawing.Point(17, 22)
        Me.SSR_StartButton.Name = "SSR_StartButton"
        Me.SSR_StartButton.Size = New System.Drawing.Size(146, 23)
        Me.SSR_StartButton.TabIndex = 0
        Me.SSR_StartButton.Text = "Start Search and Replace"
        Me.SSR_StartButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.SSR_Step8ProgressBar)
        Me.GroupBox3.Controls.Add(Me.SSR_Step7ProgressBar)
        Me.GroupBox3.Controls.Add(Me.SSR_Step6ProgressBar)
        Me.GroupBox3.Controls.Add(Me.SSR_Step3Label)
        Me.GroupBox3.Controls.Add(Me.SSR_Step5ProgressBar)
        Me.GroupBox3.Controls.Add(Me.SSR_Step4ProgressBar)
        Me.GroupBox3.Controls.Add(Me.SSR_Step2ProgressBar)
        Me.GroupBox3.Controls.Add(Me.SSR_Step8Label)
        Me.GroupBox3.Controls.Add(Me.SSR_Step7Label)
        Me.GroupBox3.Controls.Add(Me.SSR_Step6Label)
        Me.GroupBox3.Controls.Add(Me.SSR_Step5Label)
        Me.GroupBox3.Controls.Add(Me.SSR_Step4Label)
        Me.GroupBox3.Controls.Add(Me.SSR_Step2Label)
        Me.GroupBox3.Controls.Add(Me.SSR_Step1Label)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox3.Location = New System.Drawing.Point(12, 281)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(602, 212)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operation Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(408, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "[Click here to Minimize the Application]"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'SSR_Step8ProgressBar
        '
        Me.SSR_Step8ProgressBar.Location = New System.Drawing.Point(425, 180)
        Me.SSR_Step8ProgressBar.Name = "SSR_Step8ProgressBar"
        Me.SSR_Step8ProgressBar.Size = New System.Drawing.Size(161, 18)
        Me.SSR_Step8ProgressBar.TabIndex = 21
        '
        'SSR_Step7ProgressBar
        '
        Me.SSR_Step7ProgressBar.Location = New System.Drawing.Point(425, 158)
        Me.SSR_Step7ProgressBar.Name = "SSR_Step7ProgressBar"
        Me.SSR_Step7ProgressBar.Size = New System.Drawing.Size(161, 18)
        Me.SSR_Step7ProgressBar.TabIndex = 20
        '
        'SSR_Step6ProgressBar
        '
        Me.SSR_Step6ProgressBar.Location = New System.Drawing.Point(425, 136)
        Me.SSR_Step6ProgressBar.Name = "SSR_Step6ProgressBar"
        Me.SSR_Step6ProgressBar.Size = New System.Drawing.Size(161, 18)
        Me.SSR_Step6ProgressBar.TabIndex = 19
        '
        'SSR_Step3Label
        '
        Me.SSR_Step3Label.AutoEllipsis = True
        Me.SSR_Step3Label.ForeColor = System.Drawing.Color.Maroon
        Me.SSR_Step3Label.Location = New System.Drawing.Point(211, 72)
        Me.SSR_Step3Label.Name = "SSR_Step3Label"
        Me.SSR_Step3Label.Size = New System.Drawing.Size(375, 13)
        Me.SSR_Step3Label.TabIndex = 8
        Me.SSR_Step3Label.Text = "0 files retrieved"
        '
        'SSR_Step5ProgressBar
        '
        Me.SSR_Step5ProgressBar.Location = New System.Drawing.Point(425, 114)
        Me.SSR_Step5ProgressBar.Name = "SSR_Step5ProgressBar"
        Me.SSR_Step5ProgressBar.Size = New System.Drawing.Size(161, 18)
        Me.SSR_Step5ProgressBar.TabIndex = 18
        '
        'SSR_Step4ProgressBar
        '
        Me.SSR_Step4ProgressBar.Location = New System.Drawing.Point(425, 92)
        Me.SSR_Step4ProgressBar.Name = "SSR_Step4ProgressBar"
        Me.SSR_Step4ProgressBar.Size = New System.Drawing.Size(161, 18)
        Me.SSR_Step4ProgressBar.TabIndex = 17
        '
        'SSR_Step2ProgressBar
        '
        Me.SSR_Step2ProgressBar.Location = New System.Drawing.Point(425, 47)
        Me.SSR_Step2ProgressBar.Name = "SSR_Step2ProgressBar"
        Me.SSR_Step2ProgressBar.Size = New System.Drawing.Size(161, 18)
        Me.SSR_Step2ProgressBar.TabIndex = 16
        '
        'SSR_Step8Label
        '
        Me.SSR_Step8Label.AutoEllipsis = True
        Me.SSR_Step8Label.ForeColor = System.Drawing.Color.Maroon
        Me.SSR_Step8Label.Location = New System.Drawing.Point(211, 182)
        Me.SSR_Step8Label.Name = "SSR_Step8Label"
        Me.SSR_Step8Label.Size = New System.Drawing.Size(195, 13)
        Me.SSR_Step8Label.TabIndex = 15
        Me.SSR_Step8Label.Text = "0/0 files replaced"
        '
        'SSR_Step7Label
        '
        Me.SSR_Step7Label.AutoEllipsis = True
        Me.SSR_Step7Label.ForeColor = System.Drawing.Color.Maroon
        Me.SSR_Step7Label.Location = New System.Drawing.Point(211, 160)
        Me.SSR_Step7Label.Name = "SSR_Step7Label"
        Me.SSR_Step7Label.Size = New System.Drawing.Size(195, 13)
        Me.SSR_Step7Label.TabIndex = 14
        Me.SSR_Step7Label.Text = "0/0 files replaced"
        '
        'SSR_Step6Label
        '
        Me.SSR_Step6Label.AutoEllipsis = True
        Me.SSR_Step6Label.ForeColor = System.Drawing.Color.Maroon
        Me.SSR_Step6Label.Location = New System.Drawing.Point(211, 138)
        Me.SSR_Step6Label.Name = "SSR_Step6Label"
        Me.SSR_Step6Label.Size = New System.Drawing.Size(195, 13)
        Me.SSR_Step6Label.TabIndex = 13
        Me.SSR_Step6Label.Text = "0/0 files replaced"
        '
        'SSR_Step5Label
        '
        Me.SSR_Step5Label.AutoEllipsis = True
        Me.SSR_Step5Label.ForeColor = System.Drawing.Color.Maroon
        Me.SSR_Step5Label.Location = New System.Drawing.Point(211, 116)
        Me.SSR_Step5Label.Name = "SSR_Step5Label"
        Me.SSR_Step5Label.Size = New System.Drawing.Size(195, 13)
        Me.SSR_Step5Label.TabIndex = 12
        Me.SSR_Step5Label.Text = "0/0 files replaced"
        '
        'SSR_Step4Label
        '
        Me.SSR_Step4Label.AutoEllipsis = True
        Me.SSR_Step4Label.ForeColor = System.Drawing.Color.Maroon
        Me.SSR_Step4Label.Location = New System.Drawing.Point(211, 94)
        Me.SSR_Step4Label.Name = "SSR_Step4Label"
        Me.SSR_Step4Label.Size = New System.Drawing.Size(195, 13)
        Me.SSR_Step4Label.TabIndex = 11
        Me.SSR_Step4Label.Text = "0/0 files replaced"
        '
        'SSR_Step2Label
        '
        Me.SSR_Step2Label.AutoEllipsis = True
        Me.SSR_Step2Label.ForeColor = System.Drawing.Color.Maroon
        Me.SSR_Step2Label.Location = New System.Drawing.Point(211, 49)
        Me.SSR_Step2Label.Name = "SSR_Step2Label"
        Me.SSR_Step2Label.Size = New System.Drawing.Size(195, 13)
        Me.SSR_Step2Label.TabIndex = 10
        Me.SSR_Step2Label.Text = "0/0 folders renamed"
        '
        'SSR_Step1Label
        '
        Me.SSR_Step1Label.AutoEllipsis = True
        Me.SSR_Step1Label.ForeColor = System.Drawing.Color.Maroon
        Me.SSR_Step1Label.Location = New System.Drawing.Point(211, 26)
        Me.SSR_Step1Label.Name = "SSR_Step1Label"
        Me.SSR_Step1Label.Size = New System.Drawing.Size(195, 13)
        Me.SSR_Step1Label.TabIndex = 9
        Me.SSR_Step1Label.Text = "0 folders retrieved"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(14, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(118, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Retrieve Folder Names:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(14, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Search and Replace Folder Names:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(14, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Search and Replace File Contents 5:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(14, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(181, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Search and Replace File Contents 4:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(14, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Search and Replace File Contents 3:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(14, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Search and Replace File Contents 2:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(14, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Search and Replace File Contents 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(14, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Retrieve File Names:"
        '
        'BackgroundWorker7
        '
        Me.BackgroundWorker7.WorkerReportsProgress = True
        Me.BackgroundWorker7.WorkerSupportsCancellation = True
        '
        'BackgroundWorker8
        '
        Me.BackgroundWorker8.WorkerReportsProgress = True
        Me.BackgroundWorker8.WorkerSupportsCancellation = True
        '
        'Main_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 508)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AutoUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker5 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker6 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SSR_TermModifierAsIs As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SSR_ReplaceTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SSR_SearchTerm As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SSR_FileTypes As System.Windows.Forms.ListBox
    Friend WithEvents SSR_TermModifierTitleCase As System.Windows.Forms.CheckBox
    Friend WithEvents SSR_TermModifierLowercase As System.Windows.Forms.CheckBox
    Friend WithEvents SSR_TermModifierUppercase As System.Windows.Forms.CheckBox
    Friend WithEvents SSR_FolderBrowseButton As System.Windows.Forms.Button
    Friend WithEvents SSR_RootFolder As System.Windows.Forms.Label
    Friend WithEvents SSR_CancelButton As System.Windows.Forms.Button
    Friend WithEvents SSR_StartButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SSR_Step2Label As System.Windows.Forms.Label
    Friend WithEvents SSR_Step1Label As System.Windows.Forms.Label
    Friend WithEvents SSR_Step3Label As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker7 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker8 As System.ComponentModel.BackgroundWorker
    Friend WithEvents SSR_Step8ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents SSR_Step7ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents SSR_Step6ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents SSR_Step5ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents SSR_Step4ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents SSR_Step2ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents SSR_Step8Label As System.Windows.Forms.Label
    Friend WithEvents SSR_Step7Label As System.Windows.Forms.Label
    Friend WithEvents SSR_Step6Label As System.Windows.Forms.Label
    Friend WithEvents SSR_Step5Label As System.Windows.Forms.Label
    Friend WithEvents SSR_Step4Label As System.Windows.Forms.Label
    Friend WithEvents SSR_StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
