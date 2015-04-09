using BankClasses.Common.Enumeration;
using BankClasses.Common.Structure;
using BankClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Processors
{
    /// <summary>
    /// Class for keeping a transaction log 
    /// </summary>
    public class TransactionLogEntry
    {
    #region Private Fields
        /// <summary>
        /// Private field for type of transaction
        /// </summary>
        private TransactionType transactionType;

        /// <summary>
        /// Private field for ammount
        /// </summary>
        private CurrencyAmount amount;

        /// <summary>
        /// Private field for list of accounts
        /// </summary>
        private IAccount[] accounts;

        /// <summary>
        /// Private field for transaciton status
        /// </summary>
        private TransactionStatus status;

        #endregion

    #region Public Properties
        /// <summary>
        /// Property for transaction type
        /// </summary>
        public TransactionType TransactionType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }

        /// <summary>
        /// Property for amount
        /// </summary>
        public CurrencyAmount Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        /// <summary>
        /// Property for list of accounts
        /// </summary>
        public IAccount[] Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        /// <summary>
        /// Property for transaction status
        /// </summary>
        public TransactionStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion

        /// <summary>
        /// Parametarless constructor for transaction log entry
        /// </summary>
        public TransactionLogEntry()
        {

        }

        /// <summary>
        /// Constructor for transaction log entry with four parametars
        /// </summary>
        /// <param name="transactionType">transaction type</param>
        /// <param name="amount">amount</param>
        /// <param name="accounts">list of accounts</param>
        /// <param name="status">transaction status</param>
        public TransactionLogEntry(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts, TransactionStatus status)
        {
            this.TransactionType = transactionType;
            this.Amount = amount;
            this.Accounts = accounts;
            this.Accounts = accounts;
            this.Status = status;
        }
    }
}
