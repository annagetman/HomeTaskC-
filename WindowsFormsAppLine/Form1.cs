using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLine
{
    public partial class Form1 : Form
    {
        Bitmap _mainBitmap;
        Bitmap _tempBitmap;
        Bitmap _bitmap;
        Pen _pen;
        Graphics _graphics;
        Point _firstPoint;
        Point _secondPoint;
        bool _isButtonPressed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Point point = new Point(1, 2);

            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _pen = new Pen(Color.Green, 8);

            _graphics = Graphics.FromImage(_bitmap);

            _graphics.DrawLine(_pen, 0, 0, 200, 300);

            pictureBox1.Image = _bitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    _bitmap.SetPixel(i + e.X, j + e.Y, Color.Red);
                }
            }

            pictureBox1.Invalidate();

            _mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            _pen = new Pen(Color.Red, 8);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);
            pictureBox1.Image = _mainBitmap;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            _firstPoint = e.Location;
            _isButtonPressed = true;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isButtonPressed)
            {
                _tempBitmap = (Bitmap)_mainBitmap.Clone();
                _graphics = Graphics.FromImage(_tempBitmap);
                _graphics.DrawLine(_pen, _firstPoint, e.Location);
                pictureBox1.Image = _tempBitmap;
                GC.Collect();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isButtonPressed = false;
            _mainBitmap = _tempBitmap;
        }
    }


}
