using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "aykut";
            string surname = "sarac";
            int age = 30;

            string str = "My name is " + name + " " + surname + " and i am " + age + " yo.";
            string str2 = string.Format("my name is {0} {1} and im {2} yo.", name, surname, age);
            string str3 = $"my name is {name} {surname} and im {age} yo.";

            System.Console.WriteLine(str3);
            Console.WriteLine(str.Length);
            System.Console.WriteLine(str.ToLower());
            System.Console.WriteLine(str.ToUpper());
            System.Console.WriteLine(str.Trim());
            System.Console.WriteLine(str.Split()[3]);
            System.Console.WriteLine(str[6]);
            System.Console.WriteLine(str.StartsWith("My"));
            System.Console.WriteLine(str.EndsWith("."));
            System.Console.WriteLine(str.Contains("aykut"));
            System.Console.WriteLine(str.IndexOf("name"));
            System.Console.WriteLine(str.Substring(5));
            System.Console.WriteLine(str.Replace(" ", "-").Replace(".", ""));
            System.Console.WriteLine(str.Insert(0, "Hey "));
            System.Console.WriteLine(str.Insert(str.Length, "..."));
            System.Console.WriteLine(str.Remove(5, 10));
        }
    }
}
