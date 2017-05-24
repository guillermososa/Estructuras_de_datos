Module TP4_03_Alumnos
    '4.3. Crear un algoritmo que utilice arrays para almacenar las notas (0 a 10) de una serie de alumnos.
    ' Primero ingresar la cantidad de alumnos y la cantidad de notas que tiene cada uno con un máximo de 40 alumnos y 4 notas.
    ' Iterativamente ingresar el nombre de un alumno y sus notas y validar que tenga un nombre y que no sea repetido y el rango de la nota.
    ' Al completar la iteración informar por cada alumno el promedio, si aprobó o desaprobó teniendo en cuenta que aprueba con 6 o más.
    ' También informar quien es el mejor alumno (puede haber más de uno).
    ' Implementar procedimientos para resolver al menos las siguientes tareas:
    ' Uno para validad el nombre no sea vacío
    ' uno que valide la inexistencia de un nombre igual
    ' uno que valide el rango de la nota
    ' uno que determine el promedio
    ' uno que escriba si el alumno aprobó o no
    ' uno que devuelva la lista de mejores alumnos
    Sub ValidarCantidad(ByRef CantAlumnos As Byte, ByRef CantNotas As Byte)
        Do
            CantAlumnos = LeerNumero("Ingrese cantidad de alumnos: ")
        Loop Until CantAlumnos >= 1 And CantAlumnos <= 40
        Do
            CantNotas = LeerNumero("Ingrese cantidad de notas por alumno: ")
        Loop Until CantNotas >= 1 And CantNotas <= 4
        Console.Clear()
    End Sub
    Sub IngresoAlumno(ByVal fila As Integer, ByRef Alumno() As String)
        Do
            Console.Write("Ingrese nombre del alumno: ")
            Alumno(fila) = Console.ReadLine()
        Loop While ExisteNombre(fila, Alumno) Or NombreVacio(Alumno(fila))
    End Sub
    Private Function ExisteNombre(Cant As Byte, Alumno() As String) As Boolean
        For i = 0 To Cant - 1
            If Alumno(Cant) = Alumno(i) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Function NombreVacio(nombre As String) As Boolean
        If nombre = "" Then
            Return True
        End If
        Return False
    End Function
    Sub IngresoNota(ByVal fila As Integer, ByVal columna As Integer, ByRef Nota As Single)
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
    Private Function CalcularPromedio(total As Single, cant As Byte) As Single
        Return total / cant
    End Function
    Private Function CondicionAlumno(prom As Single) As String
        If prom >= 6 Then
            Return "Condicion del alumno: Aprobado."
        Else
            Return "Condicion del alumno: Desaprobado."
        End If
    End Function
    Private Function MejoresAlumnos(ByRef Promedio() As Single, ByRef Alumno() As String) As String
        Dim lista As String = "Lista de Mejores Alumnos: "
        For i = 0 To Promedio.Length - 1
            If Promedio(i) = Promedio.Max Then
                lista &= Alumno(i)
                If i < Promedio.Length - 1 Then
                    lista &= ", "
                End If
            End If
        Next
        lista &= "."
        Return lista
    End Function
    Sub Main()
        Dim CantAlumnos, CantNotas As Byte
        ValidarCantidad(CantAlumnos, CantNotas)
        Dim Alumno(CantAlumnos - 1) As String
        Dim Nota(CantAlumnos - 1, CantNotas - 1) As Single
        Dim Promedio(CantAlumnos - 1) As Single
        Dim TotalNotas As Single
        For fila = 0 To CantAlumnos - 1
            IngresoAlumno(fila, Alumno)
            TotalNotas = 0
            For columna = 0 To CantNotas - 1
                IngresoNota(fila, columna, Nota(fila, columna))
                TotalNotas += Nota(fila, columna)
            Next
            Promedio(fila) = CalcularPromedio(TotalNotas, CantNotas)
            Console.Clear()
        Next
        For x = 0 To CantAlumnos - 1
            Console.Write("Alumno: " & Alumno(x))
            Console.Write(". Notas: ")
            For y = 0 To CantNotas - 1
                Console.Write(Nota(x, y))
                If y <> CantNotas - 1 Then
                    Console.Write(", ")
                End If
            Next
            Console.Write(". Promedio: " & Promedio(x).ToString("#0.00"))
            Console.WriteLine(".")
            Console.WriteLine(CondicionAlumno(Promedio(x)))
            Console.WriteLine()
        Next
        Console.WriteLine(MejoresAlumnos(Promedio, Alumno))
        Console.ReadKey()
    End Sub
    Private Function LeerNumero(mensaje As String) As Single
        Console.Write(mensaje)
        Return Console.ReadLine()
    End Function
End Module