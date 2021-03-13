Module Module1

    Sub Main()
        Dim numeros(14) As Integer
        Dim media As Double = 0
        Dim suma As Double = 0

        Dim X(14) As Integer
        Dim nummax As Integer = 0
        Dim numero As Integer = 0
        Dim P As Integer = 0
        Dim j As Integer = 0
        Dim nummayor As Integer = 0

        Console.WriteLine("Bienvenido al programa ")

        For contador = 0 To 14 Step 1

            Console.WriteLine("Inserte un numero en la posición: " & contador + 1)
            numeros(contador) = Console.ReadLine()

            suma += numeros(contador)

        Next
        For contador = 0 To 14 Step 1
            X(contador) = 0

        Next
        For contador = 0 To 14 Step 1
            numero = numeros(contador)
            P = contador
            For j = contador To 15 - 1
                If (numeros(j) = numero) Then X(P) += 1

            Next

        Next
        nummayor = X(0)
        nummax = 0
        For contador = 0 To 14 Step 1
            If X(contador) > nummayor Then
                nummax = contador
                nummayor = X(contador)

            End If

        Next
        Console.WriteLine("La moda de los datos ingresados es : " & numeros(nummax))
        Console.ReadLine()

        media = suma / numeros.Length

        Console.WriteLine("La media de los datos ingresados es : " & media)
        Console.ReadLine()

        Array.Sort(numeros)
        Console.WriteLine("")
        Console.WriteLine("El numero mayor de los datos ingresados es : " & numeros(numeros.Length - 1))
        Console.WriteLine("")
        Console.WriteLine("El numero menor de los datos ingresados es : " & numeros(0))
        Console.WriteLine("")
        Console.WriteLine("Fin del programa")
        Console.ReadLine()

    End Sub


End Module
