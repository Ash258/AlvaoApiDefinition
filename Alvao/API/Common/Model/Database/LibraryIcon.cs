using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Service icon library.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LibraryIcon.htm"/>
[TableAttribute("dbo.LibraryIcon")]
public class LibraryIcon {
    /// <summary>Binary content of file in PNG format</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LibraryIcon_Content.htm"/>
    public virtual byte[] Content { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LibraryIcon_Id.htm"/>
    [KeyAttribute]
    public virtual int Id { get; set; }
    /// <summary>Icon name</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LibraryIcon_Name.htm"/>
    public virtual string Name { get; set; }
    /// <summary>1 = system icon</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LibraryIcon_SystemIcon.htm"/>
    public virtual bool SystemIcon { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_LibraryIcon__ctor.htm"/>
    public LibraryIcon() { }
}
