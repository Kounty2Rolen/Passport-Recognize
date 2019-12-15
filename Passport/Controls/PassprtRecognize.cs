using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronOcr;
using NickBuhro.Translit;
using Passport.Controls.Human;

namespace Passport.Controls
{
    class PassportRecognize
    {
        public PassportClass ReadPassport(Bitmap bitmap)
        {
            var ocr = new AutoOcr();
            var preresult = ocr.Read(bitmap);
            string result=null;
            Human.PassportClass passport = new Human.PassportClass();
            foreach (var page in preresult.Pages)
            {
                foreach (var paragraph in page.Paragraphs)
                {
                    if (paragraph.Text.StartsWith("PNRUS"))
                    {
                        passport.X = paragraph.X;
                        passport.Y = paragraph.Y;
                        passport.Width = paragraph.Width;
                        passport.Height = paragraph.Height;

                        result = paragraph.Text;
                        passport.Accuracy = paragraph.Confidence;
                    }
                }
            
            }
            try
            {
                passport.Country = result.Substring(2, 3).ToString();
                var name = result.Remove(0, 5).Split(new char[] { '<' }, StringSplitOptions.RemoveEmptyEntries);
                name[3] = name[3].Remove(0, 2);
                passport.Fname = Transliteration.LatinToCyrillic(name[0], Language.Russian);
                passport.Mname = Transliteration.LatinToCyrillic(name[1], Language.Russian);
                if (!Int32.TryParse(name[2], out int a))
                {
                    passport.Lname = Transliteration.LatinToCyrillic(name[2], Language.Russian);
                }
                else
                {
                    passport.Serial = name[2].Substring(0, 3) + name[3].First() + name[2].Substring(3, 6);
                    passport.Nationality = name[2].Substring(9, 3);
                    passport.Year = name[2].Substring(12, 2);
                    passport.Mounth = name[2].Substring(14, 2);
                    passport.Day = name[2].Substring(16, 2);
                    passport.Gender = name[2].Substring(18, 1);
                    passport.PassportYear = name[3].Substring(1, 2);
                    passport.PassportMounth = name[3].Substring(3, 2);
                    passport.PassportDay = name[3].Substring(5, 2);
                    passport.Code = name[3].Substring(7, 3) + "-" + name[3].Substring(10, 3);



                }
                if (passport.Serial != string.Empty)
                {
                    passport.Serial = name[3].Substring(0, 2) + " " + name[3].Substring(2, 1) + name[4].First() + " " + name[3].Substring(3, 6);
                    passport.Nationality = name[3].Substring(10, 3);
                    passport.Year = name[3].Substring(13, 2);
                    passport.Mounth = name[3].Substring(15, 2);
                    passport.Day = name[3].Substring(17, 2);
                    passport.Gender = name[3].Substring(20, 1);
                    passport.PassportYear = name[4].Substring(1, 2);
                    passport.PassportMounth = name[4].Substring(3, 2);
                    passport.PassportDay = name[4].Substring(5, 2);
                    passport.Code = name[4].Substring(7, 3) + "-" + name[4].Substring(10, 3);
                }
            }
            catch (NullReferenceException exc)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка сканирования, введите данные в ручную");
            }
            return passport;
                ocr = null;
                result = null;

        }
    }
    
}
