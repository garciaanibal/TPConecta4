using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace TPConecta4
{
    public partial class Juego : Form
    {
        //Creacion de Fichas
        Ficha ficha = new Ficha("roja");        
        String color;
        int profundidad;
        bool modojuego;

        //Creacion de jugadores
        Jugador j1 = new Jugador();
        Jugador j2 = new Jugador();

        //Creacion de listas de pbox por columnas
        List<PictureBox> c1 = new List<PictureBox>();
        List<PictureBox> c2 = new List<PictureBox>();
        List<PictureBox> c3 = new List<PictureBox>();
        List<PictureBox> c4 = new List<PictureBox>();
        List<PictureBox> c5 = new List<PictureBox>();
        List<PictureBox> c6 = new List<PictureBox>();
        List<PictureBox> c7 = new List<PictureBox>();

        //Creacion de matriz de enteros tablero        
        Tablero t = new Tablero();
            
        public Juego(bool pc, int dif)
        {
            InitializeComponent();

            cargarListPbox();            
            t.cargarTablero();
            ficha.picturbox.LoadAsync(ficha.colorRojo);
            
            modojuego = pc;
            profundidad = dif;

            t.turno = 1;
            pbRedondo1.BackColor = Color.Red;
            //timer1.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
                    
        public void cargarListPbox() {            
            c1.Add(pictureBox1);
            c1.Add(pictureBox2);
            c1.Add(pictureBox3);
            c1.Add(pictureBox4);
            c1.Add(pictureBox5);
            c1.Add(pictureBox6);
            

            c2.Add(pictureBox7);
            c2.Add(pictureBox8);
            c2.Add(pictureBox9);
            c2.Add(pictureBox10);
            c2.Add(pictureBox11);
            c2.Add(pictureBox12);

            c3.Add(pictureBox13);
            c3.Add(pictureBox14);
            c3.Add(pictureBox15);
            c3.Add(pictureBox16);
            c3.Add(pictureBox17);
            c3.Add(pictureBox18);

            c4.Add(pictureBox19);
            c4.Add(pictureBox20);
            c4.Add(pictureBox21);
            c4.Add(pictureBox22);
            c4.Add(pictureBox23);
            c4.Add(pictureBox24);

            c5.Add(pictureBox25);
            c5.Add(pictureBox26);
            c5.Add(pictureBox27);
            c5.Add(pictureBox28);
            c5.Add(pictureBox29);
            c5.Add(pictureBox30);

            c6.Add(pictureBox31);
            c6.Add(pictureBox32);
            c6.Add(pictureBox33);
            c6.Add(pictureBox34);
            c6.Add(pictureBox35);
            c6.Add(pictureBox36);

            c7.Add(pictureBox37);
            c7.Add(pictureBox38);
            c7.Add(pictureBox39);
            c7.Add(pictureBox40);
            c7.Add(pictureBox41);
            c7.Add(pictureBox42);
        }                

        private void columna1_Click(object sender, EventArgs e)
        {
            new Thread(moverFichaC1).Start();
        }

        private void columna2_Click(object sender, EventArgs e)
        {
            new Thread(moverFichaC2).Start();
        }

        private void columna3_Click(object sender, EventArgs e)
        {
            new Thread(moverFichaC3).Start();
        }

        private void columna4_Click(object sender, EventArgs e)
        {
            new Thread(moverFichaC4).Start();
        }

        private void columna5_Click(object sender, EventArgs e)
        {
            new Thread(moverFichaC5).Start();
        }

        private void columna6_Click(object sender, EventArgs e)
        {
            new Thread(moverFichaC6).Start();
        }

        private void columna7_Click(object sender, EventArgs e) {
            new Thread(moverFichaC7).Start();
        }

        public void moverFichaC1() {
            
            //Guardo elemento en la matriz
            guardarFicha(c1,0,t.turno);
            //Efecto grafico de caida de ficha
            caidaDeFicha(c1,t.turno);
            //Cambio de turno
            t.turno = cambioTurno(t.turno);
            
            
        }

        public void moverFichaC2() {
            //Guardo elemento en la matriz
            guardarFicha(c2, 1, t.turno);
            //Efecto grafico de caida de ficha
            caidaDeFicha(c2, t.turno);
            //Cambio turno
            t.turno = cambioTurno(t.turno);
            
            
        }

        public void moverFichaC3()
        {
            //Guardo elemento en la matriz
            guardarFicha(c3, 2, t.turno);
            //Efecto grafico de caida de ficha
            caidaDeFicha(c3, t.turno);
            //Cambio turno
            t.turno = cambioTurno(t.turno);
          

        }

        public void moverFichaC4()
        {
           //Guardo elemento en la matriz
            guardarFicha(c4, 3, t.turno);
            //Efecto grafico de caida de ficha
            caidaDeFicha(c4, t.turno);
            //Cambio turno
            t.turno = cambioTurno(t.turno);
          
        }

        public void moverFichaC5()
        {
            //Guardo elemento en la matriz
            guardarFicha(c5, 4, t.turno);
            //Efecto grafico de caida de ficha
            caidaDeFicha(c5, t.turno);
            //Cambio turno
            t.turno = cambioTurno(t.turno);
         
        }

        public void moverFichaC6()
        {
            //Guardo elemento en la matriz
            guardarFicha(c6, 5, t.turno);
            //Efecto grafico de caida de ficha
            caidaDeFicha(c6, t.turno);
            //Cambio turno
            t.turno = cambioTurno(t.turno);
          
        }

        public void moverFichaC7()
        {
            //Guardo elemento en la matriz
            guardarFicha(c7, 6, t.turno);
            //Efecto grafico de caida de ficha
            caidaDeFicha(c7, t.turno);
            //Cambio turno
            t.turno = cambioTurno(t.turno);
           

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }


        private void columna1_MouseMove(object sender, MouseEventArgs e)
        {
            if (c1.Count > 1)
            {
                c1[c1.Count - 1].LoadAsync(ficha.recuadro);

                c1[c1.Count - 1].LoadAsync(ficha.colorVacio);
            }
            if (c1.Count == 1)
            {
                c1[0].LoadAsync(ficha.recuadro);

                c1[0].LoadAsync(ficha.colorVacio);
            }
        }

        private void columna2_MouseMove(object sender, MouseEventArgs e)
        {
            if (c2.Count > 1)
            {
                c2[c2.Count - 1].LoadAsync(ficha.recuadro);

                c2[c2.Count - 1].LoadAsync(ficha.colorVacio);
            }
            if (c2.Count == 1)
            {
                c2[0].LoadAsync(ficha.recuadro);

                c2[0].LoadAsync(ficha.colorVacio);
            }
        }

        private void columna3_MouseMove(object sender, MouseEventArgs e)
        {
            if (c3.Count > 1)
            {
                c3[c3.Count - 1].LoadAsync(ficha.recuadro);

                c3[c3.Count - 1].LoadAsync(ficha.colorVacio);
            }
            if (c3.Count == 1)
            {
                c3[0].LoadAsync(ficha.recuadro);

                c3[0].LoadAsync(ficha.colorVacio);
            }
        }

        private void columna4_MouseMove(object sender, MouseEventArgs e)
        {
            if (c4.Count > 1)
            {
                c4[c4.Count - 1].LoadAsync(ficha.recuadro);

                c4[c4.Count - 1].LoadAsync(ficha.colorVacio);
            }
            if (c4.Count == 1)
            {
                c4[0].LoadAsync(ficha.recuadro);

                c4[0].LoadAsync(ficha.colorVacio);
            }
        }

        private void columna5_MouseMove(object sender, MouseEventArgs e)
        {
            if (c5.Count > 1)
            {
                c5[c5.Count - 1].LoadAsync(ficha.recuadro);

                c5[c5.Count - 1].LoadAsync(ficha.colorVacio);
            }
            if (c5.Count == 1)
            {
                c5[0].LoadAsync(ficha.recuadro);

                c5[0].LoadAsync(ficha.colorVacio);
            }
        }

        private void columna6_MouseMove(object sender, MouseEventArgs e)
        {
            if (c6.Count > 1)
            {
                c6[c6.Count - 1].LoadAsync(ficha.recuadro);

                c6[c6.Count - 1].LoadAsync(ficha.colorVacio);
            }
            if (c6.Count == 1)
            {
                c6[0].LoadAsync(ficha.recuadro);

                c6[0].LoadAsync(ficha.colorVacio);
            }
        }

        private void columna7_MouseMove(object sender, MouseEventArgs e)
        {
            if (c7.Count > 1)
            {
                c7[c7.Count - 1].LoadAsync(ficha.recuadro);

                c7[c7.Count - 1].LoadAsync(ficha.colorVacio);
            }
            if (c7.Count == 1)
            {
                c7[0].LoadAsync(ficha.recuadro);

                c7[0].LoadAsync(ficha.colorVacio);
            }
        }
             
        private void timer1_Tick(object sender, EventArgs e)
        {                                           
        }


        //private void btnImprimir_Click(object sender, EventArgs e)
        //{
        //    txtboxMatriz.Text = "";
        //    for (int i = 0; i < 6; i++)
        //    {

        //        for (int j = 0; j < 7; j++)
        //        {
        //            txtboxMatriz.Text += Convert.ToString(t.casilla[i, j]) + "  ";
        //        }
        //        txtboxMatriz.Text += "\t\t";
        //    }
        //}


        private void guardarFicha( List<PictureBox> c ,int col, int turno) {

            if (c.Count > 0)
            {

                if (turno == 1)
                {
                    t.casilla[c.Count - 1, col] = 1;
                }
                else
                {
                    t.casilla[c.Count - 1, col] = 2;
                }

            }
        }

        private void caidaDeFicha(List<PictureBox> c, int turno) {
                   
            //Asignacion de color segun turno
            if (turno == 1)
            {             
                color = ficha.colorRojo;
            }
            else
            {             
                color = ficha.colorAmarillo;
            }
            //Caida de ficha
            if (c.Count>0)
            {
                for (int i = 0; i < c.Count - 1; i++)
                {
                    
                    c[i].LoadAsync(color);
                    Thread.Sleep(18);
                    c[i].LoadAsync(ficha.colorVacio);
                    Thread.Sleep(18);
                }
                //Dejo color fijo en ultimo elemento de la lista.
                c[c.Count - 1].LoadAsync(color);
                //Elimino ultimo pictur box de la lista ya que queda con color fijo y la pos fue guardada
                c.RemoveAt(c.Count - 1);
            }
            
        }

        private int cambioTurno(int turno)
        {

            int winner = t.VerificarGanador(turno);

            if (winner != -1)
            {
                string player;

                if (winner == 1)
                    player = "Rojo";
                else player = "Amarillo";

                MessageBox.Show("Felicitaciones " + player + " has ganado!");
                Application.Restart();
            }
            if (t.tableroLleno) {
                MessageBox.Show("Se ha producido un empate!! ");
                Application.Restart();
            }

            if (turno == 1)
            {
                EventArgs ev = new EventArgs();
                Object xy = new Point(34, 34);

                t.turno = 2;

                if (modojuego)
                {
                    int jugadaPC = t.PcIA(6);
                    switch (jugadaPC)
                    {
                        case 0:
                            columna1_Click(xy, ev);
                            break;
                        case 1:
                            columna2_Click(xy, ev);
                            break;
                        case 2:
                            columna3_Click(xy, ev);
                            break;
                        case 3:
                            columna4_Click(xy, ev);
                            break;
                        case 4:
                            columna5_Click(xy, ev);
                            break;
                        case 5:
                            columna6_Click(xy, ev);
                            break;
                        case 6:
                            columna7_Click(xy, ev);
                            break;

                    }
                }


                pbRedondo1.BackColor = Color.Yellow;
            }
            else
            {
                t.turno = 1;
                pbRedondo1.BackColor = Color.Red;

            }

            return t.turno;
        }

        public void casillaTarget() {
            

            if (c1.Count > 1)
            {
                c1[c1.Count - 1].LoadAsync(@"C:\Users\USUARIO\source\repos\TPConecta4\TPConecta4\Images\cuadro.png");

                c1[c1.Count - 1].LoadAsync(@"C:\Users\USUARIO\source\repos\TPConecta4\TPConecta4\Images\circuloVacio.png");
            }
            if (c1.Count == 1)
            {
                c1[0].LoadAsync(@"C:\Users\USUARIO\source\repos\TPConecta4\TPConecta4\Images\cuadro.png");

                c1[0].LoadAsync(@"C:\Users\USUARIO\source\repos\TPConecta4\TPConecta4\Images\circuloVacio.png");
            }
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
           
        }

        private void pbRedondo1_Click(object sender, EventArgs e)
        {

        }
    }
}
