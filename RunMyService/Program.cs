using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using HelloServer;
using WcfHelloService;
using System.ServiceModel.Description;

namespace RunMyService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService)))
            {
                host.Open();
                DisplayHostInfo(host);
                Console.ReadLine();

                host.Close();
            }
        }
        static void DisplayHostInfo(ServiceHost host)
        {
            Console.WriteLine();
            Console.WriteLine("****** Host Info *******");
            foreach (System.ServiceModel.Description.ServiceEndpoint se
            in host.Description.Endpoints)
            {
                Console.WriteLine("Address: {0}", se.Address);
                Console.WriteLine("Binding: {0}", se.Binding.Name);
                Console.WriteLine("Contract: {0}", se.Contract.Name);
                Console.WriteLine();
            }
            Console.WriteLine("************************");
        }
    }
}
