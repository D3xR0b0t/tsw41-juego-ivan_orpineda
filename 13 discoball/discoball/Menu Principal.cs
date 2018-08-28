using System;
using System.Media;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discoball
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            solo ventana1 = new solo();
            ventana1.ShowDialog(); //.Show(this);
            //this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int puntaje = Convert.ToInt32(textBox1.Text);
            Form1 ventana2 = new Form1(puntaje);
            ventana2.ShowDialog();
            SystemSounds.Beep.Play();
            // this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
            //using (Form1) 
          
        }
    }
}
