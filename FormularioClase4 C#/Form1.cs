using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioClase4CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result= MessageBox.Show("¿Está seguro que desea salir?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }  
         }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Cli = new Clientes();
            Cli.BackColor = Color.Red;
            Cli.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Pro = new Proveedores();
            Pro.BackColor = Color.Green;
            Pro.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form List = new Listado();
            List.BackColor = Color.Blue;
            List.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form List = new Listado();
            List.BackColor = Color.Blue;
            List.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Cli = new Clientes();
            Cli.BackColor = Color.Red;
            Cli.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Pro = new Proveedores();
            Pro.BackColor = Color.Green;
            Pro.ShowDialog();
        }
    }
    }
