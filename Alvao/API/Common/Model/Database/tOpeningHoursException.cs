using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Exceptions in service operating hours.</summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tOpeningHoursException.htm"/>
[TableAttribute("dbo.tOpeningHoursException")]
public class tOpeningHoursException {
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHoursException_bOpen.htm"/>
    public virtual bool bOpen { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHoursException_dFrom.htm"/>
    public virtual DateTime dFrom { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHoursException_dTo.htm"/>
    public virtual DateTime dTo { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHoursException_iOpeningHoursExceptionId.htm"/>
    [KeyAttribute]
    public virtual int iOpeningHoursExceptionId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHoursException_liOpeningHoursId.htm"/>
    public virtual int liOpeningHoursId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tOpeningHoursException_mNotes.htm"/>
    public virtual string mNotes { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tOpeningHoursException__ctor.htm"/>
    public tOpeningHoursException() { }
}
