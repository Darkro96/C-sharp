using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class Bank
    {
        private List<Account> Accounts;

        public Bank()
        {
            Accounts = new List<Account>();

        }

        public void CreateAccount(string name, string number, decimal amount)
        {
            var ac = new AccSaving(name, number, amount);
            Accounts.Add(ac);
            Console.WriteLine("Created account: {0}, owner: {1}", number, name);
        }



        public void Transfer(string sourcenum, string targetnum, decimal amount)
        {
            var source = (from ac in Accounts
                          where ac.Number == sourcenum
                          select ac).FirstOrDefault();

            var target = (from ac in Accounts
                          where ac.Number == targetnum
                          select ac).FirstOrDefault();

            if (source == null) throw new Exception("Source account doesn't exist");
            if (target == null) throw new Exception("Target account doesn't exist");
            source.Charge(amount);
            target.Add(amount);

            Console.WriteLine("Succesull transfer from {0} to {1}\namount: {2:C}", sourcenum, targetnum, amount);

        }

        public decimal MoneyInBank
        {
            get
            {
                return Accounts.Sum(account => account.Amount);
            }
        }
    }
}
