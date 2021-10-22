using AForge;
using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = LoadImage();
        }

        private Bitmap LoadImage()
        {
            Bitmap bitmap = null;
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                bitmap = new Bitmap(img);
            }
            return bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("Red: {0}", trackBar1.Value);

           
                Bitmap bitmap = new Bitmap(pictureBox1.Image);
                LevelsLinear filter = new LevelsLinear();
                filter.InRed = new IntRange(trackBar5.Value, trackBar1.Value);
                filter.InGreen = new IntRange(trackBar6.Value, trackBar2.Value);
                filter.InBlue = new IntRange(trackBar7.Value, trackBar3.Value);
                filter.ApplyInPlace(bitmap);

                pictureBox2.Image = bitmap;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = String.Format("Green: {0}", trackBar1.Value);


            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            LevelsLinear filter = new LevelsLinear();
            filter.InRed = new IntRange(trackBar5.Value, trackBar1.Value);
            filter.InGreen = new IntRange(trackBar6.Value, trackBar2.Value);
            filter.InBlue = new IntRange(trackBar7.Value, trackBar3.Value);
            filter.ApplyInPlace(bitmap);

            pictureBox2.Image = bitmap;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = String.Format("Blue: {0}", trackBar1.Value);


            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            LevelsLinear filter = new LevelsLinear();
            filter.InRed = new IntRange(trackBar5.Value, trackBar1.Value);
            filter.InGreen = new IntRange(trackBar6.Value, trackBar2.Value);
            filter.InBlue = new IntRange(trackBar7.Value, trackBar3.Value);
            filter.ApplyInPlace(bitmap);

            pictureBox2.Image = bitmap;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            LevelsLinear filter = new LevelsLinear();
            filter.InRed = new IntRange(trackBar5.Value, trackBar1.Value);
            filter.InGreen = new IntRange(trackBar6.Value, trackBar2.Value);
            filter.InBlue = new IntRange(trackBar7.Value, trackBar3.Value);
            filter.ApplyInPlace(bitmap);

            pictureBox2.Image = bitmap;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            LevelsLinear filter = new LevelsLinear();
            filter.InRed = new IntRange(trackBar5.Value, trackBar1.Value);
            filter.InGreen = new IntRange(trackBar6.Value, trackBar2.Value);
            filter.InBlue = new IntRange(trackBar7.Value, trackBar3.Value);
            filter.ApplyInPlace(bitmap);

            pictureBox2.Image = bitmap;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            LevelsLinear filter = new LevelsLinear();
            filter.InRed = new IntRange(trackBar5.Value, trackBar1.Value);
            filter.InGreen = new IntRange(trackBar6.Value, trackBar2.Value);
            filter.InBlue = new IntRange(trackBar7.Value, trackBar3.Value);
            filter.ApplyInPlace(bitmap);

            pictureBox2.Image = bitmap;
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            LevelsLinear filter = new LevelsLinear();
            filter.InRed = new IntRange(trackBar5.Value, trackBar1.Value);
            filter.InGreen = new IntRange(trackBar6.Value, trackBar2.Value);
            filter.InBlue = new IntRange(trackBar7.Value, trackBar3.Value);
            filter.ApplyInPlace(bitmap);

            pictureBox2.Image = bitmap;
        }
    }
}
