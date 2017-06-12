Module TP4_15_Turnos
    '4.15. Crear un algoritmo para dar turnos a clientes de un local 
    'de ventas varias donde los clientes ancianos y embarazadas tienen 
    'prioridad (Son atendidos tan pronto un empleado esté disponible):
    ' Cuando los compradores ingresan al local dan su nombre y quedan 
    'esperando ser llamados por un empleado. Si tienen prioridad pasan 
    'al tope de la lista excepto que en el tope ya exista alguien con 
    'prioridad en cuyo caso quedan en lugar del primer cliente que no 
    'tenga prioridad.
    ' Un empleado llama al próximo cliente para ser atendido el programa 
    'muestra su nombre y este sale de la lista
    ' Tener en cuenta que estos procesos pueden ser en cualquier orden.
    ' En todo momento informar la cantidad de clientes en espera y el 
    'nombre del siguiente cliente a ser atendido. Si no hay compradores 
    'en espera informar “Sin clientes”.
    ' Utilizar Linkedlist.
    Enum Opciones As Byte
        Salir
        SacarTurno
        LlamarProximo
    End Enum

    Sub Main()
        Dim Clientes As New Queue
        Dim Opcion As Byte
        Do
            Console.Clear()
            Console.WriteLine("0)Salir 1)Sacar Turno 2)Llamar Proximo")
            MostrarMensaje(Clientes.Count)
            Opcion = Val(Leer("Ingrese Opcion: "))
            Select Case Opcion
                Case Opciones.Salir
                    Opcion = 0
                Case Opciones.SacarTurno
                    SacarTurno(Clientes)
                Case Opciones.LlamarProximo
                    LlamarProximo(Clientes)
                Case Else
                    Console.WriteLine("Ingrese nuevamente, valor incorrecto!.")
            End Select
        Loop Until Opcion = 0
    End Sub

    Private Sub MostrarMensaje(Cantidad As Byte)
        Dim Mensaje As String
        Mensaje = "Cantidad de Clientes en espera: " & Cantidad
        If Cantidad = 0 Then
            Mensaje &= " (Sin Clientes)"
        End If
        Console.WriteLine(Mensaje)
    End Sub

    Private Sub SacarTurno(ByRef Clientes As Queue)
        Clientes.Enqueue(Leer("Ingrese su nombre: "))
        Console.WriteLine("Aguarde un momento por favor, será llamado por uno de los empleados.")
    End Sub

    Private Sub LlamarProximo(ByRef Clientes As Queue)
        If Not EsVacio(Clientes) Then
            Console.WriteLine("Proximo Cliente: " & Clientes.Dequeue())
            Console.ReadKey()
        End If
    End Sub

    Private Function Leer(mensaje As String) As String
        Console.Write(mensaje)
        Return Console.ReadLine
    End Function

    Private Function EsVacio(Clientes As Queue) As Boolean
        Return Clientes.Count = 0
    End Function
End Module