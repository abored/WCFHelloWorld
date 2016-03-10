using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloClient
{
    class Program
    {
        static RemoteHelloReference.IHelloService helloObj = new RemoteHelloReference.HelloServiceClient();

        static void Main(string[] args)
        {
            Console.WriteLine("Indtast ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            GetName(id);
            Console.WriteLine("First call");
            GetName(id + 1);
            Console.WriteLine("Second call");
            GetName(id + 2);
            Console.WriteLine("Third call");
            Console.ReadLine();
            

        }

        async static void GetName(int id)
        {
            string result = await helloObj.GetNameIDAsync(id);
            Console.WriteLine(result);
        }
    }
}
