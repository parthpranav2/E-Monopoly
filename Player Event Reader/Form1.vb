Imports System.IO
Public Class Form1
    Dim a As String = Application.StartupPath + "\" + "History"
    Dim defaultfilename As String = "Main"
    Dim mainfilename As String = "Main"
    Private Sub rtcHistory_TextChanged(sender As Object, e As EventArgs) Handles rtcHistory.TextChanged

    End Sub

    Private Sub SplitContainer2_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer2.SplitterMoved

    End Sub

    Private Sub ListBoxD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxD.SelectedIndexChanged
        ListBoxFiles.Items.Clear()

        For Each FileName As String In IO.Directory.GetFiles(a + "\" + ListBoxD.SelectedItem.ToString)
            ListBoxFiles.Items.Add(Path.GetFileNameWithoutExtension(FileName))

        Next
    End Sub

    Private Sub SplitContainer1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles SplitContainer1.SplitterMoved

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

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub butMaximize_Click(sender As Object, e As EventArgs) Handles butMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal

        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized

        Else
        End If
    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            rtcHistory.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub butRefresh_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub butMinimize_Click(sender As Object, e As EventArgs) Handles butMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Directory.Exists(a) = Nothing Then
            MsgBox("There is nothing to show. This may be due to change in default location or first time play. If this problem persists then repair the app from setup.", vbOKOnly + vbCritical)
            End
        Else
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

            ListBoxFiles.SelectedItem = Nothing
            ListBoxD.SelectedItem = Nothing
        End If

    End Sub

    Private Sub ListBoxD_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBoxD.MouseDoubleClick
        rtcHistory.Text = My.Computer.FileSystem.ReadAllText(a + "\" + ListBoxD.SelectedItem.ToString + "\" + defaultfilename + ".log")

        ListBoxFiles.SelectedItem = defaultfilename
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbFilter_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
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
End Class
