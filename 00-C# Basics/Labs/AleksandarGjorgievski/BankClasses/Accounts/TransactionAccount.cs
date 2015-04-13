using BankClasses.Common.Structure;
using BankClasses.Helpers;
using BankClasses.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Accounts
{
    [AccountMetadata(AccountDescription = "Class for Transaction Accounts", AccountLimitations = "No Limitations")]
    /// <summary>
    /// Class that represent Transaciton Account
    /// </summary>
    public class TransactionAccount:Account,ITransactionAccount
    {
        /// <summary>
        /// Private field for amount limit for account
        /// </summary>
        private CurrencyAmount limit;


        /// <summary>
        /// Public property for private field limit
        /// </summary>
        public CurrencyAmount Limit
        {
            get { return limit; }
            private set { limit = value; }
        }


        /// <summary>
        /// TransactionAccount constructor with two parametars 
        /// </summary>
        /// <param name="currency">account currency</param>
        /// <param name="limitAmmount">account amount limit</param>
        public TransactionAccount(string currency, decimal limitAmmount)
            : base(currency)
        {
            CurrencyAmount tmp = new CurrencyAmount();
            tmp.Amount = limitAmmount;
            tmp.Currency = currency;

            this.Limit = tmp;
        }

        /// <summary>
        /// Public Method for generating account number
        /// </summary>
        /// <returns>account number</returns>
        protected override string GenerateAccountNumber()
        {
            string result = "";

            result = AccountHelper.GenerateAccountNumber<TransactionAccount>(Id);

            return result;
        }
    }
}
