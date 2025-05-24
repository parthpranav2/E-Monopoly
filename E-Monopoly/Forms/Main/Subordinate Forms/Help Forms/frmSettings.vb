Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Public Class frmSettings

    Private Sub SaveSettings()
        If txtCurrencyNew.Text = Nothing Or txtMoney.Text = Nothing Or txtProperties.Text = Nothing Or txtHouses.Text = Nothing Or txtHotels.Text = Nothing Or txtPassGo.Text = Nothing Or txtInJail.Text = Nothing Or txtIncomeTax.Text = Nothing Or txtSupertax.Text = Nothing Or txtCriticprincipal.Text = Nothing Or txtCritictime.Text = Nothing Or txtCriticalamount.Text = Nothing Then
            MsgBox("Some of the fields of settings are empty", +vbCritical)
        Else
            MsgBox("Click Refresh button after changing the settings, If there are changes in theme or another main functions then restart the app to get the changes in effect", +vbInformation)
            If cbCheckV.Checked = True Then
                My.Settings.DeluxeAssurance = True
            Else
                My.Settings.DeluxeAssurance = False
            End If
            If cbIndicator.Checked = True Then
                My.Settings.PlayerIndicator = True
            Else
                My.Settings.PlayerIndicator = False
            End If
            If cbSoundSFX.Checked = True Then
                My.Settings.Sound_SFX = True
            Else
                My.Settings.Sound_SFX = False
            End If

            txtMoney.Text = My.Settings.Money
            txtCurrencyNew.Text = My.Settings.Currency
            txtProperties.Text = My.Settings.Land
            txtHouses.Text = My.Settings.Houses
            txtHotels.Text = My.Settings.Hotels
            txtPassGo.Text = My.Settings.PassGo
            txtInJail.Text = My.Settings.InJail
            txtIncomeTax.Text = My.Settings.IncomeTax
            txtSupertax.Text = My.Settings.SuperTax
            txtCriticprincipal.Text = My.Settings.CriticalPrincipal
            txtCritictime.Value = My.Settings.CriticalTime
            txtCriticalamount.Text = My.Settings.CriticalAmount
            txtTexttoSpeech.Text = My.Settings.TexttoSpeech
            txtCriticalland.Text = My.Settings.CriticalLand
            txtCriticalhouse.Text = My.Settings.CriticalHouse
            txtrate.Value = My.Settings.InterestRate
            My.Settings.frmpropertyviewTimer = NUDPropertyLeftT.Value * 1000

            ComboBox2.Text = My.Settings.ScoreBoard2ndScreen
            My.Settings.Save()

            If frmGameModeSelector.lblGMSRGHistory.Text <> 3 Then
                Me.Close()
            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub butExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butExit.Click

        TabControl1.SelectedIndex = 0

        If frmGameModeSelector.lblGMSRGHistory.Text <> 3 Then
            EMonopoly.SecondaryScreen()
        End If

        SaveSettings()
            My.Settings.Save()

        If frmGameModeSelector.lblGMSRGHistory.Text = 3 Then
            frmGameModeSelector.Show()
            frmGameModeSelector.lblGMSRGHistory.Text = 0
            Me.Close()
        Else

        End If
    End Sub

    Private Sub butMaximize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaskedTextBox1.UseSystemPasswordChar = True
        ComboBox1.Text = My.Settings.MusicSite
        NUDPropertyLeftT.Value = My.Settings.frmpropertyviewTimer / 1000

        If My.Settings.Theme = Val(0) Then
            butthemeauto.Enabled = False
        ElseIf My.Settings.Theme = Val(1) Then
            butLight.Enabled = False
        ElseIf My.Settings.Theme = Val(2) Then
            butDark.Enabled = False
        End If

        If My.Settings.DeluxeAssurance = True Then
            cbCheckV.Checked = True
        ElseIf My.Settings.DeluxeAssurance = False Then
            cbCheckV.Checked = False
        Else
        End If
        If My.Settings.Sound_SFX = True Then
            cbSoundSFX.Checked = True
        Else
            cbSoundSFX.Checked = False
        End If
        If My.Settings.PlayerIndicator = True Then
            cbIndicator.Checked = True
        Else
            cbIndicator.Checked = False
        End If
        If cbSoundSFX.Checked = True Then
            cbSoundSFX.Text = "Sound Effects (Unmuted)"
        Else
            cbSoundSFX.Text = "Sound Effects (Muted)"
        End If

        If frmGameModeSelector.lblGMSRGHistory.Text = 3 Then
            Button23.Enabled = True
            Button25.Enabled = True
        Else
            Button23.Enabled = False
            Button25.Enabled = False
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
        End If
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cbCheckV.Checked = True
        cbIndicator.Checked = True
        cbSoundSFX.Checked = True
        If cbSoundSFX.Checked = True Then
            cbSoundSFX.Text = "Sound Effects (Unmuted)"
        Else
            cbSoundSFX.Text = "Sound Effects (Muted)"
        End If
        txtCurrencyNew.Text = "£"
        txtMoney.Text = "1748"
        txtProperties.Text = "28"
        txtHouses.Text = "32"
        txtHotels.Text = "12"
        txtPassGo.Text = "200"
        txtInJail.Text = "100"
        txtIncomeTax.Text = "200"
        txtSupertax.Text = "100"
        txtCriticprincipal.Text = "2300"
        txtCritictime.Value = 5
        txtCriticalamount.Text = "300"
        txtCriticalland.Text = "2"
        txtCriticalhouse.Text = "4"
        txtrate.Value = 10
    End Sub

    Private Sub butthemeauto_Click(sender As Object, e As EventArgs) Handles butthemeauto.Click
        butthemeauto.Enabled = False
        butDark.Enabled = True
        butLight.Enabled = True
        My.Settings.Theme = Val(0)
        MsgBox("Theme Settings changed to Automation ", +vbInformation)
    End Sub

    Private Sub butLight_Click_1(sender As Object, e As EventArgs) Handles butLight.Click
        butLight.Enabled = False
        butthemeauto.Enabled = True
        butDark.Enabled = True
        My.Settings.Theme = Val(1)
        MsgBox("Theme Settings changed to Light Mode ", +vbInformation)
    End Sub

    Private Sub butDark_Click_1(sender As Object, e As EventArgs) Handles butDark.Click
        butDark.Enabled = False
        butthemeauto.Enabled = True
        butLight.Enabled = True
        My.Settings.Theme = Val(2)
        MsgBox("Theme Settings changed to Dark Mode ", +vbInformation)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim screen As Screen
        If ComboBox2.SelectedIndex = 1 Then
            EMonopoly.SecondaryScreen()
        ElseIf ComboBox2.SelectedIndex = 0 Then
            Try
                screen = Screen.AllScreens(1)
                frmExtendedScreenPInfo.Location = screen.Bounds.Location + New Point(100, 100)
                frmExtendedScreenPInfo.Show()
                frmExtendedScreenPInfo.changing()
            Catch ex As Exception
                ComboBox2.SelectedIndex = 1
                MsgBox("No external screen connected", vbExclamation)
            End Try
        End If
    End Sub

    Private Sub txtCritictime_ValueChanged_1(sender As Object, e As EventArgs) Handles txtCritictime.ValueChanged
        If txtCritictime.Value <= 7 Then
        Else
            Me.txtCritictime.Value = 5
            MsgBox("Critical time can't be more than 7")
        End If
    End Sub

    Private Sub txtrate_ValueChanged_1(sender As Object, e As EventArgs) Handles txtrate.ValueChanged
        If txtrate.Value <= 12 Then
        Else
            Me.txtrate.Value = 10
            MsgBox("Interest rate can't be more than 12 %")
        End If
    End Sub

    Private Sub Button21_Click_1(sender As Object, e As EventArgs) Handles Button21.Click
        MsgBox("This option gives a verbal output about what is written on the message box or text box" + vbNewLine + vbNewLine + "Note : Aloow it then and then only if yo have a external audio output device connected to your pc otherwise it may lead to errors to the program", vbOKOnly)
    End Sub

    Private Sub Button19_Click_1(sender As Object, e As EventArgs) Handles Button19.Click
        MsgBox("The value in this combo box will allow or deny the appearance of the score board on the extended screen connected to your pc" + vbNewLine + vbNewLine + "Note : This will be enabled only when your system is connected to a extended screen", vbOKOnly)
    End Sub

    Private Sub Button20_Click_1(sender As Object, e As EventArgs) Handles Button20.Click
        MsgBox("The value in this text box fixes the Minimum number of House(s) which a person should have to apply the Hotel(s) which he has build", vbOKOnly)
    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs) Handles Button18.Click
        MsgBox("The value in this text box fixes the Minimum number of Land(s) which a person should have to apply the House(s) which he has build", vbOKOnly)
    End Sub

    Private Sub Button15_Click_1(sender As Object, e As EventArgs) Handles Button15.Click
        MsgBox("The value in this text box fixes the maximum time limit (in rounds) in which a loan has to be repaid", vbOKOnly)
    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        MsgBox("The value in this text box fixes the maximum amount of principal which a person can apply for a loan", vbOKOnly)
    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click
        MsgBox("The value in this text box fixes the Rate of interest (per round) for taking a loan", vbOKOnly)
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        MsgBox("The value in this text box fixes the minimum amount which should be present in the account of any player", vbOKOnly)
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        MsgBox("The value in this text box fixes the amount to be deducted for Super Tax", vbOKOnly)
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        MsgBox("The value in this text box fixes the amount to be deducted for Income Tax", vbOKOnly)
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        MsgBox("The value in this text box fixes the amount to be deducted if cought into the Jail", vbOKOnly)
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        MsgBox("The value in this text box fixes the amount to be claimed after completing one round", vbOKOnly)
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        MsgBox("The value in this text box fixes the total number of Hotels available to purchase in this game", vbOKOnly)
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        MsgBox("The value in this text box fixes the total number of Houses available to purchase in this game", vbOKOnly)
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        MsgBox("The value in this text box fixes the total number of Properties available to purchase in this game", vbOKOnly)
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("The value in this text box fixes the money in hand of each player including bank." + vbNewLine + vbNewLine + "Note : Calculate the total money in your game and devide it by 9, don't type the money in decimal, see the nearby whole number value", vbOKOnly)
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("The value in this text box changes the currency logo in whole game", vbOKOnly)
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected_1(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        If MaskedTextBox1.UseSystemPasswordChar = True Then
            MaskedTextBox1.UseSystemPasswordChar = False

        Else
            MaskedTextBox1.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub txtTexttoSpeech_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtTexttoSpeech.SelectedIndexChanged
        Me.Text = My.Settings.MusicSite
    End Sub

    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        If (MaskedTextBox1.Text = "vz0t59hk1e") Then
            txtCurrencyNew.Enabled = True
            Button4.Enabled = True
            txtMoney.Enabled = True
            txtProperties.Enabled = True
            txtHouses.Enabled = True
            txtHotels.Enabled = True
            txtPassGo.Enabled = True
            txtInJail.Enabled = True
            txtIncomeTax.Enabled = True
            txtSupertax.Enabled = True
            txtCriticprincipal.Enabled = True
            txtCritictime.Enabled = True
            txtCriticalamount.Enabled = True
            txtCriticalland.Enabled = True
            txtCriticalhouse.Enabled = True
            txtrate.Enabled = True
            Label33.Enabled = True
            lblPercent.Enabled = True
            butCalculator.Enabled = True
            pnlCalculate.Visible = True
        Else
            txtCurrencyNew.Enabled = False
            Button4.Enabled = False
            txtMoney.Enabled = False
            txtProperties.Enabled = False
            txtHouses.Enabled = False
            txtHotels.Enabled = False
            txtPassGo.Enabled = False
            txtInJail.Enabled = False
            txtIncomeTax.Enabled = False
            txtSupertax.Enabled = False
            txtCriticprincipal.Enabled = False
            txtCritictime.Enabled = False
            txtCriticalamount.Enabled = False
            txtCriticalland.Enabled = False
            txtCriticalhouse.Enabled = False
            txtrate.Enabled = False
            Label33.Enabled = False
            lblPercent.Enabled = False
            butCalculator.Enabled = False
            pnlCalculate.Visible = False
        End If
    End Sub

    Private Sub cbIndicator_CheckedChanged(sender As Object, e As EventArgs) Handles cbIndicator.CheckedChanged
        If cbIndicator.Checked = False Then
            EMonopoly.butround.Enabled = True
            EMonopoly.butincometax.Enabled = True
            EMonopoly.butsupertax.Enabled = True
            EMonopoly.butjail.Enabled = True
            EMonopoly.butloan.Enabled = True
            EMonopoly.butloandew.Enabled = True
            EMonopoly.butcheckdews.Enabled = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbSoundSFX.CheckedChanged
        If cbSoundSFX.Checked = True Then
            cbSoundSFX.Text = "Sound Effects (Unmuted)"
        Else
            cbSoundSFX.Text = "Sound Effects (Muted)"
        End If
    End Sub

    Private Sub Audio_Click(sender As Object, e As EventArgs) Handles Audio.Click

    End Sub

    Private Sub butCalculator_Click(sender As Object, e As EventArgs) Handles butCalculator.Click
        If pnlCalculate.Visible = True Then
            pnlCalculate.Visible = False
        Else
            pnlCalculate.Visible = True
        End If
    End Sub

    Dim remaind As Integer
    Dim InitialValue As Integer
    Dim FinalValue As Integer

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If txtTC.Text = Nothing Then
            MsgBox("Please type some numeral amount in the text box")
        Else
            InitialValue = txtTC.Text
            remaind = InitialValue Mod 9
            Do While remaind > 0
                InitialValue = InitialValue - 1
                remaind = InitialValue Mod 9
            Loop
            If remaind = 0 Then
                FinalValue = InitialValue / 9
                lblNewTotalCurrency.Text = InitialValue
                lblMoneyHand.Text = FinalValue
            End If

            If lblNewTotalCurrency.Text = Nothing And lblMoneyHand.Text = Nothing Then
                butApply.Enabled = False
                butReset.Enabled = False
            Else
                butApply.Enabled = True
                butReset.Enabled = True
            End If

        End If
    End Sub

    Private Sub butApply_Click(sender As Object, e As EventArgs) Handles butApply.Click
        MsgBox("This Action will change the settings of the game ", vbOKOnly + vbExclamation)
        If txtMoney.Enabled = True Then
            txtMoney.Text = FinalValue
        Else
            MsgBox("Please enter the password")
        End If
    End Sub

    Private Sub butReset_Click(sender As Object, e As EventArgs) Handles butReset.Click
        txtTC.Text = Nothing
        lblMoneyHand.Text = ("--")
        lblNewTotalCurrency.Text = ("--")
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub txtCurrencyNew_TextChanged(sender As Object, e As EventArgs) Handles txtCurrencyNew.TextChanged

    End Sub

    Private Sub txtMoney_TextChanged(sender As Object, e As EventArgs) Handles txtMoney.TextChanged

    End Sub

    Private Sub NUDPropertyLeftT_ValueChanged(sender As Object, e As EventArgs) Handles NUDPropertyLeftT.ValueChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        MsgBox("This is the timer of the apperance of the property card which we get on double clicking on an item in the property left list in main form.")
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        MsgBox("This feature is used to restore game reload files to other version (v6 or above) of Emonopoly Bank." + vbNewLine + "Note:This process cnnot be undone.", vbOKOnly + vbExclamation)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        MsgBox("Select the folder where newer version of E-Monopoly.exe is present.You can get the version info of E-Monopoly.exe by its tool tip file version domain.")
        FBDNewDirectory.ShowDialog()
        Dim NewPath As String
        Dim SourcePath As String = Application.StartupPath + "\" + "History"
        NewPath = FBDNewDirectory.SelectedPath
        If File.Exists(NewPath + "\E-Monopoly.exe") Then
            If Directory.Exists(NewPath + "\History") Then
                Directory.Delete(NewPath + "\History", True)
            End If
            FileSystem.CopyDirectory(SourcePath, NewPath + "\History")
            File.SetAttributes(NewPath, FileAttributes.Hidden)
            MsgBox("Done")
        Else
            MsgBox("The game reload files cannot be moved here" + vbOKOnly + vbCritical)
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        MsgBox("Select the folder where newer version of E-Monopoly.exe is present.You can get the version info of E-Monopoly.exe by its tool tip file version domain.")
        FBDNewDirectory.ShowDialog()
        Dim NewPath As String
        Dim SourcePath As String = Application.StartupPath + "\" + "History"
        NewPath = FBDNewDirectory.SelectedPath

        If File.Exists(NewPath + "\E-Monopoly.exe") Then
            If File.Exists(NewPath + "\E-Monopoly.exe") Then
                For Each subfolder As String In Directory.GetDirectories(SourcePath, "*", System.IO.SearchOption.AllDirectories)
                    Dim destinationSubfolderPath As String = Path.Combine(NewPath + "\" + "History", subfolder.Substring(SourcePath.Length + 1))
                    Directory.CreateDirectory(destinationSubfolderPath)
                Next
                MsgBox("Done")
            Else
                MsgBox("No game reload files exist ,Create new file" + vbOKOnly + vbCritical)
            End If

        Else
                MsgBox("The game reload files cannot be moved here" + vbOKOnly + vbCritical)
        End If
    End Sub

    Private Sub Additional_Settings_Click(sender As Object, e As EventArgs) Handles Additional_Settings.Click

    End Sub
End Class