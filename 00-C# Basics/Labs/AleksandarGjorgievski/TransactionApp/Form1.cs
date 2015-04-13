using BankClasses.Accounts;
using BankClasses.Common;
using BankClasses.Common.Enumeration;
using BankClasses.Common.Structure;
using BankClasses.Extensions;
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
        /// <summary>
        /// Button 'Create Transaction Account' click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTransactionAccount_Click(object sender, EventArgs e)
        {
            ITransactionAccount TranAccount = createTransactionAccount();

            populateAccountCommonProperties(TranAccount);
            
        }
        /// <summary>
        /// Method for making transaction account
        /// </summary>
        /// <returns></returns>
        private ITransactionAccount createTransactionAccount()
        {
            string curency = txtCurrency.Text.ToString();
            decimal limit = Convert.ToDecimal(txtLimit.Text);

            ITransactionAccount TranAccount = new TransactionAccount(curency, limit);

            return TranAccount;
        }
        /// <summary>
        /// Populate acount common properties
        /// </summary>
        /// <param name="account"></param>
        private void populateAccountCommonProperties(IAccount account)
        {
            lblId.Text = account.Id.ToString();
            lblNumber.Text = account.Number;
            lblCurrency.Text = account.Currency;
            lblBalance.Text = account.Balance.Amount.ToString();

            checkForDepositAccount(account);
            checkForTransactionAccount(account);
        }
        /// <summary>
        /// check for transaction account
        /// </summary>
        /// <param name="account"></param>
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
        /// <summary>
        /// Button 'Create Deposit Account' click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDepositAccount_Click(object sender, EventArgs e)
        {

            IDepositAccount DepAccount = createDepositAccount();

            populateAccountCommonProperties(DepAccount);
            
            
        }
        /// <summary>
        /// Method for creating deposit account
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Check for deposit account
        /// </summary>
        /// <param name="account"></param>
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
        /// <summary>
        /// Button 'Make Transaction' click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeTransaction_Click(object sender, EventArgs e)
        {
            ITransactionAccount transactionAccount = createTransactionAccount();
            //IDepositAccount depositAccount = createDepositAccount();
            ILoanAccount loanAccount = createLoanAccount();

            ITransactionProcessor transactionProccesor = TransactionProcessor.GetTransactionProcessor();

            CurrencyAmount currencyAmount = new CurrencyAmount();
            currencyAmount.Amount = Convert.ToInt32(txtTransactionAmoun.Text);
            currencyAmount.Currency = txtTransactionCurrency.Text;

            //ovde dodavam event handler-i za event-ite
            transactionAccount.OnBalanceChanged += new BalanceChanged(OnBalanceChangeEventHandler);
            loanAccount.OnBalanceChanged += new BalanceChanged(OnBalanceChangeEventHandler);

            bool errorOccurred = false;
            string errorMsg = "";
            TransactionStatus status=TransactionStatus.Failed;
            try 
            {
                status = transactionProccesor.ProcessTransaction(TransactionType.Credit, currencyAmount, transactionAccount, loanAccount);
            }
            catch (ApplicationException ae)
            {
                errorOccurred = true;
                errorMsg = ae.Message;
            }
            finally
            {
                if (errorOccurred)
                    MessageBox.Show(errorMsg);
            }
            

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
        /// <summary>
        /// Populate transaction account details
        /// </summary>
        /// <param name="account"></param>
        private void populateTransactionAccount(ITransactionAccount account)
        {
            lbl_fromId.Text = account.Id.ToString();
            lbl_fromNumber.Text = account.Number;
            lbl_fromCurrency.Text = account.Currency;
            lbl_fromBalance.Text = account.Balance.Amount.ToString()+" "+account.Balance.Currency.ToString();
            lbl_fromLimitAmount.Text = account.Limit.Amount.ToString();
            lbl_fromLimitCurrency.Text = account.Limit.Currency;
        }
        /// <summary>
        /// Populate deposit account details
        /// </summary>
        /// <param name="account"></param>
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
        /// <summary>
        /// Populate loan account details
        /// </summary>
        /// <param name="account"></param>
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
        /// <summary>
        /// Create loan account 
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Button 'Make Group Transaction' click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMakeGroupTransaction_Click(object sender, EventArgs e)
        {
            IAccount[] acounts = new IAccount[2];

                //IDepositAccount depositAccount = createDepositAccount();
                //ILoanAccount loanAccount = createLoanAccount();

            //acounts[0] = depositAccount;
            //acounts[1] = loanAccount;

            Dictionary<CreateAccountType, IAccount> accountsDictionary = CreateAccounts(CreateAccountType.DepositAccount | CreateAccountType.LoanAccount, null);

            acounts[0] = accountsDictionary[CreateAccountType.DepositAccount];
            acounts[1] = accountsDictionary[CreateAccountType.LoanAccount];

            ITransactionProcessor transactionProccesor = TransactionProcessor.GetTransactionProcessor();

            CurrencyAmount currencyAmount = new CurrencyAmount();
            currencyAmount.Amount = Convert.ToInt32(txtTransactionAmoun.Text);
            currencyAmount.Currency = txtTransactionCurrency.Text;


            bool errorOccurred = false;
            string errorMsg = "";
            TransactionStatus status = TransactionStatus.Failed;
            try
            {
                status = transactionProccesor.ProcessGroupTransaction(TransactionType.Debit, currencyAmount, acounts);
            }
            catch (CurrencyMismatchException cme)
            {
                errorOccurred = true;
                errorMsg = cme.Message;
            }
            catch (ApplicationException)
            {
                throw;
            }
            finally
            {
                if (errorOccurred)
                    MessageBox.Show(errorMsg);
            }

           

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
        /// <summary>
        /// Method for dispaiing last transaction details
        /// </summary>
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
        /// <summary>
        /// Handler for balance change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void OnBalanceChangeEventHandler(Object sender, BalanceChangedEventArguments eventArgs)
        {
            IAccount tmp=sender as IAccount;
            string result = string.Format("*EVENT*  Account Number:{0} | New Balance Amount:{1} ", tmp.Number, tmp.Balance.Amount);
            Console.WriteLine(result);
        }
        /// <summary>
        /// Method for creating accounts
        /// </summary>
        /// <param name="accountTypesToCreate">account type</param>
        /// <param name="transactionAccount">transaction account</param>
        /// <returns>dictionary of created accounts</returns>
        private Dictionary<CreateAccountType, IAccount> CreateAccounts(CreateAccountType accountTypesToCreate, ITransactionAccount transactionAccount)
        {

            Dictionary<CreateAccountType, IAccount> accounts = new Dictionary<CreateAccountType, IAccount>();


            if ((accountTypesToCreate & CreateAccountType.TransactionAccount) == CreateAccountType.TransactionAccount)
            {
                ITransactionAccount transactionAccountLocal = createTransactionAccount();
                accounts.Add(CreateAccountType.TransactionAccount, transactionAccount);
            }

            if ((accountTypesToCreate & CreateAccountType.DepositAccount) == CreateAccountType.DepositAccount)
            {
                IDepositAccount depositAccount = createDepositAccount();
                accounts.Add(CreateAccountType.DepositAccount, depositAccount);
            }

            if ((accountTypesToCreate & CreateAccountType.LoanAccount) == CreateAccountType.LoanAccount)
            {
                ILoanAccount loanAccount = createLoanAccount();
                accounts.Add(CreateAccountType.LoanAccount, loanAccount);
            }


            return accounts;
        }
        /// <summary>
        /// Button 'Charge Fee' click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChargeFee_Click(object sender, EventArgs e)
        {
            ITransactionProcessor transactionProccesor = TransactionProcessor.GetTransactionProcessor();

            CurrencyAmount currencyAmount = new CurrencyAmount();
            currencyAmount.Amount = Convert.ToInt32(txtTransactionAmoun.Text);
            currencyAmount.Currency = txtTransactionCurrency.Text;

            IDepositAccount depositAccount = createDepositAccount();
            ILoanAccount loanAccount = createLoanAccount();

            List<IAccount> accounts=new List<IAccount>();
            accounts.Add(depositAccount);
            accounts.Add(loanAccount);

            TransactionStatus status = ProcessorExtensions.ChargeProcessingFee(transactionProccesor, currencyAmount, accounts);

            if (status.Equals(TransactionStatus.Completed))
            {
                lblTransactionStatus.Text = "Transaction Completed";
            }
            else
            {
                lblTransactionStatus.Text = "Transaction Failed";
            }

           
            DisplayLastTransactionDetails();
        }

        #endregion

        
    }
}
