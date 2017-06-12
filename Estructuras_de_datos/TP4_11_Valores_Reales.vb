Module TP4_11_Valores_Reales
    '4.11. Crear un algoritmo que lea valores reales en forma 
    'consecutiva y los vaya agregando a una pila de tipo real.
    ' Si el valor ingresado es cero se quita un elemento.
    ' En todo momento informar la sumatoria total de los valores.
    Sub Main()
        Dim Pila As New Stack(Of Double)
        Dim valor As Double
        Do
            Console.Clear()
            Console.WriteLine("Sumatoria de los valores: " & Pila.Sum)
            Console.Write("Ingrese valor real: ")
            valor = Console.ReadLine()
            If valor = 0 And Not EsVacio(Pila) Then
                Console.WriteLine("Se quitó el valor: " & Pila.Pop)
            Else
                Pila.Push(valor)
                Console.WriteLine("Se ingresó el valor: " & valor)
            End If
        Loop Until EsVacio(Pila)
    End Sub

    Private Function EsVacio(valor As Stack(Of Double)) As Boolean
        Return valor.Count = 0
    End Function
End Module