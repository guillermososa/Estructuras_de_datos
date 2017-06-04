Module Pruebas

    Sub Main()
        Dim pila As New Stack
        pila.Push(1)
        pila.Push(2)
        pila.Push(3)
        MostrarTodo(pila)
        pila.Pop()
        pila.Push(4)
        MostrarTodo(pila)
        Console.WriteLine("Cantidad: " & pila.Count)
        Console.ReadKey()
    End Sub

    Private Sub MostrarTodo(pila As Stack)
        For Each elemento In pila
            Console.WriteLine(elemento)
        Next
    End Sub

End Module