using BankClasses.Common.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Interfaces
{
    /// <summary>
    /// Interface for transaction account
    /// </summary>
    public interface ITransactionAccount:IAccount
    {
        /// <summary>
        /// Property for transaction account limit
        /// </summary> 
         CurrencyAmount Limit { get; }

    }
}
