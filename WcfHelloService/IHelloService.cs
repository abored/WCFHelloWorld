using System.ServiceModel;
using HelloServer;

namespace WcfHelloService
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract] 
        string SayHello(string s);

        [OperationContract]
        string GetNameID(int id);

        [OperationContract]
        TripleOfInt addTriple(TripleOfInt t1, TripleOfInt t2);
    }
}
