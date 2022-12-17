using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(776, 426);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.Transparent);

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            Random rnd = new Random();
            var p1 = new Point(rnd.Next(w), rnd.Next(h));
            var p2 = new Point(rnd.Next(w), rnd.Next(h));
            var p3 = new Point(rnd.Next(w), rnd.Next(h));
            DrawTr(p1, p2, p3);
            Console.WriteLine("Coords of triangle: point1({0}, {1}), point2({2}, {3}), point3({4}, {5})", p1.X, p1.Y, p2.X, p2.Y, p3.X, p3.Y);

            pictureBox1.Invalidate();
        }
        static void Swap<T>(ref T first, ref T second)
        {
            T temp;
            temp = first;
            first = second;
            second = temp;
        }
        void DrawTr(Point p1, Point p2, Point p3)
        {
            //check if triangle is fine
            if ((p1.Y == p2.Y && p1.Y == p3.Y) || (p1.X == p2.X && p1.X == p3.X)) return;

            //sort the vertices lower-to-upper
            if (p1.Y > p2.Y) Swap(ref p1, ref p2);
            if (p1.Y > p3.Y) Swap(ref p1, ref p3);
            if (p2.Y > p3.Y) Swap(ref p3, ref p2); 

            int height = p3.Y - p1.Y;
            for (int i = 0; i < height; i++)
            {
                bool second_half = i > p2.Y - p1.Y || p2.Y == p1.Y;
                int segment_height = second_half ? p3.Y - p2.Y : p2.Y - p1.Y;

                float alpha = (float)i / height;
                float beta = (float)(i - (second_half ? p2.Y - p1.Y : 0)) / segment_height;

                //detect cross between triangle sides and horizontal line
                Point A = new Point((int)(p1.X + (p3.X - p1.X) * alpha), 
                                    (int)(p1.Y + (p3.Y - p1.Y) * alpha));
                Point B = second_half ? new Point((int)(p2.X + (p3.X - p2.X) * beta), 
                                                  (int)(p2.Y + (p3.Y - p2.Y) * beta)) : 
                                        new Point((int)(p1.X + (p2.X - p1.X) * beta), 
                                                  (int)(p1.Y + (p2.Y - p1.Y) * beta));

                if (A.X > B.X) Swap(ref A, ref B);

                //draw line between crosses
                for (int j = A.X; j <= B.X; j++)
                {
                    //choose color for pixel
                    var color = Color.FromArgb((int)(255 * (height - i) / height), 
                                               (int)(255 * (i + 1) / (p3.Y - p1.Y)), 
                                               (int)(255 * (B.X - j) / (B.X - A.X + 1)));

                    //fill pixel with chosen color
                    (pictureBox1.Image as Bitmap).SetPixel(j, p1.Y + i, color);                   
                }
            }
        }

        
    }
}
