using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Application scripts.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_Script.htm"/>
[TableAttribute("Apps.Script")]
public class Script
{
    /// <summary>Application ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Script_AppId.htm"/>
    public virtual int AppId { get; set; }
    /// <summary>Source code of the script.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Script_Code.htm"/>
    public virtual string Code { get; set; }
    /// <summary>Certified script integrity check value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Script_Codesign.htm"/>
    public virtual string Codesign { get; set; }
    /// <summary>Script ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Script_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Whether the source code can be compiled. 1 = yes, 0 = no.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Script_IsCompilable.htm"/>
    public virtual bool IsCompilable { get; set; }
    /// <summary>If the code is library. 1 = yes, 0 = no.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Script_IsLibCode.htm"/>
    public virtual bool IsLibCode { get; set; }
    /// <summary>The date the script was last modified.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Script_LastChanged.htm"/>
    public virtual DateTime? LastChanged { get; set; }
    /// <summary>Script name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Script_Name.htm"/>
    public virtual string Name { get; set; }
    /// <summary>1 = the script contains at least one warning, 0 = no warnings in the script.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_Script_Warning.htm"/>
    public virtual bool Warning { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_Script__ctor.htm"/>
    public Script() { }
}
