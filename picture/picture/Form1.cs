using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"c:\gabriel.jpg");
            openFileDialog1.ShowDialog();
            string FilePath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(FilePath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"c:\Users\arda.halim\Pictures\Camera Roll\gabriel.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"c:\Users\arda.halim\Pictures\Camera Roll\gabriel2.jpg");
        }
    }
}
