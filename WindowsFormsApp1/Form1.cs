using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClicked(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            listBox1.Items.Clear();
            listBox1.Items.Add(txt);
            string hostName = Dns.GetHostName();
            string printhostName = "locol hostname คือ " + hostName;
            IPHostEntry myself = Dns.GetHostEntry(hostName);
            string printIPLength = "มีไอพีทั้งหมดเท่ากับ " + myself.AddressList.Length + " ดังนี้";
            listBox1.Items.Add(printhostName);
            listBox1.Items.Add(printIPLength);
            foreach (IPAddress address in myself.AddressList)
            {
                listBox1.Items.Add(address.ToString());
            }
        }
    }
}
