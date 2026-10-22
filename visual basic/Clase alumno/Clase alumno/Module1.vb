Module Module1
    'hacer clase alumno pero quiero que el numero de matricula se asigne automaticamente, crear alumno 1,2,3 y asi sucesivamente---------sub main en el main y clase en un public class---------- podemos hacer un array o un array por cada modulo---------alumno1.invocarmetodo y a ese metodo tengo que pasarle el nombre del modulo y la nota------------tantos arrays como modulos hayan

    'miProg() miErp() miPython() miIngles() miIPE(si el alumno no cursa IPE el array estara sin dimensionar) miDdI() miPowerBI()
    'introducir evaluaciones

    'clase alumno con datos típicos y numero identificativo(matricula) Matricula ReadOnly que se asigna automáticamente


    'Private miProgr() As Byte
    '    Private miErp() As Byte

    'solo un método introducirNotas.

    'NO IF EN introducirNotas.

    'NO PUEDO METER NOTAS SI EL ALUMNO NO TIENE MATRICULA, NOMBRE Y/O APELLIDOS.(ahí si se puede un If)
    Sub Main()

    End Sub

    Public Class Alumno
        Private Shared matriculaCounter As Integer = 0
        Private ReadOnly matricula As Integer
        Private nombre As String
        Private apellidos As String
        ' Arrays for each module
        Private miProg() As Byte
        Private miErp() As Byte
        Private miPython() As Byte
        Private miIngles() As Byte
        Private miIPE() As Byte
        Private miDdI() As Byte
        Private miPowerBI() As Byte
        Public Sub New(nombre As String, apellidos As String)
            Me.nombre = nombre
            Me.apellidos = apellidos
            matriculaCounter += 1
            matricula = matriculaCounter
        End Sub
        Public ReadOnly Property MatriculaID() As Integer
            Get
                Return matricula
            End Get
        End Property
        Public Sub IntroducirNotas(modulo As String, nota As Byte)
            If String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(apellidos) Then
                Throw New InvalidOperationException("El alumno debe tener nombre y apellidos para introducir notas.")
            End If
            Select Case modulo.ToLower()
                Case "miProg"
                    ReDim Preserve miProg(0)
                    miProg(0) = nota
                Case "miErp"
                    ReDim Preserve miErp(0)
                    miErp(0) = nota
                Case "miPython"
                    ReDim Preserve miPython(0)
                    miPython(0) = nota
                Case "miIngles"
                    ReDim Preserve miIngles(0)
                    miIngles(0) = nota
                Case "miIPE"
                    ReDim Preserve miIPE(0)
                    miIPE(0) = nota
                Case "miDdI"
                    ReDim Preserve miDdI(0)
                    miDdI(0) = nota
                Case "miPowerBI"
                    ReDim Preserve miPowerBI(0)
                    miPowerBI(0) = nota
                Case Else
                    Throw New ArgumentException("Módulo no válido.")
            End Select
        End Sub
    End Class

End Module
