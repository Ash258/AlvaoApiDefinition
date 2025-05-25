using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Application scripts.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Script.html"/>
[Table("Apps.Script")]
public class Script {
    /// <summary>Application ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_AppId"/>
    public virtual int AppId { get; set; }
    /// <summary>Source code of the script.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_Code"/>
    public virtual string Code { get; set; }
    /// <summary>Certified script integrity check value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_Codesign"/>
    public virtual string Codesign { get; set; }
    /// <summary>Whether the source code can be compiled. 1 = yes, 0 = no.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_IsCompilable"/>
    public virtual bool IsCompilable { get; set; }
    /// <summary>If the code is library. 1 = yes, 0 = no.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_IsLibCode"/>
    public virtual bool IsLibCode { get; set; }
    /// <summary>The date the script was last modified.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_LastChanged"/>
    public virtual DateTime? LastChanged { get; set; }
    /// <summary>Script name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_Name"/>
    public virtual string Name { get; set; }
    /// <summary>1 = the script contains at least one warning, 0 = no warnings in the script.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_Warning"/>
    public virtual bool Warning { get; set; }
    /// <summary>Script ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_id"/>
    [Key]
    public virtual int id { get; set; }
}
