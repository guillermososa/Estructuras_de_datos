Module TP4_07_Alumnos
    '4.7. Crear un algoritmo que utilice arrayList para almacenar las notas 
    '(0 a 10) de una serie de alumnos.
    ' Primero ingresar la cantidad de alumnos y la cantidad de notas que 
    'tiene cada uno con un máximo de 40 alumnos y 4 notas.
    ' Iterativamente ingresar el nombre de un alumno y sus notas y validar 
    'que tenga un nombre y que no sea repetido y el rango de la nota.
    ' Al completar la iteración informar por cada alumno el promedio, si 
    'aprobó o desaprobó teniendo en cuenta que aprueba con 6 o más.
    ' También informar quien es el mejor alumno (puede haber más de uno).
    ' Implementar procedimientos para resolver al menos las siguientes tareas:
    ' Uno para validad el nombre no sea vacío
    ' uno que valide la inexistencia de un nombre igual
    ' uno que valide el rango de la nota
    ' uno que determine el promedio
    ' uno que escriba si el alumno aprobó o no
    Sub Main()
        Dim CantAlumnos, CantNotas As Byte
        ValidarCantidad(CantAlumnos, CantNotas)
        Dim Alumnos As New ArrayList
        Dim Notas As New ArrayList
        Dim Promedios(CantAlumnos - 1) As Single
        Dim TotalNotas As Single
        For fila As Byte = 0 To CantAlumnos - 1
            IngresoAlumno(Alumnos)
            TotalNotas = 0
            For columna As Byte = 0 To CantNotas - 1
                Notas.Add(LeerRango("Ingrese nota: ", 1, 10))
                TotalNotas += Notas(columna)
            Next
            Promedios(fila) = CalcularPromedio(TotalNotas, CantNotas)
            Notas.Clear()
            Console.Clear()
        Next
        For x = 0 To CantAlumnos - 1
            Console.Write("Alumno: " & Alumnos(x))
            Console.Write(". Promedio: " & Promedios(x).ToString("#0.00"))
            Console.WriteLine(".")
            Console.WriteLine(CondicionAlumno(Promedios(x)))
            Console.WriteLine()
        Next
        Console.WriteLine(MejoresAlumnos(Promedios, Alumnos))
        Console.ReadKey()
    End Sub

    Private Sub ValidarCantidad(ByRef CantAlumnos As Byte, ByRef CantNotas As Byte)
        CantAlumnos = LeerRango("Ingrese cantidad de alumnos: ", 1, 40)
        CantNotas = LeerRango("Ingrese cantidad de notas: ", 1, 4)
        Console.Clear()
    End Sub

    Private Function LeerRango(mensaje As String, min As Byte, max As Byte) As Single
        Dim ingreso As Single
        Do
            Console.Write(mensaje)
            ingreso = Console.ReadLine()
        Loop Until ingreso >= min And ingreso <= max
        Return ingreso
    End Function

    Private Sub IngresoAlumno(ByRef Alumnos As ArrayList)
        Dim ingreso As String
        Do
            Console.Write("Ingrese nombre del alumno: ")
            ingreso = Console.ReadLine()
        Loop While Existe(Alumnos, ingreso) Or EsVacio(ingreso)
        Alumnos.Add(ingreso)
    End Sub

    Private Function Existe(Alumnos As ArrayList, valor As String) As Boolean
        Return Alumnos.Contains(valor)
    End Function

    Private Function EsVacio(valor As String) As Boolean
        Return valor.Length = 0
    End Function

    Private Function CalcularPromedio(total As Single, cant As Byte) As Single
        Return total / cant
    End Function

    Private Function CondicionAlumno(promedio As Single) As String
        If promedio >= 6 Then
            Return "Condicion del alumno: Aprobado."
        Else
            Return "Condicion del alumno: Desaprobado."
        End If
    End Function

    Private Function MejoresAlumnos(Promedio() As Single, Alumnos As ArrayList) As String
        Dim lista As String = "Lista de Mejores Alumnos: "
        For i = 0 To Promedio.Length - 1
            If Promedio(i) = Promedio.Max Then
                lista &= Alumnos(i)
                If i < Promedio.Length - 2 Then
                    lista &= ", "
                End If
            End If
        Next
        lista &= "."
        Return lista
    End Function
End Module