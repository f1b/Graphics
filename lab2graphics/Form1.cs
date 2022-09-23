using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab2graphics
{
    public partial class Form1 : Form
    {
        List<int> xRange = new List<int>( new int[256] );
        List<int> yrFrequency = new List<int>();
        List<int> ygFrequency = new List<int>();
        List<int> ybFrequency = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pbSource_Click(object sender, EventArgs e)
        {
            int[] rChartData = new int[256];
            int[] gChartData = new int[256];
            int[] bChartData = new int[256];

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpeg;*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.Cancel) return;
                pbSource.Image = new Bitmap(ofd.FileName);
                //Bitmap[] rgb = GetRgbChannels((Bitmap)pbSource.Image, yrFrequency, ygFrequency, ybFrequency); //вызов функции
                Bitmap source = (Bitmap)pbSource.Image;
                Bitmap[] result = new Bitmap[] { new Bitmap(source.Width, source.Height), new Bitmap(source.Width, source.Height), new Bitmap(source.Width, source.Height) };
                for (int i = 0; i < source.Width; i++)
                {
                    for (int j = 0; j < source.Height; j++)
                    {
                        Color color = source.GetPixel(i, j);
                        result[0].SetPixel(i, j, Color.FromArgb(color.A, color.R, 0, 0));
                        rChartData[color.R]++;
                        result[1].SetPixel(i, j, Color.FromArgb(color.A, 0, color.G, 0));
                        gChartData[color.G]++;
                        result[2].SetPixel(i, j, Color.FromArgb(color.A, 0, 0, color.B));
                        bChartData[color.B]++;
                    }
                }

                rPb.Image = result[0];
                gPb.Image = result[1];
                bPb.Image = result[2];
                yrFrequency.AddRange(rChartData);
                ygFrequency.AddRange(gChartData);
                ybFrequency.AddRange(bChartData);
                rChart.Series["Series1"].Points.DataBindXY(xRange, yrFrequency);
                gChart.Series["Series1"].Points.DataBindXY(xRange, ygFrequency);
                bChart.Series["Series1"].Points.DataBindXY(xRange, ybFrequency);
            }
        }

        /*static Bitmap[] GetRgbChannels(Bitmap source, List<int> yr, List<int> yg, List<int> br)
        {
            
            
            yr.AddRange(rChartData);
            return result;
        }*/
    }
}
