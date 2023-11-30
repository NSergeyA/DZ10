using LAB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABWORK.LAB11
{

    internal class BankFactory
    {
        private Dictionary<int, Bankaccount> accounts = new Dictionary<int, Bankaccount>();
        private int accountnumber = 1000;
        static private Hashtable bank_hashtable = new Hashtable();
        public Hashtable bank_ht
        {
            get
            {
                return bank_ht;
            }
        }
        

        public void CreateAccount()
        {
            Bankaccount account = new Bankaccount();
            bank_hashtable.Add(accountnumber, account);
        }


        public void CreateAccount(double balance, BankType type)
        {
            
            Bankaccount account = new Bankaccount(type, balance);
            
        }

        public void CloseAccount(int accountnumber)
        {
            accounts.Remove(accountnumber);
        }
    }
}
