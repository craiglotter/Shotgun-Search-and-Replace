Imports System.IO
Imports System.Threading

Public Class Main_Screen

    Private CancelOperation As Boolean = False

    Private step1busyworking As Boolean = False
    Private step2busyworking As Boolean = False
    Private step3busyworking As Boolean = False
    Private step4busyworking As Boolean = False
    Private step5busyworking As Boolean = False
    Private step6busyworking As Boolean = False
    Private step7busyworking As Boolean = False
    Private step8busyworking As Boolean = False

    Private step2counter As Integer = 0
    Private step4counter As Integer = 0
    Private step5counter As Integer = 0
    Private step6counter As Integer = 0
    Private step7counter As Integer = 0
    Private step8counter As Integer = 0

    Private step2adjusted As Integer = 0
    Private step4adjusted As Integer = 0
    Private step5adjusted As Integer = 0
    Private step6adjusted As Integer = 0
    Private step7adjusted As Integer = 0
    Private step8adjusted As Integer = 0

    Private AutoUpdate As Boolean = False

    Private folderlist As ArrayList
    Private worker1 As ArrayList
    Private worker2 As ArrayList
    Private worker3 As ArrayList
    Private worker4 As ArrayList
    Private worker5 As ArrayList

    Private fillworker As Integer = 1
    Private totalfilecounter As Integer = 0
    Private filecounteradjusted As Integer = 0

    Private SSR_BackupFolder As String = 0


    Private Sub Error_Handler(ByVal ex As Exception, Optional ByVal identifier_msg As String = "")
        Try
            If ex.Message.IndexOf("Thread was being aborted") < 0 Then
                Dim Display_Message1 As New Display_Message()
                Display_Message1.Message_Textbox.Text = "The Application encountered the following problem: " & vbCrLf & identifier_msg & ": " & ex.ToString
                Display_Message1.Timer1.Interval = 1000
                Display_Message1.ShowDialog()
                Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs")
                If dir.Exists = False Then
                    dir.Create()
                End If
                dir = Nothing
                Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs\" & Format(Now(), "yyyyMMdd") & "_Error_Log.txt", True)
                filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & identifier_msg & ": " & ex.ToString)
                filewriter.WriteLine("")
                filewriter.Flush()
                filewriter.Close()
                filewriter = Nothing
            End If
        Catch exc As Exception
            MsgBox("An error occurred in the application's error handling routine. The application will try to recover from this serious error." & vbCrLf & vbCrLf & exc.ToString, MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub

    Private Sub Merge_Activity_Logs()
        Try
            Dim filewriter As System.IO.StreamWriter
            filewriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt", True)
            For icounter As Integer = 4 To 8
                If My.Computer.FileSystem.FileExists((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt" & icounter) = True Then
                    Dim reader As StreamReader = New StreamReader((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt" & icounter)
                    While reader.Peek <> -1
                        filewriter.WriteLine(reader.ReadLine)
                    End While
                    reader.Close()
                    reader = Nothing
                    My.Computer.FileSystem.DeleteFile(((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt" & icounter), FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                End If
            Next
            filewriter.Flush()
            filewriter.Close()
            filewriter = Nothing
        Catch ex As Exception
            Error_Handler(ex, "Merge Activity Logs")
        End Try
    End Sub

    Private Sub Activity_Handler(ByVal message As String, Optional ByVal worker As Integer = 0)
        Try

            Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs")
            If dir.Exists = False Then
                dir.Create()
            End If
            dir = Nothing
            Dim filewriter As System.IO.StreamWriter
            Select Case worker
                Case 0
                    filewriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt", True)
                Case 4
                    filewriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt4", True)
                Case 5
                    filewriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt5", True)
                Case 6
                    filewriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt6", True)
                Case 7
                    filewriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt7", True)
                Case 8
                    filewriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt8", True)
                Case Else
                    filewriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt", True)
            End Select
            filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & message)
            filewriter.WriteLine("")
            filewriter.Flush()
            filewriter.Close()
            filewriter = Nothing
        Catch ex As Exception
            Error_Handler(ex, "Activity Handler")
        End Try
    End Sub

    Private Sub Main_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Me.Text = My.Application.Info.ProductName & " (" & Format(My.Application.Info.Version.Major, "0000") & Format(My.Application.Info.Version.Minor, "00") & Format(My.Application.Info.Version.Build, "00") & "." & Format(My.Application.Info.Version.Revision, "00") & ")"
            folderlist = New ArrayList
            worker1 = New ArrayList
            worker2 = New ArrayList
            worker3 = New ArrayList
            worker4 = New ArrayList
            worker5 = New ArrayList
            loadSettings()
            SaveSettings()
        Catch ex As Exception
            Error_Handler(ex, "Application Loading")
        End Try
    End Sub

    Private Sub loadSettings()
        Try
            Dim configfile As String = (Application.StartupPath & "\config.sav").Replace("\\", "\")
            If My.Computer.FileSystem.FileExists(configfile) Then
                Dim reader As StreamReader = New StreamReader(configfile)
                Dim lineread As String
                Dim variablevalue As String
                While reader.Peek <> -1
                    lineread = reader.ReadLine
                    If lineread.IndexOf("=") <> -1 Then
                        variablevalue = lineread.Remove(0, lineread.IndexOf("=") + 1)
                        If lineread.StartsWith("SSR_SearchTerm=") Then
                            SSR_SearchTerm.Text = variablevalue
                        End If
                        If lineread.StartsWith("SSR_ReplaceTerm=") Then
                            SSR_ReplaceTerm.Text = variablevalue
                        End If
                        If lineread.StartsWith("SSR_RootFolder=") Then
                            If My.Computer.FileSystem.DirectoryExists(variablevalue) = True Then
                                SSR_RootFolder.Text = variablevalue
                                FolderBrowserDialog1.SelectedPath = variablevalue
                            End If
                        End If
                        If lineread.StartsWith("SSR_FileTypes=") Then
                            For Each input As String In variablevalue.Split(";")
                                If input.StartsWith(".") = True Then
                                    SSR_FileTypes.Items.Add(input)
                                End If
                            Next
                        End If
                        If lineread.StartsWith("SSR_TermModifierAsIs=") Then
                            If variablevalue = "True" Then
                                SSR_TermModifierAsIs.Checked = True
                            Else
                                SSR_TermModifierAsIs.Checked = False
                            End If
                        End If
                        If lineread.StartsWith("SSR_TermModifierLowercase=") Then
                            If variablevalue = "True" Then
                                SSR_TermModifierLowercase.Checked = True
                            Else
                                SSR_TermModifierLowercase.Checked = False
                            End If
                        End If
                        If lineread.StartsWith("SSR_TermModifierUppercase=") Then
                            If variablevalue = "True" Then
                                SSR_TermModifierUppercase.Checked = True
                            Else
                                SSR_TermModifierUppercase.Checked = False
                            End If
                        End If
                        If lineread.StartsWith("SSR_TermModifierTitleCase=") Then
                            If variablevalue = "True" Then
                                SSR_TermModifierTitleCase.Checked = True
                            Else
                                SSR_TermModifierTitleCase.Checked = False
                            End If
                        End If
                    End If
                End While
                reader.Close()
                reader = Nothing
            End If
            If SSR_FileTypes.Items.Count = 0 Then
                SSR_FileTypes.Items.Add(".asp")
                SSR_FileTypes.Items.Add(".htm")
                SSR_FileTypes.Items.Add(".html")
                SSR_FileTypes.Items.Add(".php")
                SSR_FileTypes.Items.Add(".inc")
            End If
        Catch ex As Exception
            Error_Handler(ex, "Load Settings")
        End Try
    End Sub

    Private Sub SaveSettings()
        Try
            Dim configfile As String = (Application.StartupPath & "\config.sav").Replace("\\", "\")
            Dim writer As StreamWriter = New StreamWriter(configfile, False)
            writer.WriteLine("SSR_SearchTerm=" & SSR_SearchTerm.Text)
            writer.WriteLine("SSR_ReplaceTerm=" & SSR_ReplaceTerm.Text)
            writer.WriteLine("SSR_RootFolder=" & SSR_RootFolder.Text)
            writer.WriteLine("SSR_TermModifierAsIs=" & SSR_TermModifierAsIs.Checked.ToString)
            writer.WriteLine("SSR_TermModifierLowercase=" & SSR_TermModifierLowercase.Checked.ToString)
            writer.WriteLine("SSR_TermModifierUppercase=" & SSR_TermModifierUppercase.Checked.ToString)
            writer.WriteLine("SSR_TermModifierTitleCase=" & SSR_TermModifierTitleCase.Checked.ToString)
            Dim output As String = ""
            For Each input As String In SSR_FileTypes.Items
                If output <> "" Then
                    output = output & ";" & input
                Else
                    output = output & input
                End If
            Next
            writer.WriteLine("SSR_FileTypes=" & output)
            writer.Flush()
            writer.Close()
            writer = Nothing
        Catch ex As Exception
            Error_Handler(ex, "Save Settings")
        End Try
    End Sub

    Private Sub Main_Screen_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            SaveSettings()
            If AutoUpdate = True Then
                If My.Computer.FileSystem.FileExists((Application.StartupPath & "\AutoUpdate.exe").Replace("\\", "\")) = True Then
                    Dim startinfo As ProcessStartInfo = New ProcessStartInfo
                    startinfo.FileName = (Application.StartupPath & "\AutoUpdate.exe").Replace("\\", "\")
                    startinfo.Arguments = "force"
                    startinfo.CreateNoWindow = False
                    Process.Start(startinfo)
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Closing Application")
        End Try
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        Try
            HelpBox1.ShowDialog()
        Catch ex As Exception
            Error_Handler(ex, "Display Help Screen")
        End Try
    End Sub

    Private Sub AutoUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoUpdateToolStripMenuItem.Click
        Try
            AutoUpdate = True
            Me.Close()
        Catch ex As Exception
            Error_Handler(ex, "AutoUpdate")
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Try
            AboutBox1.ShowDialog()
        Catch ex As Exception
            Error_Handler(ex, "Display About Screen")
        End Try
    End Sub

    Private Sub Control_Enabler(ByVal IsEnabled As Boolean)
        Try
            Select Case IsEnabled
                Case True
                    SSR_StartButton.Enabled = True
                    SSR_RootFolder.Enabled = True
                    GroupBox1.Enabled = True
                    MenuStrip1.Enabled = True
                    Me.ControlBox = True
                    SSR_CancelButton.Enabled = False
                    Label6.Visible = False
                Case False
                    SSR_StartButton.Enabled = False
                    SSR_RootFolder.Enabled = False
                    GroupBox1.Enabled = False
                    MenuStrip1.Enabled = False
                    Me.ControlBox = False
                    SSR_CancelButton.Enabled = True
                    Label6.Visible = True
            End Select
        Catch ex As Exception
            Error_Handler(ex, "Control Enabler")
        End Try
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Try
            If SSR_Step1Label.ForeColor = Color.Maroon And folderlist.Count > 0 Then
                SSR_Step1Label.ForeColor = Color.Green
            End If

            Dim oldlabel As String = SSR_Step1Label.Text
            SSR_Step1Label.Text = folderlist.Count & " folders retrieved"
            If oldlabel <> SSR_Step1Label.Text Then
                SSR_Step1Label.Refresh()
            End If

        Catch ex As Exception
            Error_Handler(ex, "Step 1 Progress Report")
        End Try
    End Sub

    Private Sub FolderRetrieve(ByVal targetdir As String)
        Try
            If CancelOperation = False Then
                Dim dinfo As DirectoryInfo = New DirectoryInfo(targetdir)
                If dinfo.Exists = True Then
                    folderlist.Add(dinfo.FullName)
                    BackgroundWorker1.ReportProgress(100)
                    For Each subdir As DirectoryInfo In dinfo.GetDirectories
                        If CancelOperation = True Then
                            Exit For
                        End If
                        FolderRetrieve(subdir.FullName)
                        subdir = Nothing
                    Next
                End If
                dinfo = Nothing
            End If
        Catch ex As Exception
            Error_Handler(ex, "Folder Retrieve (" & targetdir & ")")
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            If CancelOperation = True Then
                e.Cancel = True
            Else
                If My.Computer.FileSystem.DirectoryExists(SSR_RootFolder.Text) = True Then
                    FolderRetrieve(SSR_RootFolder.Text)
                    BackgroundWorker1.ReportProgress(100)
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 1")
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            If e.Cancelled = False And e.Error Is Nothing And CancelOperation = False Then
                step1busyworking = False
                BackgroundWorker2.RunWorkerAsync()
                'SSR_StatusLabel.Text = "Operation completed successfully."
                'Activity_Handler("Process Completed")
            Else
                step1busyworking = False
                step2busyworking = False
                step3busyworking = False
                step4busyworking = False
                step5busyworking = False
                step6busyworking = False
                step7busyworking = False
                step8busyworking = False

                SSR_Step1Label.ForeColor = Color.Gray
                SSR_Step2Label.ForeColor = Color.Gray
                SSR_Step3Label.ForeColor = Color.Gray
                SSR_Step4Label.ForeColor = Color.Gray
                SSR_Step5Label.ForeColor = Color.Gray
                SSR_Step6Label.ForeColor = Color.Gray
                SSR_Step7Label.ForeColor = Color.Gray
                SSR_Step8Label.ForeColor = Color.Gray

                SSR_Step2ProgressBar.Value = 0
                SSR_Step4ProgressBar.Value = 0
                SSR_Step5ProgressBar.Value = 0
                SSR_Step6ProgressBar.Value = 0
                SSR_Step7ProgressBar.Value = 0
                SSR_Step8ProgressBar.Value = 0

                SSR_StatusLabel.Text = "Operation did not complete successfully."
                Activity_Handler("Process Cancelled")
                Control_Enabler(True)
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 1 Completed")
        End Try
    End Sub

    Private Sub SSR_StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSR_StartButton.Click
        Try
            Dim search() As String = SSR_SearchTerm.Text.Split(";;")
            Dim replace() As String = SSR_ReplaceTerm.Text.Split(";;")
            If search.Length = replace.Length Then

                Control_Enabler(False)

                fillworker = 1
                totalfilecounter = 0
                filecounteradjusted = 0

                step1busyworking = True
                step2busyworking = True
                step3busyworking = True
                step4busyworking = True
                step5busyworking = True
                step6busyworking = True
                step7busyworking = True
                step8busyworking = True

                folderlist.Clear()
                worker1.Clear()
                worker2.Clear()
                worker3.Clear()
                worker4.Clear()
                worker5.Clear()

                SSR_Step1Label.Text = "0 folders retrieved"
                SSR_Step2Label.Text = "0/0 folders renamed"
                SSR_Step3Label.Text = "0 files retrieved"
                SSR_Step4Label.Text = "0/0 files replaced"
                SSR_Step5Label.Text = "0/0 files replaced"
                SSR_Step6Label.Text = "0/0 files replaced"
                SSR_Step7Label.Text = "0/0 files replaced"
                SSR_Step8Label.Text = "0/0 files replaced"

                SSR_Step1Label.ForeColor = Color.Maroon
                SSR_Step2Label.ForeColor = Color.Maroon
                SSR_Step3Label.ForeColor = Color.Maroon
                SSR_Step4Label.ForeColor = Color.Maroon
                SSR_Step5Label.ForeColor = Color.Maroon
                SSR_Step6Label.ForeColor = Color.Maroon
                SSR_Step7Label.ForeColor = Color.Maroon
                SSR_Step8Label.ForeColor = Color.Maroon

                SSR_Step2ProgressBar.Value = 0
                SSR_Step4ProgressBar.Value = 0
                SSR_Step5ProgressBar.Value = 0
                SSR_Step6ProgressBar.Value = 0
                SSR_Step7ProgressBar.Value = 0
                SSR_Step8ProgressBar.Value = 0

                step2counter = 0
                step4counter = 0
                step5counter = 0
                step6counter = 0
                step7counter = 0
                step8counter = 0


                step2adjusted = 0
                step4adjusted = 0
                step5adjusted = 0
                step6adjusted = 0
                step7adjusted = 0
                step8adjusted = 0

                SSR_StatusLabel.Text = "Operation is now in progress"
                CancelOperation = False

                Dim counter As Integer = 1
                SSR_BackupFolder = SSR_RootFolder.Text & " SSR Backup " & Format(Now, "yyyyMMdd") & " " & counter
                While My.Computer.FileSystem.DirectoryExists(SSR_BackupFolder) = True
                    counter = counter + 1
                    SSR_BackupFolder = SSR_RootFolder.Text & " SSR Backup " & Format(Now, "yyyyMMdd") & " " & counter
                End While
                My.Computer.FileSystem.CreateDirectory(SSR_BackupFolder)

                Activity_Handler("Process Started")
                BackgroundWorker1.RunWorkerAsync()

            Else
                MsgBox("The number of search items does not match up to the number of replace items as delimited using the ';;' delimiter string. Please go back ensure that the number of terms match up.", MsgBoxStyle.Information, "Input Error")
            End If
        Catch ex As Exception
            Error_Handler(ex, "Begin Operation")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSR_SearchTerm.TextChanged, SSR_ReplaceTerm.TextChanged, SSR_RootFolder.TextChanged
        Try
            If SSR_SearchTerm.Text.Length > 0 And SSR_SearchTerm.Text <> SSR_ReplaceTerm.Text And My.Computer.FileSystem.DirectoryExists(SSR_RootFolder.Text) = True Then
                SSR_StartButton.Enabled = True
            Else
                SSR_StartButton.Enabled = False
            End If
        Catch ex As Exception
            Error_Handler(ex, "Check Operation Feasibility")
        End Try
    End Sub

    Private Sub SSR_FolderBrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSR_FolderBrowseButton.Click
        Try
            If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                SSR_RootFolder.Text = FolderBrowserDialog1.SelectedPath
            End If
        Catch ex As Exception
            Error_Handler(ex, "Select Root Folder")
        End Try
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Try
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            Error_Handler(ex, "Minimize Window")
        End Try
    End Sub

    Private Sub SSR_CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SSR_CancelButton.Click
        Try
            CancelOperation = True
        Catch ex As Exception
            Error_Handler(ex, "Cancel Operation Button Pressed")
        End Try
    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        Try
            SSR_Step2ProgressBar.Value = e.ProgressPercentage
            If SSR_Step2Label.ForeColor = Color.Maroon And e.ProgressPercentage > 0 Then
                SSR_Step2Label.ForeColor = Color.Green
            End If

            Dim oldlabel As String = SSR_Step2Label.Text
            SSR_Step2Label.Text = step2adjusted & "/" & folderlist.Count & " folders renamed"
            If oldlabel <> SSR_Step2Label.Text Then
                SSR_Step2Label.Refresh()
            End If


        Catch ex As Exception
            Error_Handler(ex, "Step 2 Progress Report")
        End Try
    End Sub

    Private Sub FolderRename(ByVal targetdir As String, ByVal searchtermi As String, ByVal replacetermi As String)
        Try
            If CancelOperation = False Then
                Dim dinfo As DirectoryInfo = New DirectoryInfo(targetdir)
                If dinfo.Exists = True Then

                    Dim oldname As String = dinfo.Name
                    Dim newname As String
                    Dim adjusted As Boolean = False

                    If adjusted = False Then
                        newname = dinfo.Name.Replace(searchtermi, replacetermi)
                        If newname <> oldname Then
                            While My.Computer.FileSystem.DirectoryExists((dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\")) = True
                                newname = newname & "_"
                            End While
                            dinfo.MoveTo((dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\"))
                            Activity_Handler("Folder Rename:" & vbCrLf & (dinfo.Parent.FullName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]")
                            step2adjusted = step2adjusted + 1
                            adjusted = True
                        End If
                    End If

                    If SSR_TermModifierLowercase.Checked = True Then
                        If adjusted = False Then
                            newname = dinfo.Name.Replace(searchtermi.ToLower, replacetermi.ToLower)
                            If newname <> oldname Then
                                While My.Computer.FileSystem.DirectoryExists((dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\")) = True
                                    newname = newname & "_"
                                End While
                                dinfo.MoveTo((dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\"))
                                Activity_Handler("Folder Rename:" & vbCrLf & (dinfo.Parent.FullName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]")
                                step2adjusted = step2adjusted + 1
                                adjusted = True
                            End If
                        End If
                    End If

                    If SSR_TermModifierUppercase.Checked = True Then
                        If adjusted = False Then
                            newname = dinfo.Name.Replace(searchtermi.ToUpper, replacetermi.ToUpper)
                            If newname <> oldname Then
                                While My.Computer.FileSystem.DirectoryExists((dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\")) = True
                                    newname = newname & "_"
                                End While
                                dinfo.MoveTo((dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\"))
                                Activity_Handler("Folder Rename:" & vbCrLf & (dinfo.Parent.FullName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]")
                                step2adjusted = step2adjusted + 1
                                adjusted = True
                            End If
                        End If
                    End If

                    If SSR_TermModifierTitleCase.Checked = True Then
                        If adjusted = False Then
                            newname = dinfo.Name.Replace(Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(searchtermi), Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(replacetermi))
                            If newname <> oldname Then
                                While My.Computer.FileSystem.DirectoryExists((dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\")) = True
                                    newname = newname & "_"
                                End While
                                dinfo.MoveTo((dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\"))
                                Activity_Handler("Folder Rename:" & vbCrLf & (dinfo.Parent.FullName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (dinfo.Parent.FullName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]")
                                step2adjusted = step2adjusted + 1
                                adjusted = True
                            End If
                        End If
                    End If



                    step2counter = step2counter + 1
                    BackgroundWorker2.ReportProgress(CSng(step2counter) / CSng(folderlist.Count) * 100)
                    For Each subdir As DirectoryInfo In dinfo.GetDirectories
                        If CancelOperation = True Then
                            Exit For
                        End If
                        FolderRename(subdir.FullName, searchtermi, replacetermi)
                        subdir = Nothing
                    Next
                End If
                dinfo = Nothing
            End If

        Catch ex As Exception
            Error_Handler(ex, "Folder Rename (" & targetdir & ")")
        End Try
    End Sub

    Private Sub BackgroundWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Try
            If CancelOperation = True Then
                e.Cancel = True
            Else
                If My.Computer.FileSystem.DirectoryExists(SSR_RootFolder.Text) = True Then
                    Dim search() As String = SSR_SearchTerm.Text.Split(";;")
                    Dim replace() As String = SSR_ReplaceTerm.Text.Split(";;")
                    Dim termi As Integer = 0



                    For Each str As String In search
                        step2counter = 0
                        If search(termi).Length > 0 And replace(termi).Length > 0 Then
                            FolderRename(SSR_RootFolder.Text, search(termi), replace(termi))
                        End If
                        termi = termi + 1
                    Next
                            BackgroundWorker2.ReportProgress(100)
                        End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 2")
        End Try
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Try

            If e.Cancelled = False And e.Error Is Nothing And CancelOperation = False Then
                'Control_Enabler(True)
                step2busyworking = False
                BackgroundWorker3.RunWorkerAsync()
                'SSR_StatusLabel.Text = "Operation completed successfully."
                'Activity_Handler("Process Completed")
            Else
                step1busyworking = False
                step2busyworking = False
                step3busyworking = False
                step4busyworking = False
                step5busyworking = False
                step6busyworking = False
                step7busyworking = False
                step8busyworking = False

                SSR_Step1Label.ForeColor = Color.Gray
                SSR_Step2Label.ForeColor = Color.Gray
                SSR_Step3Label.ForeColor = Color.Gray
                SSR_Step4Label.ForeColor = Color.Gray
                SSR_Step5Label.ForeColor = Color.Gray
                SSR_Step6Label.ForeColor = Color.Gray
                SSR_Step7Label.ForeColor = Color.Gray
                SSR_Step8Label.ForeColor = Color.Gray

                SSR_Step2ProgressBar.Value = 0
                SSR_Step4ProgressBar.Value = 0
                SSR_Step5ProgressBar.Value = 0
                SSR_Step6ProgressBar.Value = 0
                SSR_Step7ProgressBar.Value = 0
                SSR_Step8ProgressBar.Value = 0

                SSR_StatusLabel.Text = "Operation did not complete successfully."
                Activity_Handler("Process Cancelled")
                Control_Enabler(True)
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 2 Completed")
        End Try
    End Sub

    Private Sub BackgroundWorker3_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker3.ProgressChanged
        Try
            If SSR_Step3Label.ForeColor = Color.Maroon And worker1.Count > 0 Then
                SSR_Step3Label.ForeColor = Color.Green
            End If
            Dim oldlabel As String = SSR_Step3Label.Text
            SSR_Step3Label.Text = worker1.Count + worker2.Count + worker3.Count + worker4.Count + worker5.Count & " valid files accepted (" & totalfilecounter & " files retrieved) (" & filecounteradjusted & " invalid files renamed)"
            If oldlabel <> SSR_Step3Label.Text Then
                SSR_Step3Label.Refresh()
            End If


        Catch ex As Exception
            Error_Handler(ex, "Step 3 Progress Report")
        End Try
    End Sub

    Private Sub FileRetrieve(ByVal targetdir As String)
        Try
         
            If CancelOperation = False Then
                Dim dinfo As DirectoryInfo = New DirectoryInfo(targetdir)
                If dinfo.Exists = True Then
                    For Each finfo As FileInfo In dinfo.GetFiles
                        Try
                            If CancelOperation = True Then
                                Exit For
                            End If

                            Dim addfile As Boolean = False
                            For Each filetype As String In SSR_FileTypes.Items
                                If finfo.Extension.ToLower = filetype Then
                                    addfile = True
                                End If
                            Next
                            If addfile = True Then
                                Select Case fillworker
                                    Case 1
                                        worker1.Add(finfo.FullName)
                                    Case 2
                                        worker2.Add(finfo.FullName)
                                    Case 3
                                        worker3.Add(finfo.FullName)
                                    Case 4
                                        worker4.Add(finfo.FullName)
                                    Case 5
                                        worker5.Add(finfo.FullName)
                                End Select
                                fillworker = fillworker + 1
                                If fillworker > 5 Then
                                    fillworker = 1
                                End If
                            Else
                                '******************************
                                Try
                                    Dim search() As String = SSR_SearchTerm.Text.Split(";;")
                                    Dim replace() As String = SSR_ReplaceTerm.Text.Split(";;")

                                    Dim termi As Integer = 0



                                    For Each str As String In search
                                        If search(termi).Length > 0 And replace(termi).Length > 0 Then


                                            Dim adjusted As Boolean = False

                                            If finfo.Exists = True Then
                                                Dim oldname As String = finfo.Name
                                                Dim newname As String

                                                If adjusted = False Then
                                                    newname = finfo.Name.Replace(search(termi), replace(termi))
                                                    If newname <> oldname Then
                                                        While My.Computer.FileSystem.FileExists((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\")) = True
                                                            newname = newname & "_"
                                                        End While
                                                        finfo.MoveTo((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\"))
                                                        Activity_Handler("File Rename:" & vbCrLf & (finfo.DirectoryName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]")
                                                        adjusted = True
                                                    End If
                                                End If

                                                If SSR_TermModifierLowercase.Checked = True Then
                                                    If adjusted = False Then
                                                        newname = finfo.Name.Replace(search(termi).ToLower, replace(termi).ToLower)
                                                        If newname <> oldname Then
                                                            While My.Computer.FileSystem.FileExists((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\")) = True
                                                                newname = newname & "_"
                                                            End While
                                                            finfo.MoveTo((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\"))
                                                            Activity_Handler("File Rename:" & vbCrLf & (finfo.DirectoryName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]")
                                                            adjusted = True
                                                        End If
                                                    End If
                                                End If

                                                If SSR_TermModifierUppercase.Checked = True Then
                                                    If adjusted = False Then
                                                        newname = finfo.Name.Replace(search(termi).ToUpper, replace(termi).ToUpper)
                                                        If newname <> oldname Then
                                                            While My.Computer.FileSystem.FileExists((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\")) = True
                                                                newname = newname & "_"
                                                            End While
                                                            finfo.MoveTo((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\"))
                                                            Activity_Handler("File Rename:" & vbCrLf & (finfo.DirectoryName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]")
                                                            adjusted = True
                                                        End If
                                                    End If
                                                End If

                                                If SSR_TermModifierTitleCase.Checked = True Then
                                                    If adjusted = False Then
                                                        newname = finfo.Name.Replace(Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(search(termi)), Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(replace(termi)))
                                                        If newname <> oldname Then
                                                            While My.Computer.FileSystem.FileExists((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\")) = True
                                                                newname = newname & "_"
                                                            End While
                                                            finfo.MoveTo((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\"))
                                                            Activity_Handler("File Rename:" & vbCrLf & (finfo.DirectoryName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]")
                                                            adjusted = True
                                                        End If
                                                    End If
                                                End If

                                                If adjusted = True Then
                                                    filecounteradjusted = filecounteradjusted + 1
                                                End If
                                            End If
                                        End If
                                        termi = termi + 1
                                    Next
                                Catch ex As Exception
                                    Error_Handler(ex, "File Retrieve (" & targetdir & ")")
                                End Try
                                '*******************************
                            End If
                            totalfilecounter = totalfilecounter + 1
                        Catch ex As Exception
                            Error_Handler(ex, "File Retrieve (" & targetdir & ")")
                        End Try
                        finfo = Nothing
                        BackgroundWorker3.ReportProgress(100)
                    Next
                    For Each subdir As DirectoryInfo In dinfo.GetDirectories
                        If CancelOperation = True Then
                            Exit For
                        End If
                        FileRetrieve(subdir.FullName)
                        subdir = Nothing
                    Next
                End If
                dinfo = Nothing
            End If
               
        Catch ex As Exception
            Error_Handler(ex, "File Retrieve (" & targetdir & ")")
        End Try
    End Sub

    Private Sub BackgroundWorker3_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        Try
            If CancelOperation = True Then
                e.Cancel = True
            Else
                If My.Computer.FileSystem.DirectoryExists(SSR_RootFolder.Text) = True Then
                    FileRetrieve(SSR_RootFolder.Text)
                    BackgroundWorker3.ReportProgress(100)
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 3")
        End Try
    End Sub

    Private Sub BackgroundWorker3_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted
        Try
            If e.Cancelled = False And e.Error Is Nothing And CancelOperation = False Then
                'Control_Enabler(True)
                step3busyworking = False
                BackgroundWorker4.RunWorkerAsync()
                BackgroundWorker5.RunWorkerAsync()
                BackgroundWorker6.RunWorkerAsync()
                BackgroundWorker7.RunWorkerAsync()
                BackgroundWorker8.RunWorkerAsync()
                'SSR_StatusLabel.Text = "Operation completed successfully."
                'Activity_Handler("Process Completed")
            Else
                step1busyworking = False
                step2busyworking = False
                step3busyworking = False
                step4busyworking = False
                step5busyworking = False
                step6busyworking = False
                step7busyworking = False
                step8busyworking = False

                SSR_Step1Label.ForeColor = Color.Gray
                SSR_Step2Label.ForeColor = Color.Gray
                SSR_Step3Label.ForeColor = Color.Gray
                SSR_Step4Label.ForeColor = Color.Gray
                SSR_Step5Label.ForeColor = Color.Gray
                SSR_Step6Label.ForeColor = Color.Gray
                SSR_Step7Label.ForeColor = Color.Gray
                SSR_Step8Label.ForeColor = Color.Gray

                SSR_Step2ProgressBar.Value = 0
                SSR_Step4ProgressBar.Value = 0
                SSR_Step5ProgressBar.Value = 0
                SSR_Step6ProgressBar.Value = 0
                SSR_Step7ProgressBar.Value = 0
                SSR_Step8ProgressBar.Value = 0

                SSR_StatusLabel.Text = "Operation did not complete successfully."
                Activity_Handler("Process Cancelled")
                Control_Enabler(True)
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 3 Completed")
        End Try
    End Sub

    Private Sub BackgroundWorker4_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker4.ProgressChanged
        Try
            SSR_Step4ProgressBar.Value = e.ProgressPercentage
            If SSR_Step4Label.ForeColor = Color.Maroon And e.ProgressPercentage > 0 Then
                SSR_Step4Label.ForeColor = Color.Green
            End If
            Dim oldlabel As String = SSR_Step4Label.Text
            SSR_Step4Label.Text = step4adjusted & "/" & worker1.Count & " files replaced"
            If oldlabel <> SSR_Step4Label.Text Then
                SSR_Step4Label.Refresh()
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 4 Progress Report")
        End Try
    End Sub

    Private Sub BackgroundWorker5_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker5.ProgressChanged
        Try
            SSR_Step5ProgressBar.Value = e.ProgressPercentage
            If SSR_Step5Label.ForeColor = Color.Maroon And e.ProgressPercentage > 0 Then
                SSR_Step5Label.ForeColor = Color.Green
            End If
            Dim oldlabel As String = SSR_Step5Label.Text
            SSR_Step5Label.Text = step5adjusted & "/" & worker2.Count & " files replaced"
            If oldlabel <> SSR_Step5Label.Text Then
                SSR_Step5Label.Refresh()
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 5 Progress Report")
        End Try
    End Sub

    Private Sub BackgroundWorker6_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker6.ProgressChanged
        Try
            SSR_Step6ProgressBar.Value = e.ProgressPercentage
            If SSR_Step6Label.ForeColor = Color.Maroon And e.ProgressPercentage > 0 Then
                SSR_Step6Label.ForeColor = Color.Green
            End If
            Dim oldlabel As String = SSR_Step6Label.Text
            SSR_Step6Label.Text = step6adjusted & "/" & worker3.Count & " files replaced"
            If oldlabel <> SSR_Step6Label.Text Then
                SSR_Step6Label.Refresh()
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 6 Progress Report")
        End Try
    End Sub

    Private Sub BackgroundWorker7_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker7.ProgressChanged
        Try
            SSR_Step7ProgressBar.Value = e.ProgressPercentage
            If SSR_Step7Label.ForeColor = Color.Maroon And e.ProgressPercentage > 0 Then
                SSR_Step7Label.ForeColor = Color.Green
            End If
            Dim oldlabel As String = SSR_Step7Label.Text
            SSR_Step7Label.Text = step7adjusted & "/" & worker4.Count & " files replaced"
            If oldlabel <> SSR_Step7Label.Text Then
                SSR_Step7Label.Refresh()
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 7 Progress Report")
        End Try
    End Sub

    Private Sub BackgroundWorker8_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker8.ProgressChanged
        Try
            SSR_Step8ProgressBar.Value = e.ProgressPercentage
            If SSR_Step8Label.ForeColor = Color.Maroon And e.ProgressPercentage > 0 Then
                SSR_Step8Label.ForeColor = Color.Green
            End If
            Dim oldlabel As String = SSR_Step8Label.Text
            SSR_Step8Label.Text = step8adjusted & "/" & worker5.Count & " files replaced"
            If oldlabel <> SSR_Step8Label.Text Then
                SSR_Step8Label.Refresh()
            End If

        Catch ex As Exception
            Error_Handler(ex, "Step 8 Progress Report")
        End Try
    End Sub

    Private Sub BackgroundWorker4_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker4.RunWorkerCompleted
        Try
            If e.Cancelled = False And e.Error Is Nothing And CancelOperation = False Then
                step4busyworking = False
                If step4busyworking = False And step5busyworking = False And step6busyworking = False And step7busyworking = False And step8busyworking = False Then
                    Control_Enabler(True)
                    SSR_StatusLabel.Text = "Operation completed successfully."
                    Merge_Activity_Logs()
                    Activity_Handler("Process Completed")
                End If
            Else
                step1busyworking = False
                step2busyworking = False
                step3busyworking = False
                step4busyworking = False
                step5busyworking = False
                step6busyworking = False
                step7busyworking = False
                step8busyworking = False

                SSR_Step1Label.ForeColor = Color.Gray
                SSR_Step2Label.ForeColor = Color.Gray
                SSR_Step3Label.ForeColor = Color.Gray
                SSR_Step4Label.ForeColor = Color.Gray
                SSR_Step5Label.ForeColor = Color.Gray
                SSR_Step6Label.ForeColor = Color.Gray
                SSR_Step7Label.ForeColor = Color.Gray
                SSR_Step8Label.ForeColor = Color.Gray

                SSR_Step2ProgressBar.Value = 0
                SSR_Step4ProgressBar.Value = 0
                SSR_Step5ProgressBar.Value = 0
                SSR_Step6ProgressBar.Value = 0
                SSR_Step7ProgressBar.Value = 0
                SSR_Step8ProgressBar.Value = 0

                SSR_StatusLabel.Text = "Operation did not complete successfully."
                Merge_Activity_Logs()
                Activity_Handler("Process Cancelled")
                Control_Enabler(True)
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 4 Completed")
        End Try
    End Sub

    Private Sub BackgroundWorker5_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker5.RunWorkerCompleted
        Try
            If e.Cancelled = False And e.Error Is Nothing And CancelOperation = False Then
                step5busyworking = False
                If step4busyworking = False And step5busyworking = False And step6busyworking = False And step7busyworking = False And step8busyworking = False Then
                    Control_Enabler(True)
                    SSR_StatusLabel.Text = "Operation completed successfully."
                    Merge_Activity_Logs()
                    Activity_Handler("Process Completed")
                End If
            Else
                step1busyworking = False
                step2busyworking = False
                step3busyworking = False
                step4busyworking = False
                step5busyworking = False
                step6busyworking = False
                step7busyworking = False
                step8busyworking = False

                SSR_Step1Label.ForeColor = Color.Gray
                SSR_Step2Label.ForeColor = Color.Gray
                SSR_Step3Label.ForeColor = Color.Gray
                SSR_Step4Label.ForeColor = Color.Gray
                SSR_Step5Label.ForeColor = Color.Gray
                SSR_Step6Label.ForeColor = Color.Gray
                SSR_Step7Label.ForeColor = Color.Gray
                SSR_Step8Label.ForeColor = Color.Gray

                SSR_Step2ProgressBar.Value = 0
                SSR_Step4ProgressBar.Value = 0
                SSR_Step5ProgressBar.Value = 0
                SSR_Step6ProgressBar.Value = 0
                SSR_Step7ProgressBar.Value = 0
                SSR_Step8ProgressBar.Value = 0

                SSR_StatusLabel.Text = "Operation did not complete successfully."
                Merge_Activity_Logs()
                Activity_Handler("Process Cancelled")

                Control_Enabler(True)
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 5 Completed")
        End Try
    End Sub

    Private Sub BackgroundWorker6_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker6.RunWorkerCompleted
        Try
            If e.Cancelled = False And e.Error Is Nothing And CancelOperation = False Then
                step6busyworking = False
                If step4busyworking = False And step5busyworking = False And step6busyworking = False And step7busyworking = False And step8busyworking = False Then
                    Control_Enabler(True)
                    SSR_StatusLabel.Text = "Operation completed successfully."
                    Merge_Activity_Logs()
                    Activity_Handler("Process Completed")

                End If
            Else
                step1busyworking = False
                step2busyworking = False
                step3busyworking = False
                step4busyworking = False
                step5busyworking = False
                step6busyworking = False
                step7busyworking = False
                step8busyworking = False

                SSR_Step1Label.ForeColor = Color.Gray
                SSR_Step2Label.ForeColor = Color.Gray
                SSR_Step3Label.ForeColor = Color.Gray
                SSR_Step4Label.ForeColor = Color.Gray
                SSR_Step5Label.ForeColor = Color.Gray
                SSR_Step6Label.ForeColor = Color.Gray
                SSR_Step7Label.ForeColor = Color.Gray
                SSR_Step8Label.ForeColor = Color.Gray

                SSR_Step2ProgressBar.Value = 0
                SSR_Step4ProgressBar.Value = 0
                SSR_Step5ProgressBar.Value = 0
                SSR_Step6ProgressBar.Value = 0
                SSR_Step7ProgressBar.Value = 0
                SSR_Step8ProgressBar.Value = 0

                SSR_StatusLabel.Text = "Operation did not complete successfully."
                Merge_Activity_Logs()
                Activity_Handler("Process Cancelled")

                Control_Enabler(True)
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 6 Completed")
        End Try
    End Sub

    Private Sub BackgroundWorker7_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker7.RunWorkerCompleted
        Try
            If e.Cancelled = False And e.Error Is Nothing And CancelOperation = False Then
                step7busyworking = False
                If step4busyworking = False And step5busyworking = False And step6busyworking = False And step7busyworking = False And step8busyworking = False Then
                    Control_Enabler(True)
                    SSR_StatusLabel.Text = "Operation completed successfully."
                    Merge_Activity_Logs()
                    Activity_Handler("Process Completed")

                End If
            Else
                step1busyworking = False
                step2busyworking = False
                step3busyworking = False
                step4busyworking = False
                step5busyworking = False
                step6busyworking = False
                step7busyworking = False
                step8busyworking = False

                SSR_Step1Label.ForeColor = Color.Gray
                SSR_Step2Label.ForeColor = Color.Gray
                SSR_Step3Label.ForeColor = Color.Gray
                SSR_Step4Label.ForeColor = Color.Gray
                SSR_Step5Label.ForeColor = Color.Gray
                SSR_Step6Label.ForeColor = Color.Gray
                SSR_Step7Label.ForeColor = Color.Gray
                SSR_Step8Label.ForeColor = Color.Gray

                SSR_Step2ProgressBar.Value = 0
                SSR_Step4ProgressBar.Value = 0
                SSR_Step5ProgressBar.Value = 0
                SSR_Step6ProgressBar.Value = 0
                SSR_Step7ProgressBar.Value = 0
                SSR_Step8ProgressBar.Value = 0

                SSR_StatusLabel.Text = "Operation did not complete successfully."
                Merge_Activity_Logs()
                Activity_Handler("Process Cancelled")

                Control_Enabler(True)
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 7 Completed")
        End Try
    End Sub

    Private Sub BackgroundWorker8_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker8.RunWorkerCompleted
        Try
            If e.Cancelled = False And e.Error Is Nothing And CancelOperation = False Then
                step8busyworking = False
                If step4busyworking = False And step5busyworking = False And step6busyworking = False And step7busyworking = False And step8busyworking = False Then
                    Control_Enabler(True)
                    SSR_StatusLabel.Text = "Operation completed successfully."
                    Merge_Activity_Logs()
                    Activity_Handler("Process Completed")

                End If
            Else
                step1busyworking = False
                step2busyworking = False
                step3busyworking = False
                step4busyworking = False
                step5busyworking = False
                step6busyworking = False
                step7busyworking = False
                step8busyworking = False

                SSR_Step1Label.ForeColor = Color.Gray
                SSR_Step2Label.ForeColor = Color.Gray
                SSR_Step3Label.ForeColor = Color.Gray
                SSR_Step4Label.ForeColor = Color.Gray
                SSR_Step5Label.ForeColor = Color.Gray
                SSR_Step6Label.ForeColor = Color.Gray
                SSR_Step7Label.ForeColor = Color.Gray
                SSR_Step8Label.ForeColor = Color.Gray

                SSR_Step2ProgressBar.Value = 0
                SSR_Step4ProgressBar.Value = 0
                SSR_Step5ProgressBar.Value = 0
                SSR_Step6ProgressBar.Value = 0
                SSR_Step7ProgressBar.Value = 0
                SSR_Step8ProgressBar.Value = 0

                SSR_StatusLabel.Text = "Operation did not complete successfully."
                Merge_Activity_Logs()
                Activity_Handler("Process Cancelled")

                Control_Enabler(True)
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 8 Completed")
        End Try
    End Sub

    Private Sub BackgroundWorker4_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork
        Try
            If CancelOperation = True Then
                e.Cancel = True
            Else
                If worker1.Count > 0 Then
                    filehandler(worker1, 4)
                    BackgroundWorker4.ReportProgress(100)
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 4")
        End Try
    End Sub

    Private Sub BackgroundWorker5_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker5.DoWork
        Try
            If CancelOperation = True Then
                e.Cancel = True
            Else
                If worker2.Count > 0 Then
                    filehandler(worker2, 5)
                    BackgroundWorker5.ReportProgress(100)
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 5")
        End Try
    End Sub

    Private Sub BackgroundWorker6_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker6.DoWork
        Try
            If CancelOperation = True Then
                e.Cancel = True
            Else
                If worker3.Count > 0 Then
                    filehandler(worker3, 6)
                    BackgroundWorker6.ReportProgress(100)
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 6")
        End Try
    End Sub

    Private Sub BackgroundWorker7_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker7.DoWork
        Try
            If CancelOperation = True Then
                e.Cancel = True
            Else
                If worker4.Count > 0 Then
                    filehandler(worker4, 7)
                    BackgroundWorker7.ReportProgress(100)
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 7")
        End Try
    End Sub

    Private Sub BackgroundWorker8_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker8.DoWork
        Try
            If CancelOperation = True Then
                e.Cancel = True
            Else
                If worker5.Count > 0 Then
                    filehandler(worker5, 8)
                    BackgroundWorker8.ReportProgress(100)
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Step 8")
        End Try
    End Sub

    Private Sub filehandler(ByVal filelist As ArrayList, ByVal stepnumber As Integer)
        Dim currentfile As String = ""
        Try
            For Each filename As String In filelist
                currentfile = filename
                Select Case stepnumber
                    Case 4
                        FileRename(filename, 4)
                        step4counter = step4counter + 1
                        BackgroundWorker4.ReportProgress(CSng(step4counter) / CSng(worker1.Count) * 100)
                    Case 5
                        FileRename(filename, 5)
                        step5counter = step5counter + 1
                        BackgroundWorker5.ReportProgress(CSng(step5counter) / CSng(worker2.Count) * 100)
                    Case 6
                        FileRename(filename, 6)
                        step6counter = step6counter + 1
                        BackgroundWorker6.ReportProgress(CSng(step6counter) / CSng(worker3.Count) * 100)
                    Case 7
                        FileRename(filename, 7)
                        step7counter = step7counter + 1
                        BackgroundWorker7.ReportProgress(CSng(step7counter) / CSng(worker4.Count) * 100)
                    Case 8
                        FileRename(filename, 8)
                        step8counter = step8counter + 1
                        BackgroundWorker8.ReportProgress(CSng(step8counter) / CSng(worker5.Count) * 100)
                End Select
            Next
        Catch ex As Exception
            Error_Handler(ex, "File Handler (" & currentfile & ")")
        End Try
    End Sub

    Private Sub FileRename(ByVal targetfile As String, ByVal stepnumber As Integer)
        Try
            Dim search() As String = SSR_SearchTerm.Text.Split(";;")
            Dim replace() As String = SSR_ReplaceTerm.Text.Split(";;")

            Dim termi As Integer = 0

  

            For Each str As String In search
                If search(termi).Length > 0 And replace(termi).Length > 0 Then
                    If CancelOperation = False Then
                        Dim finfo As FileInfo = New FileInfo(targetfile)
                        Dim adjusted As Boolean = False

                        If finfo.Exists = True Then


                            Dim oldname As String = finfo.Name
                            Dim newname As String

                            If adjusted = False Then
                                newname = finfo.Name.Replace(search(termi), replace(termi))
                                If newname <> oldname Then
                                    While My.Computer.FileSystem.FileExists((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\")) = True
                                        newname = newname & "_"
                                    End While
                                    finfo.MoveTo((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\"))
                                    Activity_Handler("File Rename:" & vbCrLf & (finfo.DirectoryName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]", stepnumber)
                                    adjusted = True
                                End If
                            End If

                            If SSR_TermModifierLowercase.Checked = True Then
                                If adjusted = False Then
                                    newname = finfo.Name.Replace(search(termi).ToLower, replace(termi).ToLower)
                                    If newname <> oldname Then
                                        While My.Computer.FileSystem.FileExists((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\")) = True
                                            newname = newname & "_"
                                        End While
                                        finfo.MoveTo((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\"))
                                        Activity_Handler("File Rename:" & vbCrLf & (finfo.DirectoryName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]", stepnumber)
                                        adjusted = True
                                    End If
                                End If
                            End If

                            If SSR_TermModifierUppercase.Checked = True Then
                                If adjusted = False Then
                                    newname = finfo.Name.Replace(search(termi).ToUpper, replace(termi).ToUpper)
                                    If newname <> oldname Then
                                        While My.Computer.FileSystem.FileExists((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\")) = True
                                            newname = newname & "_"
                                        End While
                                        finfo.MoveTo((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\"))
                                        Activity_Handler("File Rename:" & vbCrLf & (finfo.DirectoryName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]", stepnumber)
                                        adjusted = True
                                    End If
                                End If
                            End If

                            If SSR_TermModifierTitleCase.Checked = True Then
                                If adjusted = False Then
                                    newname = finfo.Name.Replace(Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(search(termi)), Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(replace(termi)))
                                    If newname <> oldname Then
                                        While My.Computer.FileSystem.FileExists((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\")) = True
                                            newname = newname & "_"
                                        End While
                                        finfo.MoveTo((finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\"))
                                        Activity_Handler("File Rename:" & vbCrLf & (finfo.DirectoryName.ToString & "\" & oldname).Replace("\\", "\") & " [Old Name]" & vbCrLf & (finfo.DirectoryName.ToString & "\" & newname).Replace("\\", "\") & " [New Name]", stepnumber)
                                        adjusted = True
                                    End If
                                End If
                            End If

                            Dim filecontentsadjusted As Boolean = False

                            Dim reader As StreamReader
                            Dim newlineread, lineread As String
                            reader = New StreamReader(finfo.FullName)
                            While reader.Peek <> -1
                                lineread = reader.ReadLine
                                newlineread = lineread.Replace(search(termi), replace(termi))
                                If lineread <> newlineread Then
                                    filecontentsadjusted = True
                                    Exit While
                                End If

                                If SSR_TermModifierLowercase.Checked = True Then
                                    newlineread = lineread.Replace(search(termi).ToLower, replace(termi).ToLower)
                                    If lineread <> newlineread Then
                                        filecontentsadjusted = True
                                        Exit While
                                    End If
                                End If

                                If SSR_TermModifierUppercase.Checked = True Then
                                    newlineread = lineread.Replace(search(termi).ToUpper, replace(termi).ToUpper)
                                    If lineread <> newlineread Then
                                        filecontentsadjusted = True
                                        Exit While
                                    End If
                                End If

                                If SSR_TermModifierTitleCase.Checked = True Then
                                    newlineread = lineread.Replace(Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(search(termi)), Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(replace(termi)))
                                    If lineread <> newlineread Then
                                        filecontentsadjusted = True
                                        Exit While
                                    End If
                                End If
                            End While
                            reader.Close()
                            reader = Nothing

                            If filecontentsadjusted = True Then
                                Dim writer As StreamWriter
                                writer = New StreamWriter(finfo.FullName & "_TEMP_", False)

                                reader = New StreamReader(finfo.FullName)
                                While reader.Peek <> -1
                                    lineread = reader.ReadLine
                                    newlineread = lineread.Replace(search(termi), replace(termi))

                                    If SSR_TermModifierLowercase.Checked = True Then
                                        newlineread = newlineread.Replace(search(termi).ToLower, replace(termi).ToLower)
                                    End If

                                    If SSR_TermModifierUppercase.Checked = True Then
                                        newlineread = newlineread.Replace(search(termi).ToUpper, replace(termi).ToUpper)
                                    End If

                                    If SSR_TermModifierTitleCase.Checked = True Then
                                        newlineread = newlineread.Replace(Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(search(termi)), Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(replace(termi)))
                                    End If
                                    If reader.Peek <> -1 Then
                                        writer.WriteLine(newlineread)
                                    Else
                                        writer.Write(newlineread)
                                    End If

                                End While
                                reader.Close()
                                reader = Nothing
                                writer.Flush()
                                writer.Close()
                                writer = Nothing
                                Dim filetorename As String = finfo.FullName & "_TEMP_"
                                Dim filetorename2 As String = finfo.FullName
                                Dim dinfo As DirectoryInfo = finfo.Directory
                                Dim folderstocreate As ArrayList = New ArrayList
                                While Not dinfo.Parent Is Nothing
                                    If SSR_RootFolder.Text = dinfo.FullName Then
                                        Exit While
                                    End If
                                    folderstocreate.Add(dinfo.FullName)
                                    dinfo = dinfo.Parent
                                End While
                                dinfo = Nothing
                                If folderstocreate.Count > 0 Then
                                    For i As Integer = folderstocreate.Count - 1 To 0 Step -1
                                        If My.Computer.FileSystem.DirectoryExists(folderstocreate.Item(i).ToString.Replace(SSR_RootFolder.Text, SSR_BackupFolder)) = False Then
                                            My.Computer.FileSystem.CreateDirectory(folderstocreate.Item(i).ToString.Replace(SSR_RootFolder.Text, SSR_BackupFolder))
                                        End If
                                    Next
                                End If

                                finfo.MoveTo((finfo.FullName).Replace(SSR_RootFolder.Text, SSR_BackupFolder))
                                My.Computer.FileSystem.MoveFile(filetorename, filetorename2, True)
                                Activity_Handler("File Contents Replaced:" & vbCrLf & filetorename2 & " [Contents Replaced]" & vbCrLf & (finfo.FullName).Replace("\\", "\") & " [Backup Location]", stepnumber)
                                adjusted = True
                            End If


                            If adjusted = True Then
                                Select Case stepnumber
                                    Case 4
                                        step4adjusted = step4adjusted + 1
                                    Case 5
                                        step5adjusted = step5adjusted + 1
                                    Case 6
                                        step6adjusted = step6adjusted + 1
                                    Case 7
                                        step7adjusted = step7adjusted + 1
                                    Case 8
                                        step8adjusted = step8adjusted + 1
                                End Select
                            End If

                            finfo = Nothing
                        End If
                    End If
                End If
                termi = termi + 1
            Next
        Catch ex As Exception
            Error_Handler(ex, "File Rename/Replace (" & targetfile & ")")
        End Try
    End Sub

End Class
