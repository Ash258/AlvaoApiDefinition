namespace Alvao.API.Common.Model;

/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Asset.html"/>
public class Asset {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Asset.AssignmentStatus.html#fields"/>
    public enum AssignmentStatus {
        Pending = 1,
        Accepted = 2,
        Rejected = 3,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Asset.CheckReasonNotFound.html#fields"/>
    public enum CheckReasonNotFound {
        Lost = 0,
        Stolen = 1,
        Returned = 2,
        HandedToColleague = 3,
        Other = 4,
    }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Asset.CheckStatus.html#fields"/>
    public enum CheckStatus {
        None = 0,
        Pending = 1,
        Found = 2,
        NotFound = 3,
    }
}
