using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace DiceClient
{
    public class ClientCustomTCPConnect
    {
        private TcpClient client;
        private Stream stream;
        private byte[] dataOut;
        private byte[] dataIn = new byte[100];
        private string serverIP;
        private int port;

        public ClientCustomTCPConnect(string ip, int p)
        {
            serverIP = ip;
            port = p;
            client = new TcpClient();
        }

        
        //Set up a connection to server and get stream for communication
        public int ConnectToServer()
        {
            try
            {
                //connect to server
                client.Connect(serverIP, port);

                //get stream for receiving and sending data
                stream = client.GetStream();
            }
            catch
            {
                MessageBox.Show("Wrong Ip/Port or Server did't start yet, cannot init client!");
                return -1;
            }
            return 1;
        }


        //Send data to server after connection is setup
        public void SendData(string str)
        {
            try
            {
                ASCIIEncoding asen = new ASCIIEncoding();

                //encoding to bytes
                dataOut = asen.GetBytes(str);
                stream.Write(dataOut, 0, dataOut.Length);
            }
            catch
            {
                MessageBox.Show("Cannot send data!");
            }
        }

        //Receive data from server after connection is setup
        public string ReceiveData()
        {
            string result = null;
            try
            {
                
                dataIn = new byte[100];

                //receive data form server
                int k = stream.Read(dataIn, 0, 100);

                //convert
                for (int i = 0; i < k; i++)
                    result += Convert.ToChar(dataIn[i]);
            }
            catch
            {
            }
            return result;
        }

        public void CloseClient()
        {
            client.Close();
        }
    }
}