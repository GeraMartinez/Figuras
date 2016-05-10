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

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            if (contador == 1)
            {
                Graphics papel;
                papel = pictureBox1.CreateGraphics();
                Pen lapiz = new Pen(color);              
                papel.DrawEllipse(lapiz,10, 10, 10, 10);
            }
            if (contador == 2)
            {
                Graphics papel;
                papel = pictureBox1.CreateGraphics();
                Pen lapiz = new Pen(color);
                papel.DrawRectangle(lapiz, 100,50,100,50);
            }
            if (contador == 3)
            {
                // Graphics papel;
                // papel = pictureBox1.CreateGraphics();
                // Pen lapiz = new Pen(Color.Black);
                //papel.DrawCurve(lapiz,  100, 200, 100);

                

            }
}

       
    }
}

