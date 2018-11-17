using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elixir_counter
{
    public partial class Form1 : Form
    {
        int minuto = 2;
        int segundo = 60;
        public Form1()
        {
            InitializeComponent();
            tiempo.Text = "3:00";
        }

        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        { 
            if (keyData == Keys.D1 || keyData == Keys.NumPad1 && progressBar1.Value >= 10)
            {
                progressBar1.Value -= 10;
            }
            if (keyData == Keys.D2 || keyData == Keys.NumPad2 && progressBar1.Value >= 20)
            {
                progressBar1.Value -= 20;
            }
            if (keyData == Keys.D3 || keyData == Keys.NumPad3 && progressBar1.Value >= 30)
            {
                progressBar1.Value -= 30;
            }
            if (keyData == Keys.D4 || keyData == Keys.NumPad4 && progressBar1.Value >= 40)
            {
                progressBar1.Value -= 40;
            }
            if (keyData == Keys.D5 || keyData == Keys.NumPad5 && progressBar1.Value >= 50)
            {
                progressBar1.Value -= 50;
            }
            if (keyData == Keys.D6 || keyData == Keys.NumPad6 && progressBar1.Value >= 60)
            {
                progressBar1.Value -= 60;
            }
            if (keyData == Keys.D7 || keyData == Keys.NumPad7 && progressBar1.Value >= 70)
            {
                progressBar1.Value -= 70;
            }
            if (keyData == Keys.D8 || keyData == Keys.NumPad8 && progressBar1.Value >= 80)
            {
                progressBar1.Value -= 80;
            }
            if (keyData == Keys.D9 || keyData == Keys.NumPad9 && progressBar1.Value >= 90)
            {
                progressBar1.Value -= 90;
            }
            if(keyData == Keys.F1)
            {
                timer1.Enabled = timer2.Enabled = true;
            }
            if(keyData == Keys.F2)
            {
                timer1.Enabled = timer2.Enabled = false;
                minuto = 2;
                segundo = 60;
                por.Text = "x1";
                progressBar1.Value = 5;
                tiempo.Text = "3:00";
                ecounter.Text = 5.ToString();
            }
            string aux = progressBar1.Value.ToString();
            if (aux.Length == 1){
                ecounter.Text = "0";
            }
            else{
                ecounter.Text = aux.Substring(0, aux.Length - 1);
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = timer2.Enabled = true;   
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string aux = "";
            if (minuto == 1 && segundo == 0)
            {
                timer1.Interval = 140;
                por.Text = "x2";
            }

            if (progressBar1.Value != 100)
            {
                progressBar1.PerformStep();
                aux = progressBar1.Value.ToString();
                if (aux[aux.Length-1] == '0')
                {
                    ecounter.Text = aux.Substring(0, aux.Length-1);
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void reboot_Click(object sender, EventArgs e)
        {
            timer1.Enabled = timer2.Enabled = false;
            minuto = 2;
            segundo = 60;
            por.Text = "x1";
            progressBar1.Value = 5;
            tiempo.Text = "3:00";
            ecounter.Text = 5.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            segundo--;
            if(minuto > 0 && segundo == 0)
            {
                segundo = 59;
                minuto--;
            }
            if (minuto == 0 && segundo == 0)
            {
                timer1.Enabled = timer2.Enabled = false;
            }
            if (segundo > 9)
            {
                tiempo.Text = minuto + ":" + segundo;
            }
            else
            {
                tiempo.Text = minuto + ":0" + segundo;
            }
        }

        private void ayuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pulsa F1 para iniciar \n" +
                "Pulsa F2 para reiniciar \n" +
                "Puedes utilizar cualquier número para eliminar elixir", "Ayuda",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
