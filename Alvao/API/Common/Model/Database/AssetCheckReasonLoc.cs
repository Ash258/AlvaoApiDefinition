using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Cache of processed localizations.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_AssetCheckReasonLoc.htm"/>
[TableAttribute("dbo.AssetCheckReasonLoc")]
public class AssetCheckReasonLoc
{
    /// <summary>Reason ID (AssetCheckReason.id)</summary>
    public virtual int AssetCheckReasonId { get; set; }
    /// <summary>Language ID</summary>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized reason name.</summary>
    public virtual string Name { get; set; }

    public AssetCheckReasonLoc() { }
}
