using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache for the number of unread tickets from the viewpoint of a specific user.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PersonGridView.htm"/>
[TableAttribute("dbo.PersonGridView")]
public class PersonGridView
{
    /// <summary>Name of table (grid), see the ProfileValue.ValueName table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonGridView_GridName.htm"/>
    public virtual string GridName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonGridView_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Time (UTC) of the last update of the UnreadTicketsCount value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonGridView_LastCheck.htm"/>
    public virtual DateTime? LastCheck { get; set; }
    /// <summary>Person (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonGridView_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <summary>Number of unread tickets in the view.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonGridView_UnreadTicketsCount.htm"/>
    public virtual int? UnreadTicketsCount { get; set; }
    /// <summary>View name.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_PersonGridView_ViewName.htm"/>
    public virtual string ViewName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_PersonGridView__ctor.htm"/>
    public PersonGridView() { }
}
