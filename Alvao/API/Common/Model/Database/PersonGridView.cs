using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Cache for the number of unread tickets from the viewpoint of a specific user.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonGridView.html"/>
[Table("dbo.PersonGridView")]
public class PersonGridView {
    /// <summary>Name of table (grid), see the ProfileValue.ValueName table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonGridView.html#Alvao_API_Common_Model_Database_PersonGridView_GridName"/>
    public virtual string GridName { get; set; }
    /// <summary>Time (UTC) of the last update of the UnreadTicketsCount value.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonGridView.html#Alvao_API_Common_Model_Database_PersonGridView_LastCheck"/>
    public virtual DateTime? LastCheck { get; set; }
    /// <summary>Person (tPerson.iPersonId).</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonGridView.html#Alvao_API_Common_Model_Database_PersonGridView_PersonId"/>
    public virtual int PersonId { get; set; }
    /// <summary>Number of unread tickets in the view.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonGridView.html#Alvao_API_Common_Model_Database_PersonGridView_UnreadTicketsCount"/>
    public virtual int? UnreadTicketsCount { get; set; }
    /// <summary>View name.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonGridView.html#Alvao_API_Common_Model_Database_PersonGridView_ViewName"/>
    public virtual string ViewName { get; set; }
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.PersonGridView.html#Alvao_API_Common_Model_Database_PersonGridView_id"/>
    [Key]
    public virtual int id { get; set; }
}
