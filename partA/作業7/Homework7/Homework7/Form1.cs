using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int overRange(int a)
        {
            a = Math.Abs(a);
            if (a > 255) return 255;
            else if (a < 0) return 0;
            else return a;
        }
        private int selectRef(int[,] s, int i, int j)
        {
            return s[i + 1, j + 1];
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
                button_Prewitt_operator_HVedge.Enabled = true;
                button_Prewitt_operator_Dedge.Enabled = true;
                button_Sobel_operator_HVedge.Enabled = true;
                button_Sobel_operator_Dedge.Enabled = true;
            }
        }

        private void button_Prewitt_operator_Click(object sender, EventArgs e)
        {
            int N = 3;
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            progressBar1.Maximum = bmp.Height * 3;
            progressBar1.Value = 0;
            Bitmap bmp_horizontal = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_horizontal = { { -1, -1, -1 },
                                    { 0 , 0 , 0 },
                                    { 1 , 1 , 1}};
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
                                grey += c.R * selectRef(s_horizontal, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_horizontal.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Prewitt_horizontal.Image = bmp_horizontal;
            Bitmap bmp_vertical = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_vertical = { { -1, 0, 1 },
                                    { -1 , 0 , 1 },
                                    { -1 , 0 , 1}};
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
                                grey += c.R * selectRef(s_vertical, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_vertical.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Prewitt_vertical.Image = bmp_vertical;
            Bitmap bmp_Prewitt1 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_Prewitt1 = { { -1, -1, -1 },
                                    { 0 , 0 , 0 },
                                    { 1 , 1 , 1}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    s_Prewitt1[i, j] = s_horizontal[i, j] + s_vertical[i, j];
                }
            }
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
                                grey += c.R * selectRef(s_Prewitt1, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_Prewitt1.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Prewitt1.Image = bmp_Prewitt1;
        }

        private void button_Prewitt_operator_Dedge_Click(object sender, EventArgs e)
        {
            int N = 3;
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            progressBar1.Maximum = bmp.Height * 3;
            progressBar1.Value = 0;
            Bitmap bmp_diagonalA = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_diagonalA = { { 0  , 1 , 1 },
                                    { -1 , 0 , 1 },
                                    { -1 ,-1 , 0}};
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
                                grey += c.R * selectRef(s_diagonalA, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_diagonalA.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Prewitt_diagonalA.Image = bmp_diagonalA;
            Bitmap bmp_diagonalB = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_diagonalB = { { -1  , -1 ,0 },
                                    { -1 , 0 , 1 },
                                    { 0  , 1 , 1}};
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
                                grey += c.R * selectRef(s_diagonalB, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_diagonalB.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Prewitt_diagonalB.Image = bmp_diagonalB;
            Bitmap bmp_Prewitt2 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_Prewitt2 = { { -1, -1, -1 },
                                    { 0 , 0 , 0 },
                                    { 1 , 1 , 1}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    s_Prewitt2[i, j] = s_diagonalA[i, j] + s_diagonalB[i, j];
                }
            }
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
                                grey += c.R * selectRef(s_Prewitt2, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_Prewitt2.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Prewitt2.Image = bmp_Prewitt2;
        }

        private void button_Sobel_operator_HVedge_Click(object sender, EventArgs e)
        {
            int N = 3;
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            progressBar1.Maximum = bmp.Height * 3;
            progressBar1.Value = 0;
            Bitmap bmp_Sobel_horizontal = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_Sobel_horizontal = { { -1 , -2 , -1 },
                                          {  0 ,  0 ,  0 },
                                          {  1 ,  2 ,  1 }};
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
                                grey += c.R * selectRef(s_Sobel_horizontal, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_Sobel_horizontal.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Sobel_horizontal.Image = bmp_Sobel_horizontal;
            Bitmap bmp_Sobel_vertical = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_Sobel_vertical = { { -1 , 0 , 1 },
                                        { -2 , 0 , 2 },
                                        { -1 , 0 , 1}};
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
                                grey += c.R * selectRef(s_Sobel_vertical, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_Sobel_vertical.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Sobel_vertical.Image = bmp_Sobel_vertical;
            Bitmap bmp_Sobel1 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_Sobel1 = { { -1, -1, -1 },
                                    { 0 , 0 , 0 },
                                    { 1 , 1 , 1}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    s_Sobel1[i, j] = s_Sobel_horizontal[i, j] + s_Sobel_vertical[i, j];
                }
            }
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
                                grey += c.R * selectRef(s_Sobel1, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_Sobel1.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Sobel1.Image = bmp_Sobel1;
        }

        private void button_Sobel_operator_Dedge_Click(object sender, EventArgs e)
        {
            int N = 3;
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            progressBar1.Maximum = bmp.Height * 3;
            progressBar1.Value = 0;
            Bitmap bmp_Sobel_diagonalA = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_Sobel_diagonalA = { {   0 , 1 , 2 },
                                          { -1 , 0 , 1 },
                                          { -2 , -1 , 0 }};
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
                                grey += c.R * selectRef(s_Sobel_diagonalA, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_Sobel_diagonalA.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Sobel_diagonalA.Image = bmp_Sobel_diagonalA;
            Bitmap bmp_Sobel_diagonalB = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_Sobel_diagonalB = { {  -2 , -1 ,  0 },
                                          { -1 ,  0 ,  1 },
                                          {  0 ,  1 ,  2 }};
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
                                grey += c.R * selectRef(s_Sobel_diagonalB, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_Sobel_diagonalB.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Sobel_diagonalB.Image = bmp_Sobel_diagonalB;
            Bitmap bmp_Sobel2 = new Bitmap(pictureBox_original.Image.Width, pictureBox_original.Image.Height);
            int[,] s_Sobel2 = { { -1, -1, -1 },
                                    { 0 , 0 , 0 },
                                    { 1 , 1 , 1}};
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    s_Sobel2[i, j] = s_Sobel_diagonalA[i, j] + s_Sobel_diagonalB[i, j];
                }
            }
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
                                grey += c.R * selectRef(s_Sobel2, i, j);
                            }
                        }
                        grey = overRange(grey);
                        bmp_Sobel2.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
                progressBar1.Value++;
            }
            pictureBox_Sobel2.Image = bmp_Sobel2;
        }
    }
}
