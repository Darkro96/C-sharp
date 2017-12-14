using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            START:

            Console.WriteLine("Chose a game mode!");
            Console.WriteLine("1 - You think of a number");
            Console.WriteLine("2 - The computer think of a number");

            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': goto PLAYER;
                case '2': goto COMPUTER;
            }

            PLAYER:
            Console.WriteLine("Think of a number! (1 - 100)");
            Console.ReadLine();
            int x = 50;
            int min = 0;
            int max = 100;
            int i = 0;
            Random r = new Random();
            while (i < 5)
            {
                Console.WriteLine("According to the computer the number is: {0}", x);
                Console.WriteLine("Smaller, bigger or equal? (s/b/e)");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 's':
                        if (i == 5)
                            x = r.Next(min, x);
                        else
                        {
                            max = x;
                            x -= (max - min) / 2;
                        }
                        break;
                    case 'b':
                        if (i == 5)
                            x = r.Next(x + 1, max);
                        else
                        {
                            min = x;
                            x += (max - min) / 2;
                        }
                        break;
                    case 'e':
                        Console.WriteLine("The computer won!");
                        goto END;
                }
                ++i;
            }
            Console.WriteLine("The computer didn't quess the number.");
            goto END;
            COMPUTER:
            Random rand = new Random();
            int number = rand.Next(100);
            int j = 0;
            int z;
            while (j < 5)
            {
                Console.WriteLine("\nYour tip: ");
                z = int.Parse(Console.ReadLine());

                if (z < number)
                {
                    Console.WriteLine("The number is bigger!");
                }
                else if (z > number)
                {
                    Console.WriteLine("The number is smaller!");
                }
                else
                {
                    Console.WriteLine("You won!");
                    goto END;
                }
                ++j;
            }
            Console.WriteLine("\nYou lose, the number was: {0}", number);
            goto END;


            END:
            Console.WriteLine("Wanna play again? y/n");
            switch (Console.ReadKey(true).KeyChar)
            {
                case 'y': goto START;
                case 'n': break;
                default: goto END;
            }
        }
    }
}
