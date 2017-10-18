using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework6
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

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog;
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP(*.BMP)|*.bmp|" + "PNG(*.PNG)|*.png|" + "JPG(*.jpg)|*.jpg|" + "GIF(*.GIT)|*.gif|" + "所有檔案|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = (Bitmap)Image.FromFile(openFileDialog.FileName);
                progressBar1.Maximum = bmp.Height - 1;
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c;
                        c = bmp.GetPixel(x, y);
                        int grey = (c.R + c.G + c.B) / 3;
                        bmp.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                    progressBar1.Value = y;
                }
                pictureBox_original.Image = bmp;
                button_spatial_high_pass_filter.Enabled = true;
                button_spatial_high_boost_filter.Enabled = true;
            }
        }

        private void button_spatial_high_pass_filter_Click(object sender, EventArgs e)
        {
            int N = 3;
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            progressBar1.Maximum = bmp.Height * 3;
            progressBar1.Value = 0;
            Bitmap bmp3X3 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
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
                                if (i == 0 && j == 0) grey += c.R * (N * N - 1);
                                else grey -= c.R;
                            }
                        }
                        grey /= (N * N);
                        grey = overRange(grey);
                        bmp3X3.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            N = 5;
            pictureBox_spatial_high_pass_filter3X3.Image = bmp3X3;
            Bitmap bmp5X5 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
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
                                if (i == 0 && j == 0) grey += c.R * (N * N - 1);
                                else grey -= c.R;
                            }
                        }
                        grey /= (N * N);
                        grey = overRange(grey);
                        bmp5X5.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            N = 7;
            pictureBox_spatial_high_pass_filter5X5.Image = bmp5X5;
            Bitmap bmp7X7 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
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
                                if (i == 0 && j == 0) grey += c.R * (N * N - 1);
                                else grey -= c.R;
                            }
                        }
                        grey /= (N * N);
                        grey = overRange(grey);
                        bmp7X7.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_spatial_high_pass_filter7X7.Image = bmp7X7;
        }

        private void button_spatial_high_boost_filter_Click(object sender, EventArgs e)
        {
            int N = 3, A = 1;
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            progressBar1.Maximum = bmp.Height * 3;
            progressBar1.Value = 0;
            Bitmap bmp3X3_1 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
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
                                if (i == 0 && j == 0)
                                {
                                    grey += c.R * (N * N - 1);
                                    grey += c.R * (A - 1);
                                }
                                else grey -= c.R;
                            }
                        }
                        grey /= (N * N);
                        grey = overRange(grey);
                        bmp3X3_1.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_spatial_high_boost_filter3X3_1.Image = bmp3X3_1;
            A = 2;
            Bitmap bmp3X3_2 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
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
                                if (i == 0 && j == 0)
                                {
                                    grey += c.R * (N * N - 1);
                                    grey += c.R * (A - 1);
                                }
                                else grey -= c.R;
                            }
                        }
                        grey /= (N * N);
                        grey = overRange(grey);
                        bmp3X3_2.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_spatial_high_boost_filter3X3_2.Image = bmp3X3_2;
            A = 3;
            Bitmap bmp3X3_3 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
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
                                if (i == 0 && j == 0)
                                {
                                    grey += c.R * (N * N - 1);
                                    grey += c.R * (A - 1);
                                }
                                else grey -= c.R;
                            }
                        }
                        grey /= (N * N);
                        grey = overRange(grey);
                        bmp3X3_3.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_spatial_high_boost_filter3X3_3.Image = bmp3X3_3;
        }
    }
}
