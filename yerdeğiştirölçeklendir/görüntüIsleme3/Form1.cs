using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace görüntüIsleme3
{
    public partial class Form1 : Form
    {
        Bitmap resim;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                resim = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = resim;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////ÖLÇEKLENDİRME ÖRNEĞİ

            Double w_k, h_k;

            w_k = Convert.ToDouble(textBox1.Text);
            h_k = Convert.ToDouble(textBox2.Text);

            pictureBox1.Width = Convert.ToInt32(pictureBox1.Width * w_k);
            pictureBox1.Height =Convert.ToInt32( pictureBox1.Width * h_k);


           



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //KONUM DEĞİŞTİRME


            int x, y;
            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;

            int x_arti, y_arti;
            x_arti=Convert.ToInt32(textBox3.Text);
            y_arti = Convert.ToInt32(textBox4.Text);

            y = y + y_arti;
            x = x + x_arti;

            pictureBox1.Location = new Point(x, y);
        }
    }
}
