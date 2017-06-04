Module TP4_06_Planta_de_Chipas
    '4.6. Se tiene la producción de los 7 días de la semana de una
    'planta de chipas con varios empleados. 
    'Escribir un algoritmo que permita ingresar cantidad de
    'productos producidos por cada empleado en un día especificado
    'teniendo en cuenta que la producción de cada empleado puede 
    'ser ingresadas varias veces por día.
    ' Luego de cada ingreso totalizar los ingresos por empleado 
    'y por día.
    ' Los empleados están cargados programáticamente e
    'identificados por una clave que es su nombre abreviado.
    ' Utilizar ArrayList y Collection.

    Enum DiasSemana As Byte
        domingo
        lunes
        martes
        miercoles
        jueves
        viernes
        sabado
    End Enum

    Sub Main()
        Dim Empleados As New Collection
        Empleados.Add("Guillermo Sosa ", "guille")
        Empleados.Add("Paula Bustos   ", "pau")
        Empleados.Add("Juan Perez     ", "juan")
        Empleados.Add("Cristian Chavez", "cris")
        Dim ProdEmp1 As New ArrayList
        Dim ProdEmp2 As New ArrayList
        Dim ProdEmp3 As New ArrayList
        Dim ProdEmp4 As New ArrayList
        Dim Empleado As String
        Dim Cantidad As Integer
        For dia As DiasSemana = 0 To 6
            ProdEmp1.Insert(dia, 0)
            ProdEmp2.Insert(dia, 0)
            ProdEmp3.Insert(dia, 0)
            ProdEmp4.Insert(dia, 0)
            Do
                Console.Clear()
                Console.WriteLine("Día: " & dia.ToString)
                Do
                    Console.Write("Ingrese Empleado: ")
                    Empleado = Console.ReadLine()
                Loop Until Empleados.Contains(Empleado) Or Empleado = ""
                If Empleado <> "" Then
                    Console.WriteLine("Nombre del Empleado: " & Empleados.Item(Empleado))
                    Console.Write("Ingrese Cantidad de Productos: ")
                    Cantidad = Console.ReadLine()
                    Console.WriteLine()
                    Select Case Empleados.Item(Empleado)
                        Case Empleados.Item(1)
                            ProdEmp1.Insert(dia, (ProdEmp1.Item(dia) + Cantidad))
                        Case Empleados.Item(2)
                            ProdEmp2.Insert(dia, (ProdEmp2.Item(dia) + Cantidad))
                        Case Empleados.Item(3)
                            ProdEmp3.Insert(dia, (ProdEmp3.Item(dia) + Cantidad))
                        Case Empleados.Item(4)
                            ProdEmp4.Insert(dia, (ProdEmp4.Item(dia) + Cantidad))
                    End Select
                    MostrarDia(Empleados, ProdEmp1, ProdEmp2, ProdEmp3, ProdEmp4, dia)
                    Console.ReadKey()
                End If
            Loop Until Empleado = ""
        Next
        Console.Clear()
        For dia As DiasSemana = 0 To 6
            MostrarDia(Empleados, ProdEmp1, ProdEmp2, ProdEmp3, ProdEmp4, dia)
        Next
        Console.ReadKey()
    End Sub

    Private Sub MostrarDia(Empleados As Collection, ProdEmp1 As ArrayList, ProdEmp2 As ArrayList, ProdEmp3 As ArrayList, ProdEmp4 As ArrayList, dia As DiasSemana)
        If ProdEmp1.Item(dia) <> 0 Then
            Console.WriteLine("Dia: {0} Empleado: {1} Cantidad: {2}", dia.ToString, Empleados.Item(1), ProdEmp1.Item(dia))
        End If
        If ProdEmp2.Item(dia) <> 0 Then
            Console.WriteLine("Dia: {0} Empleado: {1} Cantidad: {2}", dia.ToString, Empleados.Item(2), ProdEmp2.Item(dia))
        End If
        If ProdEmp3.Item(dia) <> 0 Then
            Console.WriteLine("Dia: {0} Empleado: {1} Cantidad: {2}", dia.ToString, Empleados.Item(3), ProdEmp3.Item(dia))
        End If
        If ProdEmp4.Item(dia) <> 0 Then
            Console.WriteLine("Dia: {0} Empleado: {1} Cantidad: {2}", dia.ToString, Empleados.Item(4), ProdEmp4.Item(dia))
        End If
        If Not (ProdEmp1.Item(dia) = 0 And ProdEmp2.Item(dia) = 0 And ProdEmp3.Item(dia) = 0 And ProdEmp4.Item(dia) = 0) Then
            Console.WriteLine()
        End If
    End Sub

End Module