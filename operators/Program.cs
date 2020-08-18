using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int val;
            val = a + b;
            val = a - b;
            val = a * b;
            val = a / b;
            val = b % a; //0
            val = a++; //val=10 a=11
            val = ++a;//val=11 a=11            

            System.Console.WriteLine("value: " + val);

            int x = 5, y = 10, z = 20;

            x += 5;//x=x+5; 10
            val = Math.Pow(x, y); // x^y
            val = Math.Sqrt(25);// 5
            val = Math.Abs(-12);//12
            val = Math.Round(4.5);//4 round to even number
            val = Math.Ceiling(5.5);//round to up 6
            val = Math.Floor(5.5);// round to down 5


            System.Console.WriteLine($"x:{x} y: {y} z: {z}");

            int a = 5, s = 5, d = 10, f = 4;
            string username = "aykut";
            string password = "123456";


            var result = (a == s);//true
            result = (a == d);//false
            result = (username == "aykut");//true
            result = (a != s); //false
            result = (a <= s); //true
            result = (a == s) ? "if true" : "if false";//same js


            System.Console.WriteLine(result);

            // (x>5) && (x<10) AND
            // (x>5) || (x<10) OR
            // !() NOT


        }
    }
}
