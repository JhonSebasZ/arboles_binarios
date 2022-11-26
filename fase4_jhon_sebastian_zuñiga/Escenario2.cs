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
    public partial class Escenario2 : Form
    {
        public Escenario2()
        {
            InitializeComponent();
        }

        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crear_nodo("15", 324, 38);
            crear_nodo("6", 209, 77);
            crear_nodo("3", 138, 128);
            crear_nodo("1", 86, 177);
            crear_nodo("4", 177, 177);
            crear_nodo("9", 255, 128);
            crear_nodo("7", 220, 177);
            crear_nodo("12", 305, 177);
            crear_nodo("20", 411, 77);
            crear_nodo("18", 389, 128);
            crear_nodo("17", 360, 177);
            crear_nodo("24", 477, 128);

            // conexiones
            conexion(324, 59, 243, 89);
            conexion(211, 103, 168, 134);
            conexion(141, 155, 116, 182);
            conexion(170, 155, 184, 180);
            conexion(243, 100, 264, 129);
            conexion(359, 56, 416, 82);
            conexion(420, 109, 413, 129);
            conexion(397, 160, 387, 180);
            conexion(445, 100, 481, 133);
            conexion(265, 161, 248, 181);
            conexion(287, 156, 309, 182);

        }

        private void preOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics preorden = CreateGraphics();
            preorden.DrawString("Pre-Orden", Font, Brushes.Purple, 30, 280);

            crear_nodo("15", 100, 270, false);
            crear_nodo("6", 140, 270, false);
            crear_nodo("3", 180, 270, false);
            crear_nodo("1", 220, 270, false);
            crear_nodo("4", 260, 270, false);
            crear_nodo("9", 300, 270, false);
            crear_nodo("7", 340, 270, false);
            crear_nodo("12", 380, 270, false);
            crear_nodo("20", 420, 270, false);
            crear_nodo("18", 460, 270, false);
            crear_nodo("17", 500, 270, false);
            crear_nodo("24", 540, 270, false);
        }

        private void inOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics inorden = CreateGraphics();
            inorden.DrawString("In-Orden", Font, Brushes.Purple, 30, 330);

            crear_nodo("1", 100, 320, false);
            crear_nodo("3", 140, 320, false);
            crear_nodo("4", 180, 320, false);
            crear_nodo("6", 220, 320, false);
            crear_nodo("7", 260, 320, false);
            crear_nodo("9", 300, 320, false);
            crear_nodo("12", 340, 320, false);
            crear_nodo("15", 380, 320, false);
            crear_nodo("17", 420, 320, false);
            crear_nodo("18", 460, 320, false);
            crear_nodo("20", 500, 320, false);
            crear_nodo("24", 540, 320, false);
        }

        private void posOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics posorden = CreateGraphics();
            posorden.DrawString("Pos-Orden", Font, Brushes.Purple, 30, 380);

            crear_nodo("1", 100, 370, false);
            crear_nodo("4", 140, 370, false);
            crear_nodo("3", 180, 370, false);
            crear_nodo("7", 220, 370, false);
            crear_nodo("12", 260, 370, false);
            crear_nodo("9", 300, 370, false);
            crear_nodo("6", 340, 370, false);
            crear_nodo("17", 380, 370, false);
            crear_nodo("18", 420, 370, false);
            crear_nodo("24", 460, 370, false);
            crear_nodo("20", 500, 370, false);
            crear_nodo("15", 540, 370, false);
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void crear_nodo(string texto, int posx, int posy, bool relleno=true)
        {
            Graphics nodo = CreateGraphics();
            if (relleno)
            {
                nodo.FillEllipse(Brushes.Black, posx, posy, 35, 35);
                nodo.DrawString(texto, Font, Brushes.White, posx + 10, posy + 10);
            }
            else
            {
                nodo.DrawString(texto, Font, Brushes.Black, posx + 10, posy + 10);
            }
            
            Pen borde = new Pen(Brushes.Purple, 2);
            nodo.DrawEllipse(borde, posx, posy, 35, 35);
        }

        private void conexion(int x1, int y1, int x2, int y2)
        {
            Graphics nodo = CreateGraphics();
            Pen conexion = new Pen(Color.Purple, 3);
            nodo.DrawLine(conexion, x1, y1, x2, y2);
        }
    }
}
