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
        int X, Y, X1, Y1, X2, Y2, a, b, segundos;
        double  m, angulo, grados;

        string seleccion;

    

        

        public Form1()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Panel1.Controls.Add(Avion);
            
        }


        private void Guatemala_Click(object sender, EventArgs e)
        {
            //Guatemala.Location.X (Y) obtiene la pocion donde esta el punto rojo
            label1.Text = "X = " + Guatemala.Location.X;
            label2.Text = "Y = " + Guatemala.Location.Y;
           
            seleccion = "Guatemala";
        }

        private void Rusia_Click(object sender, EventArgs e)
        {

            label1.Text = "X = " + Rusia.Location.X;
            label2.Text = "Y = " + Rusia.Location.Y;
            X2 = Rusia.Location.X;
            Y2 = Rusia.Location.Y;


            seleccion = "Rusia";

        }

        

        void Calculo()
        {
            //calcula el valor de la pendiente
            a = Y2 - Y1;
            b = X2 - X1;

            m = ((double)a / (double)b);

            //calculo del algulo
            angulo = Math.Atan(m);

            //convierte el angulo de radianes a grados solo para mostrarlo
            grados = angulo * 57.2958;

            //aca se define para que direccion va el avion conforme al angulo y al punto de partida
            if (X1 > X2)
            {
                X = Convert.ToInt32(X1 - segundos * Math.Cos(angulo));
                Y = Convert.ToInt32(Y1 - segundos * Math.Sin(angulo));
            }

            if (X1 < X2)
            {
                X = Convert.ToInt32(X1 + segundos * Math.Cos(angulo));
                Y = Convert.ToInt32(Y1 + segundos * Math.Sin(angulo));
            }
        }

        void Partida()
        {
           if (seleccion == "Guatemala")
           {
               X1 = Guatemala.Location.X;
               Y1 = Guatemala.Location.Y;
               
           }

           if (seleccion == "Rusia")
           {
               X1 = Rusia.Location.X;
               Y1 = Rusia.Location.Y;
           }

           TextoPrtida.Text = "Partida: " + seleccion;

        }
        void Destino()
        {
            if (seleccion == "Guatemala")
            {
                X2 = Guatemala.Location.X;
                Y2 = Guatemala.Location.Y;
            }

            if (seleccion == "Rusia")
            {
                X2 = Rusia.Location.X;
                Y2 = Rusia.Location.Y;
            }

            TextoDestino.Text = "Destino: " + seleccion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // este proceso puede servir para ingrsar el inicio, destino y accionar el programa de movimiento
            if (Proceso == 3)
            {
                timer1.Start();
                Texto.Text = "Disfrute el Vuelo";
               
            }

            if (Proceso == 2)
            {
                Destino();
                Control.Text = "Despegue!";
                Proceso = 3;

                Avion.Location = new Point(X1, Y1);
                
            }

            if (Proceso == 1)
            {
                //aca se debera de guardar las coordenadas seleccionadas el los puntos X2 y Y2
                Control.Text = "Destino";
                Proceso = 2;
                Texto.Text = "Seleccione el Destino";
                Partida();
            }

            if (Proceso == 0)
            {
                //aca se debera de guardar las coordenadas seleccionadas el los puntos X1 y Y1
                Control.Text = "Inicio";
                Proceso = 1;
                Texto.Text = "Seleccione un punto de Partida";
            } 
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Aumenta el valor del laber Tiempo cuando se inica el timer
            segundos = Convert.ToInt32(Tiempo.Text);
            segundos++;
            Tiempo.Text = Convert.ToString(segundos);

            Calculo();         
           

            //cambia la posicion del avion     
            Avion.Location = new Point(X, Y);

            //muestra la pocision actual del avion
            label1.Text = "X = " + Avion.Location.X;
            label2.Text = "Y = " + Avion.Location.Y;

            //muestra los grados
            label3.Text = "angulo = " + grados;

            if (X == X2 || Y == Y2)
            {
                timer1.Stop();
                Texto.Text = "Gracias por viajar con nosotros";
            }

        }

        

    }
}
