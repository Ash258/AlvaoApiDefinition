using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// List of media.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vMediaList.htm"/>
[TableAttribute("dbo.vMediaList")]
public class vMediaList
{
    public virtual int id { get; set; }
    public virtual string IdNumber { get; set; }
    public virtual int lintMediaTypeId { get; set; }
    public virtual string txtAuthor { get; set; }
    public virtual string txtLocation { get; set; }
    public virtual string txtMediaType { get; set; }
    public virtual string txtTitle { get; set; }

    public vMediaList() { }
}
