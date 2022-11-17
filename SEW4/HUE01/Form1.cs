﻿using System;
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
                this.txt_AktuelleTemperatur.Text = Encoding.UTF8.GetString(result.Buffer) + Environment.NewLine + " °C";               

                ausgabe = float.Parse(Encoding.UTF8.GetString(result.Buffer) + Environment.NewLine, CultureInfo.InvariantCulture); // hilfe von Raphael Völker
                i++;

                Messwert messwert = new Messwert(ausgabe, time);
                mwlist.Insert(0,messwert);

                if (i > 10)
                {
                    mwlist.RemoveAt(10);
                    
                    i--;
                    foreach (Messwert item in mwlist)
                    {
                        temp += item.Messwert1;

                    }
                    
                   average = temp / 10;
                   average2 = Math.Round(average,2);
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