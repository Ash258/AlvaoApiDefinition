using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// List of processes used in all used languages.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_vTicketTypeLoc.htm"/>
[TableAttribute("dbo.vTicketTypeLoc")]
public class vTicketTypeLoc
{
    public virtual double? BackResolveDeadlineHours { get; set; }
    public virtual int? CustomField1 { get; set; }
    public virtual string Description { get; set; }
    public virtual int id { get; set; }
    public virtual string LocalizedType { get; set; }
    public virtual string TicketType { get; set; }
    public virtual int TicketTypeBehaviorId { get; set; }
    public virtual int TicketTypeLocaleId { get; set; }

    public vTicketTypeLoc() { }
}
