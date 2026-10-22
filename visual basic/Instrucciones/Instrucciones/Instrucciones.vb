Module Instrucciones


    Sub Main()
        Dim valor As Integer
        If valor = 0 Then Console.WriteLine("sola linea no tiene EndIf") 'Si la instrucción es de una sola línea no es necesario poner el EndIf


        If valor = 0 Then 'Este bloque se va a ejecutar si valor es igual a 0


        Else 'Alternativa si valor no es igual a 0
            If valor = 1 Then 'Este bloque se va a ejecutar si valor es igual a 1.

            End If
        End If




        If valor = 0 Then


        ElseIf valor = 1 Then


        End If
        Select Case valor 'Este bloque se va a ejecutar dependiendo del valor que tenga la variable
            Case 1
                Console.WriteLine("valor 1")
            Case 120, 150
                Console.WriteLine("si 120 o 150")
            Case 300 To 400
                Console.WriteLine("entre 300 y 400")
            Case Is < 10
                Console.WriteLine("menor de 10")
            Case Else
                Console.WriteLine("cualquier otro valor")






        End Select


        While valor < 10 'Este bucle se va a ejecutar mientras valor sea menor que 10


        End While


        Do While valor <> 10 'Este bucle se va a ejecutar mientras valor sea diferente de 10


        Loop


        Do Until valor = 20 'Este bucle se va a ejecutar hasta que valor sea igual a 20


        Loop


        Do


        Loop While valor < 10 'Este bucle se va a ejecutar mientras valor sea menor que 10
        Do


        Loop Until valor = 20 'Este bucle se va a ejecutar hasta que valor sea igual a 20


        Do
            If valor = 100 Then Exit Do 'Si valor es igual a 100 entonces sale del bucle
        Loop


        For valor = 0 To 10 Step 4 'Esto lo que hace es que va a ir de 0 a 10 y va a ir sumando de 4 en 4


        Next




        For valor = 20 To 10 Step -1 'Esto lo que hace es que va a ir de 20 a 10 y va a ir restando de 1 en 1


        Next


        Dim Alumnos(3) As String 'Array de 4 elementos que va a contener los nombres de los alumnos


        Dim alumno As String 'Variable que va a contener cada elemento del array de Alumnos


        For Each alumno In Alumnos 'Este bucle se va a ejecutar por cada elemento que tenga el array de Alumnos


        Next
    End Sub
End Module