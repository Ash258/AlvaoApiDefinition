using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Employee absence records.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tTimeOff.htm"/>
[TableAttribute("dbo.tTimeOff")]
public class tTimeOff
{
    public virtual bool bHalf { get; set; }
    public virtual DateTime dCreated { get; set; }
    public virtual DateTime dModified { get; set; }
    public virtual DateTime dTimeOff { get; set; }
    [KeyAttribute]
    public virtual int iTimeOffId { get; set; }
    public virtual int? liCreatedPersonId { get; set; }
    public virtual int? liModifiedPersonId { get; set; }
    public virtual int liPersonId { get; set; }
    public virtual int liTimeOffKindId { get; set; }
    public virtual string mNotes { get; set; }

    public tTimeOff() { }
}
