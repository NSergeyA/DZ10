using LAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABWORK.LAB12
{
    internal class Bankacc
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Bankacc acc = (Bankacc)obj;
            return AccountNumber == acc.AccountNumber &&
                   Balance == acc.Balance;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"Номер аккаунта: {AccountNumber}, Баланс аккаунта: {Balance}";
        }
        public static bool operator ==(Bankacc account1, Bankacc account2)
        {
            if (ReferenceEquals(account1, account2))
            { return true; }
            else if ((account1 is null) || (account2 is null))
            { return false; }
            else
            { return account1.Equals(account2); }
        }
        public static bool operator !=(Bankacc account1, Bankacc account2)
        {
            return !(account1 == account2);
        }
        public Bankacc(int accountNumber, double balance)
        {
            this.AccountNumber = accountNumber; this.Balance = balance;
        }

    }
}
