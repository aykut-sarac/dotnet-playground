using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "hey my name is aykut";

            var result = msg.Split();
            System.Console.WriteLine(result[0]); // hey

            string[] names = new string[5];

            names[0] = "aykut";
            names[1] = "josh";
            names[2] = "caca";
            names[3] = "pawpaw";
            names[4] = "ghost";
            System.Console.WriteLine(names[2]);

            int[] numbers = { 1, 2, 3, 4, 5 }; //
            System.Console.WriteLine(numbers[0]);

            numbers[0] = 123;
            System.Console.WriteLine(numbers[0]);

            // methods

            names.SetValue("mike", 0);
            System.Console.WriteLine(names[0]);
            System.Console.WriteLine(names.GetValue(0));
            System.Console.WriteLine(Array.IndexOf(names, "josh"));
            System.Console.WriteLine(names.Length);

            // Array.Sort(names);
            // System.Console.WriteLine(names.GetValue(0));
            // Array.Reverse(names);
            // System.Console.WriteLine(names.GetValue(0));
            // Array.Clear(names, 0, 2);
            // System.Console.WriteLine(names.GetValue(0));

            System.Console.WriteLine(names[^1]); //last

            // var array1 = names[1..3];
            // var array1 = names[1..];
            // var array1 = names[..3];

            foreach (var name in names)
            {
                System.Console.WriteLine(name);
            }

            string asd = " hey my name is bob";
            System.Console.WriteLine(asd[0..5]);

        }
    }
}
