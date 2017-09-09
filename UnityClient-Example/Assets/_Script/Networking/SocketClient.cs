using System.Net;
using System.Net.Sockets;

namespace ClientSocket
{
    public class SocketClient
    {
        private Socket socket;

        private string ip;
        private short port;

        public SocketClient()
        {

        }

        public SocketClient(string ip, short port)
        {
            this.ip = ip;
            this.port = port;

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            socket.Connect(endPoint);
        }

        public void Run()
        {

        }


        public Socket Soscket
        {
            get { return socket; }
        }
    }
}
