Module TP4_08_Paises
    '4.8. Elaborar un algoritmo que cargue programáticamente nombre de países y 
    'su dominio de país en una Hashtable y permita realizar consultas por el 
    'nombre de dominio
    ' se introduce el nombre del dominio y se deberá mostrar el nombre del país
    ' Informar si la clave no existe con un mensaje.
    ' Salir cuando el valor ingresado es vacío.
    Sub Main()
        Dim paises As New Hashtable
        CargarPaises(paises)
        Dim dominio, pais As String
        Do
            Console.Clear()
            dominio = Leer("Ingrese dominio: ")
            If Not EsVacio(dominio) Then
                If ExisteClave(paises, dominio) Then
                    pais = paises.Item(dominio)
                    Console.WriteLine(pais)
                End If
                Console.ReadKey()
            End If
        Loop Until EsVacio(dominio)
    End Sub

    Private Sub CargarPaises(ByRef paises As Hashtable)
        paises.Add("ar", "Argentina")
        paises.Add("cl", "Chile")
        paises.Add("br", "Brasil")
        paises.Add("py", "Paraguay")
        paises.Add("co", "Colombia")
    End Sub

    Private Function Leer(mensaje As String) As String
        Console.Write(mensaje)
        Return Console.ReadLine()
    End Function

    Private Function EsVacio(valor As String) As Boolean
        Return valor.Length = 0
    End Function

    Private Function ExisteClave(paises As Hashtable, clave As String) As Boolean
        If Not paises.ContainsKey(clave) Then
            Console.WriteLine("Clave no existe!, reingrese...")
            Return False
        Else
            Return True
        End If
    End Function
End Module