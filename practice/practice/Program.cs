using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.CreateAccount("Test1", "555", 500);
            b.CreateAccount("Test2", "444", 500);
            b.Transfer("555", "444", 100);
            Console.WriteLine("Money in bank: {0:C}", b.MoneyInBank);
            Console.ReadLine();
        }
    }
}
