using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            char op;
            int result = 0;

            if (args.Length == 0)
            {
                Console.Write("The first number: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("The second number: ");
                y = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("The operator: ");
                op = Convert.ToChar(Console.Read());
                Console.WriteLine();
            }
            else
                if (args.Length != 3)
            {
                Console.WriteLine("Too much parameter!");
                return;
            }
            else
            {
                x = int.Parse(args[0]);
                y = int.Parse(args[1]);
                op = Convert.ToChar(args[2]);
            }

            switch (op)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
            }
            Console.WriteLine("The result of the operation: {0}", result);

            Console.ReadKey();
        }
    }
}
