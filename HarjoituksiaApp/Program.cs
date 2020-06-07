using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarjoituksiaApp
{
    class Program
    {
        public static int AddAndMultiply(int a, int b, int c)
        {
            Console.WriteLine((a + b) * c);
            return (a + b) * c;
        }

        public static void CelsiusToFahrenheit(int C)
        {
            double Fahrenheit = (C * 1.8) + 32;

            if(C == 0)
            {
                Console.WriteLine("Temperature is 32 F");
            }
            else if (C == 100)
                {
                Console.WriteLine("Temperature is 212 F");
            }
            else if (C <= -271.15)
            {
                Console.WriteLine("Temperature below absolute zero!");
            }

        }

        private static void ElementaryOperations(double v1, double v2)
        {
            Console.WriteLine(v1 + v2);
            Console.WriteLine(v2 - v1);
            Console.WriteLine(v1 * v2);
            Console.WriteLine(v1 / v2);
        }

        private static void IsResultTheSame(int v1, int v2)
        {
            if(v1 == v2)
                Console.WriteLine("sama");
            else
                Console.WriteLine("eri");
        }

        private static void ModuloOperations(int v1, int v2, int v3)
        {
            Console.WriteLine(v1 % v2 % v3);
        }

        private static void TheCubeOf(int v)
        {
            Console.WriteLine(v * v * v);
        }

        private static void SwapTwoNumbers(int a, int b)
        {
            int dummy;

            Console.WriteLine($"a on {a} ja b on {b}");
            dummy = b;
            b = a;
            a = dummy;
            Console.WriteLine($"a on {a} ja b on {b}");
        }

        static int AbsoluteValue(int number)
        {
            return number >= 0 ? number : number * -1;
        }




        static void Main(string[] args)
        {
            //------------------
            //AddAndMultiply(2, 4, 5);
            Console.WriteLine(AddAndMultiply(3, 6, 35));

            //_-----------------
            CelsiusToFahrenheit(0);
            CelsiusToFahrenheit(100);
            CelsiusToFahrenheit(-300);

            //-------------------
            ElementaryOperations(3, 8);

            //_------------------
            IsResultTheSame(2 + 2, 2 * 2);
            IsResultTheSame(9 / 3, 16 - 1);

            //--------------------
            ModuloOperations(8, 5, 2);

            //--------------------
            TheCubeOf(2);

            //--------------------
            SwapTwoNumbers(87, 45);
            SwapTwoNumbers(-13, 2);

            //--------------------
            // https://csharpexercises.com/conditional-statements/exercise/absolute-value
            Console.WriteLine(AbsoluteValue(-690543));  // 690543
            Console.WriteLine(AbsoluteValue(2744));     // 2744
            Console.WriteLine(AbsoluteValue(0));        // 0           
            Console.WriteLine(AbsoluteValue(-23));

            //---------------------



            Console.ReadLine();

        }


    }
}
