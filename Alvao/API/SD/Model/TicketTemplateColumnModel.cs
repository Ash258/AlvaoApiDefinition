using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketTemplateColumnModel.html"/>
public class TicketTemplateColumnModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketTemplateColumnModel.html#Alvao_API_SD_Model_TicketTemplateColumnModel_Column"/>
    public tColumn Column { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketTemplateColumnModel.html#Alvao_API_SD_Model_TicketTemplateColumnModel_ColumnValue"/>
    public TicketTemplateColumnValue ColumnValue { get; set; }
}
