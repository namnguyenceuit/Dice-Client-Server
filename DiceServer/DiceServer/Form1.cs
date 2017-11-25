using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceServer
{
    public partial class DiceServer : Form
    {
        /*Declare data structure*/

        private ServerCustomTCPConnect server;
        private CustomSocket[] socket1;
        private CustomSocket[] socket2;

        //declare for current socket
        private int curr;

        /*----------------*/
        

        public DiceServer()
        {
            InitializeComponent();
        }

        private void DiceServer_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Init_Server();

            Thread t = new Thread(ListenAndServe);
            t.Start();
        }

        /*Init Server*/
        public void Init_Server()
        {
            string ipAd = ipAdtb.Text;
            int port = int.Parse(porttb.Text);

            server = new ServerCustomTCPConnect(ipAd, port);

            server.Listen();

            btnStart.Enabled = false;
        }

        //Listen for clients
        public void ListenAndServe()
        {
            socket1 = new CustomSocket[2];
            socket2 = new CustomSocket[2];

            for (int i = 0; i < 2; i++)
            {
                ServeAClient();
            }
        }

        public void Accept()
        {
            int status = -1;
            Socket s = server.Listen(ref status);
            socket1[curr] = new CustomSocket(s);
            string str = socket1[curr].GetRemoteEndpoint();
            string str1 = str + " connected" + Environment.NewLine; 
            connectionManagertb.AppendText(str1);
        }

        public void AcceptAnother()
        {
            int status = -1;
            Socket s = server.Listen(ref status);
            socket2[curr] = new CustomSocket(s);
        }

        public void ServeAClient()
        {
            Accept();
            AcceptAnother();

            //increase current client
            curr++;


            Thread t = new Thread(Commmunication);
            t.Start(curr - 1);
        }

        //Show & send data
        public void Commmunication(object obj)
        {
            int id = (Int32)obj;
            while (true)
            {
                string str = socket1[id].ReceiveData();
                


                Random rnd = new Random();
                int num = rnd.Next(1, 6);
                string result = num.ToString();
                clientCommunicationtb.AppendText("Client " + id + " " + str + "ed out: " + result + Environment.NewLine);
                broadcast(id, result);
            }
        }
        public void broadcast(int id, string result)
        {
            socket1[id].SendData(result);
            if (id == 0)
            {
                socket2[1].SendData(result);
                return;
            }
            socket2[0].SendData(result);
        }

       
        private void DiceServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                server.CloseServer();
            }
            catch
            {
                //do nothing
            }
        }
    }
}
