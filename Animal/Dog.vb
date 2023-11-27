Public Class Dog : Implements IAnimal

    Public Overridable Sub Cry() Implements IAnimal.Cry
        Console.WriteLine("わん")
    End Sub

End Class
