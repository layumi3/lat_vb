Module Module1

    Sub Main()
        Console.Title = "Conversion Fahrenthait to Celcius"
        Dim fahrenhait As Single, Celcius As Single
        Dim city As String

        Console.Write("Enter the City : ")
        city = Console.ReadLine()

        Console.Write("Enter the Temperature in Fahrenhait : ")
        fahrenhait = Console.ReadLine()

        Celcius = Math.Round((fahrenhait + 40) * 5 / 9 - 40, 1)

        Console.WriteLine("The Temperature in {0} , {1}in fahrenhait  {2} in Celcius ",
        city, fahrenhait, Celcius)

        Console.ReadKey()


    End Sub

End Module
