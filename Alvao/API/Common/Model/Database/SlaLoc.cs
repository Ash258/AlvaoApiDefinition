using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Cache of SLA localizations.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SlaLoc.htm"/>
[TableAttribute("dbo.SlaLoc")]
public class SlaLoc
{
    /// <summary>Language ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaLoc_LocaleId.htm"/>
    public virtual int LocaleId { get; set; }
    /// <summary>Localized SLA name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaLoc_Sla.htm"/>
    public virtual string Sla { get; set; }
    /// <summary>Localized SLA description.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaLoc_SlaDesc.htm"/>
    public virtual string SlaDesc { get; set; }
    /// <summary>SLA ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SlaLoc_SlaId.htm"/>
    [ExplicitKeyAttribute]
    public virtual int SlaId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SlaLoc__ctor.htm"/>
    public SlaLoc() { }
}
