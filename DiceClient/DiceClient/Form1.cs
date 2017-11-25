using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceClient
{
    public partial class DiceClient : Form
    {
        private ClientCustomTCPConnect tcpPlayer;
        private ClientCustomTCPConnect tcpOpponent;

        /*-----------------------------------------*/

        public DiceClient()
        {
            InitializeComponent();
        }

        private void DiceClient_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            Init_Client();
            btnConnect.Enabled = false;
            Thread opp = new Thread(OpponentResult);
            opp.Start();
        }

        
        private void Init_Client()
        {
            //get ip & port input
            string ipAd = ipAdtb.Text;
            int port = int.Parse(porttb.Text);

            tcpPlayer = new ClientCustomTCPConnect(ipAd, port);
            tcpPlayer.ConnectToServer();

            tcpOpponent = new ClientCustomTCPConnect(ipAd, port);
            tcpOpponent.ConnectToServer();            
        }

        public void OpponentResult()
        {
            while (true)
            {
                string str = tcpOpponent.ReceiveData();
                score2tb.Text = str;
            }
        }

        private void DiceClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                tcpPlayer.CloseClient();
            }
            catch
            {
                //do nothing
            }
        }

        private void btnBounce_Click(object sender, EventArgs e)
        {
            tcpPlayer.SendData("Rolled");
            string str = tcpPlayer.ReceiveData();
            score1tb.Text = str;
        }
    }
}
