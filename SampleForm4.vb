Imports System.Threading

Public Class SampleForm4

#Region "ポリモーフィズム"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dog As IAnimal = GetAnimal(Animal.Dog)
        dog.Cry()

        Dim cat As IAnimal = GetAnimal(Animal.Cat)
        cat.Cry()

        Dim pig As IAnimal = GetAnimal(Animal.Pig)
        pig.Cry()

        Dim pome As Pomeranian = New Pomeranian()
        pome.Cry()
        pome.Cry(3)
        pome.Cry("ウォホウォホウォホ")

    End Sub

    Private Function GetAnimal(animal As Animal) As IAnimal
        Select Case animal
            Case Animal.Dog
                Return New Dog()
            Case Animal.Cat
                Return New Cat()
            Case Else
                Return New Pig()
        End Select
    End Function
#End Region

#Region "継承"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dog As Pomeranian = New Pomeranian()
        dog.Cry()
    End Sub
#End Region

#Region "マルチスレッド"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        HeavyMethod1()
        HeavyMethod2()
    End Sub

    Private Async Sub HeavyMethod1()
        Console.WriteLine("すごく思い処理　その１　開始")
        Await Task.Run(Sub()
                           Console.WriteLine("別スレッド処理　開始")
                           Thread.Sleep(3000)
                           Console.WriteLine("別スレッド処理　終了")
                       End Sub)
        Console.WriteLine("すごく思い処理　その１　終了")
        Label2.Text = "思い処理完了"
    End Sub

    Private Sub HeavyMethod2()
        Console.WriteLine("すごく思い処理　その２　開始")
        Thread.Sleep(3000)
        Console.WriteLine("すごく思い処理　その２　終了")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Visible = True
        Label2.Text = "思い処理開始"

        HeavyMethod2()
        Label2.Text = "思い処理完了"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label2.Visible = True
        Label2.Text = "思い処理開始"

        HeavyMethod1()
        Label2.Text = "別スレッドで処理中"
    End Sub

    Private Sub SampleForm4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label2.Text = ""

    End Sub
#End Region

End Class