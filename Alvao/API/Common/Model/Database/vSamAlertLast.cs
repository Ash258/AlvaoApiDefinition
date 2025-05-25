using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>SAM notification - last unresolved notifications sent</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSamAlertLast.html"/>
[Table("dbo.vSamAlertLast")]
public class vSamAlertLast {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSamAlertLast.html#Alvao_API_Common_Model_Database_vSamAlertLast_ComputerId"/>
    public virtual int ComputerId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSamAlertLast.html#Alvao_API_Common_Model_Database_vSamAlertLast_ProductId"/>
    public virtual int ProductId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSamAlertLast.html#Alvao_API_Common_Model_Database_vSamAlertLast_Recipients"/>
    public virtual string Recipients { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSamAlertLast.html#Alvao_API_Common_Model_Database_vSamAlertLast_ResolvedDate"/>
    public virtual DateTime? ResolvedDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSamAlertLast.html#Alvao_API_Common_Model_Database_vSamAlertLast_SamAlertRuleId"/>
    public virtual int SamAlertRuleId { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSamAlertLast.html#Alvao_API_Common_Model_Database_vSamAlertLast_SentDate"/>
    public virtual DateTime SentDate { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSamAlertLast.html#Alvao_API_Common_Model_Database_vSamAlertLast_SequenceNum"/>
    public virtual int SequenceNum { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.Common.Model.Database.vSamAlertLast.html#Alvao_API_Common_Model_Database_vSamAlertLast_id"/>
    public virtual int id { get; set; }
}
