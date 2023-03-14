Public Class Coche
    Implements IVehiculo

    Public Sub Acelerar() Implements IVehiculo.Acelerar
        Console.WriteLine("El coche acelera")
    End Sub

    Public Sub Frenar() Implements IVehiculo.Frenar
        Console.WriteLine("El coche frena")
    End Sub
End Class
