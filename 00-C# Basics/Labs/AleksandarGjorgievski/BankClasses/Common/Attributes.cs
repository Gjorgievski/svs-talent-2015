using System;

/// <summary>
/// Custom attribute class only for classes
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class AccountMetadataAttribute : System.Attribute 
{
    /// <summary>
    /// Class description
    /// </summary>
    public string AccountDescription { get; set; }

    /// <summary>
    /// Class limitations
    /// </summary>
    public string AccountLimitations { get; set; }
}

/// <summary>
/// Custom attribute class only for properies an fields
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class FormatRestrictionAttribute : System.Attribute
{
    /// <summary>
    /// Field/Property format
    /// </summary>
    public string FormatString { get; set; }

    /// <summary>
    /// Field/Property max length
    /// </summary>
    public int MaxLength { get; set; }
}