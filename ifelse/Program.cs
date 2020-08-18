using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            var isTrue = false;
            if (isTrue)
            {
                System.Console.WriteLine("Hi");

            }
            else
            {
                System.Console.WriteLine("not true");

            }

            int num = 5;
            if (num == 5)
            {
                System.Console.WriteLine("num is 5");
            }
            else if (num == 7)
            {
                System.Console.WriteLine("num is 7");
            }
            else
            {
                System.Console.WriteLine("num is 10");
            }

            int month = 6;

            switch (month)
            {
                case 1:
                    System.Console.WriteLine("its jan");
                    break;
                case 2:
                    System.Console.WriteLine("its feb");
                    break;
                case 5:
                    System.Console.WriteLine("its may");
                    break;

                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("it could be june july or aug");
                    break;
                default:
                    System.Console.WriteLine("wrong input");
                    break;
            }



        }
    }
}
