Module TP4_03_Alumnos
    '    Crear un algoritmo para operar las notas (0 a 10) de una serie de alumnos. Primero ingresar la
    'cantidad de alumnos y la cantidad de notas que tiene cada uno con un máximo de 40 alumnos y
    '4 notas. Iterativamente ingresar el nombre de un alumno y sus notas y validar que tenga un
    'nombre que no sea repetido y el rango de la nota. Al completar la iteración informar por cada
    'alumno el promedio, si aprobó o desaprobó teniendo en cuenta que aprueba con 6 o más.
    'Además, informar quien es el mejor alumno (puede haber más de uno). Implementar
    'procedimientos para resolver cada tarea.
    Private Sub ValidarCantidad(ByRef CantAlumnos As Byte, ByRef CantNotas As Byte)
        Do
            CantAlumnos = LeerNumero("Ingrese cantidad de alumnos: ")
        Loop Until CantAlumnos >= 1 And CantAlumnos <= 40
        Do
            CantNotas = LeerNumero("Ingrese cantidad de notas por alumno: ")
        Loop Until CantNotas >= 1 And CantNotas <= 4
    End Sub
    Private Sub IngresoAlumno(ByVal fila As Integer, ByRef Alumno() As String)
        Do
            Alumno(fila) = LeerTexto("Ingrese nombre del alumno: ")
        Loop Until Not ExisteAlumno(fila, Alumno)
    End Sub
    Private Function ExisteAlumno(Cant As Byte, Alumno() As String) As Boolean
        For i = 0 To Cant - 1
            If Alumno(Cant) = Alumno(i) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub IngresoNota(ByVal fila As Integer, ByVal columna As Integer, ByRef Nota As Single)
        Do
            Nota = LeerNumero("Ingrese Nota: ")
        Loop Until ValidarNota(Nota)
    End Sub
    Private Function ValidarNota(nota As Single) As Boolean
        If nota >= 0 And nota <= 10 Then
            Return True
        End If
        Return False
    End Function
    Sub Main()
        Dim CantAlumnos, CantNotas As Byte
        ValidarCantidad(CantAlumnos, CantNotas)
        Dim Alumno(CantAlumnos - 1) As String
        Dim Nota(CantAlumnos - 1, CantNotas - 1) As Single
        Dim Promedio(CantAlumnos - 1) As Single
        For fila = 0 To CantAlumnos - 1
            Console.Clear()
            IngresoAlumno(fila, Alumno)
            For columna = 0 To CantNotas - 1
                IngresoNota(fila, columna, Nota(fila, columna))
                Promedio(fila) += Nota(fila, columna)
            Next
            Promedio(fila) /= CantNotas
        Next
        Console.Clear()
        For x = 0 To CantAlumnos - 1
            Console.Write("Alumno: " & Alumno(x))
            Console.Write(". Notas: ")
            For y = 0 To CantNotas - 1
                Console.Write(Nota(x, y))
                If y <> CantNotas - 1 Then
                    Console.Write(", ")
                End If
            Next
            Console.Write(". Promedio: " & Promedio(x))
            Console.WriteLine(".")
            If Promedio(x) >= 6 Then
                Console.WriteLine("Condicion del alumno: Aprobado.")
            Else
                Console.WriteLine("Condicion del alumno: Desaprobado.")
            End If
            If Promedio(x) = Promedio.Max Then
                Console.WriteLine("**Es mejor alumno**")
            End If
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub
    Private Function LeerNumero(mensaje As String) As Single
        Console.Write(mensaje)
        Return Console.ReadLine()
    End Function
    Private Function LeerTexto(mensaje As String) As String
        Console.Write(mensaje)
        Return Console.ReadLine()
    End Function
End Module