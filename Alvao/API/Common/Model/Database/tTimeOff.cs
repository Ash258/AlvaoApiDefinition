using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Employee absence records.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tTimeOff.htm"/>
[TableAttribute("dbo.tTimeOff")]
public class tTimeOff
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOff_bHalf.htm"/>
    public virtual bool bHalf { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOff_dCreated.htm"/>
    public virtual DateTime dCreated { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOff_dModified.htm"/>
    public virtual DateTime dModified { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOff_dTimeOff.htm"/>
    public virtual DateTime dTimeOff { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOff_iTimeOffId.htm"/>
    [KeyAttribute]
    public virtual int iTimeOffId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOff_liCreatedPersonId.htm"/>
    public virtual int? liCreatedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOff_liModifiedPersonId.htm"/>
    public virtual int? liModifiedPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOff_liPersonId.htm"/>
    public virtual int liPersonId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOff_liTimeOffKindId.htm"/>
    public virtual int liTimeOffKindId { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_tTimeOff_mNotes.htm"/>
    public virtual string mNotes { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_tTimeOff__ctor.htm"/>
    public tTimeOff() { }
}
