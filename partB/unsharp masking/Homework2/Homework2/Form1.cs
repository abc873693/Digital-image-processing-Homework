using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog;
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP(*.BMP)|*.bmp|" + "PNG(*.PNG)|*.png|" + "JPG(*.jpg)|*.jpg|" + "GIF(*.GIT)|*.gif|" + "所有檔案|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = (Bitmap)Image.FromFile(openFileDialog.FileName);
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c;
                        c = bmp.GetPixel(x, y);
                        int grey = (c.R + c.G + c.B) / 3;
                        bmp.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                pictureBox_original.Image = bmp;
                button_unsharp_masking.Enabled = true;
            }
        }

        private void Button_unsharp_masking_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            Bitmap bmp_low_pass = LowPassFilter(bmp, 3);
            Bitmap bmp_A_B = Bitmap_minus(bmp, HistogramShrink(bmp_low_pass));
            Bitmap bmp_Stretching = HistogramStretch(bmp_A_B);
            pictureBox_unsharp_masking.Image = bmp_Stretching;
            Chart_print(bmp_A_B);

        }

        private void Chart_print(Bitmap bmp)
        {
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
            chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
        }

        private Bitmap LowPassFilter(Bitmap bmp, int N)
        {
            Bitmap bmp_result = new Bitmap(bmp.Width, bmp.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if ((x > N / 2 && y > N / 2 && x < bmp.Width - N / 2 && y < bmp.Height - N / 2))
                    {
                        int grey = 0;
                        for (int i = -(N / 2); i <= (N / 2); i++)
                        {
                            for (int j = -(N / 2); j <= (N / 2); j++)
                            {
                                grey += bmp.GetPixel(x + i, y + j).R;
                            }
                        }
                        grey /= (N * N);
                        grey = OverRange(grey);
                        bmp_result.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
            }
            return bmp_result;
        }

        private Bitmap HistogramShrink(Bitmap bmp, int rMax = 0, int rMin = 255, int sMax = 100, int sMin = 0)
        {

            Bitmap bmp_result = new Bitmap(bmp.Width, bmp.Height);
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
                    bmp_result.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }
            return bmp_result;
        }

        private Bitmap HistogramStretch(Bitmap bmp, int rMax = 0, int rMin = 255, int sMax = 255, int sMin = 0)
        {
            Bitmap bmp_result = new Bitmap(bmp.Width, bmp.Height);
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
                    //if (grey > (255 * 0.02) && grey < (255 * 0.98))
                    bmp_result.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }
            return bmp_result;
        }

        private Bitmap Bitmap_minus(Bitmap bmpA, Bitmap bmpB)
        {
            int Height = (bmpA.Height > bmpB.Height) ? bmpB.Height : bmpA.Height;
            int Width = (bmpA.Width > bmpB.Width) ? bmpB.Width : bmpA.Width;
            Bitmap bmp_result = new Bitmap(Width, Height);
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Color c = new Color();
                    int R = OverRange(bmpA.GetPixel(x, y).R - bmpB.GetPixel(x, y).R);
                    int G = OverRange(bmpA.GetPixel(x, y).R - bmpB.GetPixel(x, y).G);
                    int B = OverRange(bmpA.GetPixel(x, y).R - bmpB.GetPixel(x, y).B);
                    c = Color.FromArgb(R, G, B);
                    bmp_result.SetPixel(x, y, c);
                }
            }
            return bmp_result;
        }

        private int OverRange(int a)
        {
            if (a > 255) return 255;
            else if (a < 0) return 0;
            else return a;
        }
    }
}
