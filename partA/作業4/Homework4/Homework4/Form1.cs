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

namespace Homework4
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
            openFileDialog.Filter = "BMP(*.BMP)|*.bmp|" + "PNG(*.PNG)|*.png|" + "JPG(*.jpg)|*.jpg|" + "GIF(*.GIT)|*.gif|" + "所有檔案|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = (Bitmap)Image.FromFile(openFileDialog.FileName);
                pictureBox_original.Image = bmp;
            }
        }

        private void button_Gaussian_noise_Click(object sender, EventArgs e)
        {
            string[] xValues = new string[256];
            int[] yValues = new int[256];
            for (int i = 0; i < 256; i++)
            {
                xValues[i] = i + "";
                yValues[i] = 0;
            }
            Double m = 0, lo = 60;
            Double Gaussian_value = (Math.Sqrt(12) * lo) / Math.Sqrt(10);
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            Bitmap bmpa = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            Random rand = new Random();
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    c = bmp.GetPixel(x, y);
                    Double Noise;
                    Double total = 0, ran;
                    for (int k = 0; k < 20; k++)
                    {
                        ran = rand.NextDouble();
                        total += (float)(ran - 0.5f);
                    }
                    Noise = ((Gaussian_value * total) + m);
                    int R = overRange(c.R + Noise), G = overRange(c.G + Noise), B = overRange(c.B + Noise);
                    yValues[overRange(Noise + 127)]++;
                    bmpa.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
            }
            yValues[255] = 0;
            yValues[0] = 0;
            chart_Gaussian_noise.Series["Series1"].Points.DataBindXY(xValues, yValues);
            //chart_Gaussian_noise.ChartAreas[0].AxisY.Maximum = 2000;
            
            pictureBox_Gaussian_noise.Image = bmpa;
        }
        private Byte overRange(Double a)
        {
            if (a > 255) return 255;
            else if (a < 0) return 0;
            else return (Byte)a;
        }

        private void button_Uniform_noise_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] xValues = new string[256];
            int[] yValues = new int[256];
            for (int i = 0; i < 256; i++)
            {
                xValues[i] = i + "";
                yValues[i] = 0;
            }
            int a = 50, b = 210;
            int NoiseRange = Math.Abs(b - a);
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            Bitmap bmpa = new Bitmap(bmp);
            int PixelCount = pictureBox_original.Image.Width * pictureBox_original.Image.Height;
            int NoisePixelCount = (int)(PixelCount * (rand.Next(1, 1000) / 1000f));
            bool[,] RandMap = new bool[pictureBox_original.Image.Width, pictureBox_original.Image.Height];
            int Count = 0, RandHeight, RandWidth;
            while (Count < NoisePixelCount)
            {
                RandHeight = rand.Next(pictureBox_original.Image.Height);
                RandWidth = rand.Next(pictureBox_original.Image.Width);
                if (!RandMap[RandWidth, RandHeight])
                {
                    Color c;
                    c = bmp.GetPixel(RandWidth, RandHeight);
                    int Noise = rand.Next(NoiseRange) + a;
                    int R = overRange(c.R + Noise), G = overRange(c.G + Noise), B = overRange(c.B + Noise);
                    bmpa.SetPixel(RandWidth, RandHeight, Color.FromArgb(R, G, B));
                    RandMap[RandWidth, RandHeight] = true;
                    Count++;
                    yValues[overRange(Noise)]++;
                }
            }
            chart_Uniform_noise.Series["Series1"].Points.DataBindXY(xValues, yValues);
            pictureBox_Uniform_noise.Image = bmpa;
        }

        private void button_Impulse_noise_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] xValues = new string[2];
            int[] yValues = new int[2];
            yValues[0] = 0;
            yValues[1] = 0;
            xValues[0] = "pepper";
            xValues[1] = "salt";
            int a = 0, b = 255;
            int NoiseRange = Math.Abs(b - a);
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            Bitmap bmpa = new Bitmap(bmp);
            int PixelCount = pictureBox_original.Image.Width * pictureBox_original.Image.Height;
            int NoisePixelCount = (int)(PixelCount * (rand.Next(1, 1000) / 1000f));
            bool[,] RandMap = new bool[pictureBox_original.Image.Width, pictureBox_original.Image.Height];
            int Count = 0, RandHeight, RandWidth;
            while (Count < NoisePixelCount)
            {
                RandHeight = rand.Next(pictureBox_original.Image.Height);
                RandWidth = rand.Next(pictureBox_original.Image.Width);
                if (!RandMap[RandWidth, RandHeight])
                {
                    Color c;
                    c = bmp.GetPixel(RandWidth, RandHeight);
                    if (rand.Next(100) > 90)
                    {
                        c = Color.Black;
                        yValues[0]++;
                    }
                    else if (rand.Next(100) > 90)
                    {
                        c = Color.White;
                        yValues[1]++;
                    }
                    bmpa.SetPixel(RandWidth, RandHeight, c);
                    RandMap[RandWidth, RandHeight] = true;
                    Count++;
                }
            }
            chart_Impulse_noise.Series["Series1"].Points.DataBindXY(xValues, yValues);
            pictureBox_Impulse_noise.Image = bmpa;
        }
    }
}
