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
        int Proceso = 1;
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
         

            Avion.Location = new Point(X, Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // este proceso puede servir para ingrsar el inicio, destino y accionar el programa de movimiento
            if (Proceso == 2)
            {
                button1.Text = "Vamos!";
                Proceso = 3;
                timer1.Start();
            }

            if (Proceso == 1)
            {
                button1.Text = "Destino";
                Proceso = 2;
            } 

          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Aumenta el valor del laber Tiempo cuando se inica el timer
            int segundos = Convert.ToInt32(Tiempo.Text);
            segundos++;
            Tiempo.Text = Convert.ToString(segundos);

            //esto va a mover el avion conforme a los segundos desde el punto de Guatemala
            //falta un calculo del angulo para poder hacer que llegue donde esta el destino
            int X2 = Guatemala.Location.X + segundos;
            int Y2 = Guatemala.Location.Y - segundos;           

            Avion.Location = new Point(X2, Y2);

            if (X == Rusia.Location.X && Y == Rusia.Location.Y)
            {
                timer1.Stop();
            }

        }

    }
}
