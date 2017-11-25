using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace DiceServer
{
    public class ServerCustomTCPConnect
    {
        private IPAddress ipAd;
        private int port;
        private TcpListener server;

        public ServerCustomTCPConnect(string ip, int p)
        {
            ipAd = IPAddress.Parse(ip);
            port = p;
            server = new TcpListener(ipAd, port);
        }

        public void Listen()
        {
            try
            {
                server.Start();
            }
            catch
            {
                MessageBox.Show("Cannot start Server/Check the input!");
            }
        }

        //listening for a new connection
        public Socket Listen(ref int status)
        {
            Socket socket = server.AcceptSocket();

            status = 1;

            return socket;
        }

        public void CloseServer()
        {
            server.Stop();
        }
    }
}