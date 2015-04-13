using BankClasses.Accounts;
using BankClasses.Common.Enumeration;
using BankClasses.Common.Structure;
using BankClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Helpers
{
    /// <summary>
    /// Class for generating account id's and numbers
    /// </summary>
    public static class AccountHelper
    {
        /// <summary>
        /// Private Static field for counting number of account
        /// </summary>
        private static int sAccountId;

        /// <summary>
        /// Static Constuctor for inicialise static field
        /// </summary>
        static AccountHelper()
        {
            sAccountId = 0;
        }

        /// <summary>
        /// Stattic method for genereting account ID
        /// </summary>
        /// <returns>id for account</returns>
        public static int GenerateAccountId()
        {
            sAccountId++;

            return sAccountId;
        }

        /// <summary>
        /// Method for generating account numbers
        /// </summary>
        /// <param name="accountType">type of account</param>
        /// <param name="accountId">account id</param>
        /// <returns>account number</returns>
        public static string GenerateAccountNumber(Type accountType,long accountId)
        {
            string result="";

            if (accountType == typeof(TransactionAccount))
            {
                result += " TR0000";
            }
            else if (accountType == typeof(DepositAccount))
            {
                result += " DP0000";
            }
            else if (accountType == typeof(LoanAccount))
            {
                result += " LN0000";
            }

            result += accountId;

            return result;
        }


        /// <summary>
        /// Generic method for creating acconunt number
        /// </summary>
        /// <typeparam name="T">account type</typeparam>
        /// <param name="accountId">account id</param>
        /// <returns>account number</returns>
        public static string GenerateAccountNumber<T>(long accountId) where T : IAccount
        {

            string result = GenerateAccountNumber(typeof(T), accountId);


            return result;

        }

        /// <summary>
        /// Method for printing in console when amount of transaction exceed 20000MKD
        /// </summary>
        /// <param name="account">acount</param>
        /// <param name="transactionType">transaction type</param>
        /// <param name="amount">amount</param>
        public static void LogTransaction(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if (amount.Amount > 20000 && amount.Currency.Equals("MKD"))
            {
                string result = string.Format("*LOG* Account Number:{0} | Transaction Type:{1} | Amount:{2} | Currency:{3}", account.Number, transactionType, amount.Amount, amount.Currency);
                Console.WriteLine(result);
            }
        }

        /// <summary>
        /// Method which notificate national bank(print in coslole) when amount of transaction exceed 25000MKD
        /// </summary>
        /// <param name="account">acount</param>
        /// <param name="transactionType">transaction type</param>
        /// <param name="amount">amount</param>
        public static void NotifyNationalBank(IAccount account, TransactionType transactionType, CurrencyAmount amount)
        {
            if (amount.Amount > 25000 && amount.Currency.Equals("MKD"))
            {
                string result = string.Format("*NOTIFICATE NATIONAL BANK*  Account Number:{0} | Transaction Type:{1} | Amount:{2} | Currency:{3}", account.Number, transactionType, amount.Amount, amount.Currency);
                Console.WriteLine(result);
            }
        }
    }
}
