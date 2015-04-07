using BankClasses.Accounts;
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
    /// Interface for transaction procesor
    /// </summary>
    public interface ITransactionProcessor
    {
        /// <summary>Method for processing transaction</summary> 
        TransactionStatus ProcessTransaction(TransactionType transactionType,CurrencyAmount currencyAmount,IAccount accountFrom,IAccount accountTo);

    }
}
