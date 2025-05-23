using Alvao.API.Common.Model.Database;

namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_TicketTemplateColumnModel.htm"/>
public class TicketTemplateColumnModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketTemplateColumnModel_Column.htm"/>
    public tColumn Column { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketTemplateColumnModel_ColumnValue.htm"/>
    public TicketTemplateColumnValue ColumnValue { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_TicketTemplateColumnModel__ctor.htm"/>
    public TicketTemplateColumnModel() { }
}
