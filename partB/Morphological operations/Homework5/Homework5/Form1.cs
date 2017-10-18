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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog;
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP(*.BMP)|*.bmp|" + "PNG(*.PNG)|*.png|" + "JPG(*.jpg)|*.jpg|" + "GIF(*.GIT)|*.gif|" + "所有檔案|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = (Bitmap)Image.FromFile(openFileDialog.FileName);
                pictureBox_original.Image = bmp;
            }
            button_Dilation.Enabled = true;
            button_Erosion.Enabled = true;
            button_Opening.Enabled = true;
            button_Closing.Enabled = true;
        }

        private void Button_Dilation_Click(object sender, EventArgs e)
        {
            pictureBox_result.Image = Dilation((Bitmap)pictureBox_original.Image);
        }

        private void Button_Erosion_Click(object sender, EventArgs e)
        {
            pictureBox_result.Image = Erosion((Bitmap)pictureBox_original.Image);
        }

        private void Button_Opening_Click(object sender, EventArgs e)
        {
            pictureBox_result.Image = Dilation(Erosion((Bitmap)pictureBox_original.Image));
        }

        private void Button_Closing_Click(object sender, EventArgs e)
        {
            pictureBox_result.Image = Erosion(Dilation((Bitmap)pictureBox_original.Image));
        }

        private Bitmap Dilation(Bitmap bmp)
        {
            int N = 3;
            Bitmap bmp_result = new Bitmap(bmp.Width, bmp.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if ((x > N / 2 && y > N / 2 && x < bmp.Width - N / 2 && y < bmp.Height - N / 2))
                    {
                        int max = 0;
                        for (int i = -(N / 2); i <= (N / 2); i++)
                        {
                            for (int j = -(N / 2); j <= (N / 2); j++)
                            {
                                if (max < bmp.GetPixel(x + i, y + j).R) max = bmp.GetPixel(x + i, y + j).R;
                            }
                        }
                        bmp_result.SetPixel(x, y, Color.FromArgb(max, max, max));
                    }
                }
            }
            return bmp_result;
        }

        private Bitmap Erosion(Bitmap bmp)
        {
            int N = 3;
            Bitmap bmp_result = new Bitmap(bmp.Width, bmp.Height);
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    if ((x > N / 2 && y > N / 2 && x < bmp.Width - N / 2 && y < bmp.Height - N / 2))
                    {
                        int min = 99999;
                        for (int i = -(N / 2); i <= (N / 2); i++)
                        {
                            for (int j = -(N / 2); j <= (N / 2); j++)
                            {
                                if (min > bmp.GetPixel(x + i, y + j).R) min = bmp.GetPixel(x + i, y + j).R;
                            }
                        }
                        bmp_result.SetPixel(x, y, Color.FromArgb(min, min, min));
                    }
                }
            }
            return bmp_result;
        }
    }
}
