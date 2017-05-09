Module TP4_02_Lista_de_Productos
    'Se tiene tres arrays cargados programáticamente con una lista de productos: el primero tiene el
    'código, el segundo el nombre y el tercero el precio unitario. Repetitivamente se ingresa un
    'código de producto y el programa muestra su descripción y precio, luego el usuario ingresa la
    'cantidad. Esto sucede hasta que el código sea cero.
    Sub Main()
        Dim codigo() As Integer = {1, 2, 3}
        Dim nombre() As String = {"Jabon", "Detergente", "Esponja"}
        Dim precio() As Single = {23.5, 50.75, 10}
        Dim cod, cant As Integer
        Do
            Console.Write("Ingrese codigo de producto: ")
            cod = Console.ReadLine()
            If cod > 0 Then
                cod -= 1
                Console.WriteLine("Descripcion: " & nombre(cod))
                Console.WriteLine("Precio Unitario: $" & precio(cod).ToString)
                Console.Write("Ingrese cantidad: ")
                cant = Console.ReadLine()
                Console.WriteLine("Subtotal: $" & precio(cod) * cant)
                Console.WriteLine()
                cod += 1
            End If
        Loop Until cod = 0
    End Sub
End Module