Module reglasDeAmbito
    Public nombre As String
    Sub Main()
        Totales(3000)         'Llama al procedimiento Totales definido en el mismo módulo reglasDeAmbito con el argumento 3000 que indica el importe a calcular
        Calculos.Totales(500) 'Llama al módulo Calculos y ejecuta el procedimiento Totales con el argumento 500 que indica lo mismo que el anterior.
        Dim valor As Integer
        Verificacion("Primera")
        Verificacion("Segunda")
        Verificacion("Tercera")




        Console.ReadLine()
    End Sub
    'Private Sub Verificacion(OrdenLlamada As String)
    '    Dim importe As Integer = 5
    '    importe += 2
    '    Console.WriteLine("Orden llamada:{0} importe: {1}", OrdenLlamada, importe)
    'End Sub
    Private Sub Verificacion(OrdenLlamada As String) 'Verificacion => Procedimiento que se ejecuta cada vez que se llama
        Static Dim importe As Integer = 5 'Declaración de variable estática, se mantiene su valor entre llamadas
        importe += 2                      'Incremento de la variable estática
        Console.WriteLine("Orden llamada:{0} importe: {1}", OrdenLlamada, importe)
    End Sub




    Private Sub cambio() 'Este procedimiento unicamente cambia el valor de la variable global nombre cada vez que se llama, pero aqui no se llama, por lo que el valor de la variable nombre no cambia
        nombre = "Raul"
    End Sub


End Module
Module Calculos
    Public Sub Totales(Importe As Integer)
        Dim resultado As Integer
        resultado = Importe + 1000
        Console.WriteLine(resultado)
    End Sub
    Private Sub Totales1(Importe As Integer)
        Dim resultado As Integer
        resultado = Importe + 1000
        Console.WriteLine(resultado)
    End Sub
End Module