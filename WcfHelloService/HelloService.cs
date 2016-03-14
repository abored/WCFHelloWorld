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

        public TripleOfInt addTriple(TripleOfInt t1, TripleOfInt t2)
        {
            t1.I1 += t2.I1;
            t1.I2 += t2.I2;
            t1.I3 += t2.I3;
            return t1;
        }
    }
}
