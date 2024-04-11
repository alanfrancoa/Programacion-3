Module Module1

    Sub Main()

        'Definicion de Variables (VB es de tipado debil)'
        Dim numerito = 5

        numerito = "7"

        Console.WriteLine(numerito)

        'Captura de Variables desde teclado'
        Console.WriteLine("Por favor ingrese un numero: ")
        Dim respuesta As Integer = Console.ReadLine()

        'Concatenacion de variables'
        Console.WriteLine($"Usted ingreso el numero: {respuesta}")

        'IF'
        If respuesta = 0 Then
            Console.WriteLine("El numero que ingresaste es cero")
        End If

        If respuesta = 0 Then
            Console.WriteLine("El numero que ingresaste es cero")
        Else
            Console.WriteLine("El numero que ingresaste no es cero")
        End If

        Dim esPar As Boolean = (respuesta Mod 2 = 0)
        Dim esPositivo As Boolean = (respuesta > 0)

        'En VB, no utilizamos && o ||, para logica preposicional utilizamos los operadores AND o OR'
        If esPar And esPositivo Then
            Console.WriteLine("El numero es par y positivo")
        ElseIf Not esPositivo And esPar Then
            Console.WriteLine("El numero negativo y es par")
        Else
            Console.WriteLine("El es positivo y no es par")
        End If

        'Switch (Select)'

        Select Case numerito
            Case 1
                Console.WriteLine("El número es 1")
            Case 2
                Console.WriteLine("El número es 2")
            Case 3
                Console.WriteLine("El número es 3")
            Case Else
                Console.WriteLine("El número no es 1, 2 o 3")
        End Select

        'Definicion de Vectores, en VB no hay corchetes para este caso, se define su posicion o longitud con ()'

        Dim vecty(5) As String

        vecty(0) = "Chicho"

        Console.WriteLine($"Vecty(0): {vecty(0)}")

        'Definicion de Listas, las siguientes lineas de codigo son equivalentes'
        Dim listita As List(Of String) = New List(Of String)
        Dim listitaPiola As New List(Of String)

        'Asignar valores en Lista, las siguientes expresiones son equivalentes'
        listitaPiola.Add("Hola")
        listitaPiola.Add("Mundo")
        listitaPiola.Add("Esto")
        listitaPiola.Add("Es")
        listitaPiola.Add("Una")
        listitaPiola.Add("Lista")

        Dim listitaMasPiola As New List(Of String) From {"Hola", "Mundo", "Esto", "Es", "Una", "Lista"}

        'Bucle While'
        While 1 < 5
            Console.WriteLine("Entre al while")
            Exit While 'No tenemos return, en VB usamos Exit y definimos de donde estamos saliendo en este caso del while'
        End While

        'Bucle For'
        For i = 1 To 10
            Console.WriteLine(i)
        Next 'El bucle se cierra con Next, que seria la siguiente iteracion'

        'Do while'
        Do While 1 < 5
            Console.WriteLine("Entre al do while")
            Exit Do 'Para salir utilizamos Exit, en este caso del Do'
        Loop

        'For Each'
        For Each elemento In listitaPiola
            Console.WriteLine(elemento)
        Next

        Console.ReadLine()

    End Sub

End Module
