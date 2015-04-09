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
    /// <summary>
    /// Class that represent Transaciton Account
    /// </summary>
    public class TransactionAccount:Account,ITransactionAccount
    {
        /// <summary>Private field for amount limit for account</summary>
        private CurrencyAmount limit;


        /// <summary>Public property for private field limit</summary>
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


        protected override string GenerateAccountNumber()
        {
            string result = "";

            result = AccountHelper.GenerateAccountNumber<TransactionAccount>(Id);

            return result;
        }
    }
}
