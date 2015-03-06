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
        private static Stopwatch stopWatch = new Stopwatch();
        public static double Root(double number, int power, double accuracy = 0.000001)
        {
            if (number < 0 || power < 1 || accuracy > 0.1 || accuracy <= 0) throw new ArgumentException();
            stopWatch.Reset();
            stopWatch.Start();
            double xfirst, xlast;
            xlast = number;
            do
            {
                xfirst = xlast;
                xlast = (1.0 / power) * ((power - 1) * xfirst + number / Power(xfirst, power - 1));
            }
            while ((xfirst - xlast) > accuracy);
            stopWatch.Stop();
            return xlast;
        }
        public static int EuclideanAlgo(params int[] values)
        {
            if (values.Length < 2) throw new ArgumentException();
            stopWatch.Reset();
            stopWatch.Start();
            if (values.Length == 2) return EuclideanAlgo(values[0], values[1]);
            for (int i = values.Length - 1; i > 0; --i)
            {
                values[i - 1] = EuclideanAlgo(values[i - 1], values[i]);
            }
            stopWatch.Stop();
            return values[0];
            
        }
        public static int BinaryEuclideanAlgo(params int[] values)
        {
            if (values.Length < 2) throw new ArgumentException();
            stopWatch.Reset();
            stopWatch.Start();
            if (values.Length == 2) return BinaryEuclideanAlgo(values[0], values[1]);
            for (int i = values.Length - 1; i > 0; --i)
            {
                values[i - 1] = BinaryEuclideanAlgo(values[i - 1], values[i]);
            }
            stopWatch.Stop();
            return values[0];
        }
        /// <summary>
        /// Specifies the execution time of the previous method.
        /// </summary>
        public static void DisplayExecuteTime()
        {
            // Display the timer frequency and resolution.
            long frequency = Stopwatch.Frequency;
            long nanosecPerTick = (1000L * 1000L * 1000L) / frequency;
            long nanosecExecut = nanosecPerTick * stopWatch.ElapsedTicks;
            Console.WriteLine("The execition time: {0} nanoseconds or {1} milliseconds",
                nanosecExecut, (double)nanosecExecut / 1000000);
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
        private static int EuclideanAlgo(int value1, int value2)
        {
            int a, b;
            if (value1 >= value2) { a = value1; b = value2; }
            else { a = value2; b = value1; }
            while (b != 0)
                b = a % (a = b);
            return a;
        }
        private static int BinaryEuclideanAlgo(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            if ((a % 2 == 0) && (b % 2 == 0)) return 2 * BinaryEuclideanAlgo(a / 2, b / 2);
            if ((a % 2 == 0) && (b % 2 != 0)) return BinaryEuclideanAlgo(a / 2, b);
            if ((a % 2 != 0) && (b % 2 == 0)) return BinaryEuclideanAlgo(a, b / 2);
            return BinaryEuclideanAlgo(b, (int)Math.Abs(a - b));
        }
    }
}
