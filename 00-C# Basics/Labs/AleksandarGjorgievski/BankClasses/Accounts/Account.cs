using BankClasses.Common.Enumeration;
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
    /// Abstract class that represent account
    /// </summary>
    public abstract class Account:IAccount
    {

    #region Private Fields

        /// <summary>Private field for account id</summary>
        private long id;
        /// <summary>Private field for account number</summary>
        private string number;
        /// <summary>Private field for account currency</summary>
        private string currency;
        /// <summary>Private field for account balance</summary>
        private CurrencyAmount balance;
        
#endregion

    #region Public Properties

        /// <summary>Public property for private field id</summary>
        public long Id
        {
            get { return id; }
            private set { id = value; }
        }

        /// <summary>Public property for private field nubber</summary>
        public string Number
        {
            get { return number; }
            private set { number = value; }
        }

        /// <summary>Public property for private field currency </summary>
        public string Currency
        {
            get { return currency; }
            private set { currency = value; }
        }

        /// <summary>Public  property for private field balance </summary>
        public CurrencyAmount Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

#endregion

    #region Constructors

        /// <summary>
        /// Account constuctor with three parametars
        /// </summary>
        /// <param name="id">account id</param>
        /// <param name="number">account number</param>
        /// <param name="currency">currency</param>
        public Account(long id, string number, string currency)
        {
            this.Id = id;
            this.Number = number;
            this.Currency = currency;

            CurrencyAmount tmp = new CurrencyAmount();
            tmp.Amount = 30000;     //TODO ovde menato e vo 30000 namesto 0 zaradi testiranje
            tmp.Currency = currency;
            this.Balance = tmp;

        }

        /// <summary>
        /// Account constructor with one parametar, others parametars is initialize with default values
        /// </summary>
        /// <param name="currency">currency</param>
        public Account(string currency)
            : this(-1, "X", currency)
        {
            int tmpId = AccountHelper.GenerateAccountId();
            this.Id = tmpId;

            string tmpNumber = GenerateAccountNumber();
            this.Number = tmpNumber;
        }

#endregion

    #region Public Methods

        /// <summary>
        /// Public method for making debit transaction
        /// </summary>
        /// <param name="ammount">ammount that will be taken out</param>
        /// <returns>the success of the transaction</returns>
        public virtual TransactionStatus DebitAmmout(CurrencyAmount amount)
        {
            if ((amount.Amount < 0) || (Balance.Amount - amount.Amount < 0))
            {
                return TransactionStatus.Failed;
            }
            else
            {
                CurrencyAmount tmp = new CurrencyAmount();
                tmp.Amount = Balance.Amount;
                tmp.Currency = Balance.Currency;

                tmp.Amount -= amount.Amount;
                Balance = tmp;


                return TransactionStatus.Completed;
            }

        }

        /// <summary>
        /// Public method for making credit transaction
        /// </summary>
        /// <param name="amount">ammount that will be add</param>
        /// <returns>the success of the transaction</returns>
        public virtual TransactionStatus CreditAmmout(CurrencyAmount amount)
        {
            if (amount.Amount < 0)
            {
                return TransactionStatus.Failed;
            }
            else
            {
                CurrencyAmount tmp = new CurrencyAmount();
                tmp.Amount = Balance.Amount;
                tmp.Currency = Balance.Currency;
                
                tmp.Amount += amount.Amount;
                Balance = tmp;


                return TransactionStatus.Completed;
            }
        }


        protected abstract string GenerateAccountNumber(); 

#endregion

    #region Private Methods

        /// <summary>
        /// Private method that checks whether this is the same currency
        /// </summary>
        /// <param name="account">acount CurrencyAmount</param>
        /// <param name="input">input CurrencyAmount</param>
        /// <returns>the success of the transaction ie did both parametars has equal currency</returns>
        private TransactionStatus checkCurrency(CurrencyAmount account, CurrencyAmount input)
        {

            if (account.Currency.Equals(input.Currency))
            {
                return TransactionStatus.InProcess;
            }
            else
            {
                return TransactionStatus.Failed;
            }

        }

#endregion

    }
}
