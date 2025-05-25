using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <summary>Ticket Process Column Model</summary>
/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketProcessColumnModel.html"/>
public class TicketProcessColumnModel {
    /// <summary>Localized column (vColumnLoc)</summary>
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketProcessColumnModel.html#Alvao_API_SD_Model_TicketProcessColumnModel_Column"/>
    public vColumnLoc Column { get; set; }
}
