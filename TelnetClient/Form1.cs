using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelnetClient
{
    // https://www.youtube.com/watch?v=ve2LX1tOwIM - errore in BtnConnect_Click(object sender, EventArgs e) corretto

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //System.Net.IPAddress ip = System.Net.IPAddress.Parse(TxtHost.Text);
                client.Connect(TxtHost.Text, Convert.ToInt32(TxtPort.Text));

                BtnConnect.Enabled = false;
                BtnClose.Enabled = true;
                BtnSend.Enabled = true;
                TxtHost.Enabled = false;
                TxtPort.Enabled = false;
                TxtMessages.Enabled = true;
            }
            catch (Exception)
            {
                TxtStatus.Text = "Error during connection... please check host and port...";
                TxtStatus.AppendText(Environment.NewLine);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            TxtStatus.Invoke((MethodInvoker)delegate ()
            {
                //TxtStatus.Text += e.MessageString;
                TxtStatus.Text += e.MessageString.Substring(0, e.MessageString.Length - 1);
                TxtStatus.AppendText(Environment.NewLine);
            });
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            //client.WriteLineAndGetReply(TxtMessages.Text, TimeSpan.FromSeconds(3));
            client.WriteLineAndGetReply(TxtMessages.Text, TimeSpan.FromSeconds(0));

            TxtMessages.Text = "";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            try
            {

                client.Disconnect();

                BtnConnect.Enabled = true;
                BtnClose.Enabled = false;
                BtnSend.Enabled = false;
                TxtHost.Enabled = true;
                TxtPort.Enabled = true;
                TxtMessages.Enabled = false;
                TxtMessages.Text = "";
            }
            catch (Exception)
            {
                TxtStatus.Text = "Error during closing connection...";
                TxtStatus.AppendText(Environment.NewLine);
            }
        }
    }
}
