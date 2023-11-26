Imports System.Configuration
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class SampleForm2

#Region "引数の値型/参照型"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        num = 1
        ByValSub(num)
        Console.WriteLine(num)

        ByRefSub(num)
        Console.WriteLine(num)

        Dim sample As New RefSample()
        sample.value = 1

        ByValSub2(sample)
        Console.WriteLine(sample.value)

        ByRefSub2(sample)
        Console.WriteLine(sample.value)

        Dim sample2 As New RefSample()
        sample2.value = 1

        ByValSub3(sample2)
        Console.WriteLine(sample2.value)

        ByRefSub3(sample2)
        Console.WriteLine(sample2.value)
    End Sub

    Private Sub ByValSub(ByVal item As Integer)
        item = 10
    End Sub

    Private Sub ByRefSub(ByRef item As Integer)
        item = 20
    End Sub

    Private Sub ByValSub2(ByVal sample As RefSample)
        sample.value = 10
    End Sub

    Private Sub ByRefSub2(ByRef sample As RefSample)
        sample.value = 20
    End Sub

    Private Sub ByValSub3(ByVal sample As RefSample)
        sample = New RefSample()
        sample.value = 10
    End Sub

    Private Sub ByRefSub3(ByRef sample As RefSample)
        sample = New RefSample()
        sample.value = 20
    End Sub
#End Region

#Region "モジュール"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
#End Region

#Region "プロパティ設定"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Button3.Text = "プロパティ設定変更後"

    End Sub
#End Region

#Region "デバッグ　例外ハンドリング"
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Const readFileName As String = "test.ini"
        Dim readFileFullPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, readFileName)

        Try
            Dim buff() As Byte = New Byte(256) {}
            Dim fs As FileStream = File.Open(readFileFullPath, FileMode.Open)
            Dim readByte As Integer = fs.Read(buff, 0, 100)

            fs.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region

#Region "アプリケーション構成ファイル"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Const AppSettingKey1 As String = "SampleKey1"
        Const AppSettingKey2 As String = "SampleKey2"
        Dim sampleKey1 As String
        Dim sampleKey2 As String

        sampleKey1 = ConfigurationManager.AppSettings(AppSettingKey1)
        Console.WriteLine(sampleKey1)

        sampleKey2 = ConfigurationManager.AppSettings(AppSettingKey2)
        Console.WriteLine(sampleKey2)
    End Sub
#End Region

#Region "設定ファイル"
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim userSetting1 As String
        Dim userSetting2 As Integer
        Dim appSetting1 As String
        Dim appSetting2 As Integer

        userSetting1 = My.Settings.UserTest1
        Console.WriteLine(userSetting1)

        userSetting2 = My.Settings.UserTest2
        Console.WriteLine(userSetting2)

        appSetting1 = My.Settings.AppTest1
        Console.WriteLine(appSetting1)

        appSetting2 = My.Settings.AppTest2
        Console.WriteLine(appSetting2)

        appSetting2 = My.Settings.TestTest
    End Sub
#End Region

#Region "iniファイル"
    'プロファイル文字列取得
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (
        ByVal lpApplicationName As String,
        ByVal lpKeyName As String,
        ByVal lpDefault As String,
        ByVal lpReturnedString As System.Text.StringBuilder,
        ByVal nSize As Integer,
        ByVal lpFileName As String
    ) As Integer

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Const IniFileName As String = "app.ini"
        Const IniSectionName As String = "test"
        Const IniKey1 As String = "key1"
        Const IniKey2 As String = "key2"
        Const DefaultValue As String = "default"

        Dim iniFileFullPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, IniFileName)
        Dim iniItem1 As String
        Dim iniItem2 As String
        Dim stringBuilder = New StringBuilder(256)


        Dim ret As Integer = GetPrivateProfileString(IniSectionName, IniKey1, DefaultValue, stringBuilder, stringBuilder.Capacity, iniFileFullPath)
        If (ret > 0) Then
            iniItem1 = stringBuilder.ToString()
            Console.WriteLine(iniItem1)
        Else
            Console.WriteLine("エラー")
        End If

        ret = GetPrivateProfileString(IniSectionName, IniKey2, DefaultValue, stringBuilder, stringBuilder.Capacity, iniFileFullPath)
        If (ret > 0) Then
            iniItem2 = stringBuilder.ToString()
            Console.WriteLine(iniItem2)
        Else
            Console.WriteLine("エラー")
        End If

    End Sub
#End Region

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Console.WriteLine("Click！！")

    End Sub

    Private Sub Button8_MouseDown(sender As Object, e As MouseEventArgs) Handles Button8.MouseDown
        Console.WriteLine("MouseDown")

    End Sub
End Class