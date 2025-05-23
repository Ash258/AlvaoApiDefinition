using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache of processed localizations.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_AssetCheckReasonLoc.htm"/>
[TableAttribute("dbo.AssetCheckReasonLoc")]
public class AssetCheckReasonLoc {
    /// <summary>Reason ID (AssetCheckReason.id)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AssetCheckReasonLoc_AssetCheckReasonId.htm"/>
    public virtual int AssetCheckReasonId { get; set; }
    /// <summary>Language ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AssetCheckReasonLoc_LocaleId.htm"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized reason name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_AssetCheckReasonLoc_Name.htm"/>
    public virtual string Name { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_AssetCheckReasonLoc__ctor.htm"/>
    public AssetCheckReasonLoc() { }
}
