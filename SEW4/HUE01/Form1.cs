using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HUE01
{
    public partial class Form1 : Form
    {
        private int port1 = 8888;
        private UdpClient udpClient;
        private int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPEndPoint recieveAdr = new IPEndPoint(IPAddress.Any, port1);
            udpClient = new UdpClient(recieveAdr);
            this.RecieveAsync();
        }
        private async void RecieveAsync()
        {
            Messwert messwert = new Messwert();
            while (true)
            {
                UdpReceiveResult result = await udpClient.ReceiveAsync();
                this.txt_AktuelleTemperatur.Text = Encoding.UTF8.GetString(result.Buffer) + Environment.NewLine;

                if (i < 150)
                {
                    List.Add(txt_AktuelleTemperatur);
                    i++;
                }
                else
                {
                    i = 0;
                    messwert.MWList = List;
                    float mw = messwert.mw();
                    this.txt_MWTemp = mw.ToString();
                }
            }

        }

       
    }
}
