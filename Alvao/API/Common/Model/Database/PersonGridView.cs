using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Cache for the number of unread tickets from the viewpoint of a specific user.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_PersonGridView.htm"/>
[TableAttribute("dbo.PersonGridView")]
public class PersonGridView
{
    /// <summary>Name of table (grid), see the ProfileValue.ValueName table.</summary>
    public virtual string GridName { get; set; }
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Time (UTC) of the last update of the UnreadTicketsCount value.</summary>
    public virtual DateTime? LastCheck { get; set; }
    /// <summary>Person (tPerson.iPersonId).</summary>
    public virtual int PersonId { get; set; }
    /// <summary>Number of unread tickets in the view.</summary>
    public virtual int? UnreadTicketsCount { get; set; }
    /// <summary>View name.</summary>
    public virtual string ViewName { get; set; }

    public PersonGridView() { }
}
