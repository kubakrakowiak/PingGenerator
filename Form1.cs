using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;

namespace nauka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuRange1_RangeChanged(object sender, EventArgs e)
        {
            int ilosc = pasek_count.RangeMax - pasek_count.RangeMin;
            ilosc_pakietow_label.Text = ilosc.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int kolo = 100;
            kolo = kolo / 10;
            int ilosc = pasek_count.RangeMax - pasek_count.RangeMin;
            int packet_size=pasek_packet_size.RangeMax-pasek_packet_size.RangeMin;
            try
            {
                for (int i = 0; i < ilosc; i++)
                {
                    using (Ping p = new Ping())
                    {
                        
                        string adres = ipadress.Text;
                        wynik.Items.Add(p.Send(adres, 255, BitConverter.GetBytes(packet_size)).RoundtripTime.ToString() + "ms\n, pakiet o wielkości = " + packet_size);
                    }
                    Thread.Sleep(100);

                }
            }
            catch (Exception )
            {
                wynik.Items.Add("Nie uzyskano odpowiedzi zwrotnej od hosta");
            }

        }

        private void pasek_packet_size_RangeChanged(object sender, EventArgs e)
        {
            int wielkosc = pasek_packet_size.RangeMax - pasek_packet_size.RangeMin;
            wielkosc_pakietu_label.Text = wielkosc.ToString();
        }
    }
}
