﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronOcr;
using NickBuhro.Translit;
using PassportRecognize.Controls.Human;

namespace PassportRecognize.Controls
{
    class PassportRecognizeClass
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
                passport.Fname = NormalizeString.normalize(Transliteration.LatinToCyrillic(name[0], Language.Russian));
                passport.Mname = NormalizeString.normalize(Transliteration.LatinToCyrillic(name[1], Language.Russian));
                if (!Int32.TryParse(name[2], out int a))
                {
                    passport.Lname = NormalizeString.normalize(Transliteration.LatinToCyrillic(name[2], Language.Russian));
                }
                else
                {
                    passport.Serial = name[2].Substring(0, 3) + name[3].First() + name[2].Substring(3, 6);
                    passport.Nationality = name[2].Substring(9, 3);
                    passport.Year = Convert.ToInt32(name[2].Substring(12, 2));
                    passport.Mounth = Convert.ToInt32(name[2].Substring(14, 2));
                    passport.Day = Convert.ToInt32(name[2].Substring(16, 2));
                    passport.Gender = name[2].Substring(18, 1);
                    passport.PassportYear = Convert.ToInt32(name[3].Substring(1, 2));
                    passport.PassportMounth = Convert.ToInt32(name[3].Substring(3, 2));
                    passport.PassportDay = Convert.ToInt32(name[3].Substring(5, 2));
                    passport.Code = name[3].Substring(7, 3) + "-" + name[3].Substring(10, 3);



                }
                if (passport.Serial != string.Empty)
                {
                    passport.Serial = name[3].Substring(0, 3)+ name[4].First() + name[3].Substring(3, 6);
                    passport.Nationality = name[3].Substring(10, 3);
                    passport.Year = Convert.ToInt32(name[3].Substring(13, 2));
                    passport.Mounth = Convert.ToInt32(name[3].Substring(15, 2));
                    passport.Day = Convert.ToInt32(name[3].Substring(17, 2));
                    passport.Gender = name[3].Substring(20, 1);
                    passport.PassportYear = Convert.ToInt32(name[4].Substring(1, 2));
                    passport.PassportMounth = Convert.ToInt32(name[4].Substring(3, 2));
                    passport.PassportDay = Convert.ToInt32(name[4].Substring(5, 2));
                    passport.Code = name[4].Substring(7, 3) + "-" + name[4].Substring(10, 3);
                }
                if (passport.Year>=20)
                {
                    passport.Year += 1900;
                }
                else
                {
                    passport.Year += 2000;
                }
                if (passport.PassportYear>=20)
                {
                    passport.PassportYear += 1900;
                }
                else
                {
                    passport.PassportYear += 2000;
                }

            }
            catch (NullReferenceException exc)
            {
                System.Windows.Forms.MessageBox.Show("Ошибка сканирования, введите данные в ручную");
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message+"\n\n"+exc.StackTrace+"\n\n"+exc.HelpLink,"Ошибка сканирования",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
            }
            return passport;
                ocr = null;
                result = null;

        }
    }
    
}
