Module TP4_05_Paises
    '4.5. Al ejercicio anterior agregarle las funcionalidades que permita 
    'interactivamente agregar, editar, eliminar y mostrar el nombre de país 
    'y su dominio. También informar la cantidad de países cargados.
    Private dominio, pais As String
    Private Sub AgregarPais(ByRef paises As Collection)
        dominio = LeerTexto("Ingrese Dominio: ")
        pais = LeerTexto("Ingrese Pais: ")
        paises.Add(pais, dominio)
    End Sub
    Private Sub EditarPais(ByRef paises As Collection)
        dominio = LeerTexto("Ingrese Dominio: ")
        If Not paises.Contains(dominio) Then
            Console.WriteLine("Pais no encontrado")
            Console.ReadKey()
        Else
            pais = paises.Item(dominio)
            Console.WriteLine("Pais Actual: " & pais)
            Console.Write("Ingrese Nuevo Pais: ")
            pais = Console.ReadLine()
            paises.Remove(dominio)
            paises.Add(pais, dominio)
        End If
    End Sub
    Private Sub EliminarPais(ByRef paises As Collection)
        dominio = LeerTexto("Ingrese Dominio: ")
        If Not paises.Contains(dominio) Then
            Console.WriteLine("Pais no encontrado")
            Console.ReadKey()
        Else
            paises.Remove(dominio)
        End If
    End Sub
    Private Sub EliminarTodo(ByRef paises As Collection)
        paises.Clear()
    End Sub
    Sub MostrarPais(ByRef paises As Collection)
        dominio = LeerTexto("Ingrese Dominio: ")
        If Not paises.Contains(dominio) Then
            Console.WriteLine("Pais no encontrado")
        Else
            pais = paises.Item(dominio)
            Console.WriteLine("Pais: " & pais)
        End If
        Console.ReadKey()
    End Sub
    Sub MostrarTodo(ByRef paises As Collection)
        For i = 1 To paises.Count
            pais = paises.Item(i)
            Console.WriteLine("Pais {0}: {1}", i, pais)
        Next
        Console.ReadKey()
    End Sub
    Sub main()
        'Declaracion e inicializacion de la coleccion
        Dim paises As New Collection
        Dim opcion As Byte
        'carga inicial de la coleccion
        paises.Add("Argentina", "ar")
        paises.Add("Chile", "cl")
        paises.Add("Brasil", "br")
        paises.Add("Paraguay", "py")
        Do
            Console.Clear()
            Console.WriteLine("0) Salir 1) Agregar 2)Editar 3)Eliminar 4)Eliminar todo 5)Mostrar 6)Mostrar todo")
            Console.WriteLine("Cantidad de paises cargados " & paises.Count)
            Console.Write("Ingrese Opcion: ")
            opcion = Val(Console.ReadLine())
            Select Case opcion
                Case 1
                    AgregarPais(paises)
                Case 2
                    EditarPais(paises)
                Case 3
                    EliminarPais(paises)
                Case 4
                    EliminarTodo(paises)
                Case 5
                    MostrarPais(paises)
                Case 6
                    MostrarTodo(paises)
                Case Else
                    opcion = 0
            End Select
        Loop Until opcion = 0
    End Sub
    Function LeerTexto(mensaje As String) As String
        Console.Write(mensaje)
        Return Console.ReadLine()
    End Function
End Module