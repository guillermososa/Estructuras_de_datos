Module Pruebas
    'Métodos Collection : 
    '◦ Add(n,c): agrega un elemento.
    '◦ Clear(): elimina todos los elementos.
    '◦ Count: cantidad de elementos.
    '◦ Item(c): devuelve un elemento por su índice o clave.
    '◦ Remove(c): elimina un ítem.
    '◦ Contains(c): permite establecer si un elemento existe.

    'Métodos ArraList : 
    '◦ Add(e): agrega un elemento.
    '◦ Count: cantidad de elementos.
    '◦ Remove(e): elimina un elemento.
    '◦ Item (i): retorna un elemento por un índice dado
    '   ◦ (i): retorna un elemento por un índice dado
    '   ◦ Insert (i,e): Inserta un elemento en el índice especificado.
    '   ◦ Sort (): ordena los elementos.
    '   ◦ RemoveAt (i): Quita el elemento situado en el índice especificado.
    '   ◦ Reverse (): Invierte el orden de todos los elementos.
    '   ◦ IndexOf(e): devuelve el índice de un elemento especificado.

    'Métodos Hash Table:
    '◦ Add(n,c): agrega un elemento.
    '◦ Clear(): elimina todos los elementos.
    '◦ Count: cantidad de elementos.
    '◦ Item(c): devuelve un elemento por su índice o clave.
    '◦ Remove(c): elimina un ítem.
    '◦ Contains(c): permite establecer si un elemento existe.
    '   ◦ DictionaryEntry: tipo de dato que permite manipular un elemento de la coleccion con sus atributos.
    '   ◦ elemento.Key
    '   ◦ elemento.Value

    'Métodos Queue(FIFO) : 
    '◦ Count: cantidad de elementos.
    '   ◦ Enqueue(e): agrega un elemento a la coleccion.
    '   ◦ Dequeue(): obtiene y elimina un elemento de la coleccion.
    '   ◦ Peek(): obtiene un elemento de la coleccion.

    'Métodos Stack(LIFO) : 
    '◦ Count: cantidad de elementos.
    '   ◦ Push(e): agrega un elemento a la coleccion.
    '   ◦ Pop(): obtiene y elimina un elemento de la coleccion.
    '   ◦ Peek(): obtiene un elemento de la coleccion.
    Enum DiasSemana As Byte
        domingo
        lunes
        martes
        miercoles
        jueves
        viernes
        sabado
    End Enum

    Sub Main()
        Dim lista As New ArrayList
        Dim cantemp As Byte = 7
        For i As Byte = 1 To cantemp
            lista.Add({0, 0, 0, 0, 0, 0, 0})
        Next
        For empleado As Byte = 1 To cantemp
            Console.Write("Ingrese empleado " & empleado & " día " & DiasSemana.domingo.ToString)
            lista(empleado)(DiasSemana.domingo) = Console.ReadLine()
        Next
        For empleado As Byte = 1 To cantemp
            Console.WriteLine(lista(empleado)(DiasSemana.domingo))
        Next
        Console.ReadKey()
    End Sub
End Module