using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Passport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.ShowDialog();
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bitmap;
                Passport.Controls.PassportRecognize recognize = new Controls.PassportRecognize();
                var a = recognize.ReadPassport(bitmap);
                if (a != null)
                {
                    label2.Text = a.Accuracy.ToString();
                    textBox1.Text = a.ToString();
                }
            }
        }
    }
}
