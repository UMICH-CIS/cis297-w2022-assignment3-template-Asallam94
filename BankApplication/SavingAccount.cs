using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BankApplication
{     /// <summary>
      /// Inhereted class from account base class
      /// </summary>
      /// <Student>Amani Sallam</Student>
      /// <Class>CIS297</Class>
      /// <Semester>Winter 2022</Semester
    class SavingsAccount : Account
    {        
        private decimal Intrestrate;
        /// <summary>
        /// Constructor for intrest rate
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="rate"></param>
        public SavingsAccount(decimal accountBalance, decimal rate) : base(accountBalance)// constractor
        {
            Intrestrate = rate;
        }
        /// <summary>
        /// Method for calculating the amount of money added owing to interest
        /// </summary>
        /// <returns></returns>
        public decimal CalculateInterest() // method 
        {
             return balance() * Intrestrate / 100M;
           
        }        
    }
}
