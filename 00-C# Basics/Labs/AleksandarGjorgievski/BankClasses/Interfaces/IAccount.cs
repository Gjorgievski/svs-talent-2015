using BankClasses.Common.Enumeration;
using BankClasses.Common.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Interfaces
{
    /// <summary>
    /// Interface for properties an publc methods for account
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Property for account id
        /// </summary> 
         long Id{ get;}
         /// <summary>
         /// Property for account number
         /// </summary> 
         string Number { get; }
         /// <summary>
         /// Property for account currency
         /// </summary> 
         string Currency { get; }
         /// <summary>
         /// Property for account balance
         /// </summary> 
         CurrencyAmount Balance { get; }

       
        /// <summary>
        /// Event for balance change
        /// </summary>
        event BalanceChanged OnBalanceChanged;


         /// <summary>
         /// Method for debit transaction
         /// </summary> 
         TransactionStatus DebitAmmout(CurrencyAmount amount);
         
        /// <summary>
         /// Method for credit transaction
         /// </summary> 
         TransactionStatus CreditAmmout(CurrencyAmount amount);

    }
}
