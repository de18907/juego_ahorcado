using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_ahorcado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ahorcado_1_Click(object sender, EventArgs e)
        {

        }

        private void ahorcado_3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            var categoria_Animales = new List<string>() { "ardilla", "ballena", "bisonte", "caracol", "gaviota", "hormiga", "gorrion", "caballo", "canguro", "camello" };
            var categoria_Frutas = new List<string>() { "platano", "manzana", "ciruela", "nispero", "Castaña", "naranja", "granada", "toronja" };
            var categoria_carros = new List<string>() { };
            if (textBox2.Text == "a")
            {
                label1.Text = "a";
            }
            if (textBox2.Text == "r")
            {
                label2.Text = "r";
            }
            if (textBox2.Text == "d")
            {
                label3.Text = "d";
            }
            if (textBox2.Text == "i")
            {
                label4.Text = "i";
            }
            if (textBox2.Text == "l")
            {
                label5.Text = "l";
            }
            if (textBox2.Text == "l")
            {
                label6.Text = "l";
            }
            if (textBox2.Text == "a")
            {
                label7.Text = "a";
            }
            if(textBox2.Text != "a" && textBox2.Text != "r" && textBox2.Text != "d" && textBox2.Text != "i" && textBox2.Text != "l")
            {
                conteo += 1;
            }
            if(conteo == 0)
            {
                ahorcado_0.Visible = true;
                ahorcado_1.Visible = false;
                ahorcado_2.Visible = false;
                ahorcado_3.Visible = false;
                ahorcado_4.Visible = false;
                ahorcado_5.Visible = false;
                ahorcado_6.Visible = false;
            }
            if (conteo == 1)
            {
                ahorcado_0.Visible = false;
                ahorcado_1.Visible = true;
                ahorcado_2.Visible = false;
                ahorcado_3.Visible = false;
                ahorcado_4.Visible = false;
                ahorcado_5.Visible = false;
                ahorcado_6.Visible = false;
            }
            if (conteo == 2)
            {
                ahorcado_0.Visible = false;
                ahorcado_1.Visible = false;
                ahorcado_2.Visible = true;
                ahorcado_3.Visible = false;
                ahorcado_4.Visible = false;
                ahorcado_5.Visible = false;
                ahorcado_6.Visible = false;
            }
            if (conteo == 3)
            {
                ahorcado_0.Visible = false;
                ahorcado_1.Visible = false;
                ahorcado_2.Visible = false;
                ahorcado_3.Visible = true;
                ahorcado_4.Visible = false;
                ahorcado_5.Visible = false;
                ahorcado_6.Visible = false;
            }
            if (conteo == 4)
            {
                ahorcado_0.Visible = false;
                ahorcado_1.Visible = false;
                ahorcado_2.Visible = false;
                ahorcado_3.Visible = false;
                ahorcado_4.Visible = true;
                ahorcado_5.Visible = false;
                ahorcado_6.Visible = false;
            }
            if (conteo == 5)
            {
                ahorcado_0.Visible = false;
                ahorcado_1.Visible = false;
                ahorcado_2.Visible = false;
                ahorcado_3.Visible = false;
                ahorcado_4.Visible = false;
                ahorcado_5.Visible = true;
                ahorcado_6.Visible = false;
            }
            if (conteo == 6)
            {
                ahorcado_0.Visible = false;
                ahorcado_1.Visible = false;
                ahorcado_2.Visible = false;
                ahorcado_3.Visible = false;
                ahorcado_4.Visible = false;
                ahorcado_5.Visible = false;
                ahorcado_6.Visible = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
