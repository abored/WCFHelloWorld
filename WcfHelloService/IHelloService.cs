using System.ServiceModel;

namespace WcfHelloService
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        string SayHello(string s);
    }
}
