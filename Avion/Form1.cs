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
        int X, Y, X1, Y1, X2, Y2, X3, Y3, a, b, segundos, mitadX, mitadY, conteo;
        double distancia;

        string seleccion;
        bool mitad = false;
        
        

        

        public Form1()
        {
            InitializeComponent();
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //esto es solo para inicar el panel 
            //y para que todo lo que este sobre el pueda tener una posicion 

           
                
        }

        void reiniciar()
        {
            //Reinica todo el programa 
            conteo = 0;
            Proceso = 0;
            label3.Text = "Distancia:";
            mitad = false;
            Control.Text = "Comenzar";
            Texto.Text = "Haz clic en comenzar";
            label1.Text = "X = ";
            label2.Text = "Y = ";
            Pais.Text = "Pais: ";
            Avion.Image = null;
            timer1.Stop();
            TextoPrtida.Text = "Partida: ";
            TextoDestino.Text = "Destino: ";
            Avion.Location = new Point(100, 366);

            //cambia la imagen de fondo del panel ya que la linea se hace sobre el fondo
            Panel1.BackgroundImage = Image.FromFile("mapamundi.jpg");
            
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
        private void Canada_Click(object sender, EventArgs e)
        {
            label1.Text = "X = " + Canada.Location.X;
            label2.Text = "Y = " + Canada.Location.Y;

            seleccion = "Canada";
            Pais.Text = "Pais: " + seleccion; 
        }
        private void Africa_Click(object sender, EventArgs e)
        {
            label1.Text = "X = " + Africa.Location.X;
            label2.Text = "Y = " + Africa.Location.Y;

            seleccion = "Africa";
            Pais.Text = "Pais: " + seleccion; 
        }
        private void Italia_Click(object sender, EventArgs e)
        {
            label1.Text = "X = " + Italia.Location.X;
            label2.Text = "Y = " + Italia.Location.Y;

            seleccion = "Italia";
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
            

            //obtiene la midad del trayecto
            mitadX = Convert.ToInt32((X1 + X2) / 2);
            mitadY = Convert.ToInt32((Y1 + Y2) / 2);

            //aumenta de la mitad para poder crear la curva

            X3 = mitadX - 25;
            Y3 = mitadY - 25;
            

            

            //aca se define para que direccion va el avion conforme al angulo y al punto de partida
            if (mitad == false)
            {

                if (X1 > X3)
                {
                    //como va hacia la izquierda se resta


                    X = Convert.ToInt32(X1 - segundos);
                    Y = Convert.ToInt32((((Y3 - Y1) * (X - X1)) / (X3 - X1)) + Y1);


                }

                if (X1 < X3)
                {
                    //como va hacia la derecha se suma


                    X = Convert.ToInt32(X1 + segundos);
                    Y = Convert.ToInt32((((Y3 - Y1) * (X - X1)) / (X3 - X1)) + Y1);

                }
            }


        }

        void Partida()
        {
           if (seleccion == "Italia")
           {
               X1 = Italia.Location.X;
               Y1 = Italia.Location.Y;             
           }

           if (seleccion == "Africa")
           {
               X1 = Africa.Location.X;
               Y1 = Africa.Location.Y;             
           }

           if (seleccion == "Canada")
           {
               X1 = Canada.Location.X;
               Y1 = Canada.Location.Y;             
           }
        
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
            if (seleccion == "Italia")
            {
                X2 = Italia.Location.X;
                Y2 = Italia.Location.Y;
            }

            if (seleccion == "Africa")
            {
                X2 = Africa.Location.X;
                Y2 = Africa.Location.Y;
            }

            if (seleccion == "Canada")
            {
                X2 = Canada.Location.X;
                Y2 = Canada.Location.Y;
            }

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

        private void Reinicio_Click(object sender, EventArgs e)
        {
            reiniciar();
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

            conteo++;

            distancia = conteo * 93.07;
            //Aumenta el valor del label Tiempo cuando se inica el timer
            segundos++;
      
            Calculo(); 

            //dibujo de linea
            Graphics dibujo = Panel1.CreateGraphics();

            //define los puntos para poder crear la curva
            Point[] puntos = { new Point(X1, Y1),    //inicio
                               new Point(X3, Y3),    //altura
                               new Point(X2, Y2) };  //final

            //dibuja la curva
            dibujo.DrawCurve(new Pen(Brushes.Blue), puntos);


            if (X == X3 && Y == Y3)
            {
                mitad = true;
              
                segundos = 1;
                
            }

            if (mitad == true)
            {


                if (X3 > X2)
                {
                    //como va hacia la izquierda se resta


                    X = Convert.ToInt32(X3 - segundos);
                    Y = Convert.ToInt32((((Y2 - Y3) * (X - X3)) / (X2 - X3)) + Y3);


                }

                if (X3 < X2)
                {
                    //como va hacia la derecha se suma


                    X = Convert.ToInt32(X3 + segundos);
                    Y = Convert.ToInt32((((Y2 - Y3) * (X - X3)) / (X2 - X3)) + Y3);

                }
            }
           

            //cambia la posicion del avion     
            Avion.Location = new Point(X, Y);

            //muestra la pocision actual del avion
            label1.Text = "X = " + Avion.Location.X;
            label2.Text = "Y = " + Avion.Location.Y;

            label3.Text = "Distancia: " + distancia + "km (aprox.)";

            
            if (X == X2 && Y == Y2)
            {
                timer1.Stop();
                Texto.Text = "Gracias por viajar con nosotros";              
            }

        }

       

       

       

       

        

    }
}
