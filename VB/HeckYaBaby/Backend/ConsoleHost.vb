Imports System.Data.Entity
Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.ServiceModel.Web
Imports Backend.Infrastructure
Imports Backend.Presentation

Module ConsoleHost

    Sub Main()
        InitializeDatabase()

        Dim baseAddress = new Uri("http://localhost:8989")

        Using host As New WebServiceHost(GetType(HeckYaBabyService), baseAddress) 

            Console.Write("Starting service...")

            Dim endpoint  = host.AddServiceEndpoint(GetType(IHeckYaBabyService), New WebHttpBinding(), "api/v1")

            endpoint.Behaviors.Add(new WebHttpBehavior With { .AutomaticFormatSelectionEnabled = True })

            ' WARNING! WARNING! WARNING!
            ' Allows for testing but circumvents security
            ' TODO: Implement CORS securely
            ' https://code.msdn.microsoft.com/Implementing-CORS-support-c1f9cd4b
            endpoint.Behaviors.Add(new CorsEndpointBehavior("*")) 

            host.
                Description.
                Behaviors.
                Find(Of ServiceDebugBehavior).
                HttpHelpPageEnabled = false

            host.Open()

            Console.WriteLine("The Heck Ya Baby service is listening at {0}", baseAddress)
            Console.WriteLine("Press <Enter> to stop the service.")
            Console.ReadLine()

            host.Close()

        End Using

    End Sub

    Private Sub InitializeDatabase()

        Console.Write("Initializing database...")

        Database.SetInitializer(new ContextInitializer)

        Console.WriteLine("Done!")

    End Sub
End Module