using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kynea
{
    class Program
    {
        static bool Kynea(int a)
        {

            int i = 0;
            while (i < a)
            {
                if (Math.Pow((Math.Pow(2, i) + 1), 2) - 2 == a)
                    return true;
                i++;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give a number: ");
            int a;
            a = int.Parse(Console.ReadLine());
            if (Kynea(a))
                Console.WriteLine("This number is Kynea number.");
            else
                Console.WriteLine("This number isn't Kynea number.");
            Console.ReadKey();
        }
    }
}
