using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void message(string msg)
        {
            System.Console.Write(msg);
        }

        static void Main(string[] args)
        {   
            Account acc = new Account("Test1", 5000, "1111-2222-3333-4444");
            acc.showAccountInfo();
            acc.deposite(1000);
            acc.showAccountInfo();

            Account anotherAcc = new Account("Test2", 3000,"5555-6666-7777-8888");
            anotherAcc.showAccountInfo();
            anotherAcc.withdraw(1000);
            anotherAcc.showAccountInfo();
            Console.WriteLine("Test");

            //test
            Bank bracBank = new Bank();
            bracBank.createAccount();
            bracBank.createAccount();

            Console.WriteLine("");
            message("Enter ID to inquary: \n");
            string accId = System.Console.ReadLine();
            Console.WriteLine("The account info of "+accId+":\n");
            
            bracBank.showAccountInfo(accId);

            accId = System.Console.ReadLine();
            bracBank.showAccountInfo(accId);

            System.Console.ReadKey();
        }
    }
}
