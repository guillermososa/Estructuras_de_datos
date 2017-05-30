Module TP4_05_Paises
    '4.5. Al ejercicio anterior agregarle las funcionalidades que permita 
    'interactivamente agregar, editar, eliminar y mostrar el nombre de país 
    'y su dominio. También informar la cantidad de países cargados.
    Private dominio, pais As String
    Enum Opciones As Byte
        salir
        agregar
        editar
        eliminar
        eliminartodo
        mostrar
        mostrartodo
    End Enum
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
                Case Opciones.salir
                    opcion = 0
                Case Opciones.agregar
                    AgregarPais(paises)
                Case Opciones.editar
                    EditarPais(paises)
                Case Opciones.eliminar
                    EliminarPais(paises)
                Case Opciones.eliminartodo
                    EliminarTodo(paises)
                Case Opciones.mostrar
                    MostrarPais(paises)
                Case Opciones.mostrartodo
                    MostrarTodo(paises)
                Case Else
                    Console.WriteLine("Ingrese nuevamente, valor incorrecto!.")
            End Select
        Loop Until opcion = 0
    End Sub
    Private Sub AgregarPais(ByRef paises As Collection)
        dominio = LeerTexto("Ingrese Dominio: ")
        If paises.Contains(dominio) Then
            Console.WriteLine("Pais ya existe")
        Else
            pais = LeerTexto("Ingrese Pais: ")
            paises.Add(pais, dominio)
            Console.WriteLine("Datos guardados correctamente(Dominio: {0} Pais: {1}).", dominio, pais)
        End If
        Console.ReadKey()
    End Sub
    Private Sub EditarPais(ByRef paises As Collection)
        If paises.Count <> 0 Then
            dominio = LeerTexto("Ingrese Dominio: ")
            If Not paises.Contains(dominio) Then
                Console.WriteLine("Pais no encontrado")
            Else
                pais = paises.Item(dominio)
                Console.WriteLine("Pais Actual: " & pais)
                Console.Write("Ingrese Nuevo Pais: ")
                pais = Console.ReadLine()
                paises.Remove(dominio)
                paises.Add(pais, dominio)
                Console.WriteLine("Datos editados correctamente(Dominio: {0} Pais: {1}).", dominio, pais)
            End If
        Else
            Console.WriteLine("No existen paises para editar")
        End If
        Console.ReadKey()
    End Sub
    Private Sub EliminarPais(ByRef paises As Collection)
        If paises.Count <> 0 Then
            dominio = LeerTexto("Ingrese Dominio: ")
            If Not paises.Contains(dominio) Then
                Console.WriteLine("Pais no encontrado")
                Console.ReadKey()
            Else
                pais = paises.Item(dominio)
                Console.WriteLine("Datos eliminados correctamente(Dominio: {0} Pais: {1}).", dominio, pais)
                paises.Remove(dominio)
            End If
        Else
            Console.WriteLine("No existen paises para eliminar")
        End If
        Console.ReadKey()
    End Sub
    Private Sub EliminarTodo(ByRef paises As Collection)
        If paises.Count <> 0 Then
            paises.Clear()
            Console.WriteLine("Todos los datos fueron eliminados correctamente")
        Else
            Console.WriteLine("No existen paises para eliminar")
        End If
        Console.ReadKey()
    End Sub
    Sub MostrarPais(ByRef paises As Collection)
        If paises.Count <> 0 Then
            dominio = LeerTexto("Ingrese Dominio: ")
            If Not paises.Contains(dominio) Then
                Console.WriteLine("Pais no encontrado")
            Else
                pais = paises.Item(dominio)
                Console.WriteLine("Dominio: {0} Pais: {1}.", dominio, pais)
            End If
        Else
            Console.WriteLine("No existen paises para mostrar")
        End If
        Console.ReadKey()
    End Sub
    Sub MostrarTodo(ByRef paises As Collection)
        If paises.Count <> 0 Then
            For i = 1 To paises.Count
                pais = paises.Item(i)
                Console.WriteLine("Pais {0}: {1}", i, pais)
            Next
        Else
            Console.WriteLine("No existen paises para mostrar")
        End If
        Console.ReadKey()
    End Sub
    Function LeerTexto(mensaje As String) As String
        Dim ingreso As String
        Do
            Console.Write(mensaje)
            ingreso = Console.ReadLine()
            If ingreso = "" Then
                Console.Write("Ingrese nuevamente, valor nulo!.")
            End If
        Loop While ingreso = ""
        Return ingreso
    End Function
End Module