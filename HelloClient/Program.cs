using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClient
{
    class Program
    {
        static RemoteHelloReference.IHelloService helloObj = new RemoteHelloReference.HelloServiceClient();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine(helloObj.SayHello(name));
            Console.ReadLine();
        }
    }
}
