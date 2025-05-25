using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>Alternative ticket tags. Upon merging tickets, the final ticket uses tags from original tickets as alternative tags.</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketAltMessageTag.html"/>
[Table("dbo.tHdTicketAltMessageTag")]
public class tHdTicketAltMessageTag {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketAltMessageTag.html#Alvao_API_Common_Model_Database_tHdTicketAltMessageTag_iHdTicketAltMessageTagId"/>
    [Key]
    public virtual int iHdTicketAltMessageTagId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketAltMessageTag.html#Alvao_API_Common_Model_Database_tHdTicketAltMessageTag_liHdTicketAltMessageTagHdTicketId"/>
    public virtual int liHdTicketAltMessageTagHdTicketId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.tHdTicketAltMessageTag.html#Alvao_API_Common_Model_Database_tHdTicketAltMessageTag_sHdTicketAltMessageTag"/>
    public virtual string sHdTicketAltMessageTag { get; set; }
}
