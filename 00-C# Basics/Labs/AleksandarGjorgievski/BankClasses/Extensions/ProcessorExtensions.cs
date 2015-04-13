using BankClasses.Common.Enumeration;
using BankClasses.Common.Structure;
using BankClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Extensions
{
    /// <summary>
    /// Static class for extended functionality of TransactionProcessor
    /// </summary>
    public static class ProcessorExtensions
    {

        /// <summary>
        /// Extension Method for charging fee
        /// </summary>
        /// <param name="processor">transaction processor</param>
        /// <param name="amount">amount</param>
        /// <param name="accounts">array of account</param>
        /// <returns>transaction status</returns>
        public static TransactionStatus ChargeProcessingFee(this ITransactionProcessor processor, CurrencyAmount amount, IEnumerable<IAccount> accounts)
        {
            TransactionStatus result = TransactionStatus.Failed;

            result = processor.ProcessGroupTransaction(TransactionType.Debit, amount, accounts.ToArray());

            return result;
        }

    }
}
