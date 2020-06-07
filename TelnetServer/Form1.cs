using SimpleTCP;
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

namespace TelnetServer
{
    // https://www.youtube.com/watch?v=ve2LX1tOwIM - errore in BtnStart_Click(object sender, EventArgs e) corretto
    // https://stackoverflow.com/questions/45268898/c-sharp-client-server-chat-app-using-simpletcp-nuget-package

    public partial class TelnetServer : Form
    {
        public TelnetServer()
        {
            InitializeComponent();
        }
        SimpleTcpServer server;

        private void TelnetServer_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            //server.Delimiter = 0x13;//enter
            server.Delimiter = 0x0a;

            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;

        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            TxtStatus.Invoke((MethodInvoker)delegate ()
            {
                //TxtStatus.Text += e.MessageString;
                TxtStatus.Text += e.MessageString.Substring(0, e.MessageString.Length - 1);
                TxtStatus.AppendText(Environment.NewLine);
                //e.ReplyLine(String.Format("You said: {0}", e.MessageString));
                server.Broadcast(e.MessageString);
            });
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                System.Net.IPAddress ip = System.Net.IPAddress.Parse(TxtHost.Text);
                //System.Net.IPAddress ip = new System.Net.IPAddress(long.Parse(TxtHost.Text));
                server.Start(ip, Convert.ToInt32(TxtPort.Text));

                TxtStatus.Text = "Server starting...";
                TxtStatus.AppendText(Environment.NewLine);

                BtnStart.Enabled = false;
                BtnStop.Enabled = true;
                TxtHost.Enabled = false;
                TxtPort.Enabled = false;

            }
            catch (Exception)
            {
                TxtStatus.Text = "Error during starting... please check host and port...";
                TxtStatus.AppendText(Environment.NewLine);
            }   

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            BtnStart.Enabled = true;
            BtnStop.Enabled = false;
            TxtHost.Enabled = true;
            TxtPort.Enabled = true;

            if (server.IsStarted)
                server.Stop();

            TxtStatus.Text = "Server stopped... ";
            TxtStatus.AppendText(Environment.NewLine);
        }
    }
}
