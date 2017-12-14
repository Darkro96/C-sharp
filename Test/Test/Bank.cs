using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Bank
    {
        Account[] accounts;
        int counter = 0;
        public Bank()
        {
            accounts = new Account[50];
        }

        public void createAccount()
        {
            this.message("Enter your name: ");
            string name = this.getString();
            this.message("Enter your Initial Balance: ");
            double initBalance = this.getDouble();
            this.message("ID: ");
            string id = this.getString();
            this.accounts[counter] = new Account(name, initBalance, id);
            message("Your account ID is: " + this.accounts[counter].id + "\n");
            Console.WriteLine("");
            counter++;
        }

        public bool deposite(double amount)
        {
            return true;
        }

        public bool withdraw(double amount)
        {
            return true;
        }

        void message(string msg)
        {
            System.Console.Write(msg);
        }

        string getString()
        {
            return System.Console.ReadLine();
        }

        double getDouble()
        {
            return Convert.ToDouble(System.Console.ReadLine());
        }

        public void showAccountInfo()
        {
            this.accounts[counter - 1].showAccountInfo();
        }

        public void showAccountInfo(string accId)
        {
            bool exist = false;
            for (int i = 0; i < counter; i++)
            {
                if(accounts[i].id == accId)
                {
                    accounts[i].showAccountInfo();
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                message("Account not exist.\n");
            }
        }
    }
}
