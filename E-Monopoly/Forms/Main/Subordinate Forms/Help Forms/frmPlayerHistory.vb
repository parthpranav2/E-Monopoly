Imports System.IO

Public Class frmPlayerHistory

    Dim a As String = Application.StartupPath + "\" + "History"
    Dim mainfilename As String = "Main"
    Dim i As Integer = 0

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click
        rtcHistory.Text = My.Computer.FileSystem.ReadAllText(My.Settings.HistoryFileName)
        My.Application.Log.DefaultFileLogWriter.BaseFileName = System.IO.Path.Combine(Application.StartupPath + "\" + "History\" + My.Settings.LogFolderName, "" + My.Settings.LogFName)
        EMonopoly.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If frmGameModeSelector.lblGMSRGHistory.Text = 0 Or i = 1 Then
            rtcHistory.Text = My.Computer.FileSystem.ReadAllText(My.Settings.HistoryFileName)
            My.Application.Log.DefaultFileLogWriter.BaseFileName = System.IO.Path.Combine(Application.StartupPath + "\" + "History\" + My.Settings.LogFolderName, "" + My.Settings.LogFName)
            frmHelp.Show()
            Me.Hide()

        Else
            frmGameModeSelector.Show()
            butMaximize.Location = New Point(27, 0)
            Button1.Location = New Point(21, 379)
            butExit.Visible = True
            Button3.Visible = True
            Me.Close()

        End If

    End Sub

    Private Sub butMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized

        Else
        End If
    End Sub

    Private Sub PlayerHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            rtcHistory.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub


    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub rtcHistory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtcHistory.TextChanged

    End Sub

    Private Sub rtcHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtcHistory.Click

    End Sub

    Private Sub PlayerHistory_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmGameModeSelector.lblGMSRGHistory.Text = 0 Or i = 1 Then

            If My.Computer.FileSystem.FileExists(My.Settings.HistoryFileName) Then
                My.Application.Log.DefaultFileLogWriter.Close()

                rtcHistory.Text = My.Computer.FileSystem.ReadAllText(My.Settings.HistoryFileName)
                rtcHistory.SelectionStart = rtcHistory.Text.Length
                rtcHistory.ScrollToCaret()
                My.Application.Log.DefaultFileLogWriter.BaseFileName = System.IO.Path.Combine(Application.StartupPath + "\" + "History\" + My.Settings.LogFolderName, "" + My.Settings.LogFName)
            Else
                rtcHistory.Text = ("File not found. Please Select the file ")
            End If

            ListBoxFiles.Items.Clear()
            ListBoxD.Items.Clear()

            For Each DirectoryName As String In System.IO.Directory.GetDirectories(a)
                ListBoxD.Items.Add(Path.GetFileName(DirectoryName))

            Next

            'Filling Combobox
            If ListBoxD.Items.Count = 0 Then
                cmbFilter.Enabled = False
            Else
                cmbFilter.Enabled = True

                cmbFilter.Items.Clear()
                lbFilterPath.Items.Clear()
                lbFilterDirectory.Items.Clear()

                For Each filename As String In System.IO.Directory.GetFiles(a, "*.txt*", SearchOption.AllDirectories)
                    cmbFilter.Items.Add(Path.GetFileNameWithoutExtension(filename))
                    lbFilterPath.Items.Add(Path.GetFullPath(filename))
                    lbFilterDirectory.Items.Add(Path.GetFileName(Path.GetDirectoryName(filename)))
                Next

            End If
            Label1.Visible = True
            Label4.Visible = False

            defaults()

            MainIndexChanger()
        Else
            If frmGameModeSelector.lblGMSRGHistory.Text = 2 Then
                Label1.Visible = False
                Label4.Location = New Point(13, 509)
                Label4.Visible = True
            End If

            butMaximize.Location = New Point(3, 0)
            Button1.Location = New Point(21, 271)
            butExit.Visible = False
            Button3.Visible = False

            If My.Computer.FileSystem.FileExists(My.Settings.HistoryFileName) Then
                My.Application.Log.DefaultFileLogWriter.Close()

                rtcHistory.Text = My.Computer.FileSystem.ReadAllText(My.Settings.HistoryFileName)
                rtcHistory.SelectionStart = rtcHistory.Text.Length
                rtcHistory.ScrollToCaret()
                My.Application.Log.DefaultFileLogWriter.BaseFileName = System.IO.Path.Combine(Application.StartupPath + "\" + "History\" + My.Settings.LogFolderName, "" + My.Settings.LogFName)
            Else
                rtcHistory.Text = ("File not found. Please Select the file ")
            End If

            ListBoxFiles.Items.Clear()
            ListBoxD.Items.Clear()

            For Each DirectoryName As String In System.IO.Directory.GetDirectories(a)
                ListBoxD.Items.Add(Path.GetFileName(DirectoryName))

            Next

            'Filling Combobox
            If ListBoxD.Items.Count = 0 Then
                cmbFilter.Enabled = False
            Else
                cmbFilter.Enabled = True

                cmbFilter.Items.Clear()
                lbFilterPath.Items.Clear()
                lbFilterDirectory.Items.Clear()

                For Each filename As String In System.IO.Directory.GetFiles(a, "*.txt*", SearchOption.AllDirectories)
                    cmbFilter.Items.Add(Path.GetFileNameWithoutExtension(filename))
                    lbFilterPath.Items.Add(Path.GetFullPath(filename))
                    lbFilterDirectory.Items.Add(Path.GetFileName(Path.GetDirectoryName(filename)))
                Next
                MainIndexChanger()

            End If

        End If

        BankHeadingReamover()
    End Sub

    Private Sub BankHeadingReamover()
        For Each item As Object In ListBoxFiles.Items
            If item.ToString() = "Bank" Then
                ListBoxFiles.Items.RemoveAt(ListBoxFiles.Items.IndexOf("Bank"))
                Exit For
            End If
        Next
    End Sub

    Private Sub butRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRefresh.Click
        My.Application.Log.DefaultFileLogWriter.Close()
        rtcHistory.Text = My.Computer.FileSystem.ReadAllText(My.Settings.HistoryFileName)
        My.Application.Log.DefaultFileLogWriter.BaseFileName = System.IO.Path.Combine(Application.StartupPath + "\" + "History\" + My.Settings.LogFolderName, "" + My.Settings.LogFName)

        ListBoxFiles.Items.Clear()
        ListBoxD.Items.Clear()

        For Each DirectoryName As String In System.IO.Directory.GetDirectories(a)
            ListBoxD.Items.Add(Path.GetFileName(DirectoryName))

        Next

        'Filling Combobox
        If ListBoxD.Items.Count = 0 Then
            cmbFilter.Enabled = False
        Else
            cmbFilter.Enabled = True

            cmbFilter.Items.Clear()
            lbFilterPath.Items.Clear()
            lbFilterDirectory.Items.Clear()
            For Each filename As String In System.IO.Directory.GetFiles(a, "*.txt*", SearchOption.AllDirectories)
                cmbFilter.Items.Add(Path.GetFileNameWithoutExtension(filename))
                lbFilterPath.Items.Add(Path.GetFullPath(filename))
                lbFilterDirectory.Items.Add(Path.GetFileName(Path.GetDirectoryName(filename)))
            Next

        End If

        defaults()
    End Sub

    Private Sub PlayerHistory_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        My.Application.Log.DefaultFileLogWriter.Close()

        rtcHistory.Text = My.Computer.FileSystem.ReadAllText(My.Settings.HistoryFileName)

        My.Application.Log.DefaultFileLogWriter.BaseFileName = System.IO.Path.Combine(Application.StartupPath + "\" + "History\" + My.Settings.LogFolderName, "" + My.Settings.LogFName)

        ListBoxD.Items.Clear()
        ListBoxFiles.Items.Clear()


        For Each DirectoryName As String In System.IO.Directory.GetDirectories(a)
            ListBoxD.Items.Add(Path.GetFileName(DirectoryName))

        Next

        'Filling Combobox
        If ListBoxD.Items.Count = 0 Then
            cmbFilter.Enabled = False
        Else
            cmbFilter.Enabled = True

            cmbFilter.Items.Clear()
            lbFilterPath.Items.Clear()
            lbFilterDirectory.Items.Clear()
            For Each filename As String In System.IO.Directory.GetFiles(a, "*.txt*", SearchOption.AllDirectories)
                cmbFilter.Items.Add(Path.GetFileNameWithoutExtension(filename))
                lbFilterPath.Items.Add(Path.GetFullPath(filename))
                lbFilterDirectory.Items.Add(Path.GetFileName(Path.GetDirectoryName(filename)))
            Next



        End If

        defaults()
    End Sub

    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxD.MouseDoubleClick
        If ListBoxD.SelectedIndex = -1 Then
            MsgBox("Please select the file to be reloaded again")
        Else
            rtcHistory.Text = My.Computer.FileSystem.ReadAllText(a + "\" + ListBoxD.SelectedItem.ToString + "\" + My.Settings.LogFName + ".log")

            ListBoxFiles.SelectedItem = My.Settings.LogFName

            BankHeadingReamover()

            If frmGameModeSelector.lblGMSRGHistory.Text = 2 And i = 0 Then
                i = 1
                MsgBox("Loding game")
                EMonopoly.Show()
                Me.Hide()
            End If

        End If
    End Sub

    Private Sub ListBoxFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFiles.SelectedIndexChanged
        If ListBoxFiles.SelectedItem = mainfilename Then
            rtcHistory.Text = My.Computer.FileSystem.ReadAllText(a + "\" + ListBoxD.SelectedItem.ToString + "\" + ListBoxFiles.SelectedItem.ToString + ".log")
        ElseIf ListBoxFiles.SelectedItem = Nothing Then
            Try
                rtcHistory.Text = My.Computer.FileSystem.ReadAllText(a + "\" + ListBoxD.SelectedItem.ToString + "\.txt")
            Catch ex As Exception
                MsgBox("Nothing is selected", vbExclamation + vbOKOnly)
            End Try
        Else
            rtcHistory.Text = My.Computer.FileSystem.ReadAllText(a + "\" + ListBoxD.SelectedItem.ToString + "\" + ListBoxFiles.SelectedItem.ToString + ".txt")

        End If


    End Sub

    Private Sub ListBoxD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxD.SelectedIndexChanged
        ListBoxFiles.Items.Clear()

        For Each FileName As String In IO.Directory.GetFiles(a + "\" + ListBoxD.SelectedItem.ToString)
            ListBoxFiles.Items.Add(Path.GetFileNameWithoutExtension(FileName))

        Next

        MainIndexChanger()
        BankHeadingReamover()

        If frmGameModeSelector.lblGMSRGHistory.Text = 2 And i = 0 Then
            rtcHistory.Text = My.Computer.FileSystem.ReadAllText(a + "\" + ListBoxD.SelectedItem.ToString + "\" + My.Settings.LogFName + ".log")

            ListBoxFiles.SelectedItem = My.Settings.LogFName

        End If
    End Sub

    Private Sub defaults()
        ListBoxD.SelectedItem = My.Settings.LogFolderName
        ListBoxFiles.Items.Clear()

        For Each FileName As String In IO.Directory.GetFiles(a + "\" + ListBoxD.SelectedItem.ToString)
            ListBoxFiles.Items.Add(Path.GetFileNameWithoutExtension(FileName))

        Next
        ListBoxFiles.SelectedItem = My.Settings.LogFName

    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        Dim index As Integer
        Dim location As String
        index = cmbFilter.SelectedIndex
        lbFilterPath.SelectedIndex = index
        lbFilterDirectory.SelectedIndex = index
        location = lbFilterPath.SelectedItem

        Try
            ListBoxD.SelectedItem = lbFilterDirectory.SelectedItem
            ListBoxFiles.SelectedItem = cmbFilter.SelectedItem
        Catch ex As Exception

        End Try
        rtcHistory.Text = My.Computer.FileSystem.ReadAllText(location)

    End Sub

    Private Sub lbFilterDirectory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFilterDirectory.SelectedIndexChanged

    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

    End Sub

    Private Sub MainIndexChanger()
        If ListBoxFiles.Items.Contains("Main") Then
            Dim index As Integer = ListBoxFiles.Items.IndexOf("Main")
            ListBoxFiles.Items.RemoveAt(index)
            ListBoxFiles.Items.Insert(0, "Main")
        End If
    End Sub
End Class