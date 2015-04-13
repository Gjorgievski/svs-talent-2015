using BankClasses.Common.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Common.Structure
{
    /// <summary>
    /// Structure for interest rate
    /// </summary>
    public struct InterestRate
    {
        /// <summary>
        /// Keep percent of interest rate
        /// </summary>
        public decimal Percent { get; set; }

        /// <summary>
        /// Keep for what period applies the percentаге
        /// </summary>
        public UnitOfTime Unit { get; set; }
    }
}
