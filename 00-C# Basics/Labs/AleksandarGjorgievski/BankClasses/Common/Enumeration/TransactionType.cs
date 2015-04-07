using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Common.Enumeration
{
    /// <summary>
    /// TransactionType enumaration declare the tyoe of transaction
    /// </summary>
    public enum TransactionType
    {
        /// <summary>For regular transfer</summary>
        Transfer,
        /// <summary>For debit transaction</summary>
        Debit,
        /// <summary>For credit transaction</summary>
        Credit
    }
}
