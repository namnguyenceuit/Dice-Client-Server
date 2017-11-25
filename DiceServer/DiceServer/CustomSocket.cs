using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace DiceServer
{
    public class CustomSocket
    {
        private Socket socket;
        private byte[] dataIn;
        private string remoteEndPoint;

        public CustomSocket(Socket s)
        {
            socket = s;
            dataIn = new byte[100];
        }
        public CustomSocket(Socket s, int length)
        {
            socket = s;
            dataIn = new byte[length];
        }

        //get the IP and port of connected client throught endpoint
        public string GetRemoteEndpoint()
        {
            string str = "";
            try
            {
                str = Convert.ToString(socket.RemoteEndPoint);
                remoteEndPoint = str;
            }
            catch
            {
                MessageBox.Show("Cannot get the enpoint...!");
            }
            return str;
        }


        //receive data from client
        public string ReceiveData()
        {
            //server just can receive data AFTER a connection is set up between server and client
            string result = "";
            try
            {
                //count the length of data received (maximum is 100 bytes)
                int k = socket.Receive(dataIn);
                
                //convert the byte recevied into string
                
                for (int i = 0; i < k; i++)
                    result += Convert.ToChar(dataIn[i]);
                
            }
            catch
            {
            }
            return result;
        }

        //send data to client
        public void SendData(string str)
        {
            try
            {
                ASCIIEncoding asen = new ASCIIEncoding();
                socket.Send(asen.GetBytes(str));
            }
            catch 
            {
                MessageBox.Show("Can't send data!");
            }
        }
        //close sockket
        public void CloseSocket()
        {
            socket.Close();
        }
    }
}