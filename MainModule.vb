Module MainModule
    'アプリケーションのメイン・エントリポイント
    <STAThread()>
    Sub Main()
        '-----
        'メインフォームを表示する前に必要な初期処理を行う・・・
        '-----
        '例：二重起動をチェックする
        If Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName).Length > 1 Then
            MessageBox.Show("多重起動はできません。")
            Return
        End If

        'メイン画面の表示
        Dim frm As New SampleForm4
        Application.Run(frm)

        '-----
        'メインフォームが閉じた後で必要な終了処理を行う・・・
        '-----
    End Sub
End Module
