namespace Alvao.Context.DB;

/// <summary>Represents arguments for events triggered over transaction state changes.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.TransactionEventArgs.html"/>
public class TransactionEventArgs : EventArgs {
    /// <summary>Provides a value to use with events that do not have event data.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.TransactionEventArgs.html#Alvao_Context_DB_TransactionEventArgs_Empty"/>
    public static readonly TransactionEventArgs Empty;

    /// <summary>Name of the transaction.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.TransactionEventArgs.html#Alvao_Context_DB_TransactionEventArgs_SavePointName"/>
    public string SavePointName { get; }

    /// <summary>Initializes new instance of TransactionEventArgs class.</summary>
    /// <param name="savePointName">Name of the transaction save point.</param>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.Context.DB.TransactionEventArgs.html#Alvao_Context_DB_TransactionEventArgs__ctor_System_String_"/>
    public TransactionEventArgs(string savePointName = null) { }
}
