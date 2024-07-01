
using System.Diagnostics.CodeAnalysis;

namespace Alvao.API.SD.Model;

public class StateRequiredColumnEqualityComparer : IEqualityComparer<StateRequiredColumnModel>
{
    public bool Equals(StateRequiredColumnModel? x, StateRequiredColumnModel? y)
    {
        throw new NotImplementedException();
    }

    public int GetHashCode([DisallowNull] StateRequiredColumnModel obj)
    {
        throw new NotImplementedException();
    }
}
