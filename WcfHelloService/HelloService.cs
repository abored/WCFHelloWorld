using System;
using HelloServer;

namespace WcfHelloService
{
    public class HelloService : IHelloService
    {
        private static IHelloWorld myObject = new HelloWorld();
        private static IDBAccess dbObject = new DBAccess();
        public string SayHello(string s)
        {
            return myObject.SayHello(s);
        }

        public string GetNameID(int id)
        {
            return dbObject.GetNameID(id);
        }
    }
}
