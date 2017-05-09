Module TP4_03_Pruducto_de_Venta
    'Se ingresan dos valores relativos a un producto en venta: cantidad y precio unitario. Si la
    'cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el
    'descuento es del 10% y si es 251 o más el descuento es del 20%. Informar subtotal (cantidad por
    'precio unitario), porcentaje de descuento aplicado, monto descontado y el total (subtotal –
    'monto descontado).
    Sub Main()
        'Declaracion de variables
        Dim cant, pdesc As Integer
        Dim punit, mdesc, subtotal, total As Double
        'Ingreso de datos
        Console.Write("Ingrese Cantidad: ")
        cant = Console.ReadLine()
        Console.Write("Ingrese Precio Unitario: ")
        punit = Console.ReadLine()
        'Compara
        If cant < 10 Then
            pdesc = 0
        ElseIf cant <= 50 Then
            pdesc = 5
        ElseIf cant <= 250 Then
            pdesc = 10
        Else
            pdesc = 20
        End If
        'Calcula
        subtotal = punit * cant
        mdesc = subtotal * (pdesc / 100)
        total = subtotal - mdesc
        'Muestra la informacion
        Console.WriteLine()
        Console.WriteLine("Subtotal: $" & subtotal)
        Console.WriteLine("Descuento aplicado: {0}%", pdesc)
        Console.WriteLine("Monto descuentado: $" & mdesc)
        Console.WriteLine("Total: $" & total)
        Console.ReadKey()
    End Sub
End Module