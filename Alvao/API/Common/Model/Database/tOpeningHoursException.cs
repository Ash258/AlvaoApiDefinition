using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Exceptions in service operating hours.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tOpeningHoursException.htm"/>
[TableAttribute("dbo.tOpeningHoursException")]
public class tOpeningHoursException
{
    public virtual bool bOpen { get; set; }
    public virtual DateTime dFrom { get; set; }
    public virtual DateTime dTo { get; set; }
    [KeyAttribute]
    public virtual int iOpeningHoursExceptionId { get; set; }
    public virtual int liOpeningHoursId { get; set; }
    public virtual string mNotes { get; set; }

    public tOpeningHoursException() { }
}
