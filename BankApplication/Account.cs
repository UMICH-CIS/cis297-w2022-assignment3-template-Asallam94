using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{  /// <summary>
   /// a base class from which the saving and checking account classes were derived
   /// </summary>
   /// <Student>Amani Sallam</Student>
   /// <Class>CIS297</Class>
   /// <Semester>Winter 2022</Semester>

    public abstract class Account
    {
        private decimal accountBalance;
        /// <summary>
        /// Constructor for base class
        /// </summary>
        /// <param name="balannce"></param>
        public Account(decimal intialbalance) 
        {
            if (intialbalance > 0.0M)
            {
                accountBalance = intialbalance;

            }
            else
            {
                throw new Exception("Invalid amount.This amount is less than $0.00 .");
            }
        }
        /// <summary>
        ///  method to add an amount to current balance
        /// </summary>
        /// <param name="amount"></param>
        public virtual void Credit(decimal amount) 
        {              
            accountBalance += amount;
        }
        /// <summary>
        /// Method to withdraw money from account 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual bool Debit(decimal amount) 
             // debit amount doesnt exceed account balance if it does the balance should be left uncharged 
        {
            accountBalance -= amount;
            if (amount <= accountBalance)
            {
                return true;
            }
            else 
            {
               accountBalance += amount;
               Console.WriteLine(" The debit amount exceeds the account balance. ");
               return false;
            }  
        }
        /// <summary>
        /// Method to return current balacne 
        /// </summary>
        /// <returns></returns>
        public decimal balance()
        {
            return accountBalance;
        }

    }
}
