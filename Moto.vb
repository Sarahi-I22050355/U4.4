Public Class Moto
    Implements IVehiculo

    Public Sub Acelerar() Implements IVehiculo.Acelerar
        Console.WriteLine("La moto acelera")
    End Sub

    Public Sub Frenar() Implements IVehiculo.Frenar
        Console.WriteLine("La moto frena")
    End Sub
End Class
