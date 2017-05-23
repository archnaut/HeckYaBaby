using System;
using System.Data.Entity;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using Service;
using Service.Infrastructure;

namespace ConsoleHost
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new HeckYaBabyInitializer());

            var baseAddress =  new Uri("http://localhost:8989");

            using (var host = new WebServiceHost(typeof (HeckYaBabyService), baseAddress))
            {
                host.AddServiceEndpoint(typeof (IHeckYaBabyService), new WebHttpBinding(), "api/v1");
                
                host
                    .Description
                    .Behaviors
                    .Find<ServiceDebugBehavior>()
                    .HttpHelpPageEnabled = false;

                host.Open();

                Console.WriteLine($"The Heck Ya Baby Service is listenting at {baseAddress}");
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}
