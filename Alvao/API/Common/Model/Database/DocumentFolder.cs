using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Document folder</summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html"/>
[Table("dbo.DocumentFolder")]
public class DocumentFolder {
    /// <summary>Folder name</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html#Alvao_API_Common_Model_Database_DocumentFolder_Name"/>
    /// <remarks>Column <c>Name</c>: nvarchar(255), not null.</remarks>
    public virtual string Name { get; set; }
    /// <summary>1 = documents in this folder can be linked to objects</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html#Alvao_API_Common_Model_Database_DocumentFolder_Objects"/>
    /// <remarks>Column <c>Objects</c>: bit, not null.</remarks>
    public virtual bool Objects { get; set; }
    /// <summary>1 = documents in this folder can be linked to the asset stocktaking</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html#Alvao_API_Common_Model_Database_DocumentFolder_Stocktakings"/>
    /// <remarks>Column <c>Stocktakings</c>: bit, not null.</remarks>
    public virtual bool Stocktakings { get; set; }
    /// <summary>1 = documents in this folder can be linked to software licenses</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html#Alvao_API_Common_Model_Database_DocumentFolder_SwLicenses"/>
    /// <remarks>Column <c>SwLicenses</c>: bit, not null.</remarks>
    public virtual bool SwLicenses { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html#Alvao_API_Common_Model_Database_DocumentFolder_id"/>
    /// <remarks>Column <c>id</c>: int, not null.</remarks>
    [Key]
    public virtual int id { get; set; }
}
