using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace NowinWebServer
{
    internal interface IServerParameters
    {
        IConnectionAllocationStrategy ConnectionAllocationStrategy { get; }
        IPEndPoint EndPoint { get; }
        X509Certificate Certificate { get; }
        int BufferSize { get; }
        Func<IDictionary<string, object>, Task> OwinApp { get; }
    }
}