namespace Alvao.API.SD.Model;

public class StateRequiredColumnEqualityComparer : IEqualityComparer<StateRequiredColumnModel>
{
    public StateRequiredColumnEqualityComparer() { }

    /// <param name="x"> </param>
    /// <param name="y"> </param>
    public bool Equals(
        StateRequiredColumnModel x,
        StateRequiredColumnModel y
    )
    { throw new System.NotImplementedException(); }

    /// <param name="obj"> </param>
    public int GetHashCode(
        StateRequiredColumnModel obj
    )
    { throw new System.NotImplementedException(); }
}
