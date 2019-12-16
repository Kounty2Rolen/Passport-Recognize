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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
        //    {
        //        openFileDialog1.ShowDialog();
        //        Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
        //        pictureBox1.Image = bitmap;
        //        Passport.Controls.PassportRecognize recognize = new Controls.PassportRecognize();
        //        var a = recognize.ReadPassport(bitmap);
        //        if (a != null)
        //        {
        //            passportGiveDateLabel.Text = a.Accuracy.ToString();
        //            passportSerialTBox.Text = a.ToString();
        //        }
        //    }
        //}

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            acceptBtn.Enabled = checkBox.Checked;
        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.ShowDialog();
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                passportImagePicBx.Image = bitmap;
                Passport.Controls.PassportRecognize recognize = new Controls.PassportRecognize();
                var a = recognize.ReadPassport(bitmap);
                if (a != null)
                {
                    firstNameTBox.Text = a.Fname;
                    midlNameTxtBx.Text = a.Mname;
                    lastNameTxtBx.Text = a.Lname;
                    birdthDateDTP.Value = DateTime.Parse(a.Year + "." + a.Mounth + "." + a.Day);
                    genderCmbBx.Text = a.Gender;
                    passportSerialTBox.Text = a.Serial.Substring(0, 5);
                    passportNumberTbox.Text = a.Serial.Substring(5, 6);
                    passportGiveDTP.Value= DateTime.Parse(a.PassportYear + "." + a.PassportMounth + "." + a.PassportDay);
                    AccuracityLabel.Text = (100 - a.Accuracy).ToString();
                }
            }
        }
    }
}
