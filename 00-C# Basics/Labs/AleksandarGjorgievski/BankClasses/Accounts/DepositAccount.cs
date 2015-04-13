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
     [AccountMetadata(AccountDescription = "Class for Deposit Accounts", AccountLimitations = "No Limitations")]
    /// <summary>
    /// Class that represent Deposit Account
    /// </summary>
    public class DepositAccount:Account,IDepositAccount
    {

    #region Private Fields
        /// <summary>
        /// Private field for time period
        /// </summary>
        private TimePeriod period;
        /// <summary>
        /// Private field for interest rate
        /// </summary>
        private InterestRate interest;
        /// <summary>
        /// Private field for starting date
        /// </summary>
        private DateTime startDate;
        /// <summary>
        /// Private field for ending date
        /// </summary>
        private DateTime endDate;
        /// <summary>
        /// Private field for transaction account
        /// </summary>
        private ITransactionAccount transactionAccount;

#endregion
        

    #region Public Property
        /// <summary>
        /// Public property for private field period
        /// </summary>
        public TimePeriod Period
        {
            get { return period; }
            private set { period = value; }
        }

        /// <summary>
        /// Public property for private field interest
        /// </summary>
        public InterestRate Interest
        {
            get { return interest; }
            private set { interest = value; }
        }

        /// <summary>
        /// Public property for private field startdate
        /// </summary>
        public DateTime StartDate
        {
            get { return startDate; }
            private set { startDate = value; }
        }

        /// <summary>
        /// Public property for private field endDate
        /// </summary>
        public DateTime EndDate
        {
            get { return endDate; }
            private set { endDate = value; }
        }

        /// <summary>
        /// Public property for private field transactionAccount
        /// </summary>
        public ITransactionAccount TransactionAccount
        {
            get { return transactionAccount; }
            private set { transactionAccount = value; }
        }

#endregion


        /// <summary>
        /// DepositAccount constructor
        /// </summary>
        /// <param name="currency">currency of account</param>
        /// <param name="depositPeriod">deposit period</param>
        /// <param name="interestRate">interest rate</param>
        /// <param name="startDate">start date</param>
        /// <param name="endDate">end date</param>
        /// <param name="transactionAccount">tansaction account</param>
        public DepositAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate, 
                                DateTime startDate, DateTime endDate, TransactionAccount transactionAccount)
            : base(currency)
        {
            this.Period = depositPeriod;
            this.Interest = interestRate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TransactionAccount = transactionAccount;
        }


         /// <summary>
         /// Public method for generating account number
         /// </summary>
         /// <returns>account number</returns>
        protected override string GenerateAccountNumber()
        {
            string result = "";

            result = AccountHelper.GenerateAccountNumber<DepositAccount>(Id);

            return result;
        }
    }
}
