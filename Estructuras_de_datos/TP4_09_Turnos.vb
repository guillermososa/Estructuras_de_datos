Module TP4_09_Turnos
    '4.9. Crear un programa para dar tunos a los compradores de una tienda por 
    'orden de llegada.
    ' Cuando los compradores ingresan al local dan su nombre y quedan esperando 
    'ser llamados por un empleado.
    ' Un empleado llama al próximo cliente para ser atendido el programa muestra 
    'su nombre y este sale de la lista
    ' Tener en cuenta que estos procesos pueden ser en cualquier orden.
    ' Si no hay compradores en espera informar “Sin clientes”.
    ' En todo momento informar la cantidad de clientes en espera.
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
            Console.WriteLine("0)Salir 1)Sacar Turno 2) Llamar Proximo")
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
        Console.WriteLine("Proximo Cliente: " & Clientes.Dequeue())
        Console.ReadKey()
    End Sub

    Private Function Leer(mensaje As String) As String
        Console.Write(mensaje)
        Return Console.ReadLine
    End Function
End Module