using BankClasses.Common.Enumeration;
using BankClasses.Common.Structure;
using BankClasses.Interfaces;
using System;

/// <summary>
/// Delegate
/// </summary>
/// <param name="account">account</param>
/// <param name="transactionType">transaction type</param>
/// <param name="amount">amount</param>
public delegate void TransactionLogger(IAccount account, TransactionType transactionType, CurrencyAmount amount);

/// <summary>
/// Delegate
/// </summary>
/// <param name="sender"></param>
/// <param name="eventArgs"></param>
public delegate void BalanceChanged(Object sender, BalanceChangedEventArguments eventArgs);


/// <summary>
/// event arguments class
/// </summary>
public class BalanceChangedEventArguments : System.EventArgs
{
    /// <summary>
    /// Property for account
    /// </summary>
    public IAccount Account { get; private set; }
    /// <summary>
    /// Property for currency amount
    /// </summary>
    public CurrencyAmount Change { get; private set; }


    /// <summary>
    /// Constructor for balance changed event
    /// </summary>
    /// <param name="account">account</param>
    /// <param name="change">currency amount</param>
    public BalanceChangedEventArguments(IAccount account,CurrencyAmount change)
    {
        this.Account = account;
        this.Change = change;
    }

}