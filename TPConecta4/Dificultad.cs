using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPConecta4
{
    public partial class Dificultad : Form
    {
        int dificultad;
        public Dificultad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dificultad = 3;
            bool pc = true;
            Juego tablero = new Juego(pc, dificultad);
            tablero.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dificultad = 6;
            bool pc = true;
            Juego tablero = new Juego(pc, dificultad);
            tablero.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dificultad = 8;
            bool pc = true;
            Juego tablero = new Juego(pc, dificultad);
            tablero.ShowDialog();
            this.Close();
        }

        private void Dificultad_Load(object sender, EventArgs e)
        {
            
        }
    }
}
