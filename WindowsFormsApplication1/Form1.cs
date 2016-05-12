using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //Color del contorno
        Color color;
       
    
        public Form1()
        {
            InitializeComponent();
            //Color por defecto
            color = Color.Black;
           

        }

        private void Form1_Load(object sender, EventArgs e)
        { }
        //Selector de figura
        public int contador = 0;
        public int tamaño = 1;
   
    
    private void button1_Click(object sender, EventArgs e)
        {
            contador = 1;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contador = 2; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //limpiar
            pictureBox1.Invalidate();
        }
        private void button4_Click(object sender, EventArgs e)
            //paleta de colores
        {
            ColorDialog diag = new ColorDialog();
            diag.ShowDialog();
            color = diag.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contador = 3;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }




        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            //Random
            Random x = new Random();
            Random y = new Random();

            if (contador == 1)
            {

                Pen lapiz = new Pen(color, tamaño);
                papel.DrawEllipse(lapiz, e.X,e.Y,50,50);
            }
            if (contador == 2)
            {

                Pen lapiz = new Pen(color, tamaño);
                papel.DrawRectangle(lapiz, e.X, e.Y, e.X-20, e.Y-20);
            }
            if (contador == 3)
            {

                Pen lapiz = new Pen(color, tamaño);
                Point[] points = { new Point(e.X+60, e.Y+30), new Point(e.X+10, e.Y+15), new Point(e.X+5,e.Y+60) };
                papel.DrawPolygon(lapiz, points);



            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                tamaño = Convert.ToInt32(textBox1.Text);
            tamaño = int.Parse(textBox1.Text);
            } 
            catch(FormatException)
            { }




        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
