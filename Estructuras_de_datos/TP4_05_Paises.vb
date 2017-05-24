Module TP4_05_Paises
    '4.5. Al ejercicio anterior agregarle las funcionalidades que permita 
    'interactivamente agregar, editar, eliminar y mostrar el nombre de país 
    'y su dominio. También informar la cantidad de países cargados.
    Private Sub AgregarPais(ByRef paises As Collection)
        Dim dominio, pais As String
        dominio = LeerTexto("Ingrese Dominio: ")
        pais = LeerTexto("Ingrese Pais: ")
        paises.Add(pais, dominio)
    End Sub
    Private Sub EditarPais(ByRef paises As Collection)
        Dim dominio, pais As String
        dominio = LeerTexto("Ingrese Dominio: ")
        pais = paises.Item(dominio)
        Console.WriteLine("Pais Actual: " & pais)
        Console.Write("Ingrese Nuevo Pais: ")
        pais = Console.ReadLine()
        paises.Remove(dominio)
        paises.Add(pais, dominio)
    End Sub
    Private Sub EliminarPais(ByRef paises As Collection)
        Dim dominio As String
        dominio = LeerTexto("Ingrese Dominio: ")
        paises.Remove(dominio)
    End Sub
    Sub MostrarPais(ByRef paises As Collection)
        Dim dominio, pais As String
        dominio = LeerTexto("Ingrese Dominio: ")
        If paises.Contains(dominio) Then
            pais = paises.Item(dominio)
            Console.WriteLine("Pais: " & pais)
        Else
            Console.WriteLine("Valor no encontrado")
        End If
    End Sub
    Sub main()
        Dim paises As New Collection
        Dim ingreso As Byte
        paises.Add("Argentina", "ar")
        paises.Add("Chile", "cl")
        paises.Add("Brasil", "br")
        paises.Add("Paraguay", "py")
        Do
            Console.Clear()
            Console.WriteLine("1) Agregar 2)Editar 3)Eliminar 4)Mostrar 5)Salir")
            Console.WriteLine("Cantidad de paises cargados " & paises.Count)
            Console.Write("Ingrese Opcion: ")
            ingreso = Console.ReadLine()
            Select Case ingreso
                Case 1
                    AgregarPais(paises)
                Case 2
                    EditarPais(paises)
                Case 3
                    EliminarPais(paises)
                Case 4
                    MostrarPais(paises)
                    Console.ReadKey()
            End Select
        Loop Until ingreso = 5
    End Sub
    Function LeerTexto(mensaje As String) As String
        Console.Write(mensaje)
        Return Console.ReadLine()
    End Function
End Module