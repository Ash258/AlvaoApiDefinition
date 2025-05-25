using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Rights in the object tree - main view.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight.html"/>
[Table("dbo.vPersonNodeRight")]
public class vPersonNodeRight {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight.html#Alvao_API_Common_Model_Database_vPersonNodeRight_CreateObj"/>
    public virtual int? CreateObj { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight.html#Alvao_API_Common_Model_Database_vPersonNodeRight_bDelete"/>
    public virtual int? bDelete { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight.html#Alvao_API_Common_Model_Database_vPersonNodeRight_bMove"/>
    public virtual int? bMove { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight.html#Alvao_API_Common_Model_Database_vPersonNodeRight_bRead"/>
    public virtual int? bRead { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight.html#Alvao_API_Common_Model_Database_vPersonNodeRight_bWrite"/>
    public virtual int? bWrite { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight.html#Alvao_API_Common_Model_Database_vPersonNodeRight_liNodeId"/>
    public virtual int? liNodeId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vPersonNodeRight.html#Alvao_API_Common_Model_Database_vPersonNodeRight_liPersonId"/>
    public virtual int? liPersonId { get; set; }
}
