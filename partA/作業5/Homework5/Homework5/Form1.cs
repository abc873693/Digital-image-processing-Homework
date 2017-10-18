using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework5
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
                progressBar1.Maximum = bmp.Height-1;
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c;
                        c = bmp.GetPixel(x, y);
                        int grey =( c.R + c.G + c.B)/3;
                        bmp.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                    progressBar1.Value = y;
                }
                pictureBox_original.Image = bmp;
                button_alpha_trimmed.Enabled = true;
                button_median_filter.Enabled = true;
                button_Smoothing_filter.Enabled = true;
            }
        }

        private void button_Smoothing_filter_Click(object sender, EventArgs e)
        {
            int N = 3;
            if (radioButton_3X3.Checked) N = 3;
            else if (radioButton_5X5.Checked) N = 5;
            else if (radioButton_7X7.Checked) N = 7;
            else if (radioButton_9X9.Checked) N = 9;
            else if (radioButton_21X21.Checked) N = 21;
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            Bitmap bmpa = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            progressBar1.Maximum = bmp.Height - 1;
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    if ((x > N / 2 && y > N / 2 && x < bmp.Width - N / 2 && y < bmp.Height - N / 2))
                    {
                        int grey = 0;
                        for (int i = -(N / 2); i <= (N / 2); i++)
                        {
                            for (int j = -(N / 2); j <= (N / 2); j++)
                            {
                                c = bmp.GetPixel(x + i, y + j);
                                grey += c.R;
                            }
                        }
                        grey /= (N * N);
                        bmpa.SetPixel(x, y, Color.FromArgb(grey, grey , grey));
                    }
                    else bmpa.SetPixel(x, y, bmp.GetPixel(x, y));
                }
                progressBar1.Value = y;
            }
            pictureBox_Smoothing_filter.Image = bmpa;
        }

        private void button_median_filter_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            Bitmap bmpa = new Bitmap(bmp);
            int PixelCount = pictureBox_original.Image.Width * pictureBox_original.Image.Height;
            int NoisePixelCount = (int)(PixelCount * (rand.Next(1, 1000) / 1000f));
            bool[,] RandMap = new bool[pictureBox_original.Image.Width, pictureBox_original.Image.Height];
            int Count = 0, RandHeight, RandWidth;
            progressBar1.Value = 0;
            progressBar1.Maximum = NoisePixelCount + 2 * bmp.Height;
            while (Count < NoisePixelCount)
            {
                RandHeight = rand.Next(pictureBox_original.Image.Height);
                RandWidth = rand.Next(pictureBox_original.Image.Width);
                if (!RandMap[RandWidth, RandHeight])
                {
                    Color c;
                    c = bmp.GetPixel(RandWidth, RandHeight);
                    if (rand.Next(100) > 75)
                    {
                        c = Color.Black;
                    }
                    else if (rand.Next(100) > 75)
                    {
                        c = Color.White;
                    }
                    bmpa.SetPixel(RandWidth, RandHeight, c);
                    RandMap[RandWidth, RandHeight] = true;
                    Count++;
                    progressBar1.Value ++;
                }
            }
            pictureBox_Impulse_noise.Image = bmpa;
            int N = 3;
            Bitmap bmp3X3 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    if ((x > N / 2 && y > N / 2 && x < bmp.Width - N / 2 && y < bmp.Height - N / 2))
                    {
                        List<int> grey = new List<int>();
                        for (int i = -(N / 2); i <= (N / 2); i++)
                        {
                            for (int j = -(N / 2); j <= (N / 2); j++)
                            {
                                c = bmpa.GetPixel(x + i, y + j);
                                grey.Add(c.R);
                            }
                        }
                        grey.Sort();
                        int index = (N*N)/2;
                        bmp3X3.SetPixel(x, y, Color.FromArgb(grey[index], grey[index], grey[index]));
                    }
                    else bmp3X3.SetPixel(x, y, bmpa.GetPixel(x, y));
                }
                progressBar1.Value++;
            }
            pictureBox_median_filter3X3.Image = bmp3X3;
            N = 5;
            Bitmap bmp5X5 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    if ((x > N / 2 && y > N / 2 && x < bmp.Width - N / 2 && y < bmp.Height - N / 2))
                    {
                        List<int> grey = new List<int>();
                        for (int i = -(N / 2); i <= (N / 2); i++)
                        {
                            for (int j = -(N / 2); j <= (N / 2); j++)
                            {
                                c = bmpa.GetPixel(x + i, y + j);
                                grey.Add(c.R);
                            }
                        }
                        grey.Sort();
                        int index = (N * N) / 2;
                        bmp5X5.SetPixel(x, y, Color.FromArgb(grey[index], grey[index], grey[index]));
                    }
                    else bmp5X5.SetPixel(x, y, bmpa.GetPixel(x ,y));
                }
                progressBar1.Value++;
            }
            pictureBox_median_filter5X5.Image = bmp5X5;
            progressBar1.Value = progressBar1.Maximum;
        }

        private void button_alpha_trimmed_Click(object sender, EventArgs e)
        {
            Double m = 0, lo = Math.Sqrt(400);
            Double Gaussian_value = (Math.Sqrt(12) * lo) / Math.Sqrt(10);
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            Bitmap bmpa = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            Random rand = new Random();
            int PixelCount = pictureBox_original.Image.Width * pictureBox_original.Image.Height;
            int NoisePixelCount = (int)(PixelCount * (rand.Next(1, 1000) / 1000f));
            bool[,] RandMap = new bool[pictureBox_original.Image.Width, pictureBox_original.Image.Height];
            int Count = 0, RandHeight, RandWidth;
            progressBar1.Value = 0;
            progressBar1.Maximum = NoisePixelCount + 4 * bmp.Height;
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
                    bmpa.SetPixel(x, y, Color.FromArgb(R, G, B));
                }
                progressBar1.Value++;
            }
            while (Count < NoisePixelCount)
            {
                RandHeight = rand.Next(pictureBox_original.Image.Height);
                RandWidth = rand.Next(pictureBox_original.Image.Width);
                if (!RandMap[RandWidth, RandHeight])
                {
                    Color c;
                    c = bmp.GetPixel(RandWidth, RandHeight);
                    if (rand.Next(100) > 95)
                    {
                        c = Color.Black;
                    }
                    else if (rand.Next(100) > 95)
                    {
                        c = Color.White;
                    }
                    bmpa.SetPixel(RandWidth, RandHeight, c);
                    RandMap[RandWidth, RandHeight] = true;
                    Count++;
                    progressBar1.Value++;
                }
            }
            pictureBox_Gaussian_noise_impulse_noise.Image = bmpa;
            int N = 3,T = 1;
            Bitmap bmp3X3_T1 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    if ((x > N / 2 && y > N / 2 && x < bmp.Width - N / 2 && y < bmp.Height - N / 2))
                    {
                        List<int> grey = new List<int>();
                        for (int i = -(N / 2); i <= (N / 2); i++)
                        {
                            for (int j = -(N / 2); j <= (N / 2); j++)
                            {
                                c = bmpa.GetPixel(x + i, y + j);
                                grey.Add(c.R);
                            }
                        }
                        grey.Sort();
                        for (int i = 0; i < T; i++)
                        {
                            grey.RemoveAt(0);
                        }
                        for (int i = 0; i < T; i++)
                        {
                            grey.RemoveAt(grey.Count-1);
                        }
                        int av = Convert.ToInt32(grey.Average());
                        bmp3X3_T1.SetPixel(x, y, Color.FromArgb(av, av, av));
                    }
                    else bmp3X3_T1.SetPixel(x, y, bmpa.GetPixel(x, y));
                }
                progressBar1.Value++;
            }
            pictureBox_alpha_trimmed3X3_T1.Image = bmp3X3_T1;
            T = 2;
            Bitmap bmp3X3_T2 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    if ((x > N / 2 && y > N / 2 && x < bmp.Width - N / 2 && y < bmp.Height - N / 2))
                    {
                        List<int> grey = new List<int>();
                        for (int i = -(N / 2); i <= (N / 2); i++)
                        {
                            for (int j = -(N / 2); j <= (N / 2); j++)
                            {
                                c = bmpa.GetPixel(x + i, y + j);
                                grey.Add(c.R);
                            }
                        }
                        grey.Sort();
                        for (int i = 0; i < T; i++)
                        {
                            grey.RemoveAt(0);
                        }
                        for (int i = 0; i < T; i++)
                        {
                            grey.RemoveAt(grey.Count - 1);
                        }
                        int av = Convert.ToInt32(grey.Average());
                        bmp3X3_T2.SetPixel(x, y, Color.FromArgb(av, av, av));
                    }
                    else bmp3X3_T2.SetPixel(x, y, bmpa.GetPixel(x, y));
                }
                progressBar1.Value++;
            }
            pictureBox_alpha_trimmed3X3_T2.Image = bmp3X3_T2;
            T = 4;
            Bitmap bmp3X3_T4 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c;
                    if ((x > N / 2 && y > N / 2 && x < bmp.Width - N / 2 && y < bmp.Height - N / 2))
                    {
                        List<int> grey = new List<int>();
                        for (int i = -(N / 2); i <= (N / 2); i++)
                        {
                            for (int j = -(N / 2); j <= (N / 2); j++)
                            {
                                c = bmpa.GetPixel(x + i, y + j);
                                grey.Add(c.R);
                            }
                        }
                        grey.Sort();
                        for (int i = 0; i < T; i++)
                        {
                            grey.RemoveAt(0);
                        }
                        for (int i = 0; i < T; i++)
                        {
                            grey.RemoveAt(grey.Count - 1);
                        }
                        int av = Convert.ToInt32(grey.Average());
                        bmp3X3_T4.SetPixel(x, y, Color.FromArgb(av, av, av));
                    }
                    else bmp3X3_T4.SetPixel(x, y, bmpa.GetPixel(x, y));
                }
                progressBar1.Value++;
            }
            pictureBox_alpha_trimmed3X3_T4.Image = bmp3X3_T4;
            progressBar1.Value = progressBar1.Maximum;
        }
        private Byte overRange(Double a)
        {
            if (a > 255) return 255;
            else if (a < 0) return 0;
            else return (Byte)a;
        }
        private int Average(List<int> grey)
        {
            int sum = 0;
            foreach (int i in grey)
                sum += i;
            return (sum / grey.Count);
        }
    }
}
