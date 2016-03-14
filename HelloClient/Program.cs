using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HelloClient.RemoteHelloReference;

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
            TripleOfInt t1 = new TripleOfInt();
            TripleOfInt t2 = new TripleOfInt();
            t1.I1 = 1;
            t1.I2 = 2;
            t1.I3 = 3;

            t2.I1 = 433;
            t2.I2 = 1;
            t2.I3 = 22;

            TripleOfInt t3 = helloObj.addTriple(t1, t2);
            Console.WriteLine(t3.I1.ToString() + ", " + t3.I2.ToString() + ", " + t3.I3.ToString());
            Console.ReadLine();


        }
        async static void GetName(int id)
        {
            string result = await helloObj.GetNameIDAsync(id);
            Console.WriteLine(result);
        }
    }
}
