using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyección_3D
{
    public partial class Form1 : Form
    {
        private static Bitmap bmp;
        private static Graphics g;
        private static Graphics l;
        private Scene scene;
        private Figure cube;
     
        private int Ox, Oy;
        private float degrees;
        private float radians;
        private int option;
        private Point a, b, c, d;


        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            Ox = bmp.Width / 2;
            Oy = bmp.Height / 2;

            

            // Crear una nueva escena y agregar un cubo
            scene = new Scene();
            cube = new Figure(8);
            scene.Figures.Add(cube);
           
            degrees = 0;
            // Iniciar el timer
            pictureBox1.Refresh();
        }

        private void createPoints3D(float length,float x,float y)
        {
            cube.vertices.Add(new Vertex(-length+x, -length+y, length));
            cube.vertices.Add(new Vertex(-length+x, length+y, length));
            cube.vertices.Add(new Vertex(length+x, length+y, length));
            cube.vertices.Add(new Vertex(length+x, -length+y, length));
            cube.vertices.Add(new Vertex(length+x, length+y, -length));
            cube.vertices.Add(new Vertex(length+x, -length+y, -length));
            cube.vertices.Add(new Vertex(-length+x, length+y, -length));
            cube.vertices.Add(new Vertex(-length+x, -length+y, -length));
        }

        private void centerPoints()
        {
            for (int i = 0; i < scene.Figures[0].Pts.Count; i++)
            {
                scene.Figures[0].Pts[i] = new PointF(scene.Figures[0].Pts[i].X + Ox, Oy - scene.Figures[0].Pts[i].Y);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TB_Y.Value= 0;
            TB_X.Value= 0;
        }

        public void drawFigure()
        {
            a = new Point(0, bmp.Height / 2);
            b = new Point(bmp.Width, bmp.Height / 2);
            c = new Point(bmp.Width / 2, bmp.Height);
            d = new Point(bmp.Width / 2, 0);

            g.Clear(Color.Black);

            g.DrawLine(Pens.Yellow, a, b);
            g.DrawLine(Pens.Yellow, c, d);

            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(0), scene.Figures[0].Pts.ElementAt(1));
            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(1), scene.Figures[0].Pts.ElementAt(2));
            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(2), scene.Figures[0].Pts.ElementAt(3));
            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(3), scene.Figures[0].Pts.ElementAt(0));

            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(2), scene.Figures[0].Pts.ElementAt(4));
            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(3), scene.Figures[0].Pts.ElementAt(5));
            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(5), scene.Figures[0].Pts.ElementAt(4));

            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(1), scene.Figures[0].Pts.ElementAt(6));
            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(0), scene.Figures[0].Pts.ElementAt(7));
            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(6), scene.Figures[0].Pts.ElementAt(7));

            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(6), scene.Figures[0].Pts.ElementAt(4));
            g.DrawLine(Pens.Red, scene.Figures[0].Pts.ElementAt(7), scene.Figures[0].Pts.ElementAt(5));

            pictureBox1.Invalidate();
        }


        

        private float convertRadians(float angle,float speed)
        {
            angle = Convert.ToSingle((Math.PI / 180.0) * angle);
            degrees=degrees+speed;
            return angle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void timer_Tick(object sender, EventArgs e)
        {

            createPoints3D(trackBar1.Value,TB_X.Value,TB_Y.Value);

            radians = convertRadians(degrees,TB_SPEED.Value);

            if(trackBar2.Value<4)
            {
                scene.Figures[0].rotatePoints(radians, trackBar2.Value);
            }
            else {
                scene.Figures[0].rotatePoints(radians, 1);
                scene.Figures[0].rotatePoints(radians, 2);
                scene.Figures[0].rotatePoints(radians, 3);
            }
            
            
            scene.Figures[0].projectPoints();

            centerPoints();

            drawFigure();

            scene.Figures[0].Pts.Clear();

            cube.vertices.Clear();       

        }
    }
}
