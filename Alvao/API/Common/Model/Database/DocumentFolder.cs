using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Document folder</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_DocumentFolder.htm"/>
[TableAttribute("dbo.DocumentFolder")]
public class DocumentFolder {
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolder_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Folder name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolder_Name.htm"/>
    public virtual string Name { get; set; }
    /// <summary>1 = documents in this folder can be linked to objects</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolder_Objects.htm"/>
    public virtual bool Objects { get; set; }
    /// <summary>1 = documents in this folder can be linked to the asset stocktaking</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolder_Stocktakings.htm"/>
    public virtual bool Stocktakings { get; set; }
    /// <summary>1 = documents in this folder can be linked to software licenses</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_DocumentFolder_SwLicenses.htm"/>
    public virtual bool SwLicenses { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_DocumentFolder__ctor.htm"/>
    public DocumentFolder() { }
}
