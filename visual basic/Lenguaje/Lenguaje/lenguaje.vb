'Option Explicit Off
Module lenguaje




    Sub Main()




        'Console.WriteLine("Hola que tal?")
        'Console.Write("Hola que tal?")
        'Console.Write(" Yo regular")




        'Console.WriteLine(125)
        'Console.WriteLine(5 > 3)
        'Dim Nombre As String
        '' Dim valor As Integer = 67
        'Nombre = "Tere"
        'Nombre = 34
        'Nombre = #10/21/2021#
        'Console.WriteLine("Mi Nombre es: " & Nombre)
        'Console.WriteLine("Mi Nombre es: " & Nombre)
        'Console.WriteLine("125" & valor)
        'Console.WriteLine("Mi Nombre es: {0} y valor contien: {1} ", Nombre, valor)
        'Console.WriteLine("Mi Nombre es: {1} y valor contien: {0} ", Nombre, valor)
        'Console.Write("Introduce un Nombre: ")
        'Nombre = Console.ReadLine()




        'Boolean 'Puede ser true o false
        'Byte    'Va desde 0 hasta 255
        'Char    'Puede contener un solo caracter
        'Date    'Contiene fecha y hora
        'Decimal 12 byte  79.228.162.514.264.337.593.543.950.335 '
        'Double  'Contiene un número con decimales de doble precisión, con un rango de hasta 15 dígitos significativos
        'Integer   C 2 byte  4 bytes -2.147.483.648   +2.147.483.647 'Números enteros de hasta 4 bytes
        '    Long '
        'Short 'Contiene un entero de 2 bytes
        'Single 'Contiene un número con decimales de precisión simple
        'Object 'Objeto de cualquier tipo,
        'String 'Contiene una cadena de caracteres




        Dim FhActual As Date
        'Console.WriteLine("Fecha: {0}  ", FhActual)




        'Dim FhNueva As Date
        'Dim FhCompletaUno As Date
        'Dim FhCompletaDos As Date
        'Dim FhHora As Date
        'Dim Correcto As Boolean
        'Dim Obj As Object
        'Console.WriteLine("Boolean: {0}  ", Correcto)












        'FhActual = #10/21/2021#
        'Console.WriteLine("Fecha: {0}  ", FhActual)
        'Console.ReadLine()
        'FhNueva = "21/10/2021"
        'FhCompletaUno = #10/21/2021 4:18:00 PM#
        'FhCompletaDos = "21/10/2021 16:18:00"
        'FhHora = #4:18:00 PM#
        'Dim NuevaCadena As String
        'If NuevaCadena = "" Then Console.WriteLine("Cadena: {0}  ", NuevaCadena)




        'If Obj Is Nothing Then Console.WriteLine("Object: {0}  ", Obj)




        ' Dim Valor As String
        'Valor = "Un avlor de prueba"
        ' NuevaCadena = valor
        'FhActual = Nothing
        'Console.WriteLine("Fecha: {0}  ", FhActual)




        Dim TotalGeneral As Double
        Dim Valor As Integer
        TotalGeneral = 500.55
        Valor = CInt(TotalGeneral) 'Aqui valor se convierte a entero y se pierde la parte decimal, redondeando el valor a 500




        Console.WriteLine("Valor: {0}  ", Valor)
        Console.ReadLine()



        Dim Colores() As String




        'Colores(3) = "azul"
        'Console.WriteLine("Color: {0}  ", Colores(3))




        Dim Nombres(3) As String
        Dim frutas() As String = {"Manzana", "Naranja", "Pera"}




        ReDim Colores(5)
        Colores(3) = "verde"
        ReDim Colores(7)
        Colores(7) = "azul"
        '  Console.WriteLine("Color: {0}  ", Colores(7))








        Nombres(0) = "Guillermo"
        Nombres(1) = "Mario"
        Nombres(2) = "Arturo"
        Nombres(3) = "Miguel"




        Console.WriteLine("Nombre: {0}  ", Nombres(3))
        ReDim Nombres(7) 'Redimensionamos Nombres a 7 posiciones, pero se pierden los valores de las posiciones 0 a 3
        Console.WriteLine("Nombre: {0}  ", Nombres(3))




        ReDim Preserve Nombres(7) 'Preserve sirve para mantener el valor de Nombres en la posición 3, sin el preserve se perdería el valor de esa posición.
        Console.WriteLine("Nombre: {0}  ", Nombres(3))


        'ReDim Preserve Nombres(2)
        'Console.WriteLine("Nombre: {0}  ", Nombres(2))
        'Dim contador As Byte
        'For contador = 0 To UBound(Nombres)
        '    Console.WriteLine("Nombre {1}: {0}  ", Nombres(contador), contador)
        'Next
        Const Color As String = "Azul"
        '   Color = "verde"  Error
        'Operadores Aritméticos son: +(Suma), -(Resta), *(Multiplicación), /(División), \(División entera), Mod (Módulo, es decir, resto de la división), ^(Exponenciación, es decir, elevar un número a una potencia)


        '^
        ' Dim Resultado As Double
        Dim resultado1 As Integer
        '  Resultado = 12 ^ 5
        '  Console.WriteLine("Resultado: {0}  ", Resultado)


        'resultado1 = 50 / 3
        'Console.WriteLine("Resultado: {0}  ", resultado1)
        'Resultado = 50 \ 3
        'Console.WriteLine("Resultado: {0}  ", Resultado)
        'Resultado = 50 Mod 3
        'Console.WriteLine("Resultado: {0}  ", Resultado)


        ' Dim cadena As String = "hola"
        Dim cadena As String = "4"
        Dim cadena1 As String = "4"
        resultado1 = 256
        'Console.WriteLine("Resultado1: {0}  ", cadena + cadena1)
        ' Console.WriteLine("Resultado1: {0}  ", cadena & cadena1)
        '*
        '/
        ' += -= /= ^=
        'Operadores de comparación son: <>  <=   >=    =    <>



        ' Console.WriteLine("Resultado1: {0}  ", "a" = "A")
        'Funciones
        'Console.WriteLine(" {0}  ", Asc("a")) 'Pasa el caracter "a" a su valor en la tabla ASCII, que es 97
        'Console.WriteLine(" {0}  ", Chr(65))  'Devuelve el caracter que corresponde al valor 65 en la tabla ASCII, que es la letra A
        Dim Resultado As Boolean
        'Resultado = "HOLA" Like "HO?A"
        'Console.WriteLine(" {0}  ", Resultado)
        'Resultado = "MOTITOR" Like "MO?iT?R"
        'Console.WriteLine(" {0}  ", Resultado)
        'Resultado = "La gran llanura" Like "La*llanu*"
        'Resultado = "La gran llanura" Like "La*llanu?"
        'Resultado = "has ganado 128 millones" Like "has ganado ### millones"
        'Console.WriteLine(" {0}  ", Resultado)
        'Resultado = "has ganado 128 millones" Like "has ganado ## millones"
        'Dim objetoa As Object
        'Dim objetob As Object


        'Console.WriteLine(" {0}  ", objetoa Is objetob)
        'Dim cadenas As String
        'Console.WriteLine(" {0}  ", objetoa Is cadena)
        ' And, or, not
        ' Console.WriteLine(" {0}  ", 5 > 3 And 6 > 4)
        ' Xor, AndAlso, OrElse 'Xor: Si uno es verdadero y el otro es falso, devuelve verdadero. Si ambos son verdaderos o ambos son falsos, devuelve falso.
        'AndAlso: Si el primer operando es falso, no evalúa el segundo operando y devuelve falso. Si el primer operando es verdadero, evalúa el segundo operando y devuelve su valor.
        'OrElse: Si el primer operando es verdadero, no evalúa el segundo operando y devuelve verdadero. Si el primer operando es falso, evalúa el segundo operando y devuelve su valor.


        Console.ReadLine()








    End Sub
End Module