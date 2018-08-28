using System;
using System.Drawing;
using System.Windows.Forms;

namespace discoball
{
    public partial class solo : Form
    {
        public solo()
        {
            InitializeComponent();
        }

        int Velocidad1=20, Conta=0, Puntos = 0;
        bool Arriba1, Izquierda1;

        private void solo_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Top = e.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bola.Right < button1.Right)
            {
                timer1.Enabled = false;
               MessageBox.Show("Puntos   "+Puntos.ToString()+"  Doble Click para reiniciar o cerrar para salir");
                Puntos = 0;
                Velocidad1 = 20;
                Conta = 0;
            }
            if (Izquierda1 == true)
            {
                bola.Left += Velocidad1;
            }

            else
            {
                bola.Left -= Velocidad1;
            }

            if (Arriba1 == true)
            {
                bola.Top += Velocidad1;
            }

            else
            {
                bola.Top -= Velocidad1;
            }

            if (bola.Top >= this.Height - 75)
            {
                Arriba1 = false;
            }

            if (bola.Top <= 0)
            {
                Arriba1 = true;
            }

            if (bola.Left >= this.Width-50)
            {
                Izquierda1 = false;
            }

            if (bola.Left + bola.Width >= button1.Right &&
              bola.Left + bola.Width <= button1.Right + button1.Width &&
              bola.Top + bola.Height >= button1.Top &&
              bola.Top + bola.Height <= button1.Top + button1.Height)
            {
                Izquierda1 = true;
                Puntos += 1;
                this.Text="Puntos=  "+Puntos.ToString()+"";
                Conta += 1;
                if (Conta >=2)
                {
                    Velocidad1 += 10;
                    Conta = 0;
                }
            }
        }

        private void solo_Load(object sender, MouseEventArgs e)
        {
            Iniciar();
        }

        private void solo_Load(object sender, EventArgs e)
        {
            Iniciar();
        }
        private void solo_FormClosing(object sender, FormClosingEventArgs e)
        {
         this.Owner.Show();
        }

        public void Iniciar()
        {
            this.Text = "Puntos = 0";
            Random Pelotita = new Random();
            bola.Location = new Point(0, Pelotita.Next(this.Height));
            Arriba1 = false;
            Izquierda1 = true;
            timer1.Enabled = true;
            Puntos = 0;
        }
    }
}
