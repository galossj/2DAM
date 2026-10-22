Module Module1

    Sub Main()
        Dim oEmpleado As Empleado
        oEmpleado = New Empleado
        oEmpleado = Nothing
        oEmpleado = New Empleado
        Dim cadena As String
        '   cadena.

        Dim otroEmpleado As New Empleado
        otroEmpleado = Nothing
        otroEmpleado = New Empleado
        oEmpleado.Nombre = "Lucía"
        oEmpleado.FechaAlta = Now
        Dim I As Integer
        ' Todavía no se ha dimensionado el array,
        ' por lo que no se puede asignar ningún valor a la posición 0.
        oEmpleado.Viajes(0) = "Valencia" 'Aqui ya se dimensiona el array msViajes y se asigna el valor "Valencia" a la posición 0.
        oEmpleado.Viajes(0) = "Toledo"
        oEmpleado.Viajes(1) = "Paris"
        oEmpleado.Viajes(1) = "Alemania"
        oEmpleado.Viajes(1) = "Irlanda"
        oEmpleado.Viajes(1) = "Bruselas"
        oEmpleado.Viajes(0) = "Toledo"
        oEmpleado.Viajes(1) = "Paris"
        oEmpleado.Viajes(1) = "Alemania"
        oEmpleado.Viajes(1) = "Irlanda"
        oEmpleado.Viajes(1) = "Bruselas"
        oEmpleado.Viajes(0) = "Valencia"
        oEmpleado.Viajes(0) = "Toledo"
        oEmpleado.Viajes(1) = "Paris"
        oEmpleado.Viajes(1) = "Alemania"
        oEmpleado.Viajes(1) = "Irlanda"
        oEmpleado.Viajes(1) = "Bruselas"
        oEmpleado.Viajes(0) = "Toledo"
        oEmpleado.Viajes(1) = "Paris"
        oEmpleado.Viajes(1) = "Alemania"
        oEmpleado.Viajes(1) = "Irlanda"
        oEmpleado.Viajes(1) = "Bruselas"

        oEmpleado.IntoduceNombre("tere")
        oEmpleado.IntoduceNombre()
        Dim OtroMasEmpleado As Empleado
        'With oEmpleado
        '    .Categoria = 1
        '    .Sueldo = 200
        'End With
        'oEmpleado.Categoria = 1
        'oEmpleado.Sueldo = 100
        'With OtroMasEmpleado
        '    .Categoria = 1
        '    .IntoduceNombre()
        '    .DevuelveNombre()
        '    .FechaAlta = "12/12/2021"
        'End With


        ' Console.WriteLine("{0} - {1}", oEmpleado.Nombre, oEmpleado.Viajes(15))

        For I = 0 To oEmpleado.Dimension 'Aqui se recorre el array msViajes desde la posición 0
            'hasta la posición máxima del array, que se obtiene con la propiedad Dimension.
            Console.WriteLine("{0} - {1}", oEmpleado.Nombre, oEmpleado.Viajes(I))
            'En esta linea de arriba Viajes de I está implicando que se está accediendo a la
            'propiedad por defecto Viajes de la clase Empleado, y se está pasando el índice I
            'como argumento.
        Next
        Console.WriteLine("{0} - {1}", oEmpleado.miNacional, oEmpleado.miInternacional)
        Console.WriteLine("{0}- {1}", oEmpleado.Nombre, Format(oEmpleado.FechaAlta, "dd/MMMM/yyyy")) 'Aqui se muestra el nombre del empleado y la fecha de alta formateada como día/mes/año.
        Console.WriteLine("{0}- {1}", oEmpleado.Nombre, oEmpleado.MesAlta) 'Aqui se muestra el nombre del empleado y el mes de alta formateado como nombre completo del mes.
        ' oEmpleado.Identificador = 156




        '  Console.WriteLine("{0}", oEmpleado.Identificador)


        'oEmpleado.Nombre = "Guillermo"
        'Console.WriteLine("{0}", oEmpleado.Nombre)


        'oEmpleado.Categoria = 1
        'oEmpleado.Sueldo = 250
        ''  Console.WriteLine("{0} - {1}", oEmpleado.Nombre, oEmpleado.Sueldo)
        'oEmpleado.CuentaBancaria = "111178965621217271927"
        'Console.WriteLine("{0} - {1} - {2} ", oEmpleado.Nombre, oEmpleado.Sueldo, oEmpleado.EntidadBancaria)
        'oEmpleado.IntoduceNombre("Daniel")
        'Console.WriteLine("{0}", oEmpleado.DevuelveNombre)
        Console.ReadLine()
    End Sub




End Module
Public Class Empleado
    Private msNombre As String
    Private micategoria As Integer
    Private mdSueldo As Double
    Private msCtaBancaria As String
    Private msEntidad As String
    Private msCodigoEntidad As String
    Private Identificador As Integer
    Private mdFechaAlta As Date
    Private msViajes() As String
    Public miNacional As Integer
    Public miInternacional As Integer
    Private nosequeesesto(5, 10, 400, 5, 6) As Integer 'Esto sería un array multidimensional de 5 dimensiones, con 6, 11, 401, 6 y 7 posiciones respectivamente.
    Private matriz(50, 25) As String ' Esto sería un array bidimensional de 50 filas y 25 columnas, que almacena strings.
    Public ReadOnly Property Dimension As Integer
        Get
            Return UBound(msViajes)
        End Get

    End Property

    ' Default sirve para indicar que es la propiedad por defecto de la clase, es decir,
    ' que si no se indica el nombre de la propiedad, se llamará a esta. Por ejemplo, en el código del módulo,
    ' cuando se hace referencia a oEmpleado.Viajes(0), se está llamando a la propiedad por defecto Viajes de la
    ' clase Empleado pero si no se indicara el nombre de la propiedad, se llamaría a la propiedad por defecto Viajes de la clase
    ' Empleado.
    Default Public Property Viajes(Indice As Integer) As String
        Get
            Return msViajes(Indice) 'Aqui se devuelve el valor de la posición Indice del array msViajes,
            'que es un array de strings que almacena los viajes realizados por el empleado.
        End Get
        Set(value As String)
            If msViajes Is Nothing Then
                ReDim msViajes(0) 'En el paréntesis se indica la posición 0 porque es la primera vez
                'que se dimensiona el array, por lo que sólo tendrá una posición, la 0.
                'msViajes(Indice) = value
                'En esta linea de abajo se asigna el valor a la posición 0 del array,
                'que es la única que tiene.
                msViajes(0) = value
            Else
                Dim i As Integer    '   Aqui se declara una variable i de tipo Integer para
                '                       almacenar el índice del array msViajes.
                i = (UBound(msViajes) + 1) 'Aquí se calcula el índice del array msViajes,
                '                           que es el valor máximo del índice más 1.
                ReDim Preserve msViajes(i) 'Aquí se redimensiona el array msViajes para que tenga una
                'posición más, pero se utiliza Preserve para que se conserven los valores que ya tenía el
                'array.
                msViajes(i) = value 'Aquí se asigna el valor a la nueva posición del array msViajes.
            End If
            If Indice = 0 Then 'Aquí se comprueba si el índice es 0, que corresponde a un viaje nacional,
                'y se incrementa el contador de viajes nacionales.
                miNacional = miNacional + 1
            Else 'Y aquí se comprueba si el índice es distinto de 0, que corresponde a un viaje internacional,
                'y se incrementa el contador de viajes internacionales.
                miInternacional = miInternacional + 1
            End If

        End Set


    End Property




    Public ReadOnly Property MesAlta As String
        Get
            Return Format(mdFechaAlta, "MMMM") 'Aquí se devuelve el mes de la fecha de alta del empleado, formateado como nombre completo del mes.
        End Get
    End Property


    Public Property FechaAlta As Date
        Get
            Return mdFechaAlta
        End Get
        Set(value As Date)
            mdFechaAlta = value
        End Set
    End Property
    Public ReadOnly Property EntidadBancaria As String
        Get
            Return msEntidad
        End Get
    End Property
    Public WriteOnly Property CuentaBancaria As String
        Set(value As String)
            msCtaBancaria = value
            Select Case Left(value, 4)
                Case "1111"
                    msEntidad = "Banco universal"
                Case "2222"
                    msEntidad = "Banco central"
                Case "3333"
                    msEntidad = "Banco Sur"
                Case Else
                    msEntidad = "Entidad sin catalogar"




            End Select
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return msNombre
        End Get
        Set(value As String)
            msNombre = value
        End Set
    End Property




    Public Property Categoria As Integer
        Get
            Return micategoria
        End Get
        Set(value As Integer)
            micategoria = value
        End Set
    End Property
    Public Property Sueldo As Double
        Get
            Return mdSueldo
        End Get
        Set(value As Double)
            If micategoria = 1 Then
                If value > 200 Then
                    Console.WriteLine("La categoria no corresponde con el sueldo")
                    mdSueldo = 0
                Else
                    mdSueldo = value
                End If
            End If
        End Set
    End Property




    Public Sub IntoduceNombre(Valor As String)
        msNombre = UCase(Valor) 'UCase convierte el valor a mayúsculas y
        'lo asigna a la variable msNombre.


    End Sub
    Public Sub IntoduceNombre()




    End Sub
    Public Function DevuelveNombre() As String




    End Function


End Class
