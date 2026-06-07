using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace SrvTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nPort = 4444;
            TcpListener tcpListener = new TcpListener(IPAddress.Any, nPort);
            tcpListener.Start();

            var cert = new X509Certificate2("server.pfx", "password");
        }
    }
}
