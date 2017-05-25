using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets; // dodane przez nas - klasa klient
using System.Net; // dodane przez nas - biblioteka 

namespace Serwer_TCPIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpListener serwer = null;
        private TcpClient klient = null;

        private void Start_Click(object sender, EventArgs e)
        {
            IPAddress adresIP = null;
            try
            {
                adresIP = IPAddress.Parse(Address.Text);
            }
            catch
            {
                MessageBox.Show("Błędny format adresu IP", "Błąd");
                Address.Text = string.Empty;
                return;
            }

            int port = Convert.ToInt32(My_Port.Value);
            try
            {
                serwer = new TcpListener(adresIP, port);
                serwer.Start();

                Info_connect.Items.Add("Nawiązano połączenie!");

                klient = serwer.AcceptTcpClient();
                Start.Enabled = false;
                Stop.Enabled = true;
                klient.Close();
                serwer.Stop();
            }
            catch (Exception ex)
            {
                Info_connect.Items.Add("Błąd inicjacji serwera!");
                MessageBox.Show(ex.ToString(), "Błąd!");
            }


        }
    }
}
