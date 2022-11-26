using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fase4_jhon_sebastian_zuñiga
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Confirme su salida", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(respuesta == DialogResult.No)
            {
                return;
            }

            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();
        }

        private void btbEscenario1_Click(object sender, EventArgs e)
        {
            Escenario1 es1 = new Escenario1();
            this.Hide();
            es1.Show();
        }

        private void btnEscenario2_Click(object sender, EventArgs e)
        {
            Escenario2 es2 = new Escenario2();
            this.Hide();
            es2.Show();
        }
    }
}
