using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Common.Structure
{
    /// <summary>
    /// Structure for keeping amount of specific currency
    /// </summary>
    public struct CurrencyAmount
    {
        /// <summary>
        /// Keep ammount
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Keep Currency
        /// </summary>
        public string Currency { get; set; }
    }
}
