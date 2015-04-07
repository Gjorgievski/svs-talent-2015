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
    /// Class for making transaction
    /// </summary>
    public class TransactionProcessor:ITransactionProcessor
    {

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
                        TransactionStatus tsTo = accountTo.CreditAmmout(currencyAmount);

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
                        break;
                    }
                case TransactionType.Transfer:
                    {
                        ts = accountFrom.CreditAmmout(currencyAmount);
                        break;
                    }
                default:
                    {
                        ts = TransactionStatus.Failed;
                        break;
                    }

            }
            
            
            return ts;
        }


    }
}
