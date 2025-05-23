using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Table of users and groups which the view is shared with.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SharedViewRecipient.htm"/>
[TableAttribute("dbo.SharedViewRecipient")]
public class SharedViewRecipient {
    /// <summary>Record identifier.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SharedViewRecipient_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>A person who the view is shared with.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SharedViewRecipient_PersonId.htm"/>
    public virtual int? PersonId { get; set; }
    /// <summary>The group of persons who the view is shared with.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SharedViewRecipient_RoleId.htm"/>
    public virtual int? RoleId { get; set; }
    /// <summary>A foreign key to the SharedView table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SharedViewRecipient_SharedViewId.htm"/>
    public virtual int SharedViewId { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SharedViewRecipient__ctor.htm"/>
    public SharedViewRecipient() { }
}
