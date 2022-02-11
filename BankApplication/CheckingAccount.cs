using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{   /// <summary>
    /// class that inheret from base class account
    /// </summary>
    /// <Student>Amani Sallam</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    class CheckingAccount : Account
       {   /// <summary>
          ///  that represent fee charged
         /// </summary>
        private decimal feepertrans;
        // receive balance 
        /// <summary>
        /// constractor which includes initial charge  that is contributed to the transaction preocess.
        /// </summary>
        /// <param name="Balance"></param>
        /// <param name="fee"></param>
        public CheckingAccount(decimal initialbalance, decimal fee) : base(initialbalance)//constractor 
        {
          feepertrans = fee;
            
        }
        /// <summary>
        /// Method to withdraw money from checkingaccount
        /// </summary>
        /// <param name="amount"></param>
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            base.Debit(feepertrans);
        }
        /// <summary>
        /// Method to deposit money in checkingaccount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override bool Debit(decimal amount)
        {
           
            if (base.Debit(amount))
            {
                base.Debit(feepertrans);
                return true;
            }
            else
                return false;
        }        
    }
}
