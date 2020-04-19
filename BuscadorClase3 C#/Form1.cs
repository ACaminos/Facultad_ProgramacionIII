using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void bRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void bVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bVer.Visible = !bVer.Visible;
        }

        private void bIr_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBuscador.Text)) return;
            if (tBuscador.Equals("about:blank")) return;
            if(!tBuscador.Text.StartsWith("http://")&& !tBuscador.Text.StartsWith("https://"))
            {
                tBuscador.Text = "http://" + tBuscador.Text;
            }
            try
            {
                webBrowser1.Navigate(new Uri(tBuscador.Text));
            }
            catch
            {
                MessageBox.Show("Se produjo un error");
            }
        }
    }
}
