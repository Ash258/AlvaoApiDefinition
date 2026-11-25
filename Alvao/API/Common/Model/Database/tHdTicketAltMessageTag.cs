using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Alternative ticket tags. Upon merging tickets, the final ticket uses tags from original tickets as alternative tags.
/// </summary>
/// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketAltMessageTag.html"/>
[Table("dbo.tHdTicketAltMessageTag")]
public class tHdTicketAltMessageTag {
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketAltMessageTag.html#Alvao_API_Common_Model_Database_tHdTicketAltMessageTag_iHdTicketAltMessageTagId"/>
    /// <remarks>Column <c>iHdTicketAltMessageTagId</c>: int, not null.</remarks>
    [Key]
    public virtual int iHdTicketAltMessageTagId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketAltMessageTag.html#Alvao_API_Common_Model_Database_tHdTicketAltMessageTag_liHdTicketAltMessageTagHdTicketId"/>
    /// <remarks>
    /// Column <c>liHdTicketAltMessageTagHdTicketId</c>: int, not null. References <see cref="tHdTicket"/>.
    /// </remarks>
    public virtual int liHdTicketAltMessageTagHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/26/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketAltMessageTag.html#Alvao_API_Common_Model_Database_tHdTicketAltMessageTag_sHdTicketAltMessageTag"/>
    /// <remarks>Column <c>sHdTicketAltMessageTag</c>: nvarchar(255), null.</remarks>
    public virtual string sHdTicketAltMessageTag { get; set; }
}
