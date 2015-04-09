using BankClasses.Accounts;
using BankClasses.Common.Enumeration;
using BankClasses.Common.Structure;
using BankClasses.Interfaces;
using BankClasses.Processors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransactionApp
{
    public partial class frmMain : Form
    {
        //private TransactionAccount TranAccount;
        //private DepositAccount DepAccount;

        public frmMain()
        {
            InitializeComponent();
        }



        #region First Part / Making Accounts
        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            ITransactionAccount TranAccount = createTransactionAccount();

            populateAccountCommonProperties(TranAccount);
            
        }

        private ITransactionAccount createTransactionAccount()
        {
            string curency = txtCurrency.Text.ToString();
            decimal limit = Convert.ToDecimal(txtLimit.Text);

            ITransactionAccount TranAccount = new TransactionAccount(curency, limit);

            return TranAccount;
        }

        private void populateAccountCommonProperties(IAccount account)
        {
            lblId.Text = account.Id.ToString();
            lblNumber.Text = account.Number;
            lblCurrency.Text = account.Currency;
            lblBalance.Text = account.Balance.Amount.ToString();

            checkForDepositAccount(account);
            checkForTransactionAccount(account);
        }

        private void checkForTransactionAccount(IAccount account)
        {
            if (account is ITransactionAccount)
            {
                ITransactionAccount ta = account as TransactionAccount;

                lblLimitAmount.Text = ta.Limit.Amount.ToString();
                lblLimitCurrency.Text = ta.Limit.Currency;
            }
            else
            {
                lblLimitAmount.Text = "";
                lblLimitCurrency.Text = "";
            }
        }

        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {

            IDepositAccount DepAccount = createDepositAccount();

            populateAccountCommonProperties(DepAccount);
            
            
        }

        private IDepositAccount createDepositAccount()
        {
            int period = Convert.ToInt32(txtPeriod.Text);
            int unitNumPeriod = Convert.ToInt32(txtUnitPeriod.Text);
            decimal percent = Convert.ToDecimal(txtPercent.Text);
            int unitNumInterest = Convert.ToInt32(txtUnitInterestRate.Text);
            UnitOfTime unit;

            switch (unitNumPeriod)
            {
                case 0: unit = UnitOfTime.Day;
                    break;
                case 1: unit = UnitOfTime.Mounth;
                    break;
                case 2: unit = UnitOfTime.Year;
                    break;
                default: unit = UnitOfTime.Day;
                    break;
            }

            TimePeriod tp = new TimePeriod();
            tp.Period = period;
            tp.Unit = unit;

            switch (unitNumInterest)
            {
                case 0: unit = UnitOfTime.Day;
                    break;
                case 1: unit = UnitOfTime.Mounth;
                    break;
                case 2: unit = UnitOfTime.Year;
                    break;
                default: unit = UnitOfTime.Day;
                    break;
            }

            InterestRate ir = new InterestRate();
            ir.Percent = percent;
            ir.Unit = unit;

            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;

            ITransactionAccount ta = createTransactionAccount();

            IDepositAccount DepAccount = new DepositAccount(ta.Currency, tp, ir, start, end, ta as TransactionAccount);

            return DepAccount;
        }

        private void checkForDepositAccount(IAccount account)
        {
            if (account is IDepositAccount)
            {
                IDepositAccount da = account as DepositAccount;

                lblPeriod.Text = da.Period.Period + " " + da.Period.Unit;
                lblInterest.Text = da.Interest.Percent + " " + da.Interest.Unit;
                lblStartDate.Text = da.StartDate.ToString();
                lblEndDate.Text = da.EndDate.ToString();
            }
            else
            {
                lblPeriod.Text = "";
                lblInterest.Text = "";
                lblStartDate.Text = "";
                lblEndDate.Text = "";
            }
        }
        #endregion
       
        #region Second Part / Transaction Processor
        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            ITransactionAccount transactionAccount = createTransactionAccount();
            //IDepositAccount depositAccount = createDepositAccount();
            ILoanAccount loanAccount = createLoanAccount();

            ITransactionProcessor transactionProccesor = TransactionProcessor.GetTransactionProcessor();

            CurrencyAmount currencyAmount = new CurrencyAmount();
            currencyAmount.Amount = 20000;
            currencyAmount.Currency = "MKD";


            TransactionStatus status = transactionProccesor.ProcessTransaction(TransactionType.Credit, currencyAmount, transactionAccount, loanAccount);

            if (status.Equals(TransactionStatus.Completed))
            {
                lblTransactionStatus.Text = "Transaction Completed";
            }
            else
            {
                lblTransactionStatus.Text = "Transaction Failed";
            }

            //populateDepositAccount(depositAccount);
            //populateLoanAccount(loanAccount);
            //populateTransactionAccount(transactionAccount);
            //lblNumberTransactions.Text ="Number of transactions: " + transactionProccesor.TransactionCount;
            DisplayLastTransactionDetails();
        }

        private void populateTransactionAccount(ITransactionAccount account)
        {
            lbl_fromId.Text = account.Id.ToString();
            lbl_fromNumber.Text = account.Number;
            lbl_fromCurrency.Text = account.Currency;
            lbl_fromBalance.Text = account.Balance.Amount.ToString()+" "+account.Balance.Currency.ToString();
            lbl_fromLimitAmount.Text = account.Limit.Amount.ToString();
            lbl_fromLimitCurrency.Text = account.Limit.Currency;
        }

        private void populateDepositAccount(IDepositAccount account)
        {
            lbl_toId.Text = account.Id.ToString();
            lbl_toNumber.Text = account.Number;
            lbl_toCurrency.Text = account.Currency;
            lbl_toBalance.Text = account.Balance.Amount.ToString() + " " + account.Balance.Currency.ToString();
            lbl_toPeriod.Text = account.Period.Period + " " + account.Period.Unit;
            lbl_toInterest.Text = account.Interest.Percent + " % " + account.Interest.Unit;
            lbl_toStartDate.Text = account.StartDate.ToString();
            lbl_toEndDate.Text = account.EndDate.ToString();
        }

        private void populateLoanAccount(ILoanAccount account)
        {
            LoanAccount tmp=account as LoanAccount;
            
            lbl_LoanId.Text = tmp.Id.ToString();
            lbl_LoanNumber.Text = tmp.Number;
            lbl_LoanCurrency.Text = tmp.Currency;
            lbl_LoanBalance.Text = tmp.LoanBalance.Amount.ToString() + " " + tmp.LoanBalance.Currency.ToString();
            lbl_LoanTimePeriod.Text = tmp.Period.Period + " " + tmp.Period.Unit;
            lbl_LoanInterestRate.Text = tmp.Interest.Percent + " % " + tmp.Interest.Unit;
            lbl_LoanStartDate.Text = tmp.StartDate.ToString();
            lbl_LoanEndDate.Text = tmp.EndDate.ToString();
        }

        private ILoanAccount createLoanAccount()
        {

            int period = Convert.ToInt32(txtPeriod.Text);
            int unitNumPeriod = Convert.ToInt32(txtUnitPeriod.Text);
            decimal percent = Convert.ToDecimal(txtPercent.Text);
            int unitNumInterest = Convert.ToInt32(txtUnitInterestRate.Text);
            UnitOfTime unit;

            switch (unitNumPeriod)
            {
                case 0: unit = UnitOfTime.Day;
                    break;
                case 1: unit = UnitOfTime.Mounth;
                    break;
                case 2: unit = UnitOfTime.Year;
                    break;
                default: unit = UnitOfTime.Day;
                    break;
            }

            TimePeriod tp = new TimePeriod();
            tp.Period = period;
            tp.Unit = unit;

            switch (unitNumInterest)
            {
                case 0: unit = UnitOfTime.Day;
                    break;
                case 1: unit = UnitOfTime.Mounth;
                    break;
                case 2: unit = UnitOfTime.Year;
                    break;
                default: unit = UnitOfTime.Day;
                    break;
            }

            InterestRate ir = new InterestRate();
            ir.Percent = percent;
            ir.Unit = unit;

            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;

            ITransactionAccount ta = createTransactionAccount();

            ILoanAccount loanAccount = new LoanAccount(ta.Currency, tp, ir, start, end, ta as TransactionAccount);

            return loanAccount;

        }


        #endregion

        #region Thrith Part / Group Transactions
        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {
            IAccount[] acounts = new IAccount[2];

            IDepositAccount depositAccount = createDepositAccount();
            ILoanAccount loanAccount = createLoanAccount();

            acounts[0] = depositAccount;
            acounts[1] = loanAccount;

            ITransactionProcessor transactionProccesor = TransactionProcessor.GetTransactionProcessor();

            CurrencyAmount currencyAmount = new CurrencyAmount();
            currencyAmount.Amount = 20000;
            currencyAmount.Currency = "MKD";


            TransactionStatus status = transactionProccesor.ProcessGroupTransaction(TransactionType.Debit, currencyAmount, acounts);


            if (status.Equals(TransactionStatus.Completed))
            {
                lblTransactionStatus.Text = "Transaction Completed";
            }
            else
            {
                lblTransactionStatus.Text = "Transaction Failed";
            }

            //populateDepositAccount(depositAccount);
            //populateLoanAccount(loanAccount);
            //lblNumberTransactions.Text ="Number of transactions: " + transactionProccesor.TransactionCount;
            DisplayLastTransactionDetails();
        }


        private void DisplayLastTransactionDetails()
        {
            TransactionProcessor transactionProcessor = TransactionProcessor.GetTransactionProcessor();

            TransactionLogEntry tmp = transactionProcessor.LastTransaction;

            //TransactionLogEntry tmp = transactionProcessor[transactionProcessor.TransactionCount - 1];


            lbl_LogTransactionType.Text = tmp.TransactionType.ToString();
            lbl_LogAmount.Text = tmp.Amount.Amount.ToString();
            lbl_LogCurrency.Text = tmp.Amount.Currency;
            lbl_LogTransactionStatus.Text = tmp.Status.ToString();

            foreach (IAccount account in tmp.Accounts)
            {
                if (account is ITransactionAccount)
                {
                    populateTransactionAccount(account as ITransactionAccount);
                }
                else if (account is ILoanAccount)
                {
                    populateLoanAccount(account as ILoanAccount);
                }
                else if(account is IDepositAccount){
                    populateDepositAccount(account as IDepositAccount);
                }
                
            }


            lblNumberTransactions.Text = "Number of transactions: " + transactionProcessor.TransactionCount.ToString();
        }

        #endregion
    }
}
