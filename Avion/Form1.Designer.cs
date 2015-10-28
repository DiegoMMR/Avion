namespace Avion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Pais = new System.Windows.Forms.Label();
            this.Australia = new System.Windows.Forms.PictureBox();
            this.Avion = new System.Windows.Forms.PictureBox();
            this.TextoDestino = new System.Windows.Forms.Label();
            this.TextoPrtida = new System.Windows.Forms.Label();
            this.Texto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Label();
            this.Control = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Guatemala = new System.Windows.Forms.PictureBox();
            this.Rusia = new System.Windows.Forms.PictureBox();
            this.Reinicio = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Australia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guatemala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rusia)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel1
            // 
            this.Panel1.BackgroundImage = global::Avion.Properties.Resources.mapamundi;
            this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel1.Controls.Add(this.Reinicio);
            this.Panel1.Controls.Add(this.Avion);
            this.Panel1.Controls.Add(this.Pais);
            this.Panel1.Controls.Add(this.TextoDestino);
            this.Panel1.Controls.Add(this.TextoPrtida);
            this.Panel1.Controls.Add(this.Texto);
            this.Panel1.Controls.Add(this.label3);
            this.Panel1.Controls.Add(this.Tiempo);
            this.Panel1.Controls.Add(this.Control);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.Australia);
            this.Panel1.Controls.Add(this.Guatemala);
            this.Panel1.Controls.Add(this.Rusia);
            this.Panel1.Location = new System.Drawing.Point(12, 12);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(768, 474);
            this.Panel1.TabIndex = 0;
            this.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Pais
            // 
            this.Pais.AutoSize = true;
            this.Pais.BackColor = System.Drawing.Color.Transparent;
            this.Pais.Location = new System.Drawing.Point(18, 388);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(33, 13);
            this.Pais.TabIndex = 12;
            this.Pais.Text = "Pais: ";
            // 
            // Australia
            // 
            this.Australia.BackColor = System.Drawing.Color.Transparent;
            this.Australia.BackgroundImage = global::Avion.Properties.Resources.Punto;
            this.Australia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Australia.InitialImage = null;
            this.Australia.Location = new System.Drawing.Point(608, 345);
            this.Australia.Name = "Australia";
            this.Australia.Size = new System.Drawing.Size(20, 20);
            this.Australia.TabIndex = 11;
            this.Australia.TabStop = false;
            this.Australia.Click += new System.EventHandler(this.Australia_Click);
            // 
            // Avion
            // 
            this.Avion.BackColor = System.Drawing.Color.Transparent;
            this.Avion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avion.InitialImage = null;
            this.Avion.Location = new System.Drawing.Point(100, 366);
            this.Avion.Name = "Avion";
            this.Avion.Size = new System.Drawing.Size(40, 40);
            this.Avion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avion.TabIndex = 5;
            this.Avion.TabStop = false;
            // 
            // TextoDestino
            // 
            this.TextoDestino.AutoSize = true;
            this.TextoDestino.BackColor = System.Drawing.Color.Transparent;
            this.TextoDestino.Location = new System.Drawing.Point(18, 189);
            this.TextoDestino.Name = "TextoDestino";
            this.TextoDestino.Size = new System.Drawing.Size(49, 13);
            this.TextoDestino.TabIndex = 10;
            this.TextoDestino.Text = "Destino: ";
            // 
            // TextoPrtida
            // 
            this.TextoPrtida.AutoSize = true;
            this.TextoPrtida.BackColor = System.Drawing.Color.Transparent;
            this.TextoPrtida.Location = new System.Drawing.Point(18, 176);
            this.TextoPrtida.Name = "TextoPrtida";
            this.TextoPrtida.Size = new System.Drawing.Size(46, 13);
            this.TextoPrtida.TabIndex = 9;
            this.TextoPrtida.Text = "Partida: ";
            // 
            // Texto
            // 
            this.Texto.AutoSize = true;
            this.Texto.BackColor = System.Drawing.Color.Transparent;
            this.Texto.Location = new System.Drawing.Point(308, 439);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(109, 13);
            this.Texto.TabIndex = 8;
            this.Texto.Text = "Haz clic en comenzar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(62, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "angulo = 0";
            // 
            // Tiempo
            // 
            this.Tiempo.AutoSize = true;
            this.Tiempo.BackColor = System.Drawing.Color.Transparent;
            this.Tiempo.Location = new System.Drawing.Point(21, 13);
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.Size = new System.Drawing.Size(13, 13);
            this.Tiempo.TabIndex = 6;
            this.Tiempo.Text = "0";
            // 
            // Control
            // 
            this.Control.Location = new System.Drawing.Point(659, 435);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(75, 23);
            this.Control.TabIndex = 4;
            this.Control.Text = "Comenzar";
            this.Control.UseVisualStyleBackColor = true;
            this.Control.Click += new System.EventHandler(this.Control_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y = 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X = 0";
            // 
            // Guatemala
            // 
            this.Guatemala.BackColor = System.Drawing.Color.Transparent;
            this.Guatemala.BackgroundImage = global::Avion.Properties.Resources.Punto;
            this.Guatemala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guatemala.InitialImage = null;
            this.Guatemala.Location = new System.Drawing.Point(195, 259);
            this.Guatemala.Name = "Guatemala";
            this.Guatemala.Size = new System.Drawing.Size(20, 20);
            this.Guatemala.TabIndex = 0;
            this.Guatemala.TabStop = false;
            this.Guatemala.Click += new System.EventHandler(this.Guatemala_Click);
            // 
            // Rusia
            // 
            this.Rusia.BackColor = System.Drawing.Color.Transparent;
            this.Rusia.BackgroundImage = global::Avion.Properties.Resources.Punto;
            this.Rusia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rusia.InitialImage = null;
            this.Rusia.Location = new System.Drawing.Point(516, 129);
            this.Rusia.Name = "Rusia";
            this.Rusia.Size = new System.Drawing.Size(20, 20);
            this.Rusia.TabIndex = 1;
            this.Rusia.TabStop = false;
            this.Rusia.Click += new System.EventHandler(this.Rusia_Click);
            // 
            // Reinicio
            // 
            this.Reinicio.Location = new System.Drawing.Point(578, 434);
            this.Reinicio.Name = "Reinicio";
            this.Reinicio.Size = new System.Drawing.Size(75, 23);
            this.Reinicio.TabIndex = 13;
            this.Reinicio.Text = "Reiniciar";
            this.Reinicio.UseVisualStyleBackColor = true;
            this.Reinicio.Click += new System.EventHandler(this.Reinicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 498);
            this.Controls.Add(this.Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Avion";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Australia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guatemala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rusia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.PictureBox Avion;
        private System.Windows.Forms.PictureBox Guatemala;
        private System.Windows.Forms.PictureBox Rusia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Control;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Tiempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Texto;
        private System.Windows.Forms.Label TextoDestino;
        private System.Windows.Forms.Label TextoPrtida;
        private System.Windows.Forms.PictureBox Australia;
        private System.Windows.Forms.Label Pais;
        private System.Windows.Forms.Button Reinicio;
    }
}

