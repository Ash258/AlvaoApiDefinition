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
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ColumnId.htm"/>
    public virtual int ColumnId { get; set; }
    /// <summary>Change date and time (UTC)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ChangeDate.htm"/>
    public virtual DateTime ChangeDate { get; set; }
    /// <summary>Record ID</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_id.htm"/>
    [KeyAttribute]
    public virtual int id { get; set; }
    /// <summary>Author of the change (tPerson.iPersonId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_PersonId.htm"/>
    public virtual int PersonId { get; set; }
    /// <summary>Ticket ID (tHdTicket.iHdTicketId)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_TicketId.htm"/>
    public virtual int TicketId { get; set; }
    /// <summary>New bit value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueNewBit.htm"/>
    public virtual bool? ValueNewBit { get; set; }
    /// <summary>New date value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueNewDate.htm"/>
    public virtual DateTime? ValueNewDate { get; set; }
    /// <summary>New datetime value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueNewDatetime.htm"/>
    public virtual DateTime? ValueNewDatetime { get; set; }
    /// <summary>New float value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueNewFloat.htm"/>
    public virtual double? ValueNewFloat { get; set; }
    /// <summary>New int value (could be foreign key to various tables)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueNewInt.htm"/>
    public virtual int? ValueNewInt { get; set; }
    /// <summary>New string value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueNewNvarchar.htm"/>
    public virtual string ValueNewNvarchar { get; set; }
    /// <summary>Old bit value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueOldBit.htm"/>
    public virtual bool? ValueOldBit { get; set; }
    /// <summary>Old date value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueOldDate.htm"/>
    public virtual DateTime? ValueOldDate { get; set; }
    /// <summary>Old datetime value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueOldDatetime.htm"/>
    public virtual DateTime? ValueOldDatetime { get; set; }
    /// <summary>Old float value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueOldFloat.htm"/>
    public virtual double? ValueOldFloat { get; set; }
    /// <summary>Old int value (could be foreign key to various tables)</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueOldInt.htm"/>
    public virtual int? ValueOldInt { get; set; }
    /// <summary>Old string value</summary>
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_Common_Model_Database_TicketChange_ValueOldNvarchar.htm"/>
    public virtual string ValueOldNvarchar { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_Common_Model_Database_TicketChange__ctor.htm"/>
    public TicketChange() { }
}
