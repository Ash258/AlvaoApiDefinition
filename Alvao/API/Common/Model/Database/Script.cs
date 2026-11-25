using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Application scripts.</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Script.html"/>
[Table("Apps.Script")]
public class Script {
    /// <summary>Application ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_AppId"/>
    /// <remarks>Column <c>AppId</c>: int, not null. References <see cref="App"/>.</remarks>
    public virtual int AppId { get; set; }
    /// <summary>Source code of the script.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_Code"/>
    /// <remarks>Column <c>Code</c>: nvarchar(max), null.</remarks>
    public virtual string Code { get; set; }
    /// <summary>Certified script integrity check value.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_Codesign"/>
    /// <remarks>Column <c>Codesign</c>: nvarchar(2048), null.</remarks>
    public virtual string Codesign { get; set; }
    /// <summary>Whether the source code can be compiled. 1 = yes, 0 = no.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_IsCompilable"/>
    /// <remarks>Column <c>IsCompilable</c>: bit, not null.</remarks>
    public virtual bool IsCompilable { get; set; }
    /// <summary>If the code is library. 1 = yes, 0 = no.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_IsLibCode"/>
    /// <remarks>Column <c>IsLibCode</c>: bit, not null.</remarks>
    public virtual bool IsLibCode { get; set; }
    /// <summary>The date the script was last modified.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_LastChanged"/>
    /// <remarks>Column <c>LastChanged</c>: datetime, null.</remarks>
    public virtual DateTime? LastChanged { get; set; }
    /// <summary>Script name.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>1 = the script contains at least one warning, 0 = no warnings in the script.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_Warning"/>
    /// <remarks>Column <c>Warning</c>: bit, not null.</remarks>
    public virtual bool Warning { get; set; }
    /// <summary>Script ID.</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.Script.html#Alvao_API_Common_Model_Database_Script_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
