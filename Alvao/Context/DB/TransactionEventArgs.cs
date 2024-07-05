namespace Alvao.Context.DB;

public class TransactionEventArgs : EventArgs
{
    public string SavePointName { get; }
    public static readonly TransactionEventArgs Empty;
    public TransactionEventArgs(
    string savePointName = null
) {}
}
