using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class CustomFormatProvider
    {
        public static String Convert(int value, int toBase)
        {
            if (value < 0 || (toBase != 2 && toBase != 8 && toBase != 10 && toBase != 16)) throw new ArgumentException();
            if (toBase == 10) return value.ToString();
            StringBuilder newString = new StringBuilder();
            int modul;
            char buffer;
            while (value != 0)
            {
                modul = value % toBase;
                value /= toBase;
                if (modul > 9)
                {
                    buffer = 'A';
                    buffer += (char)(modul - 10);
                    newString.Append(buffer);
                }
                else newString.Append(modul.ToString());
            }
            int i, j;
            for (i = 0, j = newString.Length - 1; i < j; ++i, --j)
            {
                buffer = newString[i];
                newString[i] = newString[j];
                newString[j] = buffer;
            }
            return newString.ToString();
        }
    }
}
