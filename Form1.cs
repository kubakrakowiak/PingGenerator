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
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    using (Ping p = new Ping())
                    {
                          string adres = ipadress.Text;
                          wynik.Items.Add(p.Send(adres).RoundtripTime.ToString() + "ms\n");
                    }
                }
            }
            catch (Exception )
            {
                wynik.Items.Add("Nie uzyskano odpowiedzi zwrotnej od hosta");
            }

        }


    }
}
