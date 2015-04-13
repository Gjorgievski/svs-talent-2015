using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Common
{
    /// <summary>
    /// Custom exception class for currency mismatch
    /// </summary>
    public class CurrencyMismatchException:ApplicationException
    {
        public CurrencyMismatchException()
            : base() { }

        public CurrencyMismatchException(string message)
            : base(message) { }
    }
}
