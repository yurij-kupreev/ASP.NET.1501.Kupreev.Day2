using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2_3;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(MathMethods.EuclideanAlgo(12, 36, 44));
                MathMethods.DisplayExecuteTime();
                Console.WriteLine(MathMethods.BinaryEuclideanAlgo(12, 36, 44));
                MathMethods.DisplayExecuteTime();
                Console.WriteLine(MathMethods.Root(81, 4));
                MathMethods.DisplayExecuteTime();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
