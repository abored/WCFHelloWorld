using System;
using HelloServer;

namespace WcfHelloService
{
    public class HelloService : IHelloService
    {
        private static IHelloWorld myObject = new HelloWorld();
        public string SayHello(string s)
        {
            return myObject.SayHello(s);
        }
    }
}
