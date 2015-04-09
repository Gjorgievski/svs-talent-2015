using BankClasses.Accounts;
using BankClasses.Common.Enumeration;
using BankClasses.Common.Structure;
using BankClasses.Processors;
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

        /// <summary>
        /// Propert for last transaction made
        /// </summary>
        TransactionLogEntry LastTransaction { get; }

        /// <summary>
        /// Property for counting transactions
        /// </summary>
        int TransactionCount { get; }

        /// <summary>
        /// Indexer property for getting specific log transaction
        /// </summary>
        /// <param name="index">position of log transaction</param>
        /// <returns>transaction log</returns>
        TransactionLogEntry this[int index] { get; }


        /// <summary>Method for processing transaction</summary> 
        TransactionStatus ProcessTransaction(TransactionType transactionType,CurrencyAmount currencyAmount,IAccount accountFrom,IAccount accountTo);


        /// <summary>
        /// Method for making group transaction
        /// </summary>
        /// <param name="transactionType">type of transaction</param>
        /// <param name="amount">amount</param>
        /// <param name="accounts">list of accounts</param>
        /// <returns></returns>
        TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts);
    }
}
