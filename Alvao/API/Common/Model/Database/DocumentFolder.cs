using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Document folder</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html"/>
[Table("dbo.DocumentFolder")]
public class DocumentFolder {
    /// <summary>Folder name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html#Alvao_API_Common_Model_Database_DocumentFolder_Name"/>
    public virtual string Name { get; set; }
    /// <summary>1 = documents in this folder can be linked to objects</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html#Alvao_API_Common_Model_Database_DocumentFolder_Objects"/>
    public virtual bool Objects { get; set; }
    /// <summary>1 = documents in this folder can be linked to the asset stocktaking</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html#Alvao_API_Common_Model_Database_DocumentFolder_Stocktakings"/>
    public virtual bool Stocktakings { get; set; }
    /// <summary>1 = documents in this folder can be linked to software licenses</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html#Alvao_API_Common_Model_Database_DocumentFolder_SwLicenses"/>
    public virtual bool SwLicenses { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.DocumentFolder.html#Alvao_API_Common_Model_Database_DocumentFolder_id"/>
    [Key]
    public virtual int id { get; set; }
}
