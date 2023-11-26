''' <summary>
''' サンプルクラス
''' </summary>
Public Class SampleOne

    ''' <summary>
    ''' サンプル定数
    ''' </summary>
    Public Const ONE As Integer = 1

    Private _sampleValue As Integer

    ''' <summary>
    ''' サンプルプロパティ
    ''' </summary>
    ''' <returns>サンプルの値を返す</returns>
    Public Property SampleValue() As Integer
        Get
            Return _sampleValue
        End Get
        Set(ByVal value As Integer)
            _sampleValue = value
        End Set
    End Property

    ''' <summary>
    ''' このメソッドは、2つの整数を加算して結果を返します。
    ''' </summary>
    ''' <param name="a">加算する整数1</param>
    ''' <param name="b">加算する整数2</param>
    ''' <returns>加算結果</returns>
    ''' <remarks>ここに備考</remarks>
    ''' <example>
    ''' a.AddNumbers(1, 2)
    ''' </example>
    Public Function AddNumbers(a As Integer, b As Integer) As Integer
        Return a + b
    End Function
End Class
