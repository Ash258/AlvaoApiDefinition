using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Alternative ticket tags. Upon merging tickets, the final ticket uses tags from original tickets as///           alternative tags.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_tHdTicketAltMessageTag.htm"/>
[TableAttribute("dbo.tHdTicketAltMessageTag")]
public class tHdTicketAltMessageTag
{
    [KeyAttribute]
    public virtual int iHdTicketAltMessageTagId { get; set; }
    public virtual int liHdTicketAltMessageTagHdTicketId { get; set; }
    public virtual string sHdTicketAltMessageTag { get; set; }

    public tHdTicketAltMessageTag() { }
}
