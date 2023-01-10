Imports System
Module Interest
    Public deposit, rate As Double
    Sub Main()
        Dim Year1, Year2 As Double
        rate = 0.02
        deposit = 10000

        Year1 = deposit * (1 + rate)
        REM Console.WriteLine("First year = {0}", year1)
        Console.WriteLine("First year = {0}", Year1)
        Year2 = Year1 * (1 + rate)
        Console.WriteLine('Second year = {0:C}', Year2)
        Console.ReadLine()
    End Sub

End Module
