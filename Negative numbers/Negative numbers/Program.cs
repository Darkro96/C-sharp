using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Negative_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader be = new StreamReader("bemenet1.txt");
            int db = 0;
            int[] t = new int[100];
            while (be.Peek() > -1)
            {
                t[db] = int.Parse(be.ReadLine());
                db++;
            }
            be.Close();
            int dbn = 0;
            for (int i = 0; i < db; i++)
            {
                if (t[i] < 0)
                    dbn++;
            }
            Console.WriteLine("There are {0} negative numbers in the block.", dbn);
            Console.ReadKey();
        }
    }
}
