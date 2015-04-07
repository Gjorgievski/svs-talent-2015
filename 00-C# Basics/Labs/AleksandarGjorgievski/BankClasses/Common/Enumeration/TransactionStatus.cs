using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Common.Enumeration
{
    /// <summary>
    /// TransactionStatus enumeration declare the status of transaction
    /// </summary>
    public enum TransactionStatus
    {
        /// <summary>Transaction is in process</summary>
        InProcess,
        /// <summary>Transaction is completed</summary>
        Completed,
        /// <summary>Transaction is wit warning</summary>
        CompletedWithWarning,
        /// <summary>Transaction failed</summary>
        Failed
    }
}
