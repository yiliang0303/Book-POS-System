Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class frmSetting
    Private Sub btnBackgroundColor_Click(sender As Object, e As EventArgs) Handles btnBackgroundColor.Click
        Dim ans As Long = 0
        ans = dlgColor.ShowDialog()
        If ans = vbOK Then
            Me.BackColor = dlgColor.Color
            frmHomepage.BackColor = dlgColor.Color
            My.Settings.backgroundColor = dlgColor.Color
            My.Settings.Save()
        End If
    End Sub



    Private Sub btnButtonColor_Click(sender As Object, e As EventArgs) Handles btnButtonColor.Click
        Dim ans As Long = 0
        ans = dlgColor.ShowDialog()
        If ans = vbOK Then
            Me.btnBackgroundColor.BackColor = dlgColor.Color
            Me.btnButtonColor.BackColor = dlgColor.Color
            Me.btnButtonFont.BackColor = dlgColor.Color
            Me.btnFontColor.BackColor = dlgColor.Color
            Me.btnBack2.BackColor = dlgColor.Color
            My.Settings.buttonColor = dlgColor.Color
            My.Settings.Save()
        End If
    End Sub

    Private Sub btnButtonFont_Click(sender As Object, e As EventArgs) Handles btnButtonFont.Click
        Dim ans As Long = 0
        ans = dlgFont.ShowDialog()
        If ans = vbOK Then
            Me.btnBackgroundColor.Font = dlgFont.Font
            Me.btnButtonColor.Font = dlgFont.Font
            Me.btnButtonFont.Font = dlgFont.Font
            Me.btnFontColor.Font = dlgFont.Font
            Me.btnBack2.Font = dlgFont.Font
            My.Settings.buttonFont = dlgFont.Font
            My.Settings.Save()
        End If

    End Sub

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.backgroundColor

        Me.btnBackgroundColor.BackColor = My.Settings.buttonColor
        Me.btnButtonColor.BackColor = My.Settings.buttonColor
        Me.btnButtonFont.BackColor = My.Settings.buttonColor
        Me.btnFontColor.BackColor = My.Settings.buttonColor
        Me.btnBack2.BackColor = My.Settings.buttonColor

        Me.btnButtonFont.Font = My.Settings.buttonFont
        Me.btnBackgroundColor.Font = My.Settings.buttonFont
        Me.btnButtonColor.Font = My.Settings.buttonFont
        Me.btnFontColor.Font = My.Settings.buttonFont
        Me.btnBack2.Font = My.Settings.buttonFont

        Me.btnBack2.ForeColor = My.Settings.buttonForeColor
        Me.btnBackgroundColor.ForeColor = My.Settings.buttonForeColor
        Me.btnButtonColor.ForeColor = My.Settings.buttonForeColor
        Me.btnFontColor.ForeColor = My.Settings.buttonForeColor
        Me.btnButtonFont.ForeColor = My.Settings.buttonForeColor
    End Sub

    Private Sub btnFontColor_Click(sender As Object, e As EventArgs) Handles btnFontColor.Click
        Dim ans As Long = 0
        ans = dlgColor.ShowDialog()
        If ans = vbOK Then
            Me.btnBackgroundColor.ForeColor = dlgColor.Color
            Me.btnButtonColor.ForeColor = dlgColor.Color
            Me.btnButtonFont.ForeColor = dlgColor.Color
            Me.btnBack2.ForeColor = dlgColor.Color
            Me.btnFontColor.ForeColor = dlgColor.Color
            My.Settings.buttonForeColor = dlgColor.Color
            My.Settings.Save()
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack2.Click
        frmHomepage.Show()
        Me.Hide()
    End Sub
End Class