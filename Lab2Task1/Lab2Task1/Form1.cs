using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Lab2Task1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        { 
  
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                  
                    
                    MakeItGrayAgain( sender,  e);
                }
                catch
                {
                    MessageBox.Show("Can't open a file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }
 


        private void MakeItGrayAgain(object sender, EventArgs e)
        {
            
            chart1.Visible = true;
            chart1.Series.Clear();
            chart1.Series.Add("PAL/NTCS");
            chart1.Series["PAL/NTCS"].Color = Color.DarkGray;
            Dictionary<int, int> h1 = new Dictionary<int, int>();

            chart2.Visible = true;
            chart2.Series.Clear();
            chart2.Series.Add("HDTV");
            chart2.Series["HDTV"].Color = Color.DarkGray;
            Dictionary<int, int> h2 = new Dictionary<int, int>();

            if (pictureBox1.Image != null)
            {
                Bitmap input = new Bitmap(pictureBox1.Image);
                Bitmap output1 = new Bitmap(input.Width, input.Height);
                Bitmap output2 = new Bitmap(input.Width, input.Height);
                Bitmap output3 = new Bitmap(input.Width, input.Height);

                for (int j = 0; j < input.Height; j++)
                    for (int i = 0; i < input.Width; i++)
                    {
                        int R = input.GetPixel(i, j).R;
                        int G = input.GetPixel(i, j).G;
                        int B = input.GetPixel(i, j).B;

                        int grayPAL = (int)Math.Round(0.299f * R + 0.587f * G + 0.114f * B);
                        int grayHDTV = (int)Math.Round(0.2126f * R + 0.7152f * G + 0.0722f * B);
                        int grayDif = Math.Abs(grayHDTV - grayPAL);
                        
                        Color GP_newPixel = Color.FromArgb(255, grayPAL, grayPAL, grayPAL);
                        Color GH_newPixel = Color.FromArgb(255, grayHDTV, grayHDTV, grayHDTV);
                        Color GD_newPixel = Color.FromArgb(255, grayDif, grayDif, grayDif);

                        int GP_value = (GP_newPixel.R)+1;
                        int GH_value = (GH_newPixel.R)+1;
                       
                        if (h1.ContainsKey(GP_value))
                        {
                            h1[GP_value]++;
                        }
                        else
                        {
                            h1[GP_value] = 0;
                        }

                        if (h2.ContainsKey(GH_value))
                        {
                            h2[GH_value]++;
                        }
                        else
                        {
                            h2[GH_value] = 0;
                        }
                        
                        output1.SetPixel(i, j, GP_newPixel);
                        output2.SetPixel(i, j, GH_newPixel);
                        output3.SetPixel(i, j, GD_newPixel);
                    }
                pictureBox2.Image = output1;
                pictureBox3.Image = output2;
                pictureBox4.Image = output3;

                foreach (var i in h1)
                {
                    chart1.Series["PAL/NTCS"].Points.AddXY(i.Key, i.Value);
                }

                foreach (var i in h2)
                {
                    chart2.Series["HDTV"].Points.AddXY(i.Key, i.Value);
                }
            }
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
