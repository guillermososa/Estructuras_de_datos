Module TP4_06_Planta_de_Chipas
    '4.6. Se tiene la producción de los 7 días de la semana de una planta 
    'de chipas con varios empleados. Escribir un algoritmo que permita 
    'ingresar cantidad de productos producidos por cada empleado en un día 
    'especificado. La producción de cada empleado puede ser ingresadas 
    'varias veces por día. Luego de cada ingreso totalizar los ingresos por 
    'empleado y por día. Los empleados están cargados programáticamente e 
    'identificados por una clave que es su nombre abreviado. Utilizar 
    'ArrayList y Collection.
    Sub Main()
        Dim productos As New ArrayList
        Dim empleados As New Collection
        empleados.Add("Guillermo Sosa", "guille")
        empleados.Add("Paula Bustos", "pau")
        empleados.Add("Juan Perez", "juan")
        empleados.Add("Cristian Chavez", "cris")
    End Sub
End Module