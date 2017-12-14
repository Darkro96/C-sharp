using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Account
    {
        string name;
        public string id;
        double balance;
        double deposit;

        public Account()
        {

        }

        public Account(string name, double initBalance, string id)
        {
            this.name = name;
            this.balance = initBalance;
            this.id = id;
        }

        public string getName()
        {
            return this.name;
        }

        

        public double getBalance()
        {
            return this.balance;
        }

        public string getID()
        {
            return this.id;
        }

        public bool deposite(double amount)
        {
            this.balance += amount;
            this.message("\nDeposite succesfully\n");
            return true;
        }

        public bool withdraw(double amount)
        {
            this.balance -= amount;
            this.message("\nWithdraw succesfully\n");
            return true;
        }

        public void showAccountInfo()
        {
            string message = "The account ID: " + this.id;
            this.message(message);

            message = "Name: " + this.name;
            this.message(message);

            message = "Balance: " + this.balance+"\n";
            this.message(message);
        }

        void message(string msg)
        {
            System.Console.WriteLine(msg);
        }
    }
}
