using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Service icon library.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LibraryIcon.html"/>
[Table("dbo.LibraryIcon")]
public class LibraryIcon {
    /// <summary>Binary content of file in PNG format</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LibraryIcon.html#Alvao_API_Common_Model_Database_LibraryIcon_Content"/>
    public virtual byte[] Content { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LibraryIcon.html#Alvao_API_Common_Model_Database_LibraryIcon_Id"/>
    [Key]
    public virtual int Id { get; set; }
    /// <summary>Icon name</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LibraryIcon.html#Alvao_API_Common_Model_Database_LibraryIcon_Name"/>
    public virtual string Name { get; set; }
    /// <summary>1 = system icon</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.LibraryIcon.html#Alvao_API_Common_Model_Database_LibraryIcon_SystemIcon"/>
    public virtual bool SystemIcon { get; set; }
}
