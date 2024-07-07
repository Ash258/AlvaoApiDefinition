namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/T_Alvao_API_SD_Model_TicketInfoTableRowModel.htm"/>
public class TicketInfoTableRowModel
{
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketInfoTableRowModel_Label.htm"/>
    public string Label { get; set; }
    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/P_Alvao_API_SD_Model_TicketInfoTableRowModel_Value.htm"/>
    public string Value { get; set; }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_TicketInfoTableRowModel__ctor.htm"/>
    public TicketInfoTableRowModel(
        string label,
        string value
    )
    { }

    /// <see href="https://doc.alvao.com/en/alvao_11_2/alvao_api/html/M_Alvao_API_SD_Model_TicketInfoTableRowModel_GetTicketInfoTableRows.htm"/>
    ///
    /// <param name="ticketDetail"> </param>
    public static List<TicketInfoTableRowModel> GetTicketInfoTableRows(
        TicketDetailsModel ticketDetail
    )
    { throw new System.NotImplementedException(); }
}
