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
        class Pair
        {
            public int x1;
            public int y1;
            public int x2;
            public int y2;
            public Pair(int x1, int y1, int x2, int y2)
            {
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Hough transform";
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
                pictureBox_original.Image = bmp;
                button_Hough_transform.Enabled = true;
            }
        }

        private void button_Hough_transform_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox_original.Image;
            pictureBox_Hough_transform.Image = HoughTransform(bmp, pictureBox_acc);
        }

        private Bitmap HoughTransform(Bitmap bmp, PictureBox pic_acc)
        {
            Bitmap bmp_sobel = Sobel_operator(bmp);
            //Bitmap bmp_result = new Bitmap(bmp.Width, bmp.Height);
            int hough_h = Math.Max(bmp.Height, bmp.Width), T = 250;
            double rmax = Math.Sqrt(bmp.Height * bmp.Height + bmp.Width * bmp.Width);
            Bitmap bmp_hough = new Bitmap(180, (int)(rmax * 2));
            double center_x = bmp.Width / 2;
            double center_y = bmp.Height / 2;
            hough_h = (int)Math.Sqrt(2) * hough_h;
            int[,] s = new int[(int)(rmax * 2), 181];
            for (int i = 0; i < bmp_hough.Height; i++)
            {
                for (int j = 0; j < bmp_hough.Width; j++)
                {
                    s[i, j] = 0;
                }
            }
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if (bmp_sobel.GetPixel(x, y).R > T)
                    {
                        for (int theta = 0; theta < 180; theta++)
                        {
                            double p = (center_x - x) * Math.Cos(theta * (Math.PI / 180)) + (y - center_y) * Math.Sin(theta * (Math.PI / 180));

                            //bmp_result.SetPixel(x, y, Color.FromArgb(255, 0, 0));
                            s[(int)(p + hough_h), theta]++;

                        }
                    }

                }
            }
            int threshold = 100, _accu_w = 180, _accu_h = hough_h * 2;
            Bitmap bmp_acc = new Bitmap(_accu_w, _accu_h);
            int maxa = 0;
            for (int i = 0; i < _accu_h; i++)
            {
                for (int j = 0; j < _accu_w; j++)
                {
                    if (s[i, j] > maxa)
                        maxa = s[i, j];
                }
            }
            double coef = 255.0 / (double)maxa * 1.0;
            for (int y = 0; y < _accu_h; y++)
            {
                for (int x = 0; x < _accu_w; x++)
                {
                    int c = (int)((double)s[y, x] * coef < 255.0 ? (double)s[y, x] * coef : 255.0);
                    bmp_acc.SetPixel(x, y, Color.FromArgb(255, 255 - c, 255 - c));
                    s[y, x] = c;
                }
            }

            pic_acc.Image = bmp_acc;
            Bitmap bmp_result = new Bitmap(bmp.Width + 1, bmp.Height + 1);
            richTextBox1.Text = hough_h + "\n";
            List<Pair> lines = GetLine(bmp, s, threshold, _accu_w, _accu_h);
            //bmp_result.SetPixel(lines[0].x1, lines[0].y1, Color.FromArgb(255, 0, 0));
            //bmp_result.SetPixel(lines[0].x2, lines[0].y2, Color.FromArgb(255, 0, 0));
            richTextBox1.Text += lines.Count + " " + "\n";
            foreach (Pair pair in lines)
            {
                richTextBox1.Text += pair.x1 + " " + pair.y1 + " " + pair.x2 + " " + pair.y2 + " " + "\n";
                //bmp_result.SetPixel(pair.x1, pair.y1, Color.FromArgb(255, 0, 0));
                //bmp_result.SetPixel(pair.x2, pair.y2, Color.FromArgb(255, 0, 0));
                //if (isRange(pair, bmp_result))
                //{
                Pen blackPen = new Pen(Color.Red, 1);
                // Draw line to screen.
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawLine(blackPen,bmp.Width -pair.x1,pair.y1, bmp.Width - pair.x2, pair.y2);
                }
                //}
            }

            //double S0 = (lines[0].y1 - lines[0].y2) / ( lines[0].x1 - lines[0].x2);

            return bmp;
        }

        private Bitmap Sobel_operator(Bitmap bmp)
        {
            int N = 3;
            int[,] X = { { 1, 0, -1 },
                         { 2, 0, -2 },
                         { 1, 0, -1 }};
            int[,] Y = { { 1, 2,  1 },
                         { 0, 0,  0 },
                         {-1,-2, -1 }};
            Bitmap bmp_sobel = new Bitmap(bmp.Width, bmp.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if ((x > N / 2 && y > N / 2 && x < bmp.Width - N / 2 && y < bmp.Height - N / 2))
                    {
                        int Gx = 0, Gy = 0;

                        for (int i = -(N / 2); i <= (N / 2); i++)
                        {
                            for (int j = -(N / 2); j <= (N / 2); j++)
                            {
                                Gx += bmp.GetPixel(x + i, y + j).R * X[i + 1, j + 1];
                                Gy += bmp.GetPixel(x + i, y + j).R * Y[i + 1, j + 1];
                            }
                        }
                        int grey = Math.Abs(Gx) + Math.Abs(Gy);
                        grey = OverRange(grey);
                        bmp_sobel.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                    }
                }
            }
            return bmp_sobel;
        }

        private List<Pair> GetLine(Bitmap bmp, int[,] s, int threshold, int _accu_w, int _accu_h)
        {
            int hough_h = _accu_h / 2;
            double DEG2RAD = (Math.PI / 180);
            List<Pair> lines = new List<Pair>();
            for (int r = 0; r < _accu_h; r++)
            {
                for (int t = 0; t < _accu_w; t++)
                {

                    if (s[r, t] >= threshold)
                    {
                        //bmp_result.SetPixel(i, j, Color.FromArgb(255, 0, 0));
                        int max = s[r, t];
                        for (int ly = -4; ly <= 4; ly++)
                        {
                            for (int lx = -4; lx <= 4; lx++)
                            {
                                if ((ly + r >= 0 && ly + r < _accu_h) && (lx + t >= 0 && lx + t < _accu_w))
                                {
                                    if (s[(r + ly), (t + lx)] > max)
                                    {
                                        max = s[(r + ly), (t + lx)];
                                        ly = lx = 5;
                                    }
                                }
                            }
                        }
                        if (max > s[r, t])
                            continue;
                        int x1, y1, x2, y2;
                        x1 = y1 = x2 = y2 = 0;
                        if (t >= 45 && t <= 135)
                        {
                            //y = (r - x cos(t)) / sin(t)  
                            x1 = 0;
                            y1 = (int)(((r - (_accu_h / 2)) - ((x1 - (bmp.Width / 2)) * Math.Cos(t * DEG2RAD))) / Math.Sin(t * DEG2RAD) + (bmp.Height / 2));
                            x2 = bmp.Width - 0;
                            y2 = (int)(((r - (_accu_h / 2)) - ((x2 - (bmp.Width / 2)) * Math.Cos(t * DEG2RAD))) / Math.Sin(t * DEG2RAD) + (bmp.Height / 2));
                        }
                        else
                        {
                            //x = (r - y sin(t)) / cos(t);  
                            y1 = 0;
                            x1 = (int)((r - (_accu_h / 2) - ((y1 - (bmp.Height / 2)) * Math.Sin(t * DEG2RAD))) / Math.Cos(t * DEG2RAD) + (bmp.Width / 2));
                            y2 = bmp.Height - 0;
                            x2 = (int)((r - (_accu_h / 2) - ((y2 - (bmp.Height / 2)) * Math.Sin(t * DEG2RAD))) / Math.Cos(t * DEG2RAD) + (bmp.Width / 2));
                        }
                        lines.Add(new Pair(x1, y1, x2, y2));
                    }
                }
            }
            return lines;
        }

        private int OverRange(int a)
        {
            if (a > 255) return 255;
            else if (a < 0) return 0;
            else return a;
        }

        private Boolean isRange(Pair pair, Bitmap bitmap)
        {
            return (bitmap.Width > pair.x1) && (0 <= pair.x1) && (bitmap.Width > pair.x2) && (0 <= pair.x2) &&
                     (bitmap.Height > pair.y1) && (0 <= pair.y1) && (bitmap.Height > pair.y2) && (0 <= pair.y2);
        }
    }
}
