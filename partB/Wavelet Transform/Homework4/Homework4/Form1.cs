using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int overRange(int a)
        {
            if (a > 255) return 255;
            else if (a < 0) return 0;
            else return a;
        }
        private int over(int a)
        {
            return a + 127;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openfile_Click(object sender, EventArgs e)
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
                pictureBox_original_GWF.Image = bmp;
            }
            button_General_Wavelet_form.Enabled = true;
        }

        private void button_General_Wavelet_form_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox_original_GWF.Image;
            int N = bmp.Height;
            Bitmap bmp1 = pass(N, bmp);
            N /= 2;
            bmp1 = pass(N, bmp1);
            N /= 2;
            bmp1 = pass(N, bmp1);
            pictureBox_GWF.Image = bmp1;
        }

        private Bitmap pass(int N, Bitmap bmp)
        {
            Bitmap bmp_GWF = new Bitmap(512, 512);
            for (int y = 0; y < 512; y++)
            {
                for (int x = 0; x < 512; x++)
                {
                    bmp_GWF.SetPixel(x, y, bmp.GetPixel(x, y));
                }
            }
            for (int y = 0; y < N; y += 2)
            {
                for (int x = 0; x < N; x += 2)
                {
                    Color c;
                    int sum = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            c = bmp.GetPixel(x + i, y + j);
                            sum += c.R;
                        }
                    }
                    sum /= 4;
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            bmp_GWF.SetPixel(x / 2 + (N / 2) * i, y / 2 + (N / 2) * j, Color.FromArgb(sum, sum, sum));
                        }
                    }

                }
            }
            Bitmap bmp_GWFA = new Bitmap(512, 512);
            for (int y = 0; y < 512; y++)
            {
                for (int x = 0; x < 512; x++)
                {
                    bmp_GWFA.SetPixel(x, y, bmp_GWF.GetPixel(x, y));
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Color c1, c2;
                    int grey;
                    if (j < N / 2)
                    {
                        if (j == 0)
                        {
                            c1 = bmp_GWF.GetPixel(i, j);
                            c2 = bmp_GWF.GetPixel(i, j + 1);
                        }
                        else
                        {
                            c1 = bmp_GWF.GetPixel(i, j + 1);
                            c2 = bmp_GWF.GetPixel(i, j + 2);
                        }
                        grey = (c1.R + c2.R) / 2;
                    }
                    else
                    {
                        if (j == N - 1)
                        {
                            c1 = bmp_GWF.GetPixel(i, j - 1);
                            c2 = bmp_GWF.GetPixel(i, j);
                        }
                        else
                        {
                            c1 = bmp_GWF.GetPixel(i, j - 2);
                            c2 = bmp_GWF.GetPixel(i, j - 1);
                        }
                        grey = (c1.R - c2.R) / 2;
                        grey = over(grey);
                    }
                    bmp_GWFA.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            }
            Bitmap bmp_GWFB = new Bitmap(bmp.Width, bmp.Height);
            for (int y = 0; y < 512; y++)
            {
                for (int x = 0; x < 512; x++)
                {
                    bmp_GWFB.SetPixel(x, y, bmp_GWFA.GetPixel(x, y));
                }
            }
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    Color c1, c2;
                    int grey;
                    if (i < N / 2)
                    {
                        if (i == 0)
                        {
                            c1 = bmp_GWFA.GetPixel(i, j);
                            c2 = bmp_GWFA.GetPixel(i + 1, j);
                        }
                        else
                        {
                            c1 = bmp_GWFA.GetPixel(i + 1, j);
                            c2 = bmp_GWFA.GetPixel(i + 2, j);
                        }
                        grey = (c1.R + c2.R) / 2;
                    }
                    else
                    {
                        if (i == N - 1)
                        {
                            c1 = bmp_GWFA.GetPixel(i - 1, j);
                            c2 = bmp_GWFA.GetPixel(i, j);
                        }
                        else
                        {
                            c1 = bmp_GWFA.GetPixel(i - 2, j);
                            c2 = bmp_GWFA.GetPixel(i - 1, j);
                        }
                        grey = (c1.R - c2.R) / 2;
                        grey = over(grey);
                    }
                    bmp_GWFB.SetPixel(i, j, Color.FromArgb(grey, grey, grey));
                }
            }
            return bmp_GWFB;
        }
    }
}
