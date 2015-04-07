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
    /// Class that represent loan account
    /// </summary>
    public sealed class LoanAccount:DepositAccount,ILoanAccount
    {

        /// <summary>Private field for loan balance</summary>
        private CurrencyAmount loanBalance;

        /// <summary>Propety for loan balance</summary>
        public CurrencyAmount LoanBalance
        {
            get { return loanBalance; }
            private set { loanBalance = value; }
        } 


        /// <summary>
        /// LoanAccount constructor that take six parametars
        /// </summary>
        /// <param name="currency">currency</param>
        /// <param name="depositPeriod">time period</param>
        /// <param name="interestRate">interest rate</param>
        /// <param name="startDate">starting date</param>
        /// <param name="endDate">ending date</param>
        /// <param name="transactionAccount">transaction account</param>
        public LoanAccount(string currency, TimePeriod depositPeriod, InterestRate interestRate,
                                DateTime startDate, DateTime endDate, TransactionAccount transactionAccount)
            :base(currency,depositPeriod,interestRate,startDate,endDate,transactionAccount)
        {

            CurrencyAmount tmp = new CurrencyAmount();
            tmp.Amount = 0;     
            tmp.Currency = currency;
            this.LoanBalance = tmp;

        }


        /// <summary>
        /// Method for taking loan
        /// </summary>
        /// <param name="amount">amount</param>
        /// <returns>transaction status</returns>
        public override TransactionStatus DebitAmmout(CurrencyAmount amount)
        {

            if (amount.Amount < 0)
            {
                return TransactionStatus.Failed;
            }
            else
            {
                CurrencyAmount tmp = new CurrencyAmount();
                tmp.Amount = LoanBalance.Amount;
                tmp.Currency = LoanBalance.Currency;

                tmp.Amount += amount.Amount;
                LoanBalance = tmp;


                return TransactionStatus.Completed;
            }

        }

        /// <summary>
        /// Method for returning loan
        /// </summary>
        /// <param name="amount">amount</param>
        /// <returns>transaction status</returns>
        public override TransactionStatus CreditAmmout(CurrencyAmount amount)
        {
            if (amount.Amount < 0)
            {
                return TransactionStatus.Failed;
            }
            else
            {
                CurrencyAmount tmp = new CurrencyAmount();
                tmp.Amount = LoanBalance.Amount;
                tmp.Currency = LoanBalance.Currency;

                tmp.Amount -= amount.Amount;
                LoanBalance = tmp;


                return TransactionStatus.Completed;
            }
        }


        protected override string GenerateAccountNumber()
        {
            string result = "";

            result = AccountHelper.GenerateAccountNumber(typeof(LoanAccount), Id);

            return result;
        }
        
    }
}
