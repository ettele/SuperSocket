using System;
using System.IO.Pipelines;
using System.Net;
using System.Threading.Tasks;

namespace SuperSocket.NetSocket
{
    public class NetSocketPipeConnectionListener : IPipeConnectionListener
    {
        public void OnConnection(Func<IPipeConnection, Task> callback)
        {
            throw new NotImplementedException();
        }

        public void Start(IPEndPoint endpoint)
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}