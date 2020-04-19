using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?sxsrf=ALeKk00FM66tKMxv08qH4poIKmOxzDTxMw%3A1586371526334&source=hp&ei=xhuOXpnxEY655OUP9oej8AE&q=" + tBuscar.Text + "&oq=" + tBuscar.Text + "&gs_lcp=CgZwc3ktYWIQAzICCAAyAggAMgIIADICCAAyAggAMgIIADICCAAyAggAMgUIABCDATICCAA6BAgjECdKGQgXEhUwZzE0M2cxNzZnMTY3ZzE3MWcxMzVKDwgYEgswZzFnMWcxZzFnMVDqDFi3FGDGF2gAcAB4AIABf4gBrQSSAQMyLjOYAQCgAQGqAQdnd3Mtd2l6&sclient=psy-ab&ved=0ahUKEwiZ7Lm6vtnoAhWOHLkGHfbDCB4Q4dUDCAY&uact=5");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
