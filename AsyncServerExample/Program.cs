using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace AsyncServerExample
{
    class AsyncServer
    {
        IPEndPoint endP;
        Socket socket;
        public AsyncServer(string strAddr, int port)
        {
            endP = new IPEndPoint(IPAddress.Parse(strAddr), port);
        }
        void MyAcceptCallbarFunction(IAsyncResult ia)
        {
            Socket socket = (Socket)ia.AsyncState;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
