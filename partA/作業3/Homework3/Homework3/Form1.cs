using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog;
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG(*.PNG)|*.png|" + "BMP(*.BMP)|*.bmp|" + "JPG(*.jpg)|*.jpg|" + "GIF(*.GIT)|*.gif|" + "所有檔案|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = (Bitmap)Image.FromFile(openFileDialog.FileName);
                string[] xValues = new string[256];
                int[] yValues = new int[256];
                for (int i = 0; i < 256; i++)
                {
                    xValues[i] = i + "";
                    yValues[i] = 0;
                }
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c;
                        c = bmp.GetPixel(x, y);
                        int grey = (c.R + c.G + c.B) / 3;
                        bmp.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                        yValues[grey]++;
                    }
                }
                chart_original.Series["Series1"].Points.DataBindXY(xValues, yValues);
                pictureBox_original.Image = bmp;
            }

        }

        private void Histogram_Shrink_Click(object sender, EventArgs e)
        {
            int rMax = 0, rMin = 255, sMax = 100, sMin = 0;
            string[] xValues = new string[256];
            int[] yValues = new int[256];
            for (int i = 0; i < 256; i++)
            {
                xValues[i] = i + "";
                yValues[i] = 0;
            }
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            Bitmap bmpa = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    c = bmp.GetPixel(x, y);
                    int grey = c.R;
                    if (grey > rMax) rMax = grey;
                    if (grey < rMin) rMin = grey;
                }
            }
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    c = bmp.GetPixel(x, y);
                    int grey = c.R;
                    grey = (sMax - sMin) * (grey - rMin) / (rMax - rMin) + sMin;
                    bmpa.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    yValues[grey]++;
                }
            }
            chart_Shrink.Series["Series1"].Points.DataBindXY(xValues, yValues); ;
            pictureBox_Shrink.Image = bmpa;
        }

        private void Histogram_Stretch_Click(object sender, EventArgs e)
        {
            int rMax = 0, rMin = 255, sMax = 255, sMin = 0;
            string[] xValues = new string[256];
            int[] yValues = new int[256];
            for (int i = 0; i < 256; i++)
            {
                xValues[i] = i + "";
                yValues[i] = 0;
            }
            Bitmap bmp = (Bitmap)pictureBox_Shrink.Image;
            Bitmap bmpa = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    c = bmp.GetPixel(x, y);
                    int grey = c.R;
                    if (grey > rMax) rMax = grey;
                    if (grey < rMin) rMin = grey;
                }
            }
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    c = bmp.GetPixel(x, y);
                    int grey = c.R;
                    grey = (sMax - sMin) * (grey - rMin) / (rMax - rMin) + sMin;
                    bmpa.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    yValues[grey]++;
                }
            }
            chart_Stretch.Series["Series1"].Points.DataBindXY(xValues, yValues); ;
            pictureBox_Stretch.Image = bmpa;
        }

        private void button_Slide_Click(object sender, EventArgs e)
        {
            
            int sMax =256;
            string[] xValues = new string[256];
            double[] S = new double[256];
            int[] yValues = new int[256];
            for (int i = 0; i < 256; i++)
            {
                xValues[i] = i + "";
                yValues[i] = 0;
                S[i] = 0;
            }
            Bitmap bmp = (Bitmap)pictureBox_Shrink.Image;
            Bitmap bmpa = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    c = bmp.GetPixel(x, y);
                    int grey = c.R;
                    yValues[grey]++;
                }
            }
            int Nsum = 0 , pixelCount = pictureBox_original.Image.Width * pictureBox_original.Image.Height;
            for (int i = 0; i < sMax; i++)
            {
                Nsum += yValues[i];
                S[i] = ((double)Nsum) / (pixelCount);
            }
            for (int i = 0; i < sMax; i++)
            {
                S[i] *= sMax;
            }
            for (int i = 0; i < 256; i++)
            {
                yValues[i] = 0;
            }
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    c = bmp.GetPixel(x, y);
                    int grey = c.R;
                    if (S[grey] >= 255) grey = 255;
                    else if (S[grey] <= 0) grey = 0;
                    else grey = (int)S[grey];
                    bmpa.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    yValues[grey]++;
                }
            }
            chart_Equalization.Series["Series1"].Points.DataBindXY(xValues, yValues); ;
            pictureBox_Equalization.Image = bmpa;
        }
    }
}
