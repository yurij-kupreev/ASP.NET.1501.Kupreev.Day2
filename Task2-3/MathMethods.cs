using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task2_3
{
    public static class MathMethods
    {
        public static double Root(double number, int power, double accuracy = 0.000001)
        {
            if (number < 0 || power < 1 || accuracy > 0.1 || accuracy <= 0) throw new ArgumentException();
            double xfirst, xlast;
            xlast = number;
            do
            {
                xfirst = xlast;
                xlast = (1.0 / power) * ((power - 1) * xfirst + number / Power(xfirst, power - 1));
            }
            while ((xfirst - xlast) > accuracy);
            return xlast;
        }
        public static int EuclideanAlgorithm(out long ticks, params int[] values)
        {
            if (values.Length < 2) throw new ArgumentException();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = values.Length - 1; i > 0; --i)
            {
                values[i - 1] = EuclideanAlgorithm(values[i - 1], values[i]);
            }
            stopWatch.Stop();
            ticks = stopWatch.ElapsedTicks;
            return values[0];
            
        }
        public static int BinaryEuclideanAlgorithm(out long ticks, params int[] values)
        {
            if (values.Length < 2) throw new ArgumentException();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = values.Length - 1; i > 0; --i)
            {
                values[i - 1] = BinaryEuclideanAlgorithm(values[i - 1], values[i]);
            }
            stopWatch.Stop();
            ticks = stopWatch.ElapsedTicks;
            return values[0];
        }
        private static double Power(double number, int power)
        {
            double answer = number;
            while (power > 1)
            {
                answer *= number;
                --power;
            }
            return answer;
        }
        private static int EuclideanAlgorithm(int value1, int value2)
        {
            int a, b;
            if (value1 >= value2) { a = value1; b = value2; }
            else { a = value2; b = value1; }
            while (b != 0)
                b = a % (a = b);
            return a;
        }
        private static int BinaryEuclideanAlgorithm(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            if ((a % 2 == 0) && (b % 2 == 0)) return 2 * BinaryEuclideanAlgorithm(a / 2, b / 2);
            if ((a % 2 == 0) && (b % 2 != 0)) return BinaryEuclideanAlgorithm(a / 2, b);
            if ((a % 2 != 0) && (b % 2 == 0)) return BinaryEuclideanAlgorithm(a, b / 2);
            return BinaryEuclideanAlgorithm(b, (int)Math.Abs(a - b));
        }
    }
}
