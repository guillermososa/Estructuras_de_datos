Module TP4_14_Precio_Bebidas
    '4.14. Crear un algoritmo para administrar una lista de precios 
    'de bebidas: se conoce el nombre del artículo, código y precio.
    ' El algoritmo deberá poder agregar, editar, y borrar utilizando
    'el código como clave. Antes de agregar verificar que el código
    'no exista y antes de editar o borrar verificar que exista.
    ' También disponer una opción que liste los artículos ordenados
    'por su nombre
    Private codigo, articulo As String
    Private precio As Single

    Enum Opciones As Byte
        salir
        agregar
        editar
        eliminar
        eliminartodo
        mostrar
    End Enum

    Sub Main()
        Dim articulos As New Collection
        Dim precios As New Collection
        Dim opcion As Byte
        Do
            Console.Clear()
            Console.WriteLine("0) Salir 1) Agregar 2)Editar 3)Eliminar 4)Eliminar todo 5)Mostrar")
            Console.WriteLine("Cantidad de articulos cargados " & articulos.Count)
            Console.Write("Ingrese Opcion: ")
            opcion = Val(Console.ReadLine())
            Select Case opcion
                Case Opciones.salir
                    opcion = 0
                Case Opciones.agregar
                    Agregar(articulos, precios)
                Case Opciones.editar
                    Editar(articulos, precios)
                Case Opciones.eliminar
                    Eliminar(articulos, precios)
                Case Opciones.eliminartodo
                    EliminarTodo(articulos, precios)
                Case Opciones.mostrar
                    Mostrar(articulos, precios)
                Case Else
                    Console.WriteLine("Ingrese nuevamente, valor incorrecto!.")
            End Select
        Loop Until opcion = 0
    End Sub

    Private Sub Agregar(ByRef articulos As Collection, ByRef precios As Collection)
        codigo = LeerTexto("Ingrese codigo: ")
        If articulos.Contains(codigo) Then
            Console.WriteLine("articulo ya existe!.")
        Else
            articulo = LeerTexto("Ingrese articulo: ")
            precio = LeerTexto("Ingrese precio: ")
            articulos.Add(articulo, codigo)
            precios.Add(precio, codigo)
            Console.WriteLine("Datos guardados correctamente(codigo: {0} articulo: {1} precio: {2}).", codigo, articulo, precio.ToString("###0.00"))
        End If
        Console.ReadKey()
    End Sub

    Private Sub Editar(ByRef articulos As Collection, ByRef precios As Collection)
        If Existen(articulos.Count) Then
            codigo = LeerTexto("Ingrese codigo: ")
            If Not articulos.Contains(codigo) Then
                Console.WriteLine("articulo no encontrado!.")
            Else
                articulo = articulos.Item(codigo)
                precio = precios.Item(codigo)
                Console.WriteLine("articulo Actual: " & articulo)
                Console.WriteLine("precio Actual: " & precio)
                Console.Write("Ingrese Nuevo articulo: ")
                articulo = Console.ReadLine()
                Console.Write("Ingrese Nuevo precio: ")
                precio = Console.ReadLine()
                articulos.Remove(codigo)
                precios.Remove(codigo)
                articulos.Add(articulo, codigo)
                precios.Add(precio, codigo)
                Console.WriteLine("Datos editados correctamente(codigo: {0} articulo: {1} precio: {2}).", codigo, articulo, precio.ToString("###0.00"))
            End If
        End If
        Console.ReadKey()
    End Sub

    Private Sub Eliminar(ByRef articulos As Collection, ByRef precios As Collection)
        If Existen(articulos.Count) Then
            codigo = LeerTexto("Ingrese codigo: ")
            If Not articulos.Contains(codigo) Then
                Console.WriteLine("articulo no encontrado!.")
                Console.ReadKey()
            Else
                articulo = articulos.Item(codigo)
                precio = precios.Item(codigo)
                articulos.Remove(codigo)
                precios.Remove(codigo)
                Console.WriteLine("Datos eliminados correctamente(codigo: {0} articulo: {1} precio: {2}).", codigo, articulo, precio.ToString("###0.00"))
            End If
        End If
        Console.ReadKey()
    End Sub

    Private Sub EliminarTodo(ByRef articulos As Collection, ByRef precios As Collection)
        If Existen(articulos.Count) Then
            articulos.Clear()
            precios.Clear()
            Console.WriteLine("Todos los datos fueron eliminados correctamente!.")
        End If
        Console.ReadKey()
    End Sub

    Sub Mostrar(ByRef articulos As Collection, ByRef precios As Collection)
        If Existen(articulos.Count) Then
            Dim ArticulosOrdenados As New SortedList(Of String, Double)
            For i As Integer = 1 To articulos.Count
                ArticulosOrdenados.Add(articulos(i), precios(i))
            Next
            Console.WriteLine("Articulos Guardados: ")
            For Each elemento As KeyValuePair(Of String, Double) In ArticulosOrdenados
                Console.WriteLine("articulo: {0} precio: {1}).", elemento.Key, elemento.Value.ToString("###0.00"))
            Next
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

    Private Function Existen(contenido As Boolean) As Boolean
        If contenido = 0 Then
            Console.WriteLine("No existen articulos!.")
            Return False
        Else
            Return True
        End If
    End Function
End Module