Public Class Pomeranian : Inherits Dog

    Public Overrides Sub Cry()
        Console.WriteLine("キャンキャン")
    End Sub

    Public Overloads Sub Cry(count As Integer)
        For num As Integer = 0 To count - 1
            MyBase.Cry()
        Next
    End Sub

    Public Overloads Sub Cry(message As String)
        Console.WriteLine(message)
    End Sub

End Class
