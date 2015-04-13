using BankClasses.Accounts;
using BankClasses.Common.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Interfaces
{
    /// <summary>
    /// Interface for properties for deposit account
    /// </summary>
    public interface IDepositAccount:IAccount
    {
        /// <summary>
        /// Property for time period
        /// </summary> 
        TimePeriod Period { get; }
        /// <summary>
        /// Property for interest rate
        /// </summary> 
        InterestRate Interest { get; }
        /// <summary>
        /// Property for begining date
        /// </summary> 
        DateTime StartDate { get; }
        /// <summary>
        /// Property for ending date
        /// </summary> 
        DateTime EndDate { get; }
        /// <summary>
        /// Property for transaction account
        /// </summary> 
        ITransactionAccount TransactionAccount { get; }
    }
}
