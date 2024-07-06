using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Document folder
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DocumentFolder.htm"/>
[TableAttribute("dbo.DocumentFolder")]
public class DocumentFolder
{
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Folder name</summary>
    public virtual string Name { get; set; }
    /// <summary>1 = documents in this folder can be linked to objects</summary>
    public virtual bool Objects { get; set; }
    /// <summary>1 = documents in this folder can be linked to the asset stocktaking</summary>
    public virtual bool Stocktakings { get; set; }
    /// <summary>1 = documents in this folder can be linked to software licenses</summary>
    public virtual bool SwLicenses { get; set; }

    public DocumentFolder() { }
}
