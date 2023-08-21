Module Module1

    Sub Main()

        'Dim miVariable As String = "Valor De La Variable"
        ''miVariable = miVariable.ToUpper()
        'miVariable = miVariable.ToLower()
        'Console.WriteLine(miVariable)

        'Dim miCorreo As String = "CorreoInstitucional@unab.edu.com"
        'miCorreo = miCorreo.Replace(".com", ".sv")

        'Dim otravariable = "Para aprender programar, hay que practicar"
        'otravariable = otravariable.Replace("Practicar", "Programar")
        'Console.WriteLine(miCorreo)

        ''cambio del tipo de dato Strig a numericos
        'Dim numString1 = "11"
        'Dim numstring2 = "12"
        'Dim resultado = numString1 + numstring2
        'Console.WriteLine(resultado)

        'Dim numInt1 = Integer.Parse(numString1)
        'Dim numInt2 = Integer.Parse(numstring2)
        'Dim resultadoInt = numInt1 + numInt2
        'Console.WriteLine(resultadoInt)


        'Dim numString3 = "33.78"
        'Dim numstring4 = "15.67"
        'Dim numDouble1 = Double.Parse(numString3)
        'Dim numDouble2 = Double.Parse(numstring4)
        'Dim resultadoDouble = numDouble1 + numDouble2
        'Console.WriteLine(resultadoDouble)

        'Dim numFloat1 = Single.Parse(numString3)
        'Dim numFloat2 = Single.Parse(numstring4)
        'Dim resultadoFloat = numFloat1 + numFloat2
        'Console.WriteLine(resultadoFloat)

        'Dim a = True
        'Dim b = False
        ''Dim res = a 0r b
        'Dim res = a And b
        'Console.WriteLine(res)
        'Dim res2 = Not a
        'Console.WriteLine(res2)

        ''Difiniendo Constantes
        'Const PI = 3.1416
        'Const SEMANA = 52, MESES = 12, DIASSEMANA = 7
        'Dim PI2 = PI * 2
        'Console.WriteLine(PI2)



        Dim num1 = 3
        Dim num2 = 5

        Dim suma = num1 + num2

        Dim resta = num1 - num2
        Console.WriteLine(suma)
        Console.WriteLine(resta)

        Dim divicion As Single = num1 / num2
        Console.WriteLine(divicion)

        Dim residuo = num1 Mod num2
        Console.WriteLine(residuo)

        Dim multi = num1 * num2
        Console.WriteLine(multi)


        Saludar()
        Console.WriteLine("Listo para el Laboratorio #1")


    End Sub

    Public Sub Saludar()
        Console.WriteLine("Hola estudiantes de Programación II")

    End Sub



End Module
