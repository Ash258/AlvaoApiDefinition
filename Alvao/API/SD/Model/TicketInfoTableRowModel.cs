namespace Alvao.API.SD.Model;

/// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketInfoTableRowModel.html"/>
public class TicketInfoTableRowModel {
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketInfoTableRowModel.html#Alvao_API_SD_Model_TicketInfoTableRowModel_Label"/>
    public string Label { get; set; }
    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketInfoTableRowModel.html#Alvao_API_SD_Model_TicketInfoTableRowModel_Value"/>
    public string Value { get; set; }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketInfoTableRowModel.html#Alvao_API_SD_Model_TicketInfoTableRowModel__ctor_System_String_System_String_"/>
    public TicketInfoTableRowModel(string label, string value) { }

    /// <see href="https://doc.alvao.com/en/25/alvao-api/api/Alvao.API.SD.Model.TicketInfoTableRowModel.html#Alvao_API_SD_Model_TicketInfoTableRowModel_GetTicketInfoTableRows_Alvao_API_SD_Model_TicketDetailsModel_"/>
    public static List<TicketInfoTableRowModel> GetTicketInfoTableRows(TicketDetailsModel ticketDetail) { throw new NotImplementedException(); }
}
