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
        int mHieght = 40;
        int mWidth = 80;
        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog, openFileDialog2;
            openFileDialog = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog.Filter = "BMP(*.BMP)|*.bmp|" + "JPG(*.jpg)|*.jpg|" + "GIF(*.GIT)|*.gif|" + "所有檔案|*.*";
            openFileDialog2.Filter = "BMP(*.BMP)|*.bmp|" + "JPG(*.jpg)|*.jpg|" + "GIF(*.GIT)|*.gif|" + "所有檔案|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                originalPicture.Image = Image.FromFile(openFileDialog.FileName);
                Bitmap bm1 = (Bitmap)Image.FromFile(openFileDialog.FileName);
                Bitmap bmp = new Bitmap(mWidth, mHieght);
                Bitmap bmA = (Bitmap)Image.FromFile(openFileDialog.FileName);
                Bitmap bmB = (Bitmap)Image.FromFile(openFileDialog2.FileName);
                pictureBox_block.Image = Image.FromFile(openFileDialog2.FileName);
                for (int y = 0; y < originalPicture.Image.Height; y++)
                {
                    for (int x = 0; x < originalPicture.Image.Width; x++)
                    {
                        Color c1, c2;
                        c1 = bmA.GetPixel(x, y);
                        c2 = bmB.GetPixel(x, y);
                        bmA.SetPixel(x, y, Color.FromArgb(c1.R & c2.R, c1.G & c2.G, c1.B & c2.B));
                        if (x == 360 && y == 200)
                            Console.WriteLine("A");
                    }
                }
                pictureBox_anda.Image = bmA;
                for (int y = 0; y < originalPicture.Image.Height; y++)
                {
                    for (int x = 0; x < originalPicture.Image.Width; x++)
                    {
                        Color c1;
                        c1 = bm1.GetPixel(x, y);
                        if ((x >= 360 && x < 360 + mWidth && y >= 200 && y < 200 + mHieght))
                        {
                            bmp.SetPixel(x - 360, y - 200, Color.FromArgb(c1.R, c1.G, c1.B));
                        }
                        //bm1.SetPixel(x, y, Color.FromArgb(avg1, avg1, avg1));
                    }
                }
                picture_and.Image = bmp;
            }
        }

        private void A(Bitmap bmpf)
        {

            int i = -1;
            int j = -1;
            int y = bmpf.Height - 1;
            Color cx,cy;
            int x = 0;
            while (x < bmpf.Width)
            {
                cx = bmpf.GetPixel(x, y);
                if (i == -1 && j == -1)
                {
                    if (cx.A == 0 && cx.R == 0 && cx.G == 0 && cx.B == 0)
                        i = x - 1;
                }
                else
                {
                    if (!(cx.A == 0 && cx.R == 0 && cx.G == 0 && cx.B == 0))
                    {
                        j = x;
                        cx = bmpf.GetPixel(i, y);
                        cy = bmpf.GetPixel(j, y);
                        int R = Convert.ToInt32((-cx.R + cy.R) / Math.Abs(j - i));
                        int G = Convert.ToInt32((-cx.G + cy.G) / Math.Abs(j - i));
                        int B = Convert.ToInt32((-cx.B + cy.B) / Math.Abs(j - i));
                        for (int index = i + 1; index < j; index++)
                        {
                            bmpf.SetPixel(index, y, Color.FromArgb(cx.R + R * (index - i), cx.G + G * (index - i), cx.B + B * (index - i)));
                        }
                        i = -1;
                        j = -1;
                    }
                }
                x++;
            }
        }


        private void Zoomin()
        {
            Double N = (multiple.Text == "") ? 1 : Convert.ToDouble(multiple.Text);
            Color c1;
            Bitmap bmp = (Bitmap)picture_and.Image;
            if (!(multiple.Text == "")) ;
            else if (radioButton_double.Checked) N = 2;
            else if (radioButton_quadruple.Checked) N = 4;
            else if (radioButton_sextuple.Checked) N = 6;
            else if (radioButton_octuple.Checked) N = 8;
            else if (radioButton_decuple.Checked) N = 10;
            else if (radioButton_twentyfold.Checked) N = 20;
            Bitmap bmpz = new Bitmap(Convert.ToInt32(mWidth * N), Convert.ToInt32(mHieght * N));
            Bitmap bmpf = new Bitmap(Convert.ToInt32(mWidth * N), Convert.ToInt32(mHieght * N));
            for (int y = 0; y < mHieght; y++)
            {
                int x;
                for (x = 0; x < mWidth; x++)
                {
                    c1 = bmp.GetPixel(x, y);
                    if (x < mWidth * N / 2)
                    {
                        c1 = bmp.GetPixel(x, y);
                        bmpf.SetPixel(Convert.ToInt32(x * N), Convert.ToInt32(y * N), Color.FromArgb(c1.R, c1.G, c1.B));
                        c1 = bmp.GetPixel((mWidth - x) - 1, y);
                        bmpf.SetPixel(Convert.ToInt32((mWidth - x) * N - 1), Convert.ToInt32(y * N), Color.FromArgb(c1.R, c1.G, c1.B));
                        c1 = bmp.GetPixel(x, (mHieght - y) - 1);
                        bmpf.SetPixel(Convert.ToInt32(x * N), Convert.ToInt32((mHieght - y) * N - 1), Color.FromArgb(c1.R, c1.G, c1.B));
                        c1 = bmp.GetPixel((mWidth - x) - 1, (mHieght - y) - 1);
                        bmpf.SetPixel(Convert.ToInt32((mWidth - x) * N - 1), Convert.ToInt32((mHieght - y) * N - 1), Color.FromArgb(c1.R, c1.G, c1.B));
                    }

                }
            }
            for (int y = 0; y < bmpz.Height; y++)
            {
                int x;
                for (x = 0; x < bmpz.Width; x++)
                {
                    int tmpx = Convert.ToInt32(x / N) >= bmp.Width ? bmp.Width - 1 : Convert.ToInt32(x / N);
                    int tmpy = Convert.ToInt32(y / N) >= bmp.Height ? bmp.Height - 1 : Convert.ToInt32(y / N);
                    c1 = bmp.GetPixel(tmpx, tmpy);
                    bmpz.SetPixel(x, y, Color.FromArgb(c1.R, c1.G, c1.B));
                }
            }
            pictureBox_zero.Image = bmpz;
            Color cx, cy;
            for (int y = 0; y < mHieght * N; y = Convert.ToInt32(y + N))
            {
                int x = 0;
                int i = -1, j = -1;
                while (x < bmpf.Width)
                {
                    cx = bmpf.GetPixel(x, y);
                    if (i == -1 && j == -1)
                    {
                        if (cx.A == 0 && cx.R == 0 && cx.G == 0 && cx.B == 0)
                            i = x - 1;
                    }
                    else
                    {
                        if (!(cx.A == 0 && cx.R == 0 && cx.G == 0 && cx.B == 0))
                        {
                            j = x;
                            cx = bmpf.GetPixel(i, y);
                            cy = bmpf.GetPixel(j, y);
                            int R = Convert.ToInt32((-cx.R + cy.R) / Math.Abs(j - i));
                            int G = Convert.ToInt32((-cx.G + cy.G) / Math.Abs(j - i));
                            int B = Convert.ToInt32((-cx.B + cy.B) / Math.Abs(j - i));
                            for (int index = i + 1; index < j; index++)
                            {
                                bmpf.SetPixel(index, y, Color.FromArgb(cx.R + R * (index - i), cx.G + G * (index - i), cx.B + B * (index - i)));
                            }
                            i = -1;
                            j = -1;
                        }
                    }
                    x++;
                }
            }
            A(bmpf);
            for (int x = 0; x < mWidth * N; x += 1)
            {
                int y = 0;
                int i = -1, j = -1;
                while (y < bmpf.Height)
                {
                    cx = bmpf.GetPixel(x, y);
                    if (i == -1 && j == -1)
                    {
                        if (cx.A == 0 && cx.R == 0 && cx.G == 0 && cx.B == 0)
                            i = y - 1;
                    }
                    else
                    {
                        if (!(cx.A == 0 && cx.R == 0 && cx.G == 0 && cx.B == 0))
                        {
                            j = y;
                            cx = bmpf.GetPixel(x, i);
                            cy = bmpf.GetPixel(x, j);
                            int R = Convert.ToInt32(((-cx.R + cy.R) / Math.Abs(j - i)));
                            int G = Convert.ToInt32(((-cx.G + cy.G) / Math.Abs(j - i)));
                            int B = Convert.ToInt32(((-cx.B + cy.B) / Math.Abs(j - i)));
                            for (int index = i + 1; index < j; index++)
                            {
                                bmpf.SetPixel(x, index, Color.FromArgb(cx.R + (R * (index - i)), cx.G + (G * (index - i)), cx.B + (B * (index - i))));
                            }
                            i = -1;
                            j = -1;
                        }
                    }
                    y++;
                }
            }
            pictureBox_first.Image = bmpf;
            label8.Text = "處理前圖\nWidth=" + bmp.Width + "\nHeight=" + bmp.Height;
            label9.Text = "處理後圖\nWidth=" + bmpz.Width + "\nHeight=" + bmpz.Height;
        }

        private void Zoomout()
        {
            Double N = (multiple.Text == "") ? 1 : Convert.ToDouble(multiple.Text);
            if (!(multiple.Text == "")) ;
            else if (radioButton_double.Checked) N = 2;
            else if (radioButton_quadruple.Checked) N = 4;
            else if (radioButton_sextuple.Checked) N = 6;
            else if (radioButton_octuple.Checked) N = 8;
            else if (radioButton_decuple.Checked) N = 10;
            else if (radioButton_twentyfold.Checked) N = 20;

            Bitmap bmpz = new Bitmap(Convert.ToInt32(originalPicture.Image.Width / N), Convert.ToInt32(originalPicture.Image.Height / N));
            Bitmap bmpf = new Bitmap(Convert.ToInt32(originalPicture.Image.Width / N), Convert.ToInt32(originalPicture.Image.Height / N));
            Bitmap bmp = (Bitmap)originalPicture.Image;
            for (int y = 0; y < bmpz.Height; y++)
            {
                int x;
                for (x = 0; x < bmpz.Width; x++)
                {
                    Color c1;
                    c1 = bmp.GetPixel(Convert.ToInt32(x * N), Convert.ToInt32(y * N));
                    bmpz.SetPixel(x, y, Color.FromArgb(c1.R, c1.G, c1.B));
                    int Rt = c1.R, Gt = c1.G, Bt = c1.B, i = 1;
                    i++;
                    while ((i < N) && (x * N + i < bmp.Width) && (y * N < bmp.Height))
                    {
                        c1 = bmp.GetPixel(Convert.ToInt32(x * N + i), Convert.ToInt32(y * N));
                        Rt += c1.R;
                        Gt += c1.G;
                        Bt += c1.B;
                        i++;
                    }
                    bmpf.SetPixel(x, y, Color.FromArgb(Rt / i, Gt / i, Bt / i));
                }
            }
            pictureBox_zero.Image = bmpz;
            pictureBox_first.Image = bmpf;
            label8.Text = "處理前圖\nWidth=" + bmp.Width + "\nHeight=" + bmp.Height;
            label9.Text = "處理後圖\nWidth=" + bmpz.Width + "\nHeight=" + bmpz.Height;
        }

        private void process_Click(object sender, EventArgs e)
        {
            if (radioButton_zoomin.Checked)
            {
                Zoomin();
            }
            else if (radioButton_zoomout.Checked)
            {
                Zoomout();
            }
        }
    }
}
