using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>List of media.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vMediaList.htm"/>
[TableAttribute("dbo.vMediaList")]
public class vMediaList
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vMediaList_id.htm"/>
    public virtual int id { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vMediaList_IdNumber.htm"/>
    public virtual string IdNumber { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vMediaList_lintMediaTypeId.htm"/>
    public virtual int lintMediaTypeId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vMediaList_txtAuthor.htm"/>
    public virtual string txtAuthor { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vMediaList_txtLocation.htm"/>
    public virtual string txtLocation { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vMediaList_txtMediaType.htm"/>
    public virtual string txtMediaType { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_vMediaList_txtTitle.htm"/>
    public virtual string txtTitle { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_vMediaList__ctor.htm"/>
    public vMediaList() { }
}
