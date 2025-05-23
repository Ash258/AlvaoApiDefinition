using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Change record for a license or a license item.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_LicHistLog.htm"/>
[TableAttribute("dbo.LicHistLog")]
public class LicHistLog {
    /// <summary>Record ID.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistLog_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>The license ID to which the change relates. A foreign key in the LicHist table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistLog_LicHistId.htm"/>
    public virtual int? LicHistId { get; set; }
    /// <summary>Change kind ID. The kinds of changes are specified in the LicHistLogKind table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistLog_LicHistLogKindId.htm"/>
    public virtual int LicHistLogKindId { get; set; }
    /// <summary>Date and time of the event.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistLog_LogDate.htm"/>
    public virtual DateTime LogDate { get; set; }
    /// <summary>A message displayed in the license log.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistLog_Message.htm"/>
    public virtual string Message { get; set; }
    /// <summary>New property value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistLog_NewVal.htm"/>
    public virtual string NewVal { get; set; }
    /// <summary>The original property value.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistLog_OldVal.htm"/>
    public virtual string OldVal { get; set; }
    /// <summary>Change author ID. A foreign key in the tPerson table.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistLog_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <summary>Name of the changed license property or license item property.</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_LicHistLog_PropName.htm"/>
    public virtual string PropName { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_LicHistLog__ctor.htm"/>
    public LicHistLog() { }
}
