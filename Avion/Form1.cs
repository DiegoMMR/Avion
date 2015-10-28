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

                
        }

        void reiniciar()
        {
            //Reinica todo el programa 
            Proceso = 0;
            Control.Text = "Comenzar";
            Texto.Text = "Haz clic en comenzar";
            label1.Text = "X = ";
            label2.Text = "Y = ";
            Pais.Text = "Pais: ";
            Avion.Image = null;
            label3.Text = "angulo = ";
            timer1.Stop();
            TextoPrtida.Text = "Partida: ";
            TextoDestino.Text = "Destino: ";
            Avion.Location = new Point(100, 366);
            Tiempo.Text = "0";
        }

        private void Guatemala_Click(object sender, EventArgs e)
        {
            //Guatemala.Location.X (Y) obtiene la pocion donde esta el punto rojo
            label1.Text = "X = " + Guatemala.Location.X;
            label2.Text = "Y = " + Guatemala.Location.Y;
           
            seleccion = "Guatemala";
            Pais.Text = "Pais: " + seleccion;        
        }
        private void Australia_Click(object sender, EventArgs e)
        {
            label1.Text = "X = " + Australia.Location.X;
            label2.Text = "Y = " + Australia.Location.Y;

            seleccion = "Australia";
            Pais.Text = "Pais: " + seleccion; 
        }
        private void Rusia_Click(object sender, EventArgs e)
        {

            label1.Text = "X = " + Rusia.Location.X;
            label2.Text = "Y = " + Rusia.Location.Y;

            seleccion = "Rusia";
            Pais.Text = "Pais: " + seleccion; 

        }


        void imagen()
        {
            //cambia la imagen dependiendo de la direccion
            if (X1 == X2 && Y1 > Y2)
            {
                Avion.Image = Image.FromFile("Avion0.png");
            }

            if (X1 < X2 && Y1 > Y2)
            {
                Avion.Image = Image.FromFile("Avion45.png");
            }

            if (X1 < X2 && Y1 == Y2)
            {
               Avion.Image = Image.FromFile("Avion90.png");
            }
          
            if (X1 < X2 && Y1 < Y2)
            {
                Avion.Image = Image.FromFile("Avion135.png");
            }

            if (X1 == X2 && Y1 < Y2)
            {
                Avion.Image = Image.FromFile("Avion180.png");
            }

            if (X1 > X2 && Y1 < Y2)
            {
                Avion.Image = Image.FromFile("Avion225.png");
            }

            if (X1 > X2 && Y1 == Y2)
            {
                Avion.Image = Image.FromFile("Avion270.png");
            }

            if (X1 > X2 && Y1 > Y2)
            {
                Avion.Image = Image.FromFile("Avion315.png");
            }


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
                //como va hacia la izquierda se resta
                X = Convert.ToInt32(X1 - segundos * Math.Cos(angulo));
                Y = Convert.ToInt32(Y1 - segundos * Math.Sin(angulo));

            }

            if (X1 < X2)
            {
                //como va hacia la derecha se suma
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

           if (seleccion == "Australia")
           {
               X1 = Australia.Location.X;
               Y1 = Australia.Location.Y;
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

            if (seleccion == "Australia")
            {
                X2 = Australia.Location.X;
                Y2 = Australia.Location.Y;
            }

            TextoDestino.Text = "Destino: " + seleccion;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            // este proceso puede servir para ingrsar el inicio, destino y accionar el programa de movimiento
            if (Proceso == 3)
            {
                timer1.Start();
                Texto.Text = "Disfrute el Vuelo";
               
            }

            if (Proceso == 2)
            {
                Proceso = 3;
                Destino();
                Control.Text = "Despegue!";
                Avion.Location = new Point(X1, Y1);
                imagen();
            }

            if (Proceso == 1)
            {
                //aca se debera de guardar las coordenadas seleccionadas el los puntos X2 y Y2
               
                Proceso = 2;
                Control.Text = "Destino";
                Texto.Text = "Seleccione el Destino";
                Partida();
            }

            if (Proceso == 0)
            {
                //aca se debera de guardar las coordenadas seleccionadas el los puntos X1 y Y1
                
                Proceso = 1;
                Control.Text = "Inicio";
                Texto.Text = "Seleccione un punto de Partida";
                Avion.Image = Image.FromFile("Avion0.png");
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

            if (X == X2 && Y == Y2)
            {
                timer1.Stop();
                Texto.Text = "Gracias por viajar con nosotros";
            }

        }

        private void Reinicio_Click(object sender, EventArgs e)
        {
            reiniciar();
        }

    }
}
