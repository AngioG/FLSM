using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLSM
{
    public partial class Form1 : Form
    {
        char classe = default;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            List<Sottorete> eleSr = new List<Sottorete>();

            double bitSubnet = default;
            int dimensioneRete = default;

            classe = 'C';
            if (numIp1.Value < 192) classe = 'B';
            if (numIp1.Value < 128) classe = 'A';

            double bitHost = default;
            if (radioSottoreti.Checked)
            {
                bitHost = Math.Ceiling(Math.Log((double)numSottoreti.Value, 2));
            }

            if (radioHost.Checked)
            {
                int maxhost = default;
                if (classe == 'A') maxhost = (int)Math.Pow(2, 24) - 2;
                if (classe == 'B') maxhost = (int)Math.Pow(2, 16) - 2;
                if (classe == 'C') maxhost = (int)Math.Pow(2, 8) - 2;

                bitHost = Math.Floor(Math.Log(Math.Floor(maxhost / (double)numHosts.Value), 2));
            }

            if (classe == 'A')
            {
                bitSubnet = 24;
                dimensioneRete = (int)Math.Pow(2, bitSubnet - bitHost);
                string ipBase = $"{numIp1.Value}";

                for (int i = 0; i < Math.Pow(2, bitHost); i++)
                {
                    Sottorete sr = new Sottorete();
                    sr.ip = $"{ipBase}.{dimensioneRete * i / 256 / 256}.{dimensioneRete * i / 256 % 256}.{dimensioneRete * i % 256 % 256}";
                    int somma = default;
                    for (int j = (int)bitSubnet - 1; j >= bitSubnet - bitHost; j--)
                    {
                        somma += (int)Math.Pow(2, j);
                    }

                    sr.subnet = $"255.{somma / 256 / 256}.{somma / 256 % 256}.{somma % 256 % 256}";
                    sr.hosts = dimensioneRete;
                    sr.primoIp = $"{ipBase}.{dimensioneRete * i / 256 / 256}.{dimensioneRete * i / 256 % 256}.{dimensioneRete * i % 256 % 256}";
                    sr.ultimoIp = $"{ipBase}.{(dimensioneRete * (i + 1) - 2) / 256 / 256}.{(dimensioneRete * (i + 1) - 2) / 256 % 256}.{(dimensioneRete * (i + 1) - 2) % 256 % 256}";
                    sr.defaultGateway = sr.ultimoIp;
                    sr.ipBroadcast = $"{ipBase}.{(dimensioneRete * (i + 1) - 1) / 256 / 256}.{(dimensioneRete * (i + 1) - 1) / 256 % 256}.{(dimensioneRete * (i + 1) - 1) % 256 % 256}";

                    eleSr.Add(sr);
                }
            }

            if (classe == 'B')
            {
                bitSubnet = 16;
                dimensioneRete = (int)Math.Pow(2, bitSubnet - bitHost);
                string ipBase = $"{numIp1.Value}.{numIp2.Value}";

                for (int i = 0; i < Math.Pow(2, bitHost); i++)
                {
                    Sottorete sr = new Sottorete();
                    sr.ip = $"{ipBase}.{dimensioneRete * i / 256}.{dimensioneRete * i % 256}";
                    int somma = default;
                    for (int j = (int)bitSubnet - 1; j >= bitSubnet - bitHost; j--)
                    {
                        somma += (int)Math.Pow(2, j);
                    }

                    sr.subnet = $"255.255.{somma / 256}.{somma % 256}";
                    sr.hosts = dimensioneRete;
                    sr.primoIp = $"{ipBase}.{dimensioneRete * i / 256}.{dimensioneRete * i % 256}";
                    sr.ultimoIp = $"{ipBase}.{(dimensioneRete * (i + 1) - 2) / 256}.{(dimensioneRete * (i + 1) - 2) % 256}";
                    sr.defaultGateway = sr.ultimoIp;
                    sr.ipBroadcast = $"{ipBase}.{(dimensioneRete * (i + 1) - 1) / 256}.{(dimensioneRete * (i + 1) - 1) % 256}";

                    eleSr.Add(sr);
                }
            }

            if (classe == 'C')
            {
                bitSubnet = 8;
                dimensioneRete = (int)Math.Pow(2, bitSubnet - bitHost);
                string ipBase = $"{numIp1.Value}.{numIp2.Value}.{numIp3.Value}";
                eleSr = eleSr.OrderByDescending(s => s.hosts).ToList();

                for (int i = 0; i < Math.Pow(2, bitHost); i++)
                {
                    Sottorete sr = new Sottorete();
                    sr.ip = $"{ipBase}.{dimensioneRete * i}";
                    int somma = default;
                    for (int j = (int)bitSubnet - 1; j >= bitSubnet - bitHost; j--)
                    {
                        somma += (int)Math.Pow(2, j);
                    }

                    sr.subnet = $"255.255.255.{somma}";
                    sr.hosts = dimensioneRete;
                    sr.primoIp = $"{ipBase}.{dimensioneRete * i}";
                    sr.ultimoIp = $"{ipBase}.{dimensioneRete * (i + 1) - 2}";
                    sr.defaultGateway = sr.ultimoIp;
                    sr.ipBroadcast = $"{ipBase}.{dimensioneRete * (i + 1) - 1}";
                    eleSr.Add(sr);
                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = eleSr;


        }

        private void numIp1_ValueChanged(object sender, EventArgs e)
        {
            numSottoreti.Maximum = (int)Math.Pow(2, 7);
            if (numIp1.Value < 192) numSottoreti.Maximum = (int)Math.Pow(2, 14);
            if (numIp1.Value < 128) numSottoreti.Maximum = (int)Math.Pow(2, 23);

            numHosts.Maximum = numSottoreti.Maximum;
        }
    }
}