using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <summary>
/// Ticket Process Column Model
/// </summary>
/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_TicketProcessColumnModel.htm"/>
public class TicketProcessColumnModel
{
    /// <summary>Localized column (vColumnLoc)</summary>
    public vColumnLoc Column { get; set; }

    public TicketProcessColumnModel() { }
}
