using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassportRecognize.Controls.Context;


namespace PassportRecognize
{
    public partial class MainForm : Form
    {
        Controls.Human.PassportClass result;
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
                Controls.PassportRecognizeClass recognize = new Controls.PassportRecognizeClass();
                result = recognize.ReadPassport(bitmap);
                if (result != null)
                {
                    firstNameTBox.Text = result.Fname;
                    midlNameTxtBx.Text = result.Mname;
                    lastNameTxtBx.Text = result.Lname;
                    birdthDateDTP.Value = result.getBirthDate();
                    genderCmbBx.Text = result.Gender;
                    passportSerialTBox.Text = result.Serial.Substring(0, 4);
                    passportNumberTbox.Text = result.Serial.Substring(4, 6);
                    passportGiveDTP.Value = result.getPassportDate();
                    AccuracityLabel.Text = (100 - result.Accuracy).ToString();
                    countryComboBx.Text = result.Country;
                    nationalComBx.Text = result.Nationality;
                    codeMTBx.Text = result.Code;
                }
            }
        }

        private void AddRecord()
        {
            Passport passport = new Passport();
            passport.BirthDate = result.getBirthDate();
            passport.Passportdate = result.getPassportDate();
            passport.serialAndNumber=result.Serial;
            Human human = new Human();
            human.Fname = result.Fname;
            human.Mname = result.Mname;
            human.Lname = result.Lname;
            human.PassportID = passport.serialAndNumber;
            DBObject.context.Passport.Add(passport);
            DBObject.context.Human.Add(human);
            DBObject.context.SaveChanges();
        }
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (result != null)
                AddRecord();
            else
                MessageBox.Show("Паспорт не отсканирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
