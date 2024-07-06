using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Table of users and groups which the view is shared with.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SharedViewRecipient.htm"/>
[TableAttribute("dbo.SharedViewRecipient")]
public class SharedViewRecipient
{
    /// <summary>Record identifier.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>A person who the view is shared with.</summary>
    public virtual int? PersonId { get; set; }
    /// <summary>The group of persons who the view is shared with.</summary>
    public virtual int? RoleId { get; set; }
    /// <summary>A foreign key to the SharedView table.</summary>
    public virtual int SharedViewId { get; set; }

    public SharedViewRecipient() { }
}
