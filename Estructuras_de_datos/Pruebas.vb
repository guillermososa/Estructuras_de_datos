Module Pruebas
    Sub main()
        ' crea e instancia
        Dim tablita As New Hashtable
        ' agrega elementos
        tablita.Add("R", "Rojo")
        tablita.Add("V", "Verde")
        tablita.Add("A", "Azul")
        ' itera sobre la colección
        ' cada elemento es cread como un dictionaryentry
        For Each elemento As DictionaryEntry In tablita
            Console.WriteLine(elemento.Key & " " & elemento.Value)
        Next
        'tablita.Contains
        Console.ReadKey()

    End Sub
End Module