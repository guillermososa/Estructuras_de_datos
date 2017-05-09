Module TP4_01_Desviacion
    'Elaborar un algoritmo que permita cargar 5 números en un arreglo de 5 elementos; calcular la
    'media y luego imprimir cada elemento del arreglo y la desviación que tiene respecto a la media.
    'La MEDIA se obtiene la sumatoria de los todos elementos del arreglo y se divide por la cantidad
    'de los mismos. La DESVIACION de cada elemento se obtiene restándole al elemento la
    'MEDIA.
    Sub Main()
        Dim arreglo() As Integer = {0, 0, 0, 0}
        Dim total, media As Integer
        For i = 0 To 4
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