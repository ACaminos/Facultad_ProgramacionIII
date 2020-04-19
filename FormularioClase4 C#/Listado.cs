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
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var result = MessageBox.Show("¿Estás seguro que querés volver a la pantalla principal?", "¡Cuidado!", MessageBoxButtons.YesNo);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
