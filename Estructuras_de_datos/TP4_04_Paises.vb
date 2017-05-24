Module TP4_04_Paises
    '    4.4. Elaborar un algoritmo que cargue programáticamente nombre de países y su dominio de país en
    'una Collection. A continuación, debe permitir realizar consultas, se introduce el nombre del
    'dominio y se deberá mostrar el nombre del país. Salir cuando el valor ingresado es vacío.
    Sub main()
        Dim paises As New Collection
        paises.Add("Argentina", "ar")
        paises.Add("Chile", "cl")
        paises.Add("Brasil", "br")
        paises.Add("Paraguay", "py")
        Dim ingreso As String
        Do
            Console.Write("Ingrese dominio: ")
            ingreso = Console.ReadLine()
            If paises.Contains(ingreso) Then
                Console.WriteLine(paises.Item(ingreso))
            Else
                Console.WriteLine("Valor no encontrado")
            End If
            Console.ReadKey()
            Console.Clear()
        Loop Until ingreso = ""
    End Sub
End Module