Module Module1
    ' Definición de la función "Conducir", que acepta cualquier objeto que implemente la interfaz "IVehiculo"
    Public Sub Conducir(vehiculo As IVehiculo)
        vehiculo.Acelerar()
        vehiculo.Frenar()
    End Sub
    ' Función principal o método Main
    Sub Main()
        Dim coche As New Coche()
        Dim moto As New Moto()

        Conducir(coche) ' Salida: "El coche acelera" y "El coche frena"
        Conducir(moto) ' Salida: "La moto acelera" y "La moto frena"

        Console.ReadLine() ' Esperar a que el usuario presione una tecla antes de cerrar la ventana de la consola
    End Sub
End Module
