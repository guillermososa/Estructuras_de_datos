Module TP4_12_Genero_Stack_Nombres
    '4.12. En los ejercicios anteriores con queue y stack establecer el género de las listas.
    '4.10. Crear un algoritmo que tenga una colección de stack de manera tal que 
    'pueda ser accedida en todo el módulo. Con un menú permite efectuar 2 acciones:
    'ingresar nombres a la colección desde teclado y la segunda permita extraerlo 
    'y mostrarlo en la pantalla. El programa debe finalizar cuando se quitan todos 
    'los elementos de la colección.
    Private Nombres As New Stack(Of String)

    Enum Opciones As Byte
        IngresarNombre
        ExtraerNombre
    End Enum

    Sub Main()
        Dim Opcion As Byte
        Do
            Console.Clear()
            Console.WriteLine("0)Ingresar Nombre 1)Extraer Nombre")
            Opcion = Val(Leer("Ingrese Opcion: "))
            Select Case Opcion
                Case Opciones.IngresarNombre
                    IngresarNombre()
                Case Opciones.ExtraerNombre
                    ExtraerNombre()
                Case Else
                    Console.WriteLine("Ingrese nuevamente, valor incorrecto!.")
            End Select
        Loop Until EsVacio()
    End Sub

    Private Sub IngresarNombre()
        Nombres.Push(Leer("Ingrese su nombre: "))
    End Sub

    Private Sub ExtraerNombre()
        If Not EsVacio() Then
            Console.WriteLine("El nombre igresado es: " & Nombres.Pop())
            Console.ReadKey()
        End If
    End Sub

    Private Function Leer(mensaje As String) As String
        Console.Write(mensaje)
        Return Console.ReadLine
    End Function

    Private Function EsVacio() As Boolean
        Return Nombres.Count = 0
    End Function
End Module