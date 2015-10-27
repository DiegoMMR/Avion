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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Avion = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Rusia = new System.Windows.Forms.PictureBox();
            this.Guatemala = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tiempo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rusia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guatemala)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Avion.Properties.Resources.mapamundi;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Tiempo);
            this.panel1.Controls.Add(this.Avion);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Rusia);
            this.panel1.Controls.Add(this.Guatemala);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 474);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Avion
            // 
            this.Avion.BackColor = System.Drawing.Color.Transparent;
            this.Avion.BackgroundImage = global::Avion.Properties.Resources.Avion;
            this.Avion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avion.Location = new System.Drawing.Point(98, 343);
            this.Avion.Name = "Avion";
            this.Avion.Size = new System.Drawing.Size(59, 60);
            this.Avion.TabIndex = 5;
            this.Avion.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Inicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // Rusia
            // 
            this.Rusia.BackColor = System.Drawing.Color.Transparent;
            this.Rusia.BackgroundImage = global::Avion.Properties.Resources.Punto;
            this.Rusia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Rusia.InitialImage = null;
            this.Rusia.Location = new System.Drawing.Point(503, 124);
            this.Rusia.Name = "Rusia";
            this.Rusia.Size = new System.Drawing.Size(20, 20);
            this.Rusia.TabIndex = 1;
            this.Rusia.TabStop = false;
            this.Rusia.Click += new System.EventHandler(this.Rusia_Click);
            // 
            // Guatemala
            // 
            this.Guatemala.BackColor = System.Drawing.Color.Transparent;
            this.Guatemala.BackgroundImage = global::Avion.Properties.Resources.Punto;
            this.Guatemala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guatemala.InitialImage = null;
            this.Guatemala.Location = new System.Drawing.Point(196, 253);
            this.Guatemala.Name = "Guatemala";
            this.Guatemala.Size = new System.Drawing.Size(20, 20);
            this.Guatemala.TabIndex = 0;
            this.Guatemala.TabStop = false;
            this.Guatemala.Click += new System.EventHandler(this.Guatemala_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 498);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rusia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Guatemala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Guatemala;
        private System.Windows.Forms.PictureBox Rusia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Avion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Tiempo;
    }
}

