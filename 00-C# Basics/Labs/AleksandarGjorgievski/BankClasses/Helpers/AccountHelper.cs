using BankClasses.Accounts;
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

    }
}
