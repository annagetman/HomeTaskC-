using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int x;
        int y;

        Bitmap _bitmap;
        Graphics _graphics;
        Pen _pen;


        Point mouseStart;
        Point mouseEnd;

        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(10, 10);
           
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            _pen = new Pen(Color.Blue, 4);
            _pen.EndCap = LineCap.ArrowAnchor;
            //_pen.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;
           //_pen.EndCap = LineCap.DiamondAnchor;
            _graphics = Graphics.FromImage(_bitmap);

            pictureBox1.Image = _bitmap;

        }

        public void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseStart = new Point(e.X, e.Y);

            //_pointFirst = new Point(x = e.X, y = e.Y);
        }

        public void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseEnd = new Point(e.X, e.Y);

            pictureBox1.CreateGraphics().Clear(Form1.DefaultBackColor);

            //_pointSecond = new Point(x = e.X, y = e.Y);

            _graphics.DrawLine(_pen, mouseStart, mouseEnd);

            //pictureBox1.Image = _bitmap;


            //pictureBox1.Invalidate();


        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //_graphics.DrawLine(_pen, mouseStart, e.Location);

            pictureBox1.Image = _bitmap;

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    _bitmap.SetPixel(i + e.X, j + e.Y, Color.Red);
                }
            }

            pictureBox1.Invalidate();
        }

    }
}
