using BankClasses.Common.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClasses.Common.Structure
{
    /// <summary>
    /// Structure for time period
    /// </summary>
    public struct TimePeriod
    {
        /// <summary>Keep period</summary>
        public int Period { get; set; }

        /// <summary>Keep for which unit of time is the declared period</summary>
        public UnitOfTime Unit { get; set; }
    }
}
