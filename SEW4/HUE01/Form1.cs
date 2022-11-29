using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private float ausgabe = 0;
        float temp = 0;
        float average = 0;
        double average2 = 0;
        double ausgabe2 = 0;
        private DateTime time = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
              
        }

        private async void RecieveAsync()
        {        
            List<Messwert> mwlist = new List<Messwert>();

            IPEndPoint recieveAdr = new IPEndPoint(IPAddress.Any, port1);
            udpClient = new UdpClient(recieveAdr);

            while (true)
            {
                UdpReceiveResult result = await udpClient.ReceiveAsync();
           
                ausgabe = float.Parse(Encoding.UTF8.GetString(result.Buffer) + Environment.NewLine, CultureInfo.InvariantCulture); // hilfe von Raphael Völker
                ausgabe2 = Math.Round(ausgabe, 0);
                this.txt_AktuelleTemperatur.Text = ausgabe2.ToString() + Environment.NewLine + " °C";
                i++;

                Messwert messwert = new Messwert(ausgabe, time);
                mwlist.Insert(0,messwert);

                if (i > 150)
                {
                    mwlist.RemoveAt(150);
                    
                    i--;
                    foreach (Messwert item in mwlist)
                    {
                        temp += item.Messwert1;

                    }
                    
                   average = temp / 150;
                   average2 = Math.Round(average,0);
                   this.txt_MWTemp.Text = average2.ToString() + " °C";
                   average = 0;
                   temp = 0;
                }
            
            }
        }


        private void btn_readData_Click_1(object sender, EventArgs e)
        {        
            this.RecieveAsync();
        }
    }
}
