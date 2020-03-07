using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassportRecognize.Controls
{
    static class NormalizeString
    {

         public static string normalize(string str)
        {
            str = str.Replace('3', 'Ч');
            str = str.Replace('0', 'О');
            return str;
        }
    }
}
