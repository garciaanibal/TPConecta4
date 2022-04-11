using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPConecta4
{
    class Ficha
    {
        public PictureBox picturbox = new PictureBox();       
        
        public string colorRojo = @"C:\Users\aniba\source\repos\TPConecta4\TPConecta4\Images\circuloRojo.png";
        public string colorAmarillo = @"C:\Users\aniba\source\repos\TPConecta4\TPConecta4\Images\circuloAmarillo.png";
        public string colorVacio = @"C:\Users\aniba\source\repos\TPConecta4\TPConecta4\Images\circuloVacio.png";
        public string recuadro = @"C:\Users\aniba\source\repos\TPConecta4\TPConecta4\Images\circuloVacio.png";

        public Ficha(string color) {

            if (color == "blanca")
            {
                picturbox.LoadAsync(colorVacio);
            }
            if (color == "roja")
            {
                picturbox.LoadAsync(colorRojo);
            }
            if (color == "amarilla")
            {
                picturbox.LoadAsync(colorAmarillo);
            }

        }

    }
}
