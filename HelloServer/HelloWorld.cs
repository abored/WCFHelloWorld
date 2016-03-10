using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloServer
{
    public class HelloWorld : IHelloWorld
     {
        public string SayHello(string s)
        {
            return $"Hello {s}";
        }
    }
}
