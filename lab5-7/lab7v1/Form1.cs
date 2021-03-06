using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7v1
{
    public partial class Form1 : Form
    {
        int szer = 0;
        int wys = 0;
        int red, blue, green;
        double red1, green1, blue1, red2, green2, blue2;
        Color k1, k2, k3;
        private int[,] maska = new int[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OtwieranieObrazka.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(OtwieranieObrazka.FileName);
                szer = pictureBox1.Image.Width;
                wys = pictureBox1.Image.Height;
                pictureBox2.Image = new Bitmap(szer, wys);
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (OtwieranieObrazka.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Load(OtwieranieObrazka.FileName);
                szer = pictureBox3.Image.Width;
                wys = pictureBox3.Image.Height;
                pictureBox3.Visible = true;
                pictureBox2.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button16.Visible = true;
                button17.Visible = true;
                button18.Visible = true;
                button19.Visible = true;
                button20.Visible = true;
                button21.Visible = true;
                button22.Visible = true;
                button23.Visible = true;
                button24.Visible = true;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (OtwieranieObrazka.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Load(OtwieranieObrazka.FileName);
                szer = pictureBox4.Image.Width;
                wys = pictureBox4.Image.Height;
                pictureBox2.Image = new Bitmap(szer, wys);
                pictureBox2.Visible = true;
                pictureBox4.Visible = true;
                trackBar1.Visible = true;
                trackBar2.Visible = true;
                trackBar3.Visible = true;
                chart1.Visible = true;
                chart2.Visible = true;
                richTextBox1.Visible = true;
                richTextBox2.Visible = true;
                richTextBox3.Visible = true;
                button26.Visible = true;
                button27.Visible = true;
                button28.Visible = true;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (OtwieranieObrazka.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Load(OtwieranieObrazka.FileName);
                szer = pictureBox4.Image.Width;
                wys = pictureBox4.Image.Height;
                pictureBox2.Image = new Bitmap(szer, wys);
                pictureBox2.Visible = true;
                pictureBox4.Visible = true;
                button31.Visible = true;
                button32.Visible = true;
                button33.Visible = true;
                button34.Visible = true;
                button35.Visible = true;
                button36.Visible = true;
                button37.Visible = true;
                button38.Visible = true;
                button39.Visible = true;
                button40.Visible = true;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;
            button17.Visible = false;
            button18.Visible = false;
            button19.Visible = false;
            button20.Visible = false;
            button21.Visible = false;
            button22.Visible = false;
            button23.Visible = false;
            button24.Visible = false;
            trackBar1.Visible = false;
            trackBar2.Visible = false;
            trackBar3.Visible = false;
            chart1.Visible = false;
            chart2.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            button26.Visible = false;
            button27.Visible = false;
            button28.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k2 = Color.FromArgb(255-k1.R, 255-k1.G, 255-k1.B);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    int b = 40;
                    k1 = bmp1.GetPixel(i, j);
                    if (k1.R + b >= 0 && k1.R + b <= 255) red = b;
                    else red = 0;
                    if (k1.G + b >= 0 && k1.G + b <= 255) green = b;
                    else green = 0;
                    if (k1.B + b >= 0 && k1.B + b <= 255) blue = b;
                    else blue = 0;
                    k2 = Color.FromArgb(k1.R+red, k1.G+green, k1.B+blue);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    int b = -40;
                    k1 = bmp1.GetPixel(i, j);
                    if (k1.R + b >= 0 && k1.R + b <= 255) red = b;
                    else red = 0;
                    if (k1.G + b >= 0 && k1.G + b <= 255) green = b;
                    else green = 0;
                    if (k1.B + b >= 0 && k1.B + b <= 255) blue = b;
                    else blue = 0;
                    k2 = Color.FromArgb(k1.R + red, k1.G + green, k1.B + blue);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    double n = 0.33;
                    k1 = bmp1.GetPixel(i, j);
                    k2 = Color.FromArgb((int)(Math.Pow((double)(k1.R)/255,n)*255), (int)(Math.Pow((double)(k1.G) / 255, n) * 255), (int)(Math.Pow((double)(k1.B) / 255, n) * 255));
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    double n = 2;
                    k1 = bmp1.GetPixel(i, j);
                    k2 = Color.FromArgb((int)(Math.Pow((double)(k1.R) / 255, n) * 255), (int)(Math.Pow((double)(k1.G) / 255, n) * 255), (int)(Math.Pow((double)(k1.B) / 255, n) * 255));
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }


        private void button9_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    if ((double)k1.R / 255 + (double)k3.R / 255 >= 1) red1 = 1;
                    else red1 = (double)k1.R / 255 + (double)k3.R / 255;
                    if ((double)k1.G / 255 + (double)k3.G / 255 >= 1) green1 = 1;
                    else green1 = (double)k1.G / 255 + (double)k3.G / 255;
                    if ((double)k1.B / 255 + (double)k3.B / 255 >= 1) blue1 = 1;
                    else blue1 = k1.B / 255 + k3.B / 255;
                    k2 = Color.FromArgb((int)(red1 * 255), (int)(green1 * 255), (int)(blue1 * 255));
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    if ((double)k1.R / 255 + (double)k3.R / 255 - 1 >= 1) red1 = 255;
                    if ((double)k1.R / 255 + (double)k3.R / 255 - 1 <= 0) red1 = 1;
                    else red1 = ((double)k1.R / 255 + (double)k3.R / 255 - 1) * 255;
                    if ((double)k1.G / 255 + (double)k3.G / 255 - 1 >= 1) green1 = 255;
                    if ((double)k1.G / 255 + (double)k3.G / 255 - 1 <= 0) green1 = 1;
                    else green1 = ((double)k1.G / 255 + (double)k3.G / 255 - 1) * 255;
                    if ((double)k1.B / 255 + (double)k3.B / 255 - 1 >= 1) blue1 = 255;
                    if ((double)k1.B / 255 + (double)k3.B / 255 - 1 <= 0) blue1 = 1;
                    else blue1 = ((double)k1.B / 255 + (double)k3.B / 255 - 1) * 255;
                    k2 = Color.FromArgb((int)red1, (int)green1, (int)blue1);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }
        

        private void button12_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    k2 = Color.FromArgb(Math.Abs(k1.R-k3.R), Math.Abs(k1.G - k3.G), Math.Abs(k1.B - k3.B));
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }


        private void button11_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    k2 = Color.FromArgb((k1.R * k3.R)/255, (k1.G * k3.G)/255, (k1.B * k3.B)/255);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }


        private void button16_Click_1(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    k2 = Color.FromArgb(255 - (255 - k1.R) * (255 - k3.R) / 255, 255 - (255 - k1.G) * (255 - k3.G) / 255, 255 - (255 - k1.B) * (255 - k3.B) / 255);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }


        private void button15_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    k2 = Color.FromArgb(255 - Math.Abs(255 - k1.R - k3.R), 255 - Math.Abs(255 - k1.G - k3.G), 255 - Math.Abs(255 - k1.B - k3.B));
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }


        private void button14_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    if (k1.R < k3.R) red = k1.R;
                    else red = k3.R;
                    if (k1.G < k3.G) green = k1.G;
                    else green = k3.G;
                    if (k1.B < k3.B) blue = k1.B;
                    else blue = k3.B;
                    k2 = Color.FromArgb(red, green, blue);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }


        private void button13_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    if (k1.R > k3.R) red = k1.R;
                    else red = k3.R;
                    if (k1.G > k3.G) green = k1.G;
                    else green = k3.G;
                    if (k1.B > k3.B) blue = k1.B;
                    else blue = k3.B;
                    k2 = Color.FromArgb(red, green, blue);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }


        private void button24_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    k2 = Color.FromArgb(k1.R + k3.R - 2 * k1.R * k3.R / 255, k1.G + k3.G - 2 * k1.G * k3.G / 255, k1.B + k3.B - 2 * k1.B * k3.B / 255);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        

        private void button23_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    if (k1.R < 128) red1 = 2 * k1.R * k3.R / 255;
                    else red1 = 255 - 2 * (255 - k1.R) * (255 - k3.R) / 255;
                    if (k1.G < 128) green1 = 2 * k1.G * k3.G / 255;
                    else green1 = 255 - 2 * (255 - k1.G) * (255 - k3.G) / 255;
                    if (k1.B < 128) blue1 = 2 * k1.B * k3.B / 255;
                    else blue1 = 255 - 2 * (255 - k1.B) * (255 - k3.B) / 255;
                    k2 = Color.FromArgb((int)red1, (int)green1, (int)blue1);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }


        private void button22_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    if (k3.R < 128) red1 = 2 * k1.R * k3.R / 255;
                    else red1 = 255 - 2 * (255 - k1.R) * (255 - k3.R) / 255;
                    if (k3.G < 128) green1 = 2 * k1.G * k3.G / 255;
                    else green1 = 255 - 2 * (255 - k1.G) * (255 - k3.G) / 255;
                    if (k3.B < 128) blue1 = 2 * k1.B * k3.B / 255;
                    else blue1 = 255 - 2 * (255 - k1.B) * (255 - k3.B) / 255;
                    k2 = Color.FromArgb((int)red1, (int)green1, (int)blue1);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox4.Image;
            int[] r = new int[256];
            int[] g = new int[256];
            int[] b = new int[256];
            Color k;
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k = b1.GetPixel(x, y);
                    r[k.R]++;
                    g[k.G]++;
                    b[k.B]++;
                }
            }
            chart1.Series["red"].Points.Clear();
            chart1.Series["green"].Points.Clear();
            chart1.Series["blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chart1.Series["red"].Points.AddXY(i, r[i]);
                chart1.Series["green"].Points.AddXY(i, g[i]);
                chart1.Series["blue"].Points.AddXY(i, b[i]);
            }
            chart1.Invalidate();
        }
        private int[] LUT(int[] wartosci, int wymiar)
        {
            double min = 0;
            for (int i = 0; i < 256; i++)
            {
                if (wartosci[i] != 0)
                {
                    min = wartosci[i];
                    break;
                }
            }

            int[] wynik = new int[256];
            double sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += wartosci[i];
                wynik[i] = (int)(((sum - min) / (wymiar - min)) * 255.0);
            }

            return wynik;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox4.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            int[] r = new int[256];
            int[] g = new int[256];
            int[] b = new int[256];
            Color k, pixel, pixel2;
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k = b1.GetPixel(x, y);
                    r[k.R]++;
                    g[k.G]++;
                    b[k.B]++;
                }
            }
            int[] LUTr = LUT(r, szer * wys);
            int[] LUTg = LUT(g, szer * wys);
            int[] LUTb = LUT(b, szer * wys);

            r = new int[256];
            g = new int[256];
            b = new int[256];

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    pixel = b1.GetPixel(x, y);
                    pixel2 = Color.FromArgb(LUTr[pixel.R], LUTg[pixel.G], LUTb[pixel.B]);
                    b2.SetPixel(x, y, pixel2);
                    r[pixel2.R]++;
                    g[pixel2.G]++;
                    b[pixel2.B]++;
                }
            }
            pictureBox2.Refresh();

            chart2.Series["red"].Points.Clear();
            chart2.Series["green"].Points.Clear();
            chart2.Series["blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chart2.Series["red"].Points.AddXY(i, r[i]);
                chart2.Series["green"].Points.AddXY(i, g[i]);
                chart2.Series["blue"].Points.AddXY(i, b[i]);
            }
            chart2.Invalidate();
        }

        private int[] calculateLUT(int[] wartosci)
        {
            int min = 0;
            for (int i = 0; i < 256; i++)
            {
                if (wartosci[i] != 0)
                {
                    min = i;
                    break;
                }
            }

            int max = 255;
            for (int i = 255; i >= 0; i--)
            {
                if (wartosci[i] != 0)
                {
                    max = i;
                    break;
                }
            }

            int[] wynik = new int[256];
            double a = 255.0 / (max - min);
            for (int i = 0; i < 256; i++)
            {
                wynik[i] = (int)(a * (i - min));
            }

            return wynik;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox4.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            int[] r = new int[256];
            int[] g = new int[256];
            int[] b = new int[256];
            Color k, pixel, pixel2;
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k = b1.GetPixel(x, y);
                    r[k.R]++;
                    g[k.G]++;
                    b[k.B]++;
                }
            }
            int[] LUTr = calculateLUT(r);
            int[] LUTg = calculateLUT(g);
            int[] LUTb = calculateLUT(b);

            r = new int[256];
            g = new int[256];
            b = new int[256];

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    pixel = b1.GetPixel(x, y);
                    pixel2 = Color.FromArgb(LUTr[pixel.R], LUTg[pixel.G], LUTb[pixel.B]);
                    b2.SetPixel(x, y, pixel2);
                    r[pixel2.R]++;
                    g[pixel2.G]++;
                    b[pixel2.B]++;
                }
            }
            pictureBox2.Refresh();

            chart2.Series["red"].Points.Clear();
            chart2.Series["green"].Points.Clear();
            chart2.Series["blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chart2.Series["red"].Points.AddXY(i, r[i]);
                chart2.Series["green"].Points.AddXY(i, g[i]);
                chart2.Series["blue"].Points.AddXY(i, b[i]);
            }
            chart2.Invalidate();
        }

        private void przetworz(int[,] maska, int suma_maski)
        {
            Bitmap b1 = (Bitmap)pictureBox4.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color[,] k = new Color[3, 3];
            int r = 0;
            int g = 0;
            int b = 0;
            int x_mniej, x_wiecej, y_mniej, y_wiecej;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {

                    if (x == 0) x_mniej = x;
                    else x_mniej = x - 1;
                    
                    if (x == szer - 1) x_wiecej = x;
                    else x_wiecej = x + 1;
                    
                    if (y == 0) y_mniej = y;
                    else y_mniej = y - 1;
                    
                    if (y == wys - 1) y_wiecej = y;
                    else y_wiecej = y + 1;
                
                    k[0, 0] = b1.GetPixel(x_mniej, y_mniej);
                    k[0, 1] = b1.GetPixel(x, y_mniej);
                    k[0, 2] = b1.GetPixel(x_wiecej, y_mniej);
                    k[1, 0] = b1.GetPixel(x_mniej, y);
                    k[1, 1] = b1.GetPixel(x, y);
                    k[1, 2] = b1.GetPixel(x_wiecej, y);
                    k[2, 0] = b1.GetPixel(x_mniej, y_wiecej);
                    k[2, 1] = b1.GetPixel(x, y_wiecej);
                    k[2, 2] = b1.GetPixel(x_wiecej, y_wiecej);

                    r = 0;
                    g = 0;
                    b = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            r += k[i, j].R * maska[i, j];
                            g += k[i, j].G * maska[i, j];
                            b += k[i, j].B * maska[i, j];

                        }
                    }

                    if (suma_maski != 0)
                    {
                        r = r / suma_maski;
                        g = g / suma_maski;
                        b = b / suma_maski;
                    }


                    if (r > 255) r = 255;
                    if (r < 0) r = 0; 
                    if (g > 255) g = 255;
                    if (g < 0) g = 0;
                    if (b > 255) b = 255;
                    if (b < 0) b = 0;
                
                    b2.SetPixel(x, y, Color.FromArgb(r, g, b));

                }
            }
            pictureBox2.Refresh();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    maska[i, j] = 0;
            }
            maska[1, 1] = 1;
            maska[1, 2] = -1;
            int suma_maski = 0;
            przetworz(maska, suma_maski);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0)
                        maska[i, j] = 1;
                    else if (i == 1)
                        maska[i, j] = 0;
                    else
                        maska[i, j] = -1;
                }
            }
            int suma_maski = 0;
            przetworz(maska, suma_maski);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0 && j != 1)
                        maska[i, j] = 1;
                    else if (i == 1)
                        maska[i, j] = 0;
                    else if (i == 2 && j != 1)
                        maska[i, j] = -1;
                }
            }
            maska[0, 1] = 2;
            maska[2, 1] = -2;
            int suma_maski = 0;
            przetworz(maska, suma_maski);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    maska[i, j] = 0;
            }
            maska[1, 1] = 1;
            maska[2, 1] = -1;
            int suma_maski = 0;
            przetworz(maska, suma_maski);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                        maska[i, j] = 1;
                    else if (j == 1)
                        maska[i, j] = 0;
                    else
                        maska[i, j] = -1;
                }
            }
            int suma_maski = 0;
            przetworz(maska, suma_maski);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        if (i != 1)
                            maska[i, j] = 1;
                        else
                            maska[i, j] = 2;
                    }
                    else if (j == 1)
                    {
                        maska[i, j] = 0;
                    }
                    else
                    {
                        if (i != 1)
                            maska[i, j] = -1;
                        else
                            maska[i, j] = -2;
                    }
                }
            }
            int suma_maski = 0;
            przetworz(maska, suma_maski);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i != 1 && j != 1)
                        maska[i, j] = 0;
                    else
                        maska[i, j] = -1;
                }
            }
            maska[1, 1] = 4;
            int suma_maski = 0;

            przetworz(maska, suma_maski);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox4.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color[,] k = new Color[3, 3];
            int rmin;
            int gmin;
            int bmin;
            int x_mniej, x_wiecej, y_mniej, y_wiecej;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {

                    if (x == 0) x_mniej = x;
                    else x_mniej = x - 1;
                    
                    if (x == szer - 1) x_wiecej = x;
                    else x_wiecej = x + 1;
                    
                    if (y == 0) y_mniej = y;
                    else y_mniej = y - 1;
                    
                    if (y == wys - 1) y_wiecej = y;
                    else y_wiecej = y + 1;
                   

                    k[0, 0] = b1.GetPixel(x_mniej, y_mniej);
                    k[0, 1] = b1.GetPixel(x, y_mniej);
                    k[0, 2] = b1.GetPixel(x_wiecej, y_mniej);
                    k[1, 0] = b1.GetPixel(x_mniej, y);
                    k[1, 1] = b1.GetPixel(x, y);
                    k[1, 2] = b1.GetPixel(x_wiecej, y);
                    k[2, 0] = b1.GetPixel(x_mniej, y_wiecej);
                    k[2, 1] = b1.GetPixel(x, y_wiecej);
                    k[2, 2] = b1.GetPixel(x_wiecej, y_wiecej);
                    rmin = 255;
                    gmin = 255;
                    bmin = 255;

                    for (int l = 0; l < 3; l++)
                    {
                        for (int h = 1; h < 3; h++)
                        {
                            if (rmin > k[l, h].R)
                                rmin = k[l, h].R;
                            if (gmin > k[l, h].G)
                                gmin = k[l, h].G;
                            if (bmin > k[l, h].B)
                                bmin = k[l, h].B;
                        }
                    }


                    b2.SetPixel(x, y, Color.FromArgb(rmin, gmin, bmin));

                }
            }
            pictureBox2.Refresh();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox4.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color[,] k = new Color[3, 3];
            int rmax;
            int gmax;
            int bmax;
            int x_mniej, x_wiecej, y_mniej, y_wiecej;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {

                    if (x == 0) x_mniej = x;
                    else x_mniej = x - 1;
                    
                    if (x == szer - 1) x_wiecej = x;
                    else x_wiecej = x + 1;
                    
                    if (y == 0) y_mniej = y;
                    else y_mniej = y - 1;
                    
                    if (y == wys - 1) y_wiecej = y;
                    else y_wiecej = y + 1;
                    

                    k[0, 0] = b1.GetPixel(x_mniej, y_mniej);
                    k[0, 1] = b1.GetPixel(x, y_mniej);
                    k[0, 2] = b1.GetPixel(x_wiecej, y_mniej);
                    k[1, 0] = b1.GetPixel(x_mniej, y);
                    k[1, 1] = b1.GetPixel(x, y);
                    k[1, 2] = b1.GetPixel(x_wiecej, y);
                    k[2, 0] = b1.GetPixel(x_mniej, y_wiecej);
                    k[2, 1] = b1.GetPixel(x, y_wiecej);
                    k[2, 2] = b1.GetPixel(x_wiecej, y_wiecej);
                    rmax = 0;
                    gmax = 0;
                    bmax = 0;

                    for (int l = 0; l < 3; l++)
                    {
                        for (int h = 1; h < 3; h++)
                        {
                            if (rmax < k[l, h].R)
                                rmax = k[l, h].R;
                            if (gmax < k[l, h].G)
                                gmax = k[l, h].G;
                            if (bmax < k[l, h].B)
                                bmax = k[l, h].B;
                        }
                    }


                    b2.SetPixel(x, y, Color.FromArgb(rmax, gmax, bmax));

                }
            }
            pictureBox2.Refresh();
        }

        private int Partition(int[] c, int a, int b)
        {
            int e, tmp;
            e = c[a];       
            while (a < b)
            {
                while ((a < b) && (c[b] >= e)) b--;
                while ((a < b) && (c[a] < e)) a++;
                if (a < b)
                {
                    tmp = c[a];
                    c[a] = c[b];
                    c[b] = tmp;
                }
            }
            return a;
        }

        private int Med(int[] c, int size)
        {
           
            int i = 0;
            int j = size - 1;
            int w = j / 2;
            int k;
            while (i != j)
            {
                k = Partition(c, i, j);
                k = k - i + 1;
                if (k >= w)
                    j = i + k - 1;
                if (k < w)
                {
                    w -= k;
                    i += k;
                }
            }
            return c[i];
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox4.Image;
            Bitmap b2 = (Bitmap)pictureBox2.Image;
            Color[,] k = new Color[3, 3];
            int[] r = new int[9];
            int[] g = new int[9];
            int[] b = new int[9];
            int x_mniej, x_wiecej, y_mniej, y_wiecej;

            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {

                    if (x == 0) x_mniej = x;
                    else x_mniej = x - 1;
                    
                    if (x == szer - 1) x_wiecej = x;
                    else x_wiecej = x + 1;
                    
                    if (y == 0) y_mniej = y;
                    else y_mniej = y - 1;
                    
                    if (y == wys - 1) y_wiecej = y;
                    else y_wiecej = y + 1;
                    

                    k[0, 0] = b1.GetPixel(x_mniej, y_mniej);
                    k[0, 1] = b1.GetPixel(x, y_mniej);
                    k[0, 2] = b1.GetPixel(x_wiecej, y_mniej);
                    k[1, 0] = b1.GetPixel(x_mniej, y);
                    k[1, 1] = b1.GetPixel(x, y);
                    k[1, 2] = b1.GetPixel(x_wiecej, y);
                    k[2, 0] = b1.GetPixel(x_mniej, y_wiecej);
                    k[2, 1] = b1.GetPixel(x, y_wiecej);
                    k[2, 2] = b1.GetPixel(x_wiecej, y_wiecej);

                    int m = 0;

                    for (int l = 0; l < 3; l++)
                    {
                        for (int h = 1; h < 3; h++)
                        {
                            r[m] = k[l, h].R;
                            g[m] = k[l, h].G;
                            b[m] = k[l, h].B;
                            m++;
                        }
                    }


                    b2.SetPixel(x, y, Color.FromArgb(Med(r, 9), Med(g, 9), Med(b, 9)));

                }
            }
            pictureBox2.Refresh();
        }

        private void button21_Click(object sender, EventArgs e)
        {
           // f(a, b) = if (b < 0.5) 2 * a * b + a ^ 2 * (1 – 2 * b) else | sqrt(a) * (2 * b − 1) +(2 * a) * (1 − b)
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    if ((double)k3.R / 255 < 0.5) red1 = 2 * ((double)k1.R / 255) * ((double)k3.R / 255) + ((double)k1.R / 255) * ((double)k1.R / 255) * (1 - 2 * ((double)k3.R / 255))*255;
                    else red1 = Math.Sqrt((double)k1.R / 255) * (2 * ((double)k3.R / 255) - 1) + (2 * ((double)k1.R / 255)) * (1 - ((double)k3.R / 255))*255;
                    if ((double)k3.G / 255 < 0.5) green1 = 2 * ((double)k1.G / 255) * ((double)k3.G / 255) + ((double)k1.G / 255) * ((double)k1.G / 255) * (1 - 2 * ((double)k3.G / 255))*255;
                    else green1 = Math.Sqrt((double)k1.G / 255) * (2 * ((double)k3.G / 255) - 1) + (2 * ((double)k1.G / 255)) * (1 - ((double)k3.G / 255))*255;
                    if ((double)k3.B / 255 < 0.5) blue1 = 2 * ((double)k1.B / 255) * ((double)k3.B / 255) + ((double)k1.B / 255) * ((double)k1.B / 255) * (1 - 2 * ((double)k3.B / 255))*255;
                    else blue1 = Math.Sqrt((double)k1.B / 255) * (2 * ((double)k3.B / 255) - 1) + (2 * ((double)k1.B / 255)) * (1 - ((double)k3.B / 255))* 255;

                    k2 = Color.FromArgb((int)red1 , (int)green1, (int)blue1);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    if (k3.R <= 127)
                        red1 = k1.R / (255 - k3.R);
                    else
                        red1 = k1.R;
                    if (k3.G <= 127)
                        green1 = k1.G / (255 - k3.G);
                    else
                        green1 = k1.G;
                    if (k3.B <= 127)
                        blue1 = k1.B / (255 - k3.B);
                    else
                        blue1 = k1.B;

                    k2 = Color.FromArgb((int)red1, (int)green1, (int)blue1);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                   // = 1 − (1 − a)/ b
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    if (k3.R == 0) red2 = 1;
                    else red2 = k3.R;
                    if (k3.G == 0) green2 = 1;
                    else green2 = k3.G;
                    if (k3.B == 0) blue2 = 1;
                    else blue2 = k3.B;
                    red1 = (1 - (1 - ((double)k1.R/255)) / ((double)red2/255)) * 255;
                    green1 = (1 - (1 - ((double)k1.G / 255)) / ((double)green2/255)) * 255;
                    blue1 = (1 - (1 - ((double)k1.B / 255)) / ((double)blue2/255)) * 255;
                    if (red1 > 255) red1 = 255;
                    if (red1 < 0) red1 = 1;
                    if (green1 > 255) green1 = 255;
                    if (green1 < 0) green1 = 1;
                    if (blue1 > 255) blue1 = 255;
                    if (blue1 < 0) blue1 = 1;
                    k2 = Color.FromArgb((int)red1, (int)green1, (int)blue1);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //f(a, b) = a^2/(1 − b)
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    red1 = ((double)k1.R/255) * ((double)k1.R/255) / (1 - ((double)k3.R/255))*255;
                    green1 = ((double)k1.G/255) * ((double)k1.G/255) / (1 - ((double)k3.G/255))*255;
                    blue1 = ((double)k1.B/255) * ((double)k1.B/255) / (1 - ((double)k3.B/255)) *255;
                    if (red1 > 255) red1 = 255;
                    if (red1 < 0) red1 = 1;
                    if (green1 > 255) green1 = 255;
                    if (green1 < 0) green1 = 1;
                    if (blue1 > 255) blue1 = 255;
                    if (blue1 < 0) blue1 = 1;
                    k2 = Color.FromArgb((int)red1, (int)green1, (int)blue1);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double alfa = 0.35;
            Cursor = Cursors.WaitCursor;
            Bitmap bmp1 = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            Bitmap bmp3 = (Bitmap)pictureBox3.Image;
            for (int i = 0; i < szer; i++)
            {
                for (int j = 0; j < wys; j++)
                {
                    k1 = bmp1.GetPixel(i, j);
                    k3 = bmp3.GetPixel(i, j);
                    //(a, b, α) = (1 − α) *b + α * a
                    red1 = ((1 - alfa) * ((double)k3.R/255) + alfa * ((double)k1.R/255)) *255;
                    green1 = ((1 - alfa) * ((double)k3.G/255) + alfa * ((double)k1.G / 255)) *255;
                    blue1 = ((1 - alfa) * ((double)k3.B/255) + alfa * ((double)k1.B / 255)) *255;

                    if (red1 > 255) red1 = 255;
                    if (red1 < 0) red1 = 1;
                    if (green1 > 255) green1 = 255;
                    if (green1 < 0) green1 = 1;
                    if (blue1 > 255) blue1 = 255;
                    if (blue1 < 0) blue1 = 1;
                    k2 = Color.FromArgb((int)red1, (int)green1, (int)blue1);
                    bmp2.SetPixel(i, j, k2);
                }
            }
            pictureBox2.Refresh();
            Cursor = Cursors.Default;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {


            double n = Convert.ToDouble(trackBar1.Value) / 10;
            Bitmap bmp1 = (Bitmap)pictureBox4.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = bmp1.GetPixel(x, y);
                    red1 = Math.Pow(k1.R / 255.0, 1 / n) * 255.0;
                    green1 = Math.Pow(k1.G / 255.0, 1 / n) * 255.0;
                    blue1 = Math.Pow(k1.B / 255.0, 1 / n) * 255.0;
                    k2 = Color.FromArgb((int)red1, (int)green1, (int)blue1);
                    bmp2.SetPixel(x, y, k2);
                }
            }
            pictureBox2.Refresh();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(trackBar2.Value);
            Bitmap bmp1 = (Bitmap)pictureBox4.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = bmp1.GetPixel(x, y);
                    if (c >= 0)
                    {
                        red1 = 127.0 / (127.0 - c) * (k1.R - c);
                        green1 = 127.0 / (127.0 - c) * (k1.G - c);
                        blue1 = 127.0 / (127.0 - c) * (k1.B - c);
                    }
                    else
                    {
                        red1 = (127.0 + c) / 127.0 * (k1.R - c);
                        green1 = (127.0 + c) / 127.0 * (k1.G - c);
                        blue1 = (127.0 + c) / 127.0 * (k1.B - c);
                    }
                    if (red1 > 255.0)
                        red1 = 255.0;
                    if (red1 < 0.0)
                        red1 = 0.0;
                    if (green1 > 255.0)
                        green1 = 255.0;
                    if (green1 < 0.0)
                        green1 = 0.0;
                    if (blue1 > 255.0)
                        blue1 = 255.0;
                    if (blue1 < 0.0)
                        blue1 = 0.0;

                    k2 = Color.FromArgb((int)red1, (int)green1, (int)blue1);
                    bmp2.SetPixel(x, y, k2);
                }
            }
            pictureBox2.Refresh();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(trackBar3.Value);
            Bitmap bmp1 = (Bitmap)pictureBox4.Image;
            Bitmap bmp2 = (Bitmap)pictureBox2.Image;
            for (int x = 0; x < szer; x++)
            {
                for (int y = 0; y < wys; y++)
                {
                    k1 = bmp1.GetPixel(x, y);
                    if (c >= 0)
                    {
                        if (k1.R < 127.0)
                            red1 = ((127.0 - c) / 127.0) * k1.R;
                        else
                            red1 = ((127.0 - c) / 127.0) * k1.R + (2.0 * c);
                        if (k1.G < 127.0)
                            green1 = ((127.0 - c) / 127.0) * k1.G;
                        else
                            green1 = ((127.0 - c) / 127.0) * k1.G + (2.0 * c);
                        if (k1.B < 127.0)
                            blue1 = ((127.0 - c) / 127.0) * k1.B;
                        else
                            blue1 = ((127.0 - c) / 127.0) * k1.B + (2.0 * c);
                    }
                    else
                    {
                        if (k1.R < 127.0 + c)
                            red1 = (127.0 / (127.0 + c)) * k1.R;
                        else if (k1.R > 127.0 - c)
                            red1 = ((127.0 * k1.R) + (255.0 * c)) / (127.0 + c);
                        else
                            red1 = 127.0;
                        if (k1.G < 127.0 + c)
                            green1 = (127.0 / (127.0 + c)) * k1.G;
                        else if (k1.G > 127.0 - c)
                            green1 = ((127.0 * k1.G) + (255.0 * c)) / (127.0 + c);
                        else
                            green1 = 127.0;
                        if (k1.B < 127.0 + c)
                            blue1 = (127.0 / (127.0 + c)) * k1.B;
                        else if (k1.B > 127.0 - c)
                            blue1 = ((127.0 * k1.B) + (255.0 * c)) / (127.0 + c);
                        else
                            blue1 = 127.0;
                    }
                    if (red1 > 255.0)
                        red1 = 255.0;
                    if (green1 > 255.0)
                        green1 = 255.0;
                    if (blue1 > 255.0)
                        blue1 = 255.0;
                    if (red1 < 0.0)
                        red1 = 0.0;
                    if (green1 < 0.0)
                        green1 = 0.0;
                    if (blue1 < 0.0)
                        blue1 = 0.0;
                    k2 = Color.FromArgb((int)red1, (int)green1, (int)blue1);
                    bmp2.SetPixel(x, y, k2);
                }
            }
            pictureBox2.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
