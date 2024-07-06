using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Change record for a license or a license item.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicHistLog.htm"/>
[TableAttribute("dbo.LicHistLog")]
public class LicHistLog
{
    /// <summary>Record ID.</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>The license ID to which the change relates. A foreign key in the LicHist table.</summary>
    public virtual int? LicHistId { get; set; }
    /// <summary>Change kind ID. The kinds of changes are specified in the LicHistLogKind table.</summary>
    public virtual int LicHistLogKindId { get; set; }
    /// <summary>Date and time of the event.</summary>
    public virtual DateTime LogDate { get; set; }
    /// <summary>A message displayed in the license log.</summary>
    public virtual string Message { get; set; }
    /// <summary>New property value.</summary>
    public virtual string NewVal { get; set; }
    /// <summary>The original property value.</summary>
    public virtual string OldVal { get; set; }
    /// <summary>Change author ID. A foreign key in the tPerson table.</summary>
    public virtual int PersonId { get; set; }
    /// <summary>Name of the changed license property or license item property.</summary>
    public virtual string PropName { get; set; }

    public LicHistLog() { }
}
