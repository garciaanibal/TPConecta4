using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPConecta4
{
    class Tablero
    {
        public int[,] casilla = new int[6,7];
        public int turno;

        public Tablero()
        {

        }

        public void cargarTablero() {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    casilla[i, j] = 0;
                }
            }
        }

     
        
        public int VerificarGanador(int playerToCheck) {
            //VERTICAL
            for (int row = 0; row < this.casilla.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < this.casilla.GetLength(1); col++)
                {
                    if (this.AllNumberEqual(playerToCheck, this.casilla[row, col], this.casilla[row + 1, col], this.casilla[row + 2, col], this.casilla[row + 3, col]))
                    {
                        return playerToCheck;
                    }
                }
            }

            //Horizontal
            for (int row = 0; row < this.casilla.GetLength(0); row++)
            {
                for (int col = 0; col < this.casilla.GetLength(1) - 3; col++)
                {
                    if (this.AllNumberEqual(playerToCheck, this.casilla[row, col], this.casilla[row, col + 1], this.casilla[row, col + 2], this.casilla[row, col + 3]))
                    {
                        return playerToCheck;
                    }
                }
            }

            //Diagonal (\)
            for (int row = 0; row < this.casilla.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < this.casilla.GetLength(1) - 3; col++)
                {
                    if (this.AllNumberEqual(playerToCheck, this.casilla[row, col], this.casilla[row + 1, col + 1], this.casilla[row + 2, col + 2], this.casilla[row + 3, col + 3]))
                    {
                        return playerToCheck;
                    }
                }
            }

            //Diagonal (/)
            for (int row = 0; row < this.casilla.GetLength(0) - 3; row++)
            {
                for (int col = 3; col < this.casilla.GetLength(1); col++)
                {
                    if (this.AllNumberEqual(playerToCheck, this.casilla[row, col], this.casilla[row + 1, col - 1], this.casilla[row + 2, col - 2], this.casilla[row + 3, col - 3]))
                    {
                        return playerToCheck;
                    }
                }
            }

            return -1;
        }

        private bool AllNumberEqual(int toCheck, params int[] numbers)
        {
            foreach (int num in numbers)
            {
                if (num != toCheck)
                    return false;
            }
            return true;
        }


        public int PcIA(int profundidad)
        {
            int alfa = -10000, beta = 10000;
            var random = new Random();
            var turnoPc = new List<Tuple<int, int>>();
            for (int i = 0; i < 7; i++)
            {
                if (!SoltarFicha(2, i))
                    continue;
                turnoPc.Add(Tuple.Create(i, MinMax(casilla, profundidad, alfa, beta, false)));
                SacarFicha(i);
            }
            int mejorPuntuacion = turnoPc.Max(t => t.Item2);
            var mejoreMovimiento = turnoPc.Where(t => t.Item2 == mejorPuntuacion).ToList();
            return mejoreMovimiento[random.Next(0, mejoreMovimiento.Count)].Item1;

        }


        private int MinMax(int[,] casilla, int profundidad, int alfa, int beta, bool jugadorMaximizador)
        {
            if (profundidad <= 0)
                return 0;
            if (VerificarGanador(2) == 2)
                return profundidad;
            if (VerificarGanador(1) == 1)
                return -profundidad;
            if (tableroLleno)
                return 0;

            int mejorValor = jugadorMaximizador ? -1 : 1;
            for (int i = 0; i < 7; i++)
            {
                if (!SoltarFicha(jugadorMaximizador ? 2 : 1, i))
                    continue;
                int v = MinMax(casilla, profundidad - 1, alfa, beta, !jugadorMaximizador);
                mejorValor = jugadorMaximizador ? Math.Max(mejorValor, v) : Math.Min(mejorValor, v);
                if (jugadorMaximizador)
                    alfa = Math.Max(alfa, mejorValor);
                else
                    beta = Math.Min(beta, mejorValor);
                SacarFicha(i);
                if (beta <= alfa)
                {
                    return mejorValor;
                }

            }
            return mejorValor;

        }
        public bool SoltarFicha(int idJugador, int columna)
        {
            int fila = 0;
            while (fila < 6 && casilla[fila, columna] == 0)
            {
                fila++;
            }

            if (fila == 0)
                return false;
            casilla[fila - 1, columna] = idJugador;
            return true;
        }

        public bool SacarFicha(int columna)
        {
            int fila = 0;
            while (fila < 6 && (casilla[fila, columna] == 0))
            {
                fila++;
            }

            if (fila == 6)
                return false;
            casilla[fila, columna] = 0;
            return true;
        }

        public bool tableroLleno
        {
            get
            {
                for (int i = 0; i < 7; i++)
                {
                    if (casilla[0, i] == 0)
                        return false;
                }

                return true;

            }
        }

    }
}
