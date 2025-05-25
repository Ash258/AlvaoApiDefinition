using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Types of objects.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vClass.html"/>
[Table("dbo.vClass")]
public class vClass {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vClass.html#Alvao_API_Common_Model_Database_vClass_bComputer"/>
    public virtual bool bComputer { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vClass.html#Alvao_API_Common_Model_Database_vClass_intClassId"/>
    public virtual int intClassId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vClass.html#Alvao_API_Common_Model_Database_vClass_txtClass"/>
    public virtual string txtClass { get; set; }
}
