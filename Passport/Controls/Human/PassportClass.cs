using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Passport.Controls.Human
{
    class PassportClass
    {
        string country;
        string fname;
        string mname;
        string lname;
        string serial;
        string nationality;
        int year;
        int mounth;
        int day;
        string gender;
        int passportYear;
        int passportMounth;
        int passportDay;
        string code;
        double accuracy;
        double x;
        double y;
        double width;
        double height;



        public string Country { get => country; set => country = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Mname { get => mname; set => mname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Serial { get => serial; set => serial = value; }
        public int Year { get => year; set => year = value; }
        public int Mounth { get => mounth; set => mounth = value; }
        public int Day { get => day; set => day = value; }
        public string Gender { get => gender; set => gender = value; }
        public int PassportYear { get => passportYear; set => passportYear = value; }
        public int PassportMounth { get => passportMounth; set => passportMounth = value; }
        public int PassportDay { get => passportDay; set => passportDay = value; }
        public string Code { get => code; set => code = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public double Accuracy { get => accuracy; set => accuracy = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
    }
}
