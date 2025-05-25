using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Table of shared views.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SharedView.html"/>
[Table("dbo.SharedView")]
public class SharedView {
    /// <summary>Name of a table which the shared view is assigned to. The same as dbo.ProfileValue.ValueName.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SharedView.html#Alvao_API_Common_Model_Database_SharedView_GridName"/>
    public virtual string GridName { get; set; }
    /// <summary>View owner. A foreign key to the tPerson table.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SharedView.html#Alvao_API_Common_Model_Database_SharedView_OwnerPersonId"/>
    public virtual int OwnerPersonId { get; set; }
    /// <summary>Time of view deletion. If it wasnât, NULL is present.</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SharedView.html#Alvao_API_Common_Model_Database_SharedView_Removed"/>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Shared view setting</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SharedView.html#Alvao_API_Common_Model_Database_SharedView_Settings"/>
    public virtual string Settings { get; set; }
    /// <summary>Shared view identifier</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.SharedView.html#Alvao_API_Common_Model_Database_SharedView_id"/>
    [Key]
    public virtual int id { get; set; }
}
