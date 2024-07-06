using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// SAM notification - last unresolved notifications sent
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vSamAlertLast.htm"/>
[TableAttribute("dbo.vSamAlertLast")]
public class vSamAlertLast
{
    public virtual int ComputerId { get; set; }
    public virtual int id { get; set; }
    public virtual int ProductId { get; set; }
    public virtual string Recipients { get; set; }
    public virtual DateTime? ResolvedDate { get; set; }
    public virtual int SamAlertRuleId { get; set; }
    public virtual DateTime SentDate { get; set; }
    public virtual int SequenceNum { get; set; }

    public vSamAlertLast() { }
}
