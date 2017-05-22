Module TP4_02_Lista_de_Productos
    '    Se tiene tres arrays cargados programáticamente con una lista de productos: el primero tiene el
    'código, el segundo el nombre y el tercero el precio unitario. Repetitivamente se ingresa un
    'código de producto y el programa muestra su descripción y precio, luego el usuario ingresa la
    'cantidad con lo que el programa responde calculando el total del producto y el total general
    '(acumulando los productos anteriores). Esto sucede hasta que el código sea cero.
    Sub Main()
        Dim codigos = New Integer() {1, 2, 3}
        Dim nombres = New String() {"Jabon", "Detergente", "Esponja"}
        Dim precios = New Double() {23.5, 50.75, 10}
        Dim total, total_acumulado As Double
        Dim cod, cant As Integer
        Do
            cod = Leer("Ingrese codigo de producto: ")
            If cod > 0 Then
                If Existe(cod, codigos) Then
                    cod -= 1
                    Console.WriteLine("Descripcion: " & Chr(34) & nombres(cod) & Chr(34) & " Precio unitario: $" & precios(cod))
                    cant = Leer("Ingrese cantidad: ")
                    total = precios(cod) * cant
                    total_acumulado += total
                    Console.WriteLine("Total: $" & total & " y Total acumulado: $" & total_acumulado)
                    cod += 1
                    'Else
                    '    Console.WriteLine("Codigo inexistente!")
                End If
                Console.WriteLine()
            End If
        Loop Until cod = 0
    End Sub
    Private Function Leer(mensaje As String) As Double
        Console.Write(mensaje)
        Return Console.ReadLine()
    End Function
    Private Function Existe(ingreso As Integer, arreglo() As Integer) As Boolean
        For i = 0 To arreglo.Length - 1
            If ingreso = arreglo(i) Then
                Return True
            End If
        Next
        Return False
    End Function
End Module