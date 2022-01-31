using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using GettingStarted;
namespace GettingStartedHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/GettingStarted/");

            ServiceHost selfHost = new ServiceHost(typeof(Service1), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "Калькулятор");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                selfHost.Open();
                Console.WriteLine("Служба запущена?");

                Console.ReadKey();
                selfHost.Close();
            }
            catch (CommunicationException e)
            {
                Console.WriteLine("Ошибка {0}", e.Message);
                selfHost.Abort();
            }
        }
    }
}
