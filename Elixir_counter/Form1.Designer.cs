namespace Elixir_counter
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ecounter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tiempo = new System.Windows.Forms.Label();
            this.por = new System.Windows.Forms.Label();
            this.reboot = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ayuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBar1.ForeColor = System.Drawing.Color.Fuchsia;
            this.progressBar1.Location = new System.Drawing.Point(15, 89);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(468, 51);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // ecounter
            // 
            this.ecounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecounter.Location = new System.Drawing.Point(435, 39);
            this.ecounter.Name = "ecounter";
            this.ecounter.Size = new System.Drawing.Size(45, 47);
            this.ecounter.TabIndex = 1;
            this.ecounter.Text = "5";
            this.ecounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ecounter.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo.Location = new System.Drawing.Point(13, 11);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(70, 25);
            this.tiempo.TabIndex = 3;
            this.tiempo.Text = "label1";
            // 
            // por
            // 
            this.por.AutoSize = true;
            this.por.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.por.Location = new System.Drawing.Point(12, 47);
            this.por.Name = "por";
            this.por.Size = new System.Drawing.Size(42, 31);
            this.por.TabIndex = 4;
            this.por.Text = "x1";
            this.por.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.por.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // reboot
            // 
            this.reboot.Location = new System.Drawing.Point(15, 146);
            this.reboot.Name = "reboot";
            this.reboot.Size = new System.Drawing.Size(87, 33);
            this.reboot.TabIndex = 5;
            this.reboot.Text = "Reiniciar";
            this.reboot.UseVisualStyleBackColor = true;
            this.reboot.Click += new System.EventHandler(this.reboot_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ayuda
            // 
            this.ayuda.Location = new System.Drawing.Point(393, 143);
            this.ayuda.Name = "ayuda";
            this.ayuda.Size = new System.Drawing.Size(87, 33);
            this.ayuda.TabIndex = 6;
            this.ayuda.Text = "Ayuda";
            this.ayuda.UseVisualStyleBackColor = true;
            this.ayuda.Click += new System.EventHandler(this.ayuda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 188);
            this.Controls.Add(this.ayuda);
            this.Controls.Add(this.reboot);
            this.Controls.Add(this.por);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ecounter);
            this.Controls.Add(this.progressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Elixir Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label ecounter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tiempo;
        private System.Windows.Forms.Label por;
        private System.Windows.Forms.Button reboot;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button ayuda;
    }
}

