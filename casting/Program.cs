using System;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit casting : smaller to larger
            //int-long

            int a = 10; // 32bit
            long b = a; // 64bit

            float e = 10.5f;
            double f = e;

            // explicit casting : larger to smaller

            long c = 10;
            int d = (int)c;

            double g = 10.6;
            float h = (float)g;

            int x = 10;
            string z = x.ToString();


            System.Console.WriteLine("1.number: ");
            int num1 = int.Parse(Console.ReadLine()); // short.parse long.parse
            System.Console.WriteLine(" 2.number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2; // 5+2 =52
            System.Console.WriteLine($"sum : {sum}");
        }
    }
}
