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
    public partial class Escenario1 : Form
    {
        public Escenario1()
        {
            InitializeComponent();
        }

        private void grafiacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nivel 1
            crear_nodo("13", 340, 30);
            

            // nivel 2
            crear_nodo("4", 265, 63);
            crear_nodo("15", 415, 63);
            

            // nivel 3
            crear_nodo("3", 202, 105);
            crear_nodo("11", 324, 105);
            crear_nodo("14", 367, 105);
            crear_nodo("18", 473, 105);

            // nivel 4
            crear_nodo("8", 278, 150);
            crear_nodo("16", 427, 150);
            crear_nodo("20", 529, 150);

            // nivel 5
            crear_nodo("6", 229, 186);
            crear_nodo("17", 473, 186);

            // nivel 6
            crear_nodo("5", 169, 232);
            crear_nodo("7", 278, 232);

            // conexiones
            conexion(340, 50, 296, 69);
            conexion(375, 50, 420, 70);
            conexion(267, 90, 235, 113);
            conexion(298, 90, 328, 111);
            conexion(328, 133, 308, 155);
            conexion(280, 176, 260, 192);
            conexion(230, 210, 200, 238);
            conexion(260, 213, 285, 237);
            conexion(418, 90, 397, 111);
            conexion(451, 84, 478, 109);
            conexion(477, 134, 458, 155);
            conexion(506, 132, 534, 155);
            conexion(458, 179, 478, 190);

        }

        private void preOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics preorden = CreateGraphics();
            preorden.DrawString("Pre-Orden ", Font, Brushes.Purple, 30, 325);

            crear_nodo("13", 100, 315, false);
            crear_nodo("4", 140, 315, false);
            crear_nodo("3", 180, 315, false);
            crear_nodo("11", 220, 315, false);
            crear_nodo("8", 260, 315, false);
            crear_nodo("6", 300, 315, false);
            crear_nodo("5", 340, 315, false);
            crear_nodo("7", 380, 315, false);
            crear_nodo("15", 420, 315, false);
            crear_nodo("14", 460, 315, false);
            crear_nodo("18", 500, 315, false);
            crear_nodo("16", 540, 315, false);
            crear_nodo("17", 580, 315, false);
            crear_nodo("20", 620, 315, false);
        }

        private void inOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics inorden = CreateGraphics();
            inorden.DrawString("In-Orden ", Font, Brushes.Purple, 30, 380);

            crear_nodo("3", 100, 370, false);
            crear_nodo("4", 140, 370, false);
            crear_nodo("5", 180, 370, false);
            crear_nodo("6", 220, 370, false);
            crear_nodo("7", 260, 370, false);
            crear_nodo("8", 300, 370, false);
            crear_nodo("11", 340, 370, false);
            crear_nodo("13", 380, 370, false);
            crear_nodo("14", 420, 370, false);
            crear_nodo("15", 460, 370, false);
            crear_nodo("16", 500, 370, false);
            crear_nodo("17", 540, 370, false);
            crear_nodo("18", 580, 370, false);
            crear_nodo("20", 620, 370, false);
        }

        private void postOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics posorden = CreateGraphics();
            posorden.DrawString("Pos-Orden ", Font, Brushes.Purple, 30, 425);
            crear_nodo("3", 100, 415, false);
            crear_nodo("5", 140, 415, false);
            crear_nodo("7", 180, 415, false);
            crear_nodo("6", 220, 415, false);
            crear_nodo("8", 260, 415, false);
            crear_nodo("11", 300, 415, false);
            crear_nodo("4", 340, 415, false);
            crear_nodo("14", 380, 415, false);
            crear_nodo("17", 420, 415, false);
            crear_nodo("16", 460, 415, false);
            crear_nodo("20", 500, 415, false);
            crear_nodo("18", 540, 415, false);
            crear_nodo("15", 580, 415, false);
            crear_nodo("13", 620, 415, false);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void crear_nodo(string text, int posx, int posy, bool relleno=true)
        {
            Graphics nodo;
            nodo = CreateGraphics();
            if (relleno)
            {
                nodo.FillEllipse(Brushes.Black, posx, posy, 35, 35);
                nodo.DrawString(text, Font, Brushes.White, posx + 10, posy + 10);
            }
            else
            {
                nodo.DrawString(text, Font, Brushes.Black, posx + 10, posy + 10);
            }
            Pen borde = new Pen(Color.Purple, 2);
            nodo.DrawEllipse(borde, posx, posy, 35, 35);
        }

        private void conexion(int x1, int y1, int x2, int y2)
        {
            Graphics nodo;
            nodo = CreateGraphics();
            Pen conexion = new Pen(Color.Purple, 2);
            nodo.DrawLine(conexion, x1, y1, x2, y2);
        }
    }
}
