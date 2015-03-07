using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Task1
{
    public class BinaryFormatter : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }
        public String Format(String format, object arg, IFormatProvider formatProvider)
        {
            if (!(arg is int)) throw new ArgumentException();
            int baseNumber;
            string thisFmt = String.Empty;
            if (!String.IsNullOrEmpty(format))
                thisFmt = format.Length > 1 ? format.Substring(0, 1) : format;

            switch (thisFmt.ToUpper())
            {
                case "B":
                    baseNumber = 2;
                    break;
                case "O":
                    baseNumber = 8;
                    break;
                case "H":
                    baseNumber = 16;
                    break;
                default:
                    try
                    {
                        return HandleOtherFormats(format, arg);
                    }
                    catch (FormatException e)
                    {
                        throw new FormatException(String.Format("The format of '{0}' is invalid.", format), e);
                    }
            }
            string numericString = Convert((int)arg, baseNumber);
            return numericString;
        }
        private String Convert(int value, int toBase)
        {
            if (value < 0) throw new ArgumentException();
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

        private String HandleOtherFormats(String format, object arg)
        {
            if (arg is IFormattable)
                return ((IFormattable)arg).ToString(format, CultureInfo.CurrentCulture);
            else if (arg != null)
                return arg.ToString();
            else
                return String.Empty;
        }
    }
}
