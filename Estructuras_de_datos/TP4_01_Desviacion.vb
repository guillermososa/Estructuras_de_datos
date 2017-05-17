Module TP4_01_Desviacion
    '    Elaborar un algoritmo que permita cargar 5 números en un arreglo de 5 elementos; calcular la
    'media y luego imprimir cada elemento del arreglo y la desviación que tiene respecto a la media.
    'La MEDIA se obtiene la sumatoria de los todos elementos del arreglo y se divide por la cantidad
    'de los mismos. La DESVIACION de cada elemento se obtiene restándole al elemento la
    'MEDIA.
    Sub Main()
        Dim arreglo(4), media, desviacion As Double
        For i = 0 To 4
            arreglo(i) = Leer("Ingrese numero: ")
        Next
        media = arreglo.Sum / arreglo.Count
        For i = 0 To 4
            desviacion = arreglo(i) - media
            Console.WriteLine("La desviación de " & arreglo(i) & " es : " & desviacion)
        Next
        Console.ReadKey()
    End Sub
    Private Function Leer(mensaje As String) As Double
        Console.Write(mensaje)
        Return Console.ReadLine()
    End Function
End Module