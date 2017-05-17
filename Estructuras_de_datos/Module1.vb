Module Module1
    Sub Main()
        Dim arreglo(4), total, media As Double
        For Each i As UShort In arreglo
            Console.Write("Ingrese un numero: ")
            arreglo(i) = Console.ReadLine()
            total += arreglo(i)
        Next
        media = total / 5
        Console.WriteLine()
        For i = 0 To 4
            Console.WriteLine("El elemento {0} es {1} y su desviacion es {2}", i, arreglo(i), arreglo(i) - media)
        Next
        Console.ReadKey()
    End Sub
End Module