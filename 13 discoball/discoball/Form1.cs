using System;
using System.Drawing;
using System.Windows.Forms;

namespace discoball
{

    public partial class Form1 : Form
    {
        int puntos;
        public Form1(int puntaje)
        {
            InitializeComponent();
            puntos = puntaje;
        }
        int velocidad = 5;
        int p1 = 0, p2 = 0;
        bool arriba = true, izquierda = true;
        private void Form1_Load(object sender, EventArgs e)
        {
            Iniciar();      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button3.Left > button2.Left )
            {  
                timer1.Enabled = false;
                MessageBox.Show("Jugador 1 Anota\n\n\nPULSA 2 VECES \n\n Click", "PUNTO");
                velocidad = 5;
                p1 += 1;
                if (p1 == puntos)
                {
                    MessageBox.Show("Jugador 1 es el Ganador","Ganador");
                    Menu_Principal principal = new Menu_Principal();
                    principal.Show();
                    this.Hide();
                }
            } 
            if (button3.Right < button1.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("Jugador 2 Anota\n\n\n PULSA 2 VECES \n\nClick", "PUNTO");
                velocidad = 5;
                p2 += 1;
                izquierda = true;
                if (p2 == puntos)
                {
                    MessageBox.Show("Jugador 2 es el Ganador", "Ganador");
                    Menu_Principal principal = new Menu_Principal();
                    principal.Show();
                    this.Hide();

                }
            }

            if (button3.Left + button3.Width >= button2.Left &&
                button3.Left + button3.Width <= button2.Left + button2.Width &&
                button3.Top + button3.Height >= button2.Top &&
                button3.Top + button3.Height <= button2.Top + button2.Height)
            {
                izquierda = false;
                velocidad += 1;
            }

            if (button3.Left + button3.Width >= button1.Right &&
                button3.Left + button3.Width <= button1.Right + button1.Width &&
                button3.Top + button3.Height >= button1.Top &&
                button3.Top + button3.Height <= button1.Top + button1.Height)
            {
                izquierda = true;
                velocidad += 1;
            }

            if (izquierda == true)
            {
                button3.Left += velocidad;
            }

            else
            {
                button3.Left -= velocidad;
            }

            if (arriba == true)
            {
                button3.Top += velocidad;
            }

            else
            {
                button3.Top -= velocidad;
            }

            if (button3.Top >= this.Height - 75)
            {
                arriba = false;
            }

            if (button3.Top <= 0)
            {
                arriba = true;
            }
        }

        public void Iniciar()
        {
            this.Text = "Player 1  " + p1.ToString() + "             Player 2  " + p2.ToString();
            Random aleatorio = new Random();
            button3.Location = new Point(20, aleatorio.Next(this.Height,this.Width));
            timer1.Enabled = true;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Iniciar();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            p1 = 0;p2 = 0;
            arriba = true; izquierda = true;
            velocidad = 5;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y - 54);
            }
            else if (e.KeyData == Keys.Z)
            {
                button1.Location = new Point(button1.Location.X, button1.Location.Y + 54);
            }
            else if (e.KeyData == Keys.P)
            {
                button2.Location = new Point(button2.Location.X, button2.Location.Y - 54);
            }
            else if (e.KeyData == Keys.L)
            {
                button2.Location = new Point(button2.Location.X, button2.Location.Y + 54);
            }
          
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
