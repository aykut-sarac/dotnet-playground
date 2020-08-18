using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for

            int sum = 0;
            string[] names = { "josh", "john", "jon" };
            for (int i = 0; i < 10; i++)
            {
                //System.Console.WriteLine(i);
                if (i % 2 == 0)
                {
                    System.Console.WriteLine(i);
                    sum += i;
                }
            }
            System.Console.WriteLine(sum);

            for (int i = 0; i < names.Length; i++)
            {
                System.Console.WriteLine(names[i]);
            }


            //while

            int j = 0;
            while (j < 10)
            {
                System.Console.WriteLine(j);
                j++;
            }

            string name = "";
            while (string.IsNullOrEmpty(name))
            {
                System.Console.Write("yourname ");
                name = Console.ReadLine();
            }


            //do-while
            string surname = "";
            do
            {
                System.Console.Write("surname: ");
                surname = Console.ReadLine();
            } while (string.IsNullOrEmpty(surname));
            System.Console.Write($"hi {surname}");

            //break-continue

            string fullname = "aykut josh";
            for (int i = 0; i < fullname.Length; i++)
            {
                if (fullname[i] == 'j')
                    continue;
                //break;
                System.Console.WriteLine(fullname[i]);
            }

            //little game-guess the number
            int secretNumber = (new Random()).Next(1, 100);
            //System.Console.WriteLine(secretNumber);
            int lives = 5;
            int guess;

            while (lives > 0)
            {
                Console.Write("guess: ");
                guess = int.Parse(Console.ReadLine());
                lives--;
                if (guess == secretNumber)
                {
                    System.Console.WriteLine("you god damn right");
                    break;
                }
                else
                {
                    if (lives == 0)
                        break;
                    if (secretNumber > guess)
                    {
                        System.Console.WriteLine("up");
                    }
                    else
                    {
                        System.Console.WriteLine("down");
                    }
                }



            }
            System.Console.WriteLine("gameover");
        }
    }
}
