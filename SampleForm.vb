Public Class SampleForm

#Region "ロードイベント"
    Private Sub SampleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region

#Region "値型/参照型"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value As Integer = 10

        Dim refSample As New RefSample()
        refSample.value = 10

        Dim copySample As New RefSample()
        copySample = refSample
        Console.WriteLine(copySample.value)

        copySample.value = 20
        Console.WriteLine(copySample.value)
        Console.WriteLine(refSample.value)

    End Sub
#End Region

#Region "構造体"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim structSample As StructSample
        structSample.value = 10

        Dim copySample As StructSample
        copySample = structSample
        Console.WriteLine(copySample.value)

        copySample.value = 20
        Console.WriteLine(copySample.value)
        Console.WriteLine(structSample.value)
    End Sub
#End Region

#Region "列挙体"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim weekday As WeekDay
        weekday = WeekDay.Tuesday
        Console.WriteLine(weekday)
        Console.WriteLine(weekday.ToString())
    End Sub
#End Region

#Region "配列"
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        '１次元配列へ値を格納
        Dim score(9) As Integer
        score(3) = 80

        '２次元配列へ値を格納
        Dim score2(2, 9) As Integer
        score2(1, 4) = 90

        '１次元配列の初期化
        Dim array() As Integer = {10, 20, 30, 40, 50}

        '２次元配列の初期化
        Dim array2(,) As Integer = {{10, 20}, {30, 40}, {50, 60}}

        '動的配列の宣言と要素数割り当て
        Dim intArray() As Integer
        ReDim intArray(9)

    End Sub

#End Region


End Class
