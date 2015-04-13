using BankClasses.Common.Enumeration;
using BankClasses.Common.Structure;
using BankClasses.Helpers;
using BankClasses.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Processors
{
    /// <summary>
    /// Class for making transaction
    /// </summary>
    public class TransactionProcessor:ITransactionProcessor
    {
        /// <summary>
        /// Static field for TransactionProcessor instance
        /// </summary>
        private static TransactionProcessor instance;

        /// <summary>
        /// Private field for transaction log
        /// </summary>
        private IList<TransactionLogEntry> transactionLog;


        /// <summary>
        /// Parametarless constructor for Transaction processor
        /// </summary>
        private TransactionProcessor()
        {
            //IList transactionLog = new IList<TransactionLogEntry>();
            ExternalLogger += AccountHelper.LogTransaction;
            ExternalLogger += AccountHelper.NotifyNationalBank;
        }

        /// <summary>
        /// Method for making transaction
        /// </summary>
        /// <param name="transactionType">type of transaction</param>
        /// <param name="currencyAmount">currency amount</param>
        /// <param name="accountFrom">from account</param>
        /// <param name="accountTo">to account</param>
        /// <returns>status of transaction</returns>
        public TransactionStatus ProcessTransaction(TransactionType transactionType, CurrencyAmount currencyAmount, IAccount accountFrom, IAccount accountTo)
        {

            TransactionStatus ts=TransactionStatus.Failed;

            switch (transactionType)
            {
                case TransactionType.Credit:
                    {
                        TransactionStatus tsFrom = accountFrom.DebitAmmout(currencyAmount);
                        CallExternalLogger(accountFrom, transactionType, currencyAmount);
                        TransactionStatus tsTo = accountTo.CreditAmmout(currencyAmount);
                        CallExternalLogger(accountTo, transactionType, currencyAmount);

                        if (tsFrom.Equals(TransactionStatus.Completed) && tsTo.Equals(TransactionStatus.Completed))
                        {
                            ts = TransactionStatus.Completed;
                        }
                        else{
                            ts=TransactionStatus.Failed;
                        }

                        break;
                    }
                case TransactionType.Debit:
                    {
                        ts = accountFrom.DebitAmmout(currencyAmount);
                        CallExternalLogger(accountFrom, transactionType, currencyAmount);
                        break;
                    }
                case TransactionType.Transfer:
                    {
                        ts = accountFrom.CreditAmmout(currencyAmount);
                        CallExternalLogger(accountFrom, transactionType, currencyAmount);
                        break;
                    }
                default:
                    {
                        ts = TransactionStatus.Failed;
                        break;
                    }

            }

            IAccount[] pom = { accountFrom, accountTo };
            LogTransaction(transactionType, currencyAmount, pom, ts);
            
            return ts;
        }


        /// <summary>
        /// Method for making group trasaction
        /// </summary>
        /// <param name="transactionType">type of transaction</param>
        /// <param name="amount">amount</param>
        /// <param name="accounts">list of accounts</param>
        /// <returns></returns>
        public TransactionStatus ProcessGroupTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts)
        {
            TransactionStatus result = TransactionStatus.Failed;

            if (transactionType.Equals(TransactionType.Credit))
            {
                foreach (IAccount account in accounts)
                {
                    account.CreditAmmout(amount);
                    CallExternalLogger(account, transactionType, amount);
                }

                result = TransactionStatus.Completed;
            }
            else if (transactionType.Equals(TransactionType.Debit))
            {
                foreach (IAccount account in accounts)
                {
                    account.DebitAmmout(amount);
                    CallExternalLogger(account, transactionType, amount);
                }

                result = TransactionStatus.Completed;
            }

            LogTransaction(transactionType, amount, accounts, result);

            return result;
        }


        /// <summary>
        /// Method for adding transactions log in list of transactions logs
        /// </summary>
        /// <param name="transactionType">transaction type</param>
        /// <param name="amount">amount</param>
        /// <param name="accounts">list of accounts</param>
        /// <param name="status">transaction status</param>
        private void LogTransaction(TransactionType transactionType, CurrencyAmount amount, IAccount[] accounts, TransactionStatus status)
        {

            TransactionLogEntry tmp = new TransactionLogEntry(transactionType, amount, accounts, status);


            transactionLog.Add(tmp);

        }

        /// <summary>
        /// Property which return last made transaction log
        /// </summary>
        public TransactionLogEntry LastTransaction
        {
            get
            {
                if (transactionLog.Count == 0)
                {
                    return null;
                }
                else
                {
                    return transactionLog[transactionLog.Count - 1];
                }

            }
        }

        /// <summary>
        /// Property which return number of made transactions
        /// </summary>
        public int TransactionCount
        {
            get
            {
                return transactionLog.Count;
            }
        }

        /// <summary>
        /// Property which return specific transaction log
        /// </summary>
        /// <param name="index">inedx of wanted transaction log</param>
        /// <returns>transaction log entry</returns>
        public TransactionLogEntry this[int index]
        {
            get
            {
                if ((index < 0) && (index > transactionLog.Count - 1))
                {
                    return null;
                }
                else
                {
                    return transactionLog[index];
                }
            }
        }


        /// <summary>
        /// Static method for getting transaction processor instance
        /// </summary>
        /// <returns>transaction processor</returns>
        public static TransactionProcessor GetTransactionProcessor()
        {

            if (instance == null)
            {
                instance = new TransactionProcessor();
                instance.transactionLog = new List<TransactionLogEntry>();
            }
            return instance;
        }

        /// <summary>
        /// Delegate property for transaction logger
        /// </summary>
        public TransactionLogger ExternalLogger
        {
            get;

            set;

        }


        /// <summary>
        /// Private method for calling external loger delegate property
        /// </summary>
        /// <param name="account">account</param>
        /// <param name="transactionType">transaction type</param>
        /// <param name="amount">amount</param>
        private void CallExternalLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            ExternalLogger(account,transactionType,amount);
        }

        /// <summary>
        /// Method for process charge fee
        /// </summary>
        /// <param name="amount">amount</param>
        /// <param name="accounts">array of accounts</param>
        /// <returns>transaction status</returns>
        public TransactionStatus ChargeProcessingFee(CurrencyAmount amount, IEnumerable<IAccount> accounts)
        {
            throw new NotImplementedException();
        }
    }
}
