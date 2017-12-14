using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public abstract class Account
    {
        public string Owner { get; private set; }

        public string Number { get; private set; }

        public decimal Amount { get; protected set; }

        public abstract void Charge(decimal charge);

        public void Add(decimal amount)
        {
            Amount += amount;
        }

        public Account(string owner, string number, decimal ammount = 0)
        {
            Owner = owner;
            Number = number;
            Amount = ammount;
        }
    }

    public class AccSaving: Account
    {
        public AccSaving(string owner, string number, decimal ammount) : base(owner, number, ammount)
        {
        }

        public override void Charge(decimal charge)
        {
            var newvalue = Amount - charge;
            if (newvalue > -500) Amount = newvalue;
            else throw new Exception("Ovedraft error");
        }
    }
}


