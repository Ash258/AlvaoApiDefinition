using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Table of shared views.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_SharedView.htm"/>
[TableAttribute("dbo.SharedView")]
public class SharedView
{
    /// <summary>Name of a table which the shared view is assigned to. The same as dbo.ProfileValue.ValueName.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SharedView_GridName.htm"/>
    public virtual string GridName { get; set; }
    /// <summary>Shared view identifier</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SharedView_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>View owner. A foreign key to the tPerson table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SharedView_OwnerPersonId.htm"/>
    public virtual int OwnerPersonId { get; set; }
    /// <summary>Time of view deletion. If it wasn’t, NULL is present.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SharedView_Removed.htm"/>
    public virtual DateTime? Removed { get; set; }
    /// <summary>Shared view setting</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_SharedView_Settings.htm"/>
    public virtual string Settings { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_SharedView__ctor.htm"/>
    public SharedView() { }
}
