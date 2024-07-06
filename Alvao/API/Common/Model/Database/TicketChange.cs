using Dapper.Contrib.Extensions;

namespace Alvao.API.Common.Model.Database;

/// <summary>
/// Ticket log record for changes to the ticket field value.
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_Common_Model_Database_TicketChange.htm"/>
[TableAttribute("dbo.TicketChange")]
public class TicketChange
{
    /// <summary>Changed field (tColumn.iColumnId)</summary>
    public virtual int ColumnId { get; set; }
    /// <summary>Change date and time (UTC)</summary>
    public virtual DateTime ChangeDate { get; set; }
    /// <summary>Record ID</summary>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Author of the change (tPerson.iPersonId)</summary>
    public virtual int PersonId { get; set; }
    /// <summary>Ticket ID (tHdTicket.iHdTicketId)</summary>
    public virtual int TicketId { get; set; }
    /// <summary>New bit value</summary>
    public virtual bool? ValueNewBit { get; set; }
    /// <summary>New date value</summary>
    public virtual DateTime? ValueNewDate { get; set; }
    /// <summary>New datetime value</summary>
    public virtual DateTime? ValueNewDatetime { get; set; }
    /// <summary>New float value</summary>
    public virtual double? ValueNewFloat { get; set; }
    /// <summary>New int value (could be foreign key to various tables)</summary>
    public virtual int? ValueNewInt { get; set; }
    /// <summary>New string value</summary>
    public virtual string ValueNewNvarchar { get; set; }
    /// <summary>Old bit value</summary>
    public virtual bool? ValueOldBit { get; set; }
    /// <summary>Old date value</summary>
    public virtual DateTime? ValueOldDate { get; set; }
    /// <summary>Old datetime value</summary>
    public virtual DateTime? ValueOldDatetime { get; set; }
    /// <summary>Old float value</summary>
    public virtual double? ValueOldFloat { get; set; }
    /// <summary>Old int value (could be foreign key to various tables)</summary>
    public virtual int? ValueOldInt { get; set; }
    /// <summary>Old string value</summary>
    public virtual string ValueOldNvarchar { get; set; }

    public TicketChange() { }
}
