Imports System.Data.Entity
Imports Backend.Infrastructure

Module ConsoleHost

    Sub Main()
        Console.Write("Initializing database...")

        Database.SetInitializer(new ContextInitializer)

        Console.WriteLine("Done!")
        Console.WriteLine("Press <Enter> to stop the service.")
        Console.ReadLine()

    End Sub

End Module
