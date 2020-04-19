using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jueguito
{
    public partial class ElJuegoDeLasPuertas : Form
    {
        public ElJuegoDeLasPuertas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Com = new NivelUno();
            Com.ShowDialog();
        }
    }
}
