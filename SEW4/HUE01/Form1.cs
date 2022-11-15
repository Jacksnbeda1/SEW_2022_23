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
        private int i = 0;
        private UdpClient udpClient;
        private int port1 = 8888;
        public Form1()
        {
            InitializeComponent();
                  

        }

        private async void RecieveAsync()
        {
            Messwert messwert = new Messwert();
            IPEndPoint recieveAdr = new IPEndPoint(IPAddress.Any, port1);
            udpClient = new UdpClient(recieveAdr);

            while (true)
            {
                UdpReceiveResult result = await udpClient.ReceiveAsync();
                this.txt_AktuelleTemperatur.Text = Encoding.UTF8.GetString(result.Buffer) + Environment.NewLine;
            
            }
        }


        private void btn_readData_Click_1(object sender, EventArgs e)
        {        
            this.RecieveAsync();
        }
    }
}
