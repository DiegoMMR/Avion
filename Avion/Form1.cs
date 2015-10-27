using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avion
{


    public partial class Form1 : Form
    {
        int Proceso = 0;
        int X, Y;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         

            
        }

        private void Guatemala_Click(object sender, EventArgs e)
        {
            //Guatemala.Location.X (Y) obtiene la pocion donde esta el punto rojo
            label1.Text = "X = " + Guatemala.Location.X;
            label2.Text = "Y = " + Guatemala.Location.Y;
            //solo para poder guardar los datos de una forma mas corta
            X =  Guatemala.Location.X;
            Y =  Guatemala.Location.Y;
            
            //coloca el Avion el la posicion de Guatemala
            Avion.Location = new Point(X, Y);

            
        }

        private void Rusia_Click(object sender, EventArgs e)
        {
            label1.Text = "X = " + Rusia.Location.X;
            label2.Text = "Y = " + Rusia.Location.Y;
            X = Rusia.Location.X;
            Y = Rusia.Location.Y;

            Avion.Location = new Point(X, Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // este proceso puede servir para ingrsar el inicio, destino y accionar el programa de movimiento
            if (Proceso == 2)
            {
                button1.Text = "Vamos!";
                Proceso = 3;
            }

            if (Proceso == 1)
            {
                button1.Text = "Destino";
                Proceso = 2;
            }

            if (Proceso == 0)
            {
                button1.Text = "Inicio";
                Proceso = 1;
            }

         

          

        }

    }
}
