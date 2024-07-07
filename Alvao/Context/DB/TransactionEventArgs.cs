namespace Alvao.Context.DB;

/// <summary>
/// Represents arguments for events triggered over transaction state changes.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_Context_DB_TransactionEventArgs.htm"/>
public class TransactionEventArgs : EventArgs
{
    /// <summary>Name of the transaction.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_Context_DB_TransactionEventArgs_SavePointName.htm"/>
    public string SavePointName { get; }
    /// <summary>Provides a value to use with events that do not have event data.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/F_Alvao_Context_DB_TransactionEventArgs_Empty.htm"/>
    public static readonly TransactionEventArgs Empty;

    /// <summary>Initializes new instance of TransactionEventArgs class.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_Context_DB_TransactionEventArgs__ctor.htm"/>
    public TransactionEventArgs(
        string savePointName = null
    )
    { }
}
